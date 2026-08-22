using Blueprint41;
using Blueprint41.Core;
using Blueprint41.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DeckBuilder.Model
{
    public class Datastore : DatastoreModel<Datastore>
    {
		private string _baseDataDirectory = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/cards data";

		[Version(0, 1, 0)]
		protected void Initial()
		{
			FunctionalIds.Default = FunctionalIds.UUID;

			Entities
				.New("Card")
				.Abstract(true)
				.AddProperty("Name", typeof(string), false)
				.AddProperty("BaseEffect", typeof(string), true)
				.AddProperty("ReactionEffect", typeof(string), true)
				.AddProperty("EnteringEffect", typeof(string), true)
				.AddProperty("LeavingEffect", typeof(string), true)
				.AddProperty("ActivationEffect", typeof(string), true)
				.AddProperty("MandatoryActivationEffect", typeof(string), true)
				.AddProperty("PermanentEffect", typeof(string), true)
				.AddProperty("LoosingEffect", typeof(string), true)
				.AddProperty("Lore", typeof(string), true)
				.AddProperty("Id", typeof(string), false, IndexType.Unique)
				.SetKey("Id")
				.HasStaticData(true);

			Entities
				.New("Value", Entities["Card"])
				.Abstract(true)
				.Virtual(true);
				
			Entities
				.New("Cost", Entities["Card"])
				.Abstract(true)
				.Virtual(true);

            Entities
                .New("Boss", Entities["Card"])
				.HasStaticData(true);
            Entities
                .New("Action", Entities["Card"])
				.HasStaticData(true);
            Entities
                .New("Sbire", Entities["Cost"])
				.HasStaticData(true);
            Entities
                .New("SbireUnique", Entities["Cost"])
				.HasStaticData(true);
            Entities
                .New("Allie", Entities["Value"])
				.HasStaticData(true);
            Entities
                .New("Eclipse", Entities["Value"])
				.AddProperty("EclipseEffect", typeof(string), true)
				.HasStaticData(true);
            Entities
                .New("Valise", Entities["Card"])
				.HasStaticData(true);
            Entities
                .New("Reaction", Entities["Card"])
				.HasStaticData(true);

            Entities
                .New("Token")
				.AddProperty("Name", typeof(string), false)
				.AddProperty("Id", typeof(string), false, IndexType.Unique)
				.SetKey("Id");

            Entities
                .New("CardSet")
				.AddProperty("Name", typeof(string), false, IndexType.Unique)
				.AddProperty("Id", typeof(string), false, IndexType.Unique)
				.SetKey("Id");

			Relations
				.New(Entities["CardSet"], Entities["Card"], "HAS_CARD", "HAS_CARD")
				.SetInProperty("Cards", PropertyType.Collection)
				.SetOutProperty("CardSet", PropertyType.Lookup);

			Relations
				.New(Entities["Eclipse"], Entities["Allie"], "ECLIPSING", "ECLIPSING")
				.SetInProperty("Ally", PropertyType.Collection); //Collection instead of lookup because it cannot find the lookup property

			Relations
				.New(Entities["Cost"], Entities["Token"], "HAS_VALUE_TOKEN", "HAS_VALUE_TOKEN")
				.SetInProperty("Tokens", PropertyType.Collection);
				
			Relations
				.New(Entities["Value"], Entities["Token"], "HAS_COST_TOKEN", "HAS_COST_TOKEN")
				.SetInProperty("Tokens", PropertyType.Collection);
		}
		
		[Version(0, 2, 0)]
		protected void AddBaseCard()
		{
			DataMigration.Run(delegate ()
			{
				InstantiateNewCards("0.2.0", "Base");
			});
		}
		
		[Version(0, 3, 0)]
		protected void AddPromoCard()
		{
			DataMigration.Run(delegate ()
			{
				InstantiateNewCards("0.3.0", "Promotionnel");
			});
		}

		private void InstantiateNewCards(string rawVersion, string setName)
		{
				Version version = new (rawVersion);
				JArray baseCardsJson = JArray.Parse(File.ReadAllText(GetStaticJsonFilePath(version.ToString(), "cards.json")));
				List<CardData> previousVersionCards = LoadCardsPriorTo(version);

				dynamic promoSetNode = Entities["CardSet"].Refactor.CreateNode(new {Name = setName});
				
				List<CardData> newCards = new();
				newCards.AddRange(RawToCardData(baseCardsJson, promoSetNode));

				CreateCards(newCards, previousVersionCards);
		}

		private void CreateCards(List<CardData> newCards, List<CardData> previousVersionCards)
		{

			foreach(CardData cardData in newCards.Where(card => card.Type != "Eclipse"))
			{
				cardData.Card = Entities[cardData.Type].Refactor.CreateNode(new
				{
					cardData.Card.Id,
					cardData.Card.CardSet,
					cardData.Card.Name,
					cardData.Card.BaseEffect,
					cardData.Card.ReactionEffect,
					cardData.Card.EnteringEffect,
					cardData.Card.LeavingEffect,
					cardData.Card.ActivationEffect,
					cardData.Card.MandatoryActivationEffect,
					cardData.Card.PermanentEffect,
					cardData.Card.LoosingEffect,
					cardData.Card.Lore,
				});
			}

			foreach(CardData cardData in newCards.Where(card => card.Type == "Eclipse"))
			{
				CardData eclipseAlly = newCards.SingleOrDefault(card => card.Card.Name == cardData.Card.EclipseEffect);

				if(eclipseAlly is null)
					eclipseAlly = previousVersionCards.SingleOrDefault(card => card.Card.Name == cardData.Card.EclipseEffect);

				if(eclipseAlly is null)
					throw new InvalidDataException("Ally linked to Eclipse card is missing");

				cardData.Card = Entities[cardData.Type].Refactor.CreateNode(new
				{
					cardData.Card.Id,
					cardData.Card.CardSet,
					cardData.Card.Name,
					cardData.Card.BaseEffect,
					cardData.Card.ReactionEffect,
					cardData.Card.EnteringEffect,
					cardData.Card.LeavingEffect,
					cardData.Card.ActivationEffect,
					cardData.Card.MandatoryActivationEffect,
					cardData.Card.PermanentEffect,
					cardData.Card.LoosingEffect,
					cardData.Card.Lore,
					cardData.Card.EclipseEffect,
				});
				cardData.Card.Ally.Add(eclipseAlly.Card);
			}

			foreach(CardData card in newCards.Where(card => card.Type == "Eclipse" || card.Type == "Allie" || card.Type == "Sbire" || card.Type == "SbireUnique" ))
			{
				ProcessValues(card.RawData["costs_values"] as JArray, card);
				ProcessValues(card.RawData["provided_values"] as JArray, card);
			}
		}

		private List<CardData> LoadCardsPriorTo(Version currentVersion)
		{
			List<CardData> loadedCards = new();
			List<Version> versions = 
				Directory
					.GetDirectories(_baseDataDirectory)
					.Select(dir => new Version(dir.Split('/').Last()))
					.Where(ver => ver < currentVersion)
					.ToList();
			versions.Sort();

			foreach(Version version in versions)
			{
				JArray versionCards = JArray.Parse(File.ReadAllText(GetStaticJsonFilePath(version.ToString(), "cards.json")));
				loadedCards.AddRange(LoadFromRawData(versionCards));
			}

			return loadedCards;
		}

		private void ProcessValues(JArray values, CardData card)
		{
			if(values.Count == 0)
				return;

			foreach(JToken value in values)
			{
				card.Card.Tokens.Add(Entities["Token"].Refactor.CreateNode(new { Id=Guid.NewGuid().ToString(), Name=value.ToString()}));
			}
		}

		private List<CardData> RawToCardData(JArray cards, dynamic cardSet)
		{
			List<CardData> createdCards = new();

			foreach(JToken card in cards)
			{
				CardData data = new()
				{
					Card = new
					{
						Id = card["id"],
						CardSet = cardSet,
						Name = card["name"].ToString().ToUpper(),
						BaseEffect = card["effect"]["base"]?.ToString(),
						ReactionEffect = card["effect"]["reaction"]?.ToString(),
						EnteringEffect = card["effect"]["entre"]?.ToString(),
						LeavingEffect = card["effect"]["sortie"]?.ToString(),
						ActivationEffect = card["effect"]["activation"]?.ToString(),
						MandatoryActivationEffect = card["effect"]["activation obligatoire"]?.ToString(),
						PermanentEffect = card["effect"]["permanent"]?.ToString(),
						LoosingEffect = card["effect"]["defaite"]?.ToString(),
						Lore = card["lore"]?.ToString(),
						EclipseEffect = card["effect"]["eclipse"]?.ToString()
					},
					Type = card["type"].ToString(),
					RawData = card
				};

				createdCards.Add(data);
			}

			return createdCards;
		}

		private List<CardData> LoadFromRawData(JArray rawCards)
		{
			List<CardData> loadedCards = new();

			foreach(JToken card in rawCards)
			{
				CardData data = new()
				{
					Card = Entities["Card"].Refactor.MatchNode(card["id"].ToString()),
					Type = card["type"].ToString(),
					RawData = card
				};

				loadedCards.Add(data);
			}

			return loadedCards;
		}

		private string GetStaticJsonFilePath(string version, string fileName) => $@"{_baseDataDirectory}/{version}/{fileName}";
		
        protected override void SubscribeEventHandlers()
        {
            // Susbcribe your event handlers here
            //Entities["Movie"].Events.OnAfterSave += (s,e) => Console.WriteLine($"Added New Movie with Uid: { e.Entity.Properties["Uid"].GetValue((OGM)s) }");
        }
    }
}
