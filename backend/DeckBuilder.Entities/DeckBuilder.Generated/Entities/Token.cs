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
    public interface ITokenOriginalData
    {
        string Name { get; }
        string Id { get; }
    }

    public partial class Token : OGM<Token, Token.TokenData, System.String>, ITokenOriginalData
    {
        #region Initialize


        [Obsolete]
        static Token()
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
        public static Token LoadById(System.String id)
        {
            return FromQuery(nameof(LoadById), new Parameter(Param0, id)).FirstOrDefault();
        }
        partial void AdditionalGeneratedStoredQueries();

        public static Dictionary<System.String, Token> LoadByKeys(IEnumerable<System.String> ids)
        {
            return FromQuery(nameof(LoadByKeys), new Parameter(Param0, ids.ToArray(), typeof(System.String))).ToDictionary(item=> item.Id, item => item);
        }

        protected static void RegisterQuery(string name, Func<IMatchQuery, q.TokenAlias, IWhereQuery> query)
        {
            q.TokenAlias alias;

            IMatchQuery matchQuery = Blueprint41.Transaction.CompiledQuery.Match(q.Node.Token.Alias(out alias, "node"));
            IWhereQuery partial = query.Invoke(matchQuery, alias);
            ICompiled compiled = partial.Return(alias).Compile();

            RegisterQuery(name, compiled);
        }

        public override string ToString()
        {
            return $"Token => Name : {this.Name}, Id : {this.Id}";
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
                    OriginalData = new TokenData(InnerData);
            }
        }


        #endregion

        #region Validations

        protected override void ValidateSave()
        {
            bool isUpdate = (PersistenceState != PersistenceState.New && PersistenceState != PersistenceState.NewAndChanged);

            if (InnerData.Name is null)
                throw new PersistenceException(string.Format("Cannot save Token with key '{0}' because the Name cannot be null.", this.Id?.ToString() ?? "<null>"));
        }

        protected override void ValidateDelete()
        {
        }

        #endregion

        #region Inner Data

        public class TokenData : Data<System.String>
        {
            public TokenData()
            {

            }

            public TokenData(TokenData data)
            {
                Name = data.Name;
                Id = data.Id;
            }


            #region Initialize Collections

            protected override void InitializeCollections()
            {
                NodeType = "Token";

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

            #region Members for interface IToken

            public string Name { get; set; }
            public string Id { get; set; }

            #endregion
        }

        #endregion

        #region Outer Data

        #region Members for interface IToken

        public string Name { get { LazyGet(); return InnerData.Name; } set { if (LazySet(Members.Name, InnerData.Name, value)) InnerData.Name = value; } }
        public string Id { get { return InnerData.Id; } set { KeySet(() => InnerData.Id = value); } }

        #endregion

        #region Virtual Node Type
        
        public string NodeType  { get { return InnerData.NodeType; } }
        
        #endregion

        #endregion

        #region Relationship Properties

        private static readonly Parameter key = Parameter.New<string>("key");
        private static readonly Parameter moment = Parameter.New<DateTime>("moment");

        #endregion

        #region Reflection

        private static TokenMembers members = null;
        public static TokenMembers Members
        {
            get
            {
                if (members is null)
                {
                    lock (typeof(Token))
                    {
                        if (members is null)
                            members = new TokenMembers();
                    }
                }
                return members;
            }
        }
        public class TokenMembers
        {
            internal TokenMembers() { }

            #region Members for interface IToken

            public EntityProperty Name { get; } = DeckBuilder.Model.Datastore.Model.Entities["Token"].Properties["Name"];
            public EntityProperty Id { get; } = DeckBuilder.Model.Datastore.Model.Entities["Token"].Properties["Id"];
            #endregion

        }

        private static TokenFullTextMembers fullTextMembers = null;
        public static TokenFullTextMembers FullTextMembers
        {
            get
            {
                if (fullTextMembers is null)
                {
                    lock (typeof(Token))
                    {
                        if (fullTextMembers is null)
                            fullTextMembers = new TokenFullTextMembers();
                    }
                }
                return fullTextMembers;
            }
        }

        public class TokenFullTextMembers
        {
            internal TokenFullTextMembers() { }

        }

        sealed public override Entity GetEntity()
        {
            if (entity is null)
            {
                lock (typeof(Token))
                {
                    if (entity is null)
                        entity = DeckBuilder.Model.Datastore.Model.Entities["Token"];
                }
            }
            return entity;
        }

        private static TokenEvents events = null;
        public static TokenEvents Events
        {
            get
            {
                if (events is null)
                {
                    lock (typeof(Token))
                    {
                        if (events is null)
                            events = new TokenEvents();
                    }
                }
                return events;
            }
        }
        public class TokenEvents
        {

            #region OnNew

            private bool onNewIsRegistered = false;

            private EventHandler<Token, EntityEventArgs> onNew;
            public event EventHandler<Token, EntityEventArgs> OnNew
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
                EventHandler<Token, EntityEventArgs> handler = onNew;
                if (handler is not null)
                    handler.Invoke((Token)sender, args);
            }

            #endregion

            #region OnDelete

            private bool onDeleteIsRegistered = false;

            private EventHandler<Token, EntityEventArgs> onDelete;
            public event EventHandler<Token, EntityEventArgs> OnDelete
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
                EventHandler<Token, EntityEventArgs> handler = onDelete;
                if (handler is not null)
                    handler.Invoke((Token)sender, args);
            }

            #endregion

            #region OnSave

            private bool onSaveIsRegistered = false;

            private EventHandler<Token, EntityEventArgs> onSave;
            public event EventHandler<Token, EntityEventArgs> OnSave
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
                EventHandler<Token, EntityEventArgs> handler = onSave;
                if (handler is not null)
                    handler.Invoke((Token)sender, args);
            }

            #endregion

            #region OnAfterSave

            private bool onAfterSaveIsRegistered = false;

            private EventHandler<Token, EntityEventArgs> onAfterSave;
            public event EventHandler<Token, EntityEventArgs> OnAfterSave
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
                EventHandler<Token, EntityEventArgs> handler = onAfterSave;
                if (handler is not null)
                    handler.Invoke((Token)sender, args);
            }

            #endregion

            #region OnPropertyChange

            public static class OnPropertyChange
            {

                #region OnName

                private static bool onNameIsRegistered = false;

                private static EventHandler<Token, PropertyEventArgs> onName;
                public static event EventHandler<Token, PropertyEventArgs> OnName
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
                    EventHandler<Token, PropertyEventArgs> handler = onName;
                    if (handler is not null)
                        handler.Invoke((Token)sender, args);
                }

                #endregion

                #region OnId

                private static bool onIdIsRegistered = false;

                private static EventHandler<Token, PropertyEventArgs> onId;
                public static event EventHandler<Token, PropertyEventArgs> OnId
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
                    EventHandler<Token, PropertyEventArgs> handler = onId;
                    if (handler is not null)
                        handler.Invoke((Token)sender, args);
                }

                #endregion

            }

            #endregion
        }

        #endregion

        #region ITokenOriginalData

        public ITokenOriginalData OriginalVersion { get { return this; } }

        #region Members for interface IToken

        string ITokenOriginalData.Name { get { return OriginalData.Name; } }
        string ITokenOriginalData.Id { get { return OriginalData.Id; } }

        #endregion
        #endregion
    }
}
