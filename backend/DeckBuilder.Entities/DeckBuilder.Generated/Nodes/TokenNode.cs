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
        public static TokenNode Token { get { return new TokenNode(); } }
    }

    public partial class TokenNode : Blueprint41.Query.Node
    {
        public static implicit operator QueryCondition(TokenNode a)
        {
            return new QueryCondition(a);
        }
        public static QueryCondition operator !(TokenNode a)
        {
            return new QueryCondition(a, true);
        } 

        protected override string GetNeo4jLabel()
        {
            return "Token";
        }

        protected override Entity GetEntity()
        {
            return m.Token.Entity;
        }
        public FunctionalId FunctionalId
        {
            get
            {
                return m.Token.Entity.FunctionalId;
            }
        }

        internal TokenNode() { }
        internal TokenNode(TokenAlias alias, bool isReference = false)
        {
            NodeAlias = alias;
            IsReference = isReference;
        }
        internal TokenNode(RELATIONSHIP relationship, DirectionEnum direction, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity) { }
        internal TokenNode(RELATIONSHIP relationship, DirectionEnum direction, AliasResult nodeAlias, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity)
        {
            NodeAlias = nodeAlias;
        }

        public TokenNode Where(JsNotation<string> Id = default, JsNotation<string> Name = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<TokenAlias> alias = new Lazy<TokenAlias>(delegate()
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
        public TokenNode Assign(JsNotation<string> Id = default, JsNotation<string> Name = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<TokenAlias> alias = new Lazy<TokenAlias>(delegate()
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

        public TokenNode Alias(out TokenAlias alias)
        {
            if (NodeAlias is TokenAlias a)
            {
                alias = a;
            }
            else
            {
                alias = new TokenAlias(this);
                NodeAlias = alias;
            }
            return this;
        }
        public TokenNode Alias(out TokenAlias alias, string name)
        {
            if (NodeAlias is TokenAlias a)
            {
                a.SetAlias(name);
                alias = a;
            }
            else
            {
                alias = new TokenAlias(this, name);
                NodeAlias = alias;
            }
            return this;
        }

        public TokenNode UseExistingAlias(AliasResult alias)
        {
            NodeAlias = alias;
            IsReference = true;
            return this;
        }


        public TokenOut Out { get { return new TokenOut(this); } }
        public class TokenOut
        {
            private TokenNode Parent;
            internal TokenOut(TokenNode parent)
            {
                Parent = parent;
            }
            public IFromOut_HAS_COST_TOKEN_REL HAS_COST_TOKEN { get { return new HAS_COST_TOKEN_REL(Parent, DirectionEnum.Out); } }
            public IFromOut_HAS_VALUE_TOKEN_REL HAS_VALUE_TOKEN { get { return new HAS_VALUE_TOKEN_REL(Parent, DirectionEnum.Out); } }
        }
    }

    public class TokenAlias : AliasResult<TokenAlias, TokenListAlias>
    {
        internal TokenAlias(TokenNode parent)
        {
            Node = parent;
        }
        internal TokenAlias(TokenNode parent, string name)
        {
            Node = parent;
            AliasName = name;
        }
        internal void SetAlias(string name) => AliasName = name;

        private  TokenAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private  TokenAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private  TokenAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type)
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
                        { "Name", new StringResult(this, "Name", DeckBuilder.Model.Datastore.Model.Entities["Token"], DeckBuilder.Model.Datastore.Model.Entities["Token"].Properties["Name"]) },
                        { "Id", new StringResult(this, "Id", DeckBuilder.Model.Datastore.Model.Entities["Token"], DeckBuilder.Model.Datastore.Model.Entities["Token"].Properties["Id"]) },
                    };
                }
                return m_AliasFields;
            }
        }
        private IReadOnlyDictionary<string, FieldResult> m_AliasFields = null;

        public TokenNode.TokenOut Out { get { return new TokenNode.TokenOut(new TokenNode(this, true)); } }

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
        public AsResult As(string aliasName, out TokenAlias alias)
        {
            alias = new TokenAlias((TokenNode)Node)
            {
                AliasName = aliasName
            };
            return this.As(aliasName);
        }
    }

    public class TokenListAlias : ListResult<TokenListAlias, TokenAlias>, IAliasListResult
    {
        private TokenListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private TokenListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private TokenListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
    public class TokenJaggedListAlias : ListResult<TokenJaggedListAlias, TokenListAlias>, IAliasJaggedListResult
    {
        private TokenJaggedListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private TokenJaggedListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private TokenJaggedListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
}
