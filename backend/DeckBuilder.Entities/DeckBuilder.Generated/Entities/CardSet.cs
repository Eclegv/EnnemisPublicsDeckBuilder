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
using node = DeckBuilder.Generated.Query.Node;

namespace DeckBuilder.Generated.Manipulation
{
    public interface ICardSetOriginalData
    {
        string Name { get; }
        string Id { get; }
        IEnumerable<ICard> Cards { get; }
        IEnumerable<IValue> Cards_Value { get; }
        IEnumerable<ICost> Cards_Cost { get; }
        IEnumerable<Boss> Cards_Boss { get; }
        IEnumerable<Action> Cards_Action { get; }
        IEnumerable<Sbire> Cards_Sbire { get; }
        IEnumerable<SbireUnique> Cards_SbireUnique { get; }
        IEnumerable<Allie> Cards_Allie { get; }
        IEnumerable<Eclipse> Cards_Eclipse { get; }
        IEnumerable<Valise> Cards_Valise { get; }
        IEnumerable<Reaction> Cards_Reaction { get; }
    }

    public partial class CardSet : OGM<CardSet, CardSet.CardSetData, System.String>, ICardSetOriginalData
    {
        #region Initialize


        [Obsolete]
        static CardSet()
        {
            Register.Types();
        }


        protected override void RegisterGeneratedStoredQueries()
        {
            #region LoadByKeys
            
            RegisterQuery(nameof(LoadByKeys), (query, alias) => query.
                Where(alias.Id.In(Parameter.New<System.String>(Param0))));

            #endregion

            #region LoadByName

            RegisterQuery(nameof(LoadByName), (query, alias) => query.
                Where(alias.Name == Parameter.New<System.String>(Param0)));

            #endregion

            #region LoadById

            RegisterQuery(nameof(LoadById), (query, alias) => query.
                Where(alias.Id == Parameter.New<System.String>(Param0)));

            #endregion

            AdditionalGeneratedStoredQueries();
        }
        public static CardSet LoadByName(System.String name)
        {
            return FromQuery(nameof(LoadByName), new Parameter(Param0, name)).FirstOrDefault();
        }
        public static CardSet LoadById(System.String id)
        {
            return FromQuery(nameof(LoadById), new Parameter(Param0, id)).FirstOrDefault();
        }
        partial void AdditionalGeneratedStoredQueries();

        public static Dictionary<System.String, CardSet> LoadByKeys(IEnumerable<System.String> ids)
        {
            return FromQuery(nameof(LoadByKeys), new Parameter(Param0, ids.ToArray(), typeof(System.String))).ToDictionary(item=> item.Id, item => item);
        }

        protected static void RegisterQuery(string name, Func<IMatchQuery, q.CardSetAlias, IWhereQuery> query)
        {
            q.CardSetAlias alias;

            IMatchQuery matchQuery = Blueprint41.Transaction.CompiledQuery.Match(q.Node.CardSet.Alias(out alias, "node"));
            IWhereQuery partial = query.Invoke(matchQuery, alias);
            ICompiled compiled = partial.Return(alias).Compile();

            RegisterQuery(name, compiled);
        }

