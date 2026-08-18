 
#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using System.Linq;
using System.Collections.Generic;


using Blueprint41;
using Blueprint41.Core;
using Blueprint41.Query;
using Blueprint41.DatastoreTemplates;
using q = DeckBuilder.Generated.Query;

namespace DeckBuilder.Generated.Manipulation
{
    public interface ICardOriginalData
    {
        string Name { get; }
        string BaseEffect { get; }
        string ReactionEffect { get; }
        string EnteringEffect { get; }
        string LeavingEffect { get; }
        string ActivationEffect { get; }
        string MandatoryActivationEffect { get; }
        string PermanentEffect { get; }
        string LoosingEffect { get; }
        string Lore { get; }
        string Id { get; }
        CardSet CardSet { get; }
    }

    public partial interface ICard : OGM
    {
        string NodeType { get; }

        #region Properties
        string Name { get; set; }
        string BaseEffect { get; set; }
        string ReactionEffect { get; set; }
        string EnteringEffect { get; set; }
        string LeavingEffect { get; set; }
        string ActivationEffect { get; set; }
        string MandatoryActivationEffect { get; set; }
        string PermanentEffect { get; set; }
        string LoosingEffect { get; set; }
        string Lore { get; set; }
        string Id { get; set; }
        CardSet CardSet { get; set; }

        #endregion

        #region Relationship Properties

        #region CardSet (Lookup)

        HAS_CARD CardSetRelation();
        HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition> expression);
        HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition[]> expression);
        HAS_CARD GetCardSetIf(JsNotation<System.DateTime?> CreationDate = default);
        void SetCardSet(CardSet cardSet);

        #endregion
        #endregion


        ICardOriginalData OriginalVersion { get; }
    }

    public partial class Card : OGMAbstractImpl<Card, ICard, System.String>
    {
        #region Initialize

        [Obsolete]
        static Card()
        {
            Register.Types();
        }

        protected override void RegisterGeneratedStoredQueries()
        {
            #region LoadByKeys
            
            RegisterQuery(nameof(LoadByKeys), (query, alias) => query.
                Where(alias.Id.In(Parameter.New<System.String>(Param0))));

            #endregion


            #region LoadById

            RegisterQuery(nameof(LoadById), (query, alias) => query.
                Where(alias.Id == Parameter.New<System.String>(Param0)));

            #endregion
            AdditionalGeneratedStoredQueries();
        }
        public static ICard LoadById(System.String id)
        {
            return FromQuery(nameof(LoadById), new Parameter(Param0, id)).FirstOrDefault();
        }
        partial void AdditionalGeneratedStoredQueries();
        
        public static Dictionary<System.String, ICard> LoadByKeys(IEnumerable<System.String> ids)
        {
            return FromQuery(nameof(LoadByKeys), new Parameter(Param0, ids.ToArray(), typeof(System.String))).ToDictionary(item=> item.Id, item => item);
        }

        protected static void RegisterQuery(string name, Func<IMatchQuery, q.CardAlias, IWhereQuery> query)
        {
            q.CardAlias alias;

            IMatchQuery matchQuery = Blueprint41.Transaction.CompiledQuery.Match(q.Node.Card.Alias(out alias));
            IWhereQuery partial = query.Invoke(matchQuery, alias);
            ICompiled compiled = partial.Return(alias).Compile();

            RegisterQuery(name, compiled);
        }

        #endregion

        private static ICardMembers members = null;
        public static ICardMembers Members
        {
            get
            {
                if (members is null)
                {
                    lock (typeof(ICard))
                    {
                        if (members is null)
                            members = new ICardMembers();
                    }
                }
                return members;
            }
        }
        public class ICardMembers
        {
            internal ICardMembers() { }

            #region Members for interface ICard

            public EntityProperty Name { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Name"];
            public EntityProperty BaseEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["BaseEffect"];
            public EntityProperty ReactionEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ReactionEffect"];
            public EntityProperty EnteringEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["EnteringEffect"];
            public EntityProperty LeavingEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LeavingEffect"];
            public EntityProperty ActivationEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ActivationEffect"];
            public EntityProperty MandatoryActivationEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["MandatoryActivationEffect"];
            public EntityProperty PermanentEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["PermanentEffect"];
            public EntityProperty LoosingEffect { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LoosingEffect"];
            public EntityProperty Lore { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Lore"];
            public EntityProperty Id { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Id"];
            public EntityProperty CardSet { get; } = DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["CardSet"];
            #endregion

        }

        sealed public override Entity GetEntity()
        {
            if (entity is null)
            {
                lock (typeof(ICard))
                {
                    if (entity is null)
                        entity = DeckBuilder.Model.Datastore.Model.Entities["Card"];
                }
            }
            return entity;
        }
    }
}
