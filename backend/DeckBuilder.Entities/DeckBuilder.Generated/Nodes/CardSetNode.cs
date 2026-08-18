#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using System.Collections.Generic;

using Blueprint41;
using Blueprint41.Core;
using Blueprint41.Neo4j.Model;
using Blueprint41.Query;

using m = DeckBuilder.Generated.Manipulation;

namespace DeckBuilder.Generated.Query
{
    public partial class Node
    {
        public static CardSetNode CardSet { get { return new CardSetNode(); } }
    }

    public partial class CardSetNode : Blueprint41.Query.Node
    {
        public static implicit operator QueryCondition(CardSetNode a)
        {
            return new QueryCondition(a);
        }
        public static QueryCondition operator !(CardSetNode a)
        {
            return new QueryCondition(a, true);
        } 

        protected override string GetNeo4jLabel()
        {
            return "CardSet";
        }

        protected override Entity GetEntity()
        {
            return m.CardSet.Entity;
        }
        public FunctionalId FunctionalId
        {
            get
            {
                return m.CardSet.Entity.FunctionalId;
            }
        }

        internal CardSetNode() { }
        internal CardSetNode(CardSetAlias alias, bool isReference = false)
        {
            NodeAlias = alias;
            IsReference = isReference;
        }
        internal CardSetNode(RELATIONSHIP relationship, DirectionEnum direction, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity) { }
        internal CardSetNode(RELATIONSHIP relationship, DirectionEnum direction, AliasResult nodeAlias, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity)
        {
            NodeAlias = nodeAlias;
        }

        public CardSetNode Where(JsNotation<string> Id = default, JsNotation<string> Name = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<CardSetAlias> alias = new Lazy<CardSetAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<QueryCondition> conditions = new List<QueryCondition>();
            if (Id.HasValue) conditions.Add(new QueryCondition(alias.Value.Id, Operator.Equals, ((IValue)Id).GetValue()));
            if (Name.HasValue) conditions.Add(new QueryCondition(alias.Value.Name, Operator.Equals, ((IValue)Name).GetValue()));

            InlineConditions = conditions.ToArray();

            return this;
        }
        public CardSetNode Assign(JsNotation<string> Id = default, JsNotation<string> Name = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<CardSetAlias> alias = new Lazy<CardSetAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<Assignment> assignments = new List<Assignment>();
            if (Id.HasValue) assignments.Add(new Assignment(alias.Value.Id, Id));
            if (Name.HasValue) assignments.Add(new Assignment(alias.Value.Name, Name));

            InlineAssignments = assignments.ToArray();

            return this;
        }

        public CardSetNode Alias(out CardSetAlias alias)
        {
            if (NodeAlias is CardSetAlias a)
            {
                alias = a;
            }
            else
            {
                alias = new CardSetAlias(this);
                NodeAlias = alias;
            }
            return this;
        }
        public CardSetNode Alias(out CardSetAlias alias, string name)
        {
            if (NodeAlias is CardSetAlias a)
            {
                a.SetAlias(name);
                alias = a;
            }
            else
            {
                alias = new CardSetAlias(this, name);
                NodeAlias = alias;
            }
            return this;
        }

        public CardSetNode UseExistingAlias(AliasResult alias)
        {
            NodeAlias = alias;
            IsReference = true;
            return this;
        }

        public CardSetIn  In  { get { return new CardSetIn(this); } }
        public class CardSetIn
        {
            private CardSetNode Parent;
            internal CardSetIn(CardSetNode parent)
            {
                Parent = parent;
            }
            public IFromIn_HAS_CARD_REL HAS_CARD { get { return new HAS_CARD_REL(Parent, DirectionEnum.In); } }

        }
    }

    public class CardSetAlias : AliasResult<CardSetAlias, CardSetListAlias>
    {
        internal CardSetAlias(CardSetNode parent)
        {
            Node = parent;
        }
        internal CardSetAlias(CardSetNode parent, string name)
        {
            Node = parent;
            AliasName = name;
        }
        internal void SetAlias(string name) => AliasName = name;

        private  CardSetAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private  CardSetAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private  CardSetAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type)
        {
            Node = alias.Node;
        }

        public Assignment[] Assign(JsNotation<string> Id = default, JsNotation<string> Name = default)
        {
            List<Assignment> assignments = new List<Assignment>();
            if (Id.HasValue) assignments.Add(new Assignment(this.Id, Id));
            if (Name.HasValue) assignments.Add(new Assignment(this.Name, Name));
            
            return assignments.ToArray();
        }


        public override IReadOnlyDictionary<string, FieldResult> AliasFields
        {
            get
            {
                if (m_AliasFields is null)
                {
                    m_AliasFields = new Dictionary<string, FieldResult>()
                    {
                        { "Name", new StringResult(this, "Name", DeckBuilder.Model.Datastore.Model.Entities["CardSet"], DeckBuilder.Model.Datastore.Model.Entities["CardSet"].Properties["Name"]) },
                        { "Id", new StringResult(this, "Id", DeckBuilder.Model.Datastore.Model.Entities["CardSet"], DeckBuilder.Model.Datastore.Model.Entities["CardSet"].Properties["Id"]) },
                    };
                }
                return m_AliasFields;
            }
        }
        private IReadOnlyDictionary<string, FieldResult> m_AliasFields = null;

        public CardSetNode.CardSetIn In { get { return new CardSetNode.CardSetIn(new CardSetNode(this, true)); } }

        public StringResult Name
        {
            get
            {
                if (m_Name is null)
                    m_Name = (StringResult)AliasFields["Name"];

                return m_Name;
            }
        }
        private StringResult m_Name = null;
        public StringResult Id
        {
            get
            {
                if (m_Id is null)
                    m_Id = (StringResult)AliasFields["Id"];

                return m_Id;
            }
        }
        private StringResult m_Id = null;
        public AsResult As(string aliasName, out CardSetAlias alias)
        {
            alias = new CardSetAlias((CardSetNode)Node)
            {
                AliasName = aliasName
            };
            return this.As(aliasName);
        }
    }

    public class CardSetListAlias : ListResult<CardSetListAlias, CardSetAlias>, IAliasListResult
    {
        private CardSetListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private CardSetListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private CardSetListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
    public class CardSetJaggedListAlias : ListResult<CardSetJaggedListAlias, CardSetListAlias>, IAliasJaggedListResult
    {
        private CardSetJaggedListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private CardSetJaggedListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private CardSetJaggedListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
}