        public override string ToString()
        {
            return $"CardSet => Name : {this.Name}, Id : {this.Id}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected override void LazySet()
        {
            base.LazySet();
            if (PersistenceState == PersistenceState.NewAndChanged || PersistenceState == PersistenceState.LoadedAndChanged)
            {
                if (ReferenceEquals(InnerData, OriginalData))
                    OriginalData = new CardSetData(InnerData);
            }
        }


        #endregion

        #region Validations

        protected override void ValidateSave()
        {
            bool isUpdate = (PersistenceState != PersistenceState.New && PersistenceState != PersistenceState.NewAndChanged);

            if (InnerData.Name is null)
                throw new PersistenceException(string.Format("Cannot save CardSet with key '{0}' because the Name cannot be null.", this.Id?.ToString() ?? "<null>"));
        }

        protected override void ValidateDelete()
        {
        }

        #endregion

        #region Inner Data

        public class CardSetData : Data<System.String>
        {
            public CardSetData()
            {

            }

            public CardSetData(CardSetData data)
            {
                Name = data.Name;
                Id = data.Id;
                Cards = data.Cards;
            }


            #region Initialize Collections

            protected override void InitializeCollections()
            {
                NodeType = "CardSet";

                Cards = new EntityCollection<ICard>(Wrapper, Members.Cards, item => { if (Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers || Members.Cards.Events.HasRegisteredChangeHandlers) { object loadHack = item.CardSet; } });
            }
            public string NodeType { get; private set; }
            sealed public override System.String GetKey() { return Entity.Parent.PersistenceProvider.ConvertFromStoredType<System.String>(Id); }
            sealed protected override void SetKey(System.String key) { Id = (string)Entity.Parent.PersistenceProvider.ConvertToStoredType<System.String>(key); base.SetKey(Id); }

            #endregion
            #region Map Data

            sealed public override IDictionary<string, object> MapTo()
            {
                IDictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("Name",  Name);
                dictionary.Add("Id",  Id);
                return dictionary;
            }

            sealed public override void MapFrom(IReadOnlyDictionary<string, object> properties)
            {
                object value;
                if (properties.TryGetValue("Name", out value))
                    Name = (string)value;
                if (properties.TryGetValue("Id", out value))
                    Id = (string)value;
            }

            #endregion

            #region Members for interface ICardSet

            public string Name { get; set; }
            public string Id { get; set; }
            public EntityCollection<ICard> Cards { get; private set; }

            #endregion
        }

        #endregion

        #region Outer Data

        #region Members for interface ICardSet

        public string Name { get { LazyGet(); return InnerData.Name; } set { if (LazySet(Members.Name, InnerData.Name, value)) InnerData.Name = value; } }
        public string Id { get { return InnerData.Id; } set { KeySet(() => InnerData.Id = value); } }
        public EntityCollection<ICard> Cards { get { return InnerData.Cards; } }
        public IEnumerable<IValue> Cards_Value { get { return InnerData.Cards.Where(item => item is IValue).Cast<IValue>(); } }
        public IEnumerable<ICost> Cards_Cost { get { return InnerData.Cards.Where(item => item is ICost).Cast<ICost>(); } }
        public IEnumerable<Boss> Cards_Boss { get { return InnerData.Cards.Where(item => item is Boss).Cast<Boss>(); } }
        public IEnumerable<Action> Cards_Action { get { return InnerData.Cards.Where(item => item is Action).Cast<Action>(); } }
        public IEnumerable<Sbire> Cards_Sbire { get { return InnerData.Cards.Where(item => item is Sbire).Cast<Sbire>(); } }
        public IEnumerable<SbireUnique> Cards_SbireUnique { get { return InnerData.Cards.Where(item => item is SbireUnique).Cast<SbireUnique>(); } }
        public IEnumerable<Allie> Cards_Allie { get { return InnerData.Cards.Where(item => item is Allie).Cast<Allie>(); } }
        public IEnumerable<Eclipse> Cards_Eclipse { get { return InnerData.Cards.Where(item => item is Eclipse).Cast<Eclipse>(); } }
        public IEnumerable<Valise> Cards_Valise { get { return InnerData.Cards.Where(item => item is Valise).Cast<Valise>(); } }
        public IEnumerable<Reaction> Cards_Reaction { get { return InnerData.Cards.Where(item => item is Reaction).Cast<Reaction>(); } }
        private void ClearCards(DateTime? moment)
        {
            ((ILookupHelper<ICard>)InnerData.Cards).ClearLookup(moment);
        }

        #endregion

        #region Virtual Node Type
        
        public string NodeType  { get { return InnerData.NodeType; } }
        
        #endregion

        #endregion

        #region Relationship Properties

        #region Cards (Collection)

        public List<HAS_CARD> CardRelations()
        {
            return HAS_CARD.Load(_queryCardRelations.Value, ("key", Id));
        }
        private readonly Lazy<ICompiled> _queryCardRelations = new Lazy<ICompiled>(delegate()
        {
            return Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(inAlias.Id == key)
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();
        });
        public List<HAS_CARD> CardsWhere(Func<HAS_CARD.Alias, QueryCondition> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(inAlias.Id == Id)
                .And(expression.Invoke(new HAS_CARD.Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return HAS_CARD.Load(query);
        }
        public List<HAS_CARD> CardsWhere(Func<HAS_CARD.Alias, QueryCondition[]> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(inAlias.Id == Id)
                .And(expression.Invoke(new HAS_CARD.Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return HAS_CARD.Load(query);
        }
        public List<HAS_CARD> CardsWhere(JsNotation<System.DateTime?> CreationDate = default)
        {
            return CardsWhere(delegate(HAS_CARD.Alias alias)
            {
                List<QueryCondition> conditions = new List<QueryCondition>();

                if (CreationDate.HasValue) conditions.Add(alias.CreationDate == CreationDate.Value);

                return conditions.ToArray();
            });
        }
        public void AddCard(ICard card)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            ((ILookupHelper<ICard>)InnerData.Cards).AddItem(card, null, properties);
        }
        public void RemoveCard(ICard card)
        {
            Cards.Remove(card);
        }

        #endregion

        private static readonly Parameter key = Parameter.New<string>("key");
        private static readonly Parameter moment = Parameter.New<DateTime>("moment");

        #endregion

        #region Reflection

        private static CardSetMembers members = null;
        public static CardSetMembers Members
        {
            get
            {
                if (members is null)
                {
                    lock (typeof(CardSet))
                    {
                        if (members is null)
                            members = new CardSetMembers();
                    }
                }
                return members;
            }
        }
        public class CardSetMembers
        {
            internal CardSetMembers() { }

            #region Members for interface ICardSet

            public EntityProperty Name { get; } = DeckBuilder.Model.Datastore.Model.Entities["CardSet"].Properties["Name"];
            public EntityProperty Id { get; } = DeckBuilder.Model.Datastore.Model.Entities["CardSet"].Properties["Id"];
            public EntityProperty Cards { get; } = DeckBuilder.Model.Datastore.Model.Entities["CardSet"].Properties["Cards"];
            #endregion

        }

        private static CardSetFullTextMembers fullTextMembers = null;
        public static CardSetFullTextMembers FullTextMembers
        {
            get
            {
                if (fullTextMembers is null)
                {
                    lock (typeof(CardSet))
                    {
                        if (fullTextMembers is null)
                            fullTextMembers = new CardSetFullTextMembers();
                    }
                }
                return fullTextMembers;
            }
        }

        public class CardSetFullTextMembers
        {
            internal CardSetFullTextMembers() { }

        }

        sealed public override Entity GetEntity()
        {
            if (entity is null)
            {
                lock (typeof(CardSet))
                {
                    if (entity is null)
                        entity = DeckBuilder.Model.Datastore.Model.Entities["CardSet"];
                }
            }
            return entity;
        }

        private static CardSetEvents events = null;
        public static CardSetEvents Events
        {
            get
            {
                if (events is null)
                {
                    lock (typeof(CardSet))
                    {
                        if (events is null)
                            events = new CardSetEvents();
                    }
                }
                return events;
            }
        }
        public class CardSetEvents
        {

            #region OnNew

            private bool onNewIsRegistered = false;

            private EventHandler<CardSet, EntityEventArgs> onNew;
            public event EventHandler<CardSet, EntityEventArgs> OnNew
            {
                add
                {
                    lock (this)
                    {
                        if (!onNewIsRegistered)
                        {
                            Entity.Events.OnNew -= onNewProxy;
                            Entity.Events.OnNew += onNewProxy;
                            onNewIsRegistered = true;
                        }
                        onNew += value;
                    }
                }
                remove
                {
                    lock (this)
                    {
                        onNew -= value;
                        if (onNew is null && onNewIsRegistered)
                        {
                            Entity.Events.OnNew -= onNewProxy;
                            onNewIsRegistered = false;
                        }
                    }
                }
            }
            
            private void onNewProxy(object sender, EntityEventArgs args)
            {
                EventHandler<CardSet, EntityEventArgs> handler = onNew;
                if (handler is not null)
                    handler.Invoke((CardSet)sender, args);
            }

            #endregion

            #region OnDelete

            private bool onDeleteIsRegistered = false;

            private EventHandler<CardSet, EntityEventArgs> onDelete;
            public event EventHandler<CardSet, EntityEventArgs> OnDelete
            {
                add
                {
                    lock (this)
                    {
                        if (!onDeleteIsRegistered)
                        {
                            Entity.Events.OnDelete -= onDeleteProxy;
                            Entity.Events.OnDelete += onDeleteProxy;
                            onDeleteIsRegistered = true;
                        }
                        onDelete += value;
                    }
                }
                remove
                {
                    lock (this)
                    {
                        onDelete -= value;
                        if (onDelete is null && onDeleteIsRegistered)
                        {
                            Entity.Events.OnDelete -= onDeleteProxy;
                            onDeleteIsRegistered = false;
                        }
                    }
                }
            }
            
            private void onDeleteProxy(object sender, EntityEventArgs args)
            {
                EventHandler<CardSet, EntityEventArgs> handler = onDelete;
                if (handler is not null)
                    handler.Invoke((CardSet)sender, args);
            }

            #endregion

            #region OnSave

            private bool onSaveIsRegistered = false;

            private EventHandler<CardSet, EntityEventArgs> onSave;
            public event EventHandler<CardSet, EntityEventArgs> OnSave
            {
                add
                {
                    lock (this)
                    {
                        if (!onSaveIsRegistered)
                        {
                            Entity.Events.OnSave -= onSaveProxy;
                            Entity.Events.OnSave += onSaveProxy;
                            onSaveIsRegistered = true;
                        }
                        onSave += value;
                    }
                }
                remove
                {
                    lock (this)
                    {
                        onSave -= value;
                        if (onSave is null && onSaveIsRegistered)
                        {
                            Entity.Events.OnSave -= onSaveProxy;
                            onSaveIsRegistered = false;
                        }
                    }
                }
            }
            
            private void onSaveProxy(object sender, EntityEventArgs args)
            {
                EventHandler<CardSet, EntityEventArgs> handler = onSave;
                if (handler is not null)
                    handler.Invoke((CardSet)sender, args);
            }

            #endregion

            #region OnAfterSave

            private bool onAfterSaveIsRegistered = false;

            private EventHandler<CardSet, EntityEventArgs> onAfterSave;
            public event EventHandler<CardSet, EntityEventArgs> OnAfterSave
            {
                add
                {
                    lock (this)
                    {
                        if (!onAfterSaveIsRegistered)
                        {
                            Entity.Events.OnAfterSave -= onAfterSaveProxy;
                            Entity.Events.OnAfterSave += onAfterSaveProxy;
                            onAfterSaveIsRegistered = true;
                        }
                        onAfterSave += value;
                    }
                }
                remove
                {
                    lock (this)
                    {
                        onAfterSave -= value;
                        if (onAfterSave is null && onAfterSaveIsRegistered)
                        {
                            Entity.Events.OnAfterSave -= onAfterSaveProxy;
                            onAfterSaveIsRegistered = false;
                        }
                    }
                }
            }
            
            private void onAfterSaveProxy(object sender, EntityEventArgs args)
            {
                EventHandler<CardSet, EntityEventArgs> handler = onAfterSave;
                if (handler is not null)
                    handler.Invoke((CardSet)sender, args);
            }

            #endregion

            #region OnPropertyChange

            public static class OnPropertyChange
            {

                #region OnName

                private static bool onNameIsRegistered = false;

                private static EventHandler<CardSet, PropertyEventArgs> onName;
                public static event EventHandler<CardSet, PropertyEventArgs> OnName
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onNameIsRegistered)
                            {
                                Members.Name.Events.OnChange -= onNameProxy;
                                Members.Name.Events.OnChange += onNameProxy;
                                onNameIsRegistered = true;
                            }
                            onName += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onName -= value;
                            if (onName is null && onNameIsRegistered)
                            {
                                Members.Name.Events.OnChange -= onNameProxy;
                                onNameIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onNameProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<CardSet, PropertyEventArgs> handler = onName;
                    if (handler is not null)
                        handler.Invoke((CardSet)sender, args);
                }

                #endregion

                #region OnId

                private static bool onIdIsRegistered = false;

                private static EventHandler<CardSet, PropertyEventArgs> onId;
                public static event EventHandler<CardSet, PropertyEventArgs> OnId
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onIdIsRegistered)
                            {
                                Members.Id.Events.OnChange -= onIdProxy;
                                Members.Id.Events.OnChange += onIdProxy;
                                onIdIsRegistered = true;
                            }
                            onId += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onId -= value;
                            if (onId is null && onIdIsRegistered)
                            {
                                Members.Id.Events.OnChange -= onIdProxy;
                                onIdIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onIdProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<CardSet, PropertyEventArgs> handler = onId;
                    if (handler is not null)
                        handler.Invoke((CardSet)sender, args);
                }

                #endregion

                #region OnCards

                private static bool onCardsIsRegistered = false;

                private static EventHandler<CardSet, PropertyEventArgs> onCards;
                public static event EventHandler<CardSet, PropertyEventArgs> OnCards
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onCardsIsRegistered)
                            {
                                Members.Cards.Events.OnChange -= onCardsProxy;
                                Members.Cards.Events.OnChange += onCardsProxy;
                                onCardsIsRegistered = true;
                            }
                            onCards += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onCards -= value;
                            if (onCards is null && onCardsIsRegistered)
                            {
                                Members.Cards.Events.OnChange -= onCardsProxy;
                                onCardsIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onCardsProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<CardSet, PropertyEventArgs> handler = onCards;
                    if (handler is not null)
                        handler.Invoke((CardSet)sender, args);
                }

                #endregion

            }

            #endregion
        }

        #endregion

        #region ICardSetOriginalData

        public ICardSetOriginalData OriginalVersion { get { return this; } }

        #region Members for interface ICardSet

        string ICardSetOriginalData.Name { get { return OriginalData.Name; } }
        string ICardSetOriginalData.Id { get { return OriginalData.Id; } }
        IEnumerable<ICard> ICardSetOriginalData.Cards { get { return OriginalData.Cards.OriginalData; } }
        IEnumerable<IValue> ICardSetOriginalData.Cards_Value { get { return OriginalData.Cards.OriginalData.Where(item => item is IValue).Select(item => item as IValue); } }
        IEnumerable<ICost> ICardSetOriginalData.Cards_Cost { get { return OriginalData.Cards.OriginalData.Where(item => item is ICost).Select(item => item as ICost); } }
        IEnumerable<Boss> ICardSetOriginalData.Cards_Boss { get { return OriginalData.Cards.OriginalData.Where(item => item is Boss).Select(item => item as Boss); } }
        IEnumerable<Action> ICardSetOriginalData.Cards_Action { get { return OriginalData.Cards.OriginalData.Where(item => item is Action).Select(item => item as Action); } }
        IEnumerable<Sbire> ICardSetOriginalData.Cards_Sbire { get { return OriginalData.Cards.OriginalData.Where(item => item is Sbire).Select(item => item as Sbire); } }
        IEnumerable<SbireUnique> ICardSetOriginalData.Cards_SbireUnique { get { return OriginalData.Cards.OriginalData.Where(item => item is SbireUnique).Select(item => item as SbireUnique); } }
        IEnumerable<Allie> ICardSetOriginalData.Cards_Allie { get { return OriginalData.Cards.OriginalData.Where(item => item is Allie).Select(item => item as Allie); } }
        IEnumerable<Eclipse> ICardSetOriginalData.Cards_Eclipse { get { return OriginalData.Cards.OriginalData.Where(item => item is Eclipse).Select(item => item as Eclipse); } }
        IEnumerable<Valise> ICardSetOriginalData.Cards_Valise { get { return OriginalData.Cards.OriginalData.Where(item => item is Valise).Select(item => item as Valise); } }
        IEnumerable<Reaction> ICardSetOriginalData.Cards_Reaction { get { return OriginalData.Cards.OriginalData.Where(item => item is Reaction).Select(item => item as Reaction); } }

        #endregion
        #endregion
    }
}
