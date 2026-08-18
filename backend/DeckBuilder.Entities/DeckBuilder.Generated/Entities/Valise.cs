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
    public interface IValiseOriginalData : ICardOriginalData
    {
    }

    public partial class Valise : OGM<Valise, Valise.ValiseData, System.String>, ICard, IValiseOriginalData
    {
        #region Initialize


        [Obsolete]
        static Valise()
        {
            Register.Types();
        }


        protected override void RegisterGeneratedStoredQueries()
        {
            #region LoadByKeys
            
            RegisterQuery(nameof(LoadByKeys), (query, alias) => query.
                Where(alias.Id.In(Parameter.New<System.String>(Param0))));

            #endregion

            AdditionalGeneratedStoredQueries();
        }
        partial void AdditionalGeneratedStoredQueries();

        public static Dictionary<System.String, Valise> LoadByKeys(IEnumerable<System.String> ids)
        {
            return FromQuery(nameof(LoadByKeys), new Parameter(Param0, ids.ToArray(), typeof(System.String))).ToDictionary(item=> item.Id, item => item);
        }

        protected static void RegisterQuery(string name, Func<IMatchQuery, q.ValiseAlias, IWhereQuery> query)
        {
            q.ValiseAlias alias;

            IMatchQuery matchQuery = Blueprint41.Transaction.CompiledQuery.Match(q.Node.Valise.Alias(out alias, "node"));
            IWhereQuery partial = query.Invoke(matchQuery, alias);
            ICompiled compiled = partial.Return(alias).Compile();

            RegisterQuery(name, compiled);
        }

        public override string ToString()
        {
            return $"Valise => Name : {this.Name}, BaseEffect : {this.BaseEffect?.ToString() ?? "null"}, ReactionEffect : {this.ReactionEffect?.ToString() ?? "null"}, EnteringEffect : {this.EnteringEffect?.ToString() ?? "null"}, LeavingEffect : {this.LeavingEffect?.ToString() ?? "null"}, ActivationEffect : {this.ActivationEffect?.ToString() ?? "null"}, MandatoryActivationEffect : {this.MandatoryActivationEffect?.ToString() ?? "null"}, PermanentEffect : {this.PermanentEffect?.ToString() ?? "null"}, LoosingEffect : {this.LoosingEffect?.ToString() ?? "null"}, Lore : {this.Lore?.ToString() ?? "null"}, Id : {this.Id}";
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
                    OriginalData = new ValiseData(InnerData);
            }
        }


        #endregion

        #region Validations

        protected override void ValidateSave()
        {
            bool isUpdate = (PersistenceState != PersistenceState.New && PersistenceState != PersistenceState.NewAndChanged);

            if (InnerData.Name is null)
                throw new PersistenceException(string.Format("Cannot save Valise with key '{0}' because the Name cannot be null.", this.Id?.ToString() ?? "<null>"));
        }

        protected override void ValidateDelete()
        {
        }

        #endregion

        #region Inner Data

        public class ValiseData : Data<System.String>
        {
            public ValiseData()
            {

            }

            public ValiseData(ValiseData data)
            {
                Name = data.Name;
                BaseEffect = data.BaseEffect;
                ReactionEffect = data.ReactionEffect;
                EnteringEffect = data.EnteringEffect;
                LeavingEffect = data.LeavingEffect;
                ActivationEffect = data.ActivationEffect;
                MandatoryActivationEffect = data.MandatoryActivationEffect;
                PermanentEffect = data.PermanentEffect;
                LoosingEffect = data.LoosingEffect;
                Lore = data.Lore;
                Id = data.Id;
                CardSet = data.CardSet;
            }


            #region Initialize Collections

            protected override void InitializeCollections()
            {
                NodeType = "Valise";

                CardSet = new EntityCollection<CardSet>(Wrapper, Members.CardSet, item => { if (Members.CardSet.Events.HasRegisteredChangeHandlers) { int loadHack = item.Cards.Count; } });
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
                dictionary.Add("BaseEffect",  BaseEffect);
                dictionary.Add("ReactionEffect",  ReactionEffect);
                dictionary.Add("EnteringEffect",  EnteringEffect);
                dictionary.Add("LeavingEffect",  LeavingEffect);
                dictionary.Add("ActivationEffect",  ActivationEffect);
                dictionary.Add("MandatoryActivationEffect",  MandatoryActivationEffect);
                dictionary.Add("PermanentEffect",  PermanentEffect);
                dictionary.Add("LoosingEffect",  LoosingEffect);
                dictionary.Add("Lore",  Lore);
                dictionary.Add("Id",  Id);
                return dictionary;
            }

            sealed public override void MapFrom(IReadOnlyDictionary<string, object> properties)
            {
                object value;
                if (properties.TryGetValue("Name", out value))
                    Name = (string)value;
                if (properties.TryGetValue("BaseEffect", out value))
                    BaseEffect = (string)value;
                if (properties.TryGetValue("ReactionEffect", out value))
                    ReactionEffect = (string)value;
                if (properties.TryGetValue("EnteringEffect", out value))
                    EnteringEffect = (string)value;
                if (properties.TryGetValue("LeavingEffect", out value))
                    LeavingEffect = (string)value;
                if (properties.TryGetValue("ActivationEffect", out value))
                    ActivationEffect = (string)value;
                if (properties.TryGetValue("MandatoryActivationEffect", out value))
                    MandatoryActivationEffect = (string)value;
                if (properties.TryGetValue("PermanentEffect", out value))
                    PermanentEffect = (string)value;
                if (properties.TryGetValue("LoosingEffect", out value))
                    LoosingEffect = (string)value;
                if (properties.TryGetValue("Lore", out value))
                    Lore = (string)value;
                if (properties.TryGetValue("Id", out value))
                    Id = (string)value;
            }

            #endregion

            #region Members for interface IValise


            #endregion
            #region Members for interface ICard

            public string Name { get; set; }
            public string BaseEffect { get; set; }
            public string ReactionEffect { get; set; }
            public string EnteringEffect { get; set; }
            public string LeavingEffect { get; set; }
            public string ActivationEffect { get; set; }
            public string MandatoryActivationEffect { get; set; }
            public string PermanentEffect { get; set; }
            public string LoosingEffect { get; set; }
            public string Lore { get; set; }
            public string Id { get; set; }
            public EntityCollection<CardSet> CardSet { get; private set; }

            #endregion
        }

        #endregion

        #region Outer Data

        #region Members for interface IValise


        #endregion
        #region Members for interface ICard

        public string Name { get { LazyGet(); return InnerData.Name; } set { if (LazySet(Members.Name, InnerData.Name, value)) InnerData.Name = value; } }
        public string BaseEffect { get { LazyGet(); return InnerData.BaseEffect; } set { if (LazySet(Members.BaseEffect, InnerData.BaseEffect, value)) InnerData.BaseEffect = value; } }
        public string ReactionEffect { get { LazyGet(); return InnerData.ReactionEffect; } set { if (LazySet(Members.ReactionEffect, InnerData.ReactionEffect, value)) InnerData.ReactionEffect = value; } }
        public string EnteringEffect { get { LazyGet(); return InnerData.EnteringEffect; } set { if (LazySet(Members.EnteringEffect, InnerData.EnteringEffect, value)) InnerData.EnteringEffect = value; } }
        public string LeavingEffect { get { LazyGet(); return InnerData.LeavingEffect; } set { if (LazySet(Members.LeavingEffect, InnerData.LeavingEffect, value)) InnerData.LeavingEffect = value; } }
        public string ActivationEffect { get { LazyGet(); return InnerData.ActivationEffect; } set { if (LazySet(Members.ActivationEffect, InnerData.ActivationEffect, value)) InnerData.ActivationEffect = value; } }
        public string MandatoryActivationEffect { get { LazyGet(); return InnerData.MandatoryActivationEffect; } set { if (LazySet(Members.MandatoryActivationEffect, InnerData.MandatoryActivationEffect, value)) InnerData.MandatoryActivationEffect = value; } }
        public string PermanentEffect { get { LazyGet(); return InnerData.PermanentEffect; } set { if (LazySet(Members.PermanentEffect, InnerData.PermanentEffect, value)) InnerData.PermanentEffect = value; } }
        public string LoosingEffect { get { LazyGet(); return InnerData.LoosingEffect; } set { if (LazySet(Members.LoosingEffect, InnerData.LoosingEffect, value)) InnerData.LoosingEffect = value; } }
        public string Lore { get { LazyGet(); return InnerData.Lore; } set { if (LazySet(Members.Lore, InnerData.Lore, value)) InnerData.Lore = value; } }
        public string Id { get { return InnerData.Id; } set { KeySet(() => InnerData.Id = value); } }
        public CardSet CardSet
        {
            get { return ((ILookupHelper<CardSet>)InnerData.CardSet).GetItem(null); }
            set 
            { 
                if (LazySet(Members.CardSet, ((ILookupHelper<CardSet>)InnerData.CardSet).GetItem(null), value))
                    ((ILookupHelper<CardSet>)InnerData.CardSet).SetItem(value, null); 
            }
        }
        private void ClearCardSet(DateTime? moment)
        {
            ((ILookupHelper<CardSet>)InnerData.CardSet).ClearLookup(moment);
        }

        #endregion

        #region Virtual Node Type
        
        public string NodeType  { get { return InnerData.NodeType; } }
        
        #endregion

        #endregion

        #region Relationship Properties

        #region CardSet (Lookup)

        public HAS_CARD CardSetRelation()
        {
            return HAS_CARD.Load(_queryCardSetRelation.Value, ("key", Id)).FirstOrDefault();
        }
        private readonly Lazy<ICompiled> _queryCardSetRelation = new Lazy<ICompiled>(delegate()
        {
            return Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(outAlias.Id == key)
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();
        });
        public HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(outAlias.Id == Id)
                .And(expression.Invoke(new HAS_CARD.Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return HAS_CARD.Load(query).FirstOrDefault();
        }
        public HAS_CARD GetCardSetIf(Func<HAS_CARD.Alias, QueryCondition[]> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(outAlias.Id == Id)
                .And(expression.Invoke(new HAS_CARD.Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return HAS_CARD.Load(query).FirstOrDefault();
        }
        public HAS_CARD GetCardSetIf(JsNotation<System.DateTime?> CreationDate = default)
        {
            return GetCardSetIf(delegate(HAS_CARD.Alias alias)
            {
                List<QueryCondition> conditions = new List<QueryCondition>();

                if (CreationDate.HasValue) conditions.Add(alias.CreationDate == CreationDate.Value);

                return conditions.ToArray();
            });
        }
        public void SetCardSet(CardSet cardSet)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();

            ((ILookupHelper<CardSet>)InnerData.CardSet).SetItem(cardSet, null, properties);
        }

        #endregion

        private static readonly Parameter key = Parameter.New<string>("key");
        private static readonly Parameter moment = Parameter.New<DateTime>("moment");

        #endregion

        #region Reflection

        private static ValiseMembers members = null;
        public static ValiseMembers Members
        {
            get
            {
                if (members is null)
                {
                    lock (typeof(Valise))
                    {
                        if (members is null)
                            members = new ValiseMembers();
                    }
                }
                return members;
            }
        }
        public class ValiseMembers
        {
            internal ValiseMembers() { }

            #region Members for interface IValise

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

        private static ValiseFullTextMembers fullTextMembers = null;
        public static ValiseFullTextMembers FullTextMembers
        {
            get
            {
                if (fullTextMembers is null)
                {
                    lock (typeof(Valise))
                    {
                        if (fullTextMembers is null)
                            fullTextMembers = new ValiseFullTextMembers();
                    }
                }
                return fullTextMembers;
            }
        }

        public class ValiseFullTextMembers
        {
            internal ValiseFullTextMembers() { }

        }

        sealed public override Entity GetEntity()
        {
            if (entity is null)
            {
                lock (typeof(Valise))
                {
                    if (entity is null)
                        entity = DeckBuilder.Model.Datastore.Model.Entities["Valise"];
                }
            }
            return entity;
        }

        private static ValiseEvents events = null;
        public static ValiseEvents Events
        {
            get
            {
                if (events is null)
                {
                    lock (typeof(Valise))
                    {
                        if (events is null)
                            events = new ValiseEvents();
                    }
                }
                return events;
            }
        }
        public class ValiseEvents
        {

            #region OnNew

            private bool onNewIsRegistered = false;

            private EventHandler<Valise, EntityEventArgs> onNew;
            public event EventHandler<Valise, EntityEventArgs> OnNew
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
                EventHandler<Valise, EntityEventArgs> handler = onNew;
                if (handler is not null)
                    handler.Invoke((Valise)sender, args);
            }

            #endregion

            #region OnDelete

            private bool onDeleteIsRegistered = false;

            private EventHandler<Valise, EntityEventArgs> onDelete;
            public event EventHandler<Valise, EntityEventArgs> OnDelete
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
                EventHandler<Valise, EntityEventArgs> handler = onDelete;
                if (handler is not null)
                    handler.Invoke((Valise)sender, args);
            }

            #endregion

            #region OnSave

            private bool onSaveIsRegistered = false;

            private EventHandler<Valise, EntityEventArgs> onSave;
            public event EventHandler<Valise, EntityEventArgs> OnSave
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
                EventHandler<Valise, EntityEventArgs> handler = onSave;
                if (handler is not null)
                    handler.Invoke((Valise)sender, args);
            }

            #endregion

            #region OnAfterSave

            private bool onAfterSaveIsRegistered = false;

            private EventHandler<Valise, EntityEventArgs> onAfterSave;
            public event EventHandler<Valise, EntityEventArgs> OnAfterSave
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
                EventHandler<Valise, EntityEventArgs> handler = onAfterSave;
                if (handler is not null)
                    handler.Invoke((Valise)sender, args);
            }

            #endregion

            #region OnPropertyChange

            public static class OnPropertyChange
            {

                #region OnName

                private static bool onNameIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onName;
                public static event EventHandler<Valise, PropertyEventArgs> OnName
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
                    EventHandler<Valise, PropertyEventArgs> handler = onName;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnBaseEffect

                private static bool onBaseEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onBaseEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnBaseEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onBaseEffectIsRegistered)
                            {
                                Members.BaseEffect.Events.OnChange -= onBaseEffectProxy;
                                Members.BaseEffect.Events.OnChange += onBaseEffectProxy;
                                onBaseEffectIsRegistered = true;
                            }
                            onBaseEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onBaseEffect -= value;
                            if (onBaseEffect is null && onBaseEffectIsRegistered)
                            {
                                Members.BaseEffect.Events.OnChange -= onBaseEffectProxy;
                                onBaseEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onBaseEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onBaseEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnReactionEffect

                private static bool onReactionEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onReactionEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnReactionEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onReactionEffectIsRegistered)
                            {
                                Members.ReactionEffect.Events.OnChange -= onReactionEffectProxy;
                                Members.ReactionEffect.Events.OnChange += onReactionEffectProxy;
                                onReactionEffectIsRegistered = true;
                            }
                            onReactionEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onReactionEffect -= value;
                            if (onReactionEffect is null && onReactionEffectIsRegistered)
                            {
                                Members.ReactionEffect.Events.OnChange -= onReactionEffectProxy;
                                onReactionEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onReactionEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onReactionEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnEnteringEffect

                private static bool onEnteringEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onEnteringEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnEnteringEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onEnteringEffectIsRegistered)
                            {
                                Members.EnteringEffect.Events.OnChange -= onEnteringEffectProxy;
                                Members.EnteringEffect.Events.OnChange += onEnteringEffectProxy;
                                onEnteringEffectIsRegistered = true;
                            }
                            onEnteringEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onEnteringEffect -= value;
                            if (onEnteringEffect is null && onEnteringEffectIsRegistered)
                            {
                                Members.EnteringEffect.Events.OnChange -= onEnteringEffectProxy;
                                onEnteringEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onEnteringEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onEnteringEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnLeavingEffect

                private static bool onLeavingEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onLeavingEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnLeavingEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onLeavingEffectIsRegistered)
                            {
                                Members.LeavingEffect.Events.OnChange -= onLeavingEffectProxy;
                                Members.LeavingEffect.Events.OnChange += onLeavingEffectProxy;
                                onLeavingEffectIsRegistered = true;
                            }
                            onLeavingEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onLeavingEffect -= value;
                            if (onLeavingEffect is null && onLeavingEffectIsRegistered)
                            {
                                Members.LeavingEffect.Events.OnChange -= onLeavingEffectProxy;
                                onLeavingEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onLeavingEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onLeavingEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnActivationEffect

                private static bool onActivationEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onActivationEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnActivationEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onActivationEffectIsRegistered)
                            {
                                Members.ActivationEffect.Events.OnChange -= onActivationEffectProxy;
                                Members.ActivationEffect.Events.OnChange += onActivationEffectProxy;
                                onActivationEffectIsRegistered = true;
                            }
                            onActivationEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onActivationEffect -= value;
                            if (onActivationEffect is null && onActivationEffectIsRegistered)
                            {
                                Members.ActivationEffect.Events.OnChange -= onActivationEffectProxy;
                                onActivationEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onActivationEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onActivationEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnMandatoryActivationEffect

                private static bool onMandatoryActivationEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onMandatoryActivationEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnMandatoryActivationEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onMandatoryActivationEffectIsRegistered)
                            {
                                Members.MandatoryActivationEffect.Events.OnChange -= onMandatoryActivationEffectProxy;
                                Members.MandatoryActivationEffect.Events.OnChange += onMandatoryActivationEffectProxy;
                                onMandatoryActivationEffectIsRegistered = true;
                            }
                            onMandatoryActivationEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onMandatoryActivationEffect -= value;
                            if (onMandatoryActivationEffect is null && onMandatoryActivationEffectIsRegistered)
                            {
                                Members.MandatoryActivationEffect.Events.OnChange -= onMandatoryActivationEffectProxy;
                                onMandatoryActivationEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onMandatoryActivationEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onMandatoryActivationEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnPermanentEffect

                private static bool onPermanentEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onPermanentEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnPermanentEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onPermanentEffectIsRegistered)
                            {
                                Members.PermanentEffect.Events.OnChange -= onPermanentEffectProxy;
                                Members.PermanentEffect.Events.OnChange += onPermanentEffectProxy;
                                onPermanentEffectIsRegistered = true;
                            }
                            onPermanentEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onPermanentEffect -= value;
                            if (onPermanentEffect is null && onPermanentEffectIsRegistered)
                            {
                                Members.PermanentEffect.Events.OnChange -= onPermanentEffectProxy;
                                onPermanentEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onPermanentEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onPermanentEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnLoosingEffect

                private static bool onLoosingEffectIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onLoosingEffect;
                public static event EventHandler<Valise, PropertyEventArgs> OnLoosingEffect
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onLoosingEffectIsRegistered)
                            {
                                Members.LoosingEffect.Events.OnChange -= onLoosingEffectProxy;
                                Members.LoosingEffect.Events.OnChange += onLoosingEffectProxy;
                                onLoosingEffectIsRegistered = true;
                            }
                            onLoosingEffect += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onLoosingEffect -= value;
                            if (onLoosingEffect is null && onLoosingEffectIsRegistered)
                            {
                                Members.LoosingEffect.Events.OnChange -= onLoosingEffectProxy;
                                onLoosingEffectIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onLoosingEffectProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onLoosingEffect;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnLore

                private static bool onLoreIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onLore;
                public static event EventHandler<Valise, PropertyEventArgs> OnLore
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onLoreIsRegistered)
                            {
                                Members.Lore.Events.OnChange -= onLoreProxy;
                                Members.Lore.Events.OnChange += onLoreProxy;
                                onLoreIsRegistered = true;
                            }
                            onLore += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onLore -= value;
                            if (onLore is null && onLoreIsRegistered)
                            {
                                Members.Lore.Events.OnChange -= onLoreProxy;
                                onLoreIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onLoreProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onLore;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnId

                private static bool onIdIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onId;
                public static event EventHandler<Valise, PropertyEventArgs> OnId
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
                    EventHandler<Valise, PropertyEventArgs> handler = onId;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

                #region OnCardSet

                private static bool onCardSetIsRegistered = false;

                private static EventHandler<Valise, PropertyEventArgs> onCardSet;
                public static event EventHandler<Valise, PropertyEventArgs> OnCardSet
                {
                    add
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            if (!onCardSetIsRegistered)
                            {
                                Members.CardSet.Events.OnChange -= onCardSetProxy;
                                Members.CardSet.Events.OnChange += onCardSetProxy;
                                onCardSetIsRegistered = true;
                            }
                            onCardSet += value;
                        }
                    }
                    remove
                    {
                        lock (typeof(OnPropertyChange))
                        {
                            onCardSet -= value;
                            if (onCardSet is null && onCardSetIsRegistered)
                            {
                                Members.CardSet.Events.OnChange -= onCardSetProxy;
                                onCardSetIsRegistered = false;
                            }
                        }
                    }
                }
            
                private static void onCardSetProxy(object sender, PropertyEventArgs args)
                {
                    EventHandler<Valise, PropertyEventArgs> handler = onCardSet;
                    if (handler is not null)
                        handler.Invoke((Valise)sender, args);
                }

                #endregion

            }

            #endregion
        }

        #endregion

        #region Static Data

        public static class StaticData
        {
            /// <summary>
            /// Get the 'Key' value for the corresponding ActivationEffect
            /// </summary>
            public static class ActivationEffect
            {
                public static bool Exist(string activationEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding BaseEffect
            /// </summary>
            public static class BaseEffect
            {
                public static bool Exist(string baseEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding EnteringEffect
            /// </summary>
            public static class EnteringEffect
            {
                public static bool Exist(string enteringEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding Id
            /// </summary>
            public static class Id
            {
                public static bool Exist(string id)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding LeavingEffect
            /// </summary>
            public static class LeavingEffect
            {
                public static bool Exist(string leavingEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding LoosingEffect
            /// </summary>
            public static class LoosingEffect
            {
                public static bool Exist(string loosingEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding Lore
            /// </summary>
            public static class Lore
            {
                public static bool Exist(string lore)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding MandatoryActivationEffect
            /// </summary>
            public static class MandatoryActivationEffect
            {
                public static bool Exist(string mandatoryActivationEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding Name
            /// </summary>
            public static class Name
            {
                public static bool Exist(string name)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding PermanentEffect
            /// </summary>
            public static class PermanentEffect
            {
                public static bool Exist(string permanentEffect)
                {
                    return false;
                }
            }
            /// <summary>
            /// Get the 'Key' value for the corresponding ReactionEffect
            /// </summary>
            public static class ReactionEffect
            {
                public static bool Exist(string reactionEffect)
                {
                    return false;
                }
            }
        }

        #endregion

        #region IValiseOriginalData

        public IValiseOriginalData OriginalVersion { get { return this; } }

        #region Members for interface IValise


        #endregion
        #region Members for interface ICard

        ICardOriginalData ICard.OriginalVersion { get { return this; } }

        string ICardOriginalData.Name { get { return OriginalData.Name; } }
        string ICardOriginalData.BaseEffect { get { return OriginalData.BaseEffect; } }
        string ICardOriginalData.ReactionEffect { get { return OriginalData.ReactionEffect; } }
        string ICardOriginalData.EnteringEffect { get { return OriginalData.EnteringEffect; } }
        string ICardOriginalData.LeavingEffect { get { return OriginalData.LeavingEffect; } }
        string ICardOriginalData.ActivationEffect { get { return OriginalData.ActivationEffect; } }
        string ICardOriginalData.MandatoryActivationEffect { get { return OriginalData.MandatoryActivationEffect; } }
        string ICardOriginalData.PermanentEffect { get { return OriginalData.PermanentEffect; } }
        string ICardOriginalData.LoosingEffect { get { return OriginalData.LoosingEffect; } }
        string ICardOriginalData.Lore { get { return OriginalData.Lore; } }
        string ICardOriginalData.Id { get { return OriginalData.Id; } }
        CardSet ICardOriginalData.CardSet { get { return ((ILookupHelper<CardSet>)OriginalData.CardSet).GetOriginalItem(null); } }

        #endregion
        #endregion
    }
}
