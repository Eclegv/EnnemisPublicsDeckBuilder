 
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
    public interface IValueOriginalData : ICardOriginalData
    {
        IEnumerable<Token> Tokens { get; }
    }

    public partial interface IValue : OGM, ICard
    {

        #region Properties
        EntityCollection<Token> Tokens { get; }

        #endregion

        #region Relationship Properties

        #region Tokens (Collection)

        List<HAS_COST_TOKEN> TokenRelations();
        List<HAS_COST_TOKEN> TokensWhere(Func<HAS_COST_TOKEN.Alias, QueryCondition> expression);
        List<HAS_COST_TOKEN> TokensWhere(Func<HAS_COST_TOKEN.Alias, QueryCondition[]> expression);
        List<HAS_COST_TOKEN> TokensWhere(JsNotation<System.DateTime?> CreationDate = default);
        void AddToken(Token token);
        void RemoveToken(Token token);

        #endregion

        #region CardSet (Lookup)

        HAS_CARD CardSetRelation();
        HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition> expression);
        HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition[]> expression);
        HAS_CARD GetCardSetIf(JsNotation<System.DateTime?> CreationDate = default);
        void SetCardSet(CardSet cardSet);

        #endregion
        #endregion


        new IValueOriginalData OriginalVersion { get; }
    }

    public partial class Value : OGMAbstractImpl<Value, IValue, System.String>
    {
        #region Initialize

        [Obsolete]
        static Value()
        {
            Register.Types();
        }

        protected override void RegisterGeneratedStoredQueries()
        {
            AdditionalGeneratedStoredQueries();
        }
        partial void AdditionalGeneratedStoredQueries();

        #endregion

        private static IValueMembers members = null;
        public static IValueMembers Members
        {
            get
            {
                if (members is null)
                {
                    lock (typeof(IValue))
                    {
                        if (members is null)
                            members = new IValueMembers();
                    }
                }
                return members;
            }
        }
        public class IValueMembers
        {
            internal IValueMembers() { }

            #region Members for interface IValue

            public EntityProperty Tokens { get; } = DeckBuilder.Model.Datastore.Model.Entities["Value"].Properties["Tokens"];
            #endregion

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
                lock (typeof(IValue))
                {
                    if (entity is null)
                        entity = DeckBuilder.Model.Datastore.Model.Entities["Value"];
                }
            }
            return entity;
        }
    }
}
