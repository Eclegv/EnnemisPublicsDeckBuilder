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
    /// <summary>
    /// Relationship: (Cost)-[HAS_VALUE_TOKEN]->(Token)
    /// </summary>
    public partial class HAS_VALUE_TOKEN
    {
        private HAS_VALUE_TOKEN(string elementId, ICost @in, Token @out, Dictionary<string, object> properties)
        {
            _elementId = elementId;
            
            Cost = @in;
            Token = @out;
            
            CreationDate = (System.DateTime?)PersistenceProvider.CurrentPersistenceProvider.ConvertFromStoredType(typeof(System.DateTime?), properties.GetValue("CreationDate"));
        }

        internal string _elementId { get; private set; }

        /// <summary>
        /// Cost (In Node)
        /// </summary>
        public ICost Cost { get; private set; }

        /// <summary>
        /// Token (Out Node)
        /// </summary>
        public Token Token { get; private set; }

        public System.DateTime? CreationDate { get; private set; }

        public void Assign()
        {
            var query = Transaction.CompiledQuery
                .Match(node.Token.Alias(out var outAlias).Out.HAS_VALUE_TOKEN.Alias(out var relAlias).In.Cost.Alias(out var inAlias))
                .Where(inAlias.Id == Cost.Id, outAlias.Id == Token.Id, relAlias.ElementId == _elementId)
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.HAS_VALUE_TOKEN_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
        public static List<HAS_VALUE_TOKEN> Where(Func<Alias, QueryCondition> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Token.Alias(out var outAlias).Out.HAS_VALUE_TOKEN.Alias(out var relAlias).In.Cost.Alias(out var inAlias))
                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<HAS_VALUE_TOKEN> Where(Func<Alias, QueryCondition[]> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Token.Alias(out var outAlias).Out.HAS_VALUE_TOKEN.Alias(out var relAlias).In.Cost.Alias(out var inAlias))

                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<HAS_VALUE_TOKEN> Where(JsNotation<System.DateTime?> CreationDate = default, JsNotation<ICost> InNode = default, JsNotation<Token> OutNode = default)
        {
            return Where(delegate(Alias alias)
            {
                List<QueryCondition> conditions = new List<QueryCondition>();

                if (CreationDate.HasValue) conditions.Add(alias.CreationDate == CreationDate.Value);
                if (InNode.HasValue) conditions.Add(alias.Cost(InNode.Value));
                if (OutNode.HasValue) conditions.Add(alias.Token(OutNode.Value));

                return conditions.ToArray();
            });
        }
        internal static List<HAS_VALUE_TOKEN> Load(ICompiled query) => Load(query, null);
        internal static List<HAS_VALUE_TOKEN> Load(ICompiled query, params (string name, object value)[] arguments)
        {
            var context = query.GetExecutionContext();
            if (arguments is not null && arguments.Length > 0)
            {
                foreach ((string name, object value) in arguments)
                    context.SetParameter(name, value);
            }

            var results = context.Execute(NodeMapping.AsWritableEntity);

            return results.Select(result => new HAS_VALUE_TOKEN(
                result.elementId,
                result.@in,
                result.@out,
                result.properties
            )).ToList();
        }

        public static Relationship Relationship => ThreadSafe.LazyInit(ref _relationship, () => DeckBuilder.Model.Datastore.Model.Relations["HAS_VALUE_TOKEN"]);
        private static Relationship _relationship = null;

        /// <summary>
        /// CRUD Specific alias for relationship: (Cost)-[HAS_VALUE_TOKEN]->(Token)
        /// </summary>
        public partial class Alias
        {
            internal Alias(q.HAS_VALUE_TOKEN_ALIAS relAlias, q.CostAlias inAlias, q.TokenAlias outAlias)
            {
                _relAlias = relAlias;
                _inAlias = inAlias;
                _outAlias = outAlias;
            }

            public DateTimeResult CreationDate
            {
                get
                {
                    if (_creationDate is null)
                        _creationDate = _relAlias.CreationDate;

                    return _creationDate;
                }
            }
            private DateTimeResult _creationDate = null;

            /// <summary>
            /// Cost in-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where in-node is the given cost
            /// </returns>
            public QueryCondition Cost(ICost cost)
            {
                return _inAlias.Id == cost.Id;
            }
            /// <summary>
            /// Cost in-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of costs
            /// </returns>
            public QueryCondition Costs(IEnumerable<ICost> costs)
            {
                return _inAlias.Id.In(costs.Select(item => item.Id));
            }
            /// <summary>
            /// Cost in-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of costs
            /// </returns>
            public QueryCondition Costs(params ICost[] costs)
            {
                return _inAlias.Id.In(costs.Select(item => item.Id));
            }

            /// <summary>
            /// Token out-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where out-node is the given token
            /// </returns>
            public QueryCondition Token(Token token)
            {
                return _outAlias.Id == token.Id;
            }
            /// <summary>
            /// Token out-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of tokens
            /// </returns>
            public QueryCondition Tokens(IEnumerable<Token> tokens)
            {
                return _outAlias.Id.In(tokens.Select(item => item.Id));
            }
            /// <summary>
            /// Token out-node: (Cost)-[HAS_VALUE_TOKEN]->(Token)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of tokens
            /// </returns>
            public QueryCondition Tokens(params Token[] tokens)
            {
                return _outAlias.Id.In(tokens.Select(item => item.Id));
            }

            private readonly q.HAS_VALUE_TOKEN_ALIAS _relAlias;
            private readonly q.CostAlias _inAlias;
            private readonly q.TokenAlias _outAlias;
        }
    }

    public static partial class RelationshipAssignmentExtensions
    {
        public static void Assign(this IEnumerable<HAS_VALUE_TOKEN> @this)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Token.Alias(out var outAlias).Out.HAS_VALUE_TOKEN.Alias(out var relAlias).In.Cost.Alias(out var inAlias))
                .Where(relAlias.ElementId.In(@this.Select(item => item._elementId)))
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.HAS_VALUE_TOKEN_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
    }
}
