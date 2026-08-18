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
    /// Relationship: (Eclipse)-[ECLIPSING]->(Allie)
    /// </summary>
    public partial class ECLIPSING
    {
        private ECLIPSING(string elementId, Eclipse @in, Allie @out, Dictionary<string, object> properties)
        {
            _elementId = elementId;
            
            Eclipse = @in;
            Allie = @out;
            
            CreationDate = (System.DateTime?)PersistenceProvider.CurrentPersistenceProvider.ConvertFromStoredType(typeof(System.DateTime?), properties.GetValue("CreationDate"));
        }

        internal string _elementId { get; private set; }

        /// <summary>
        /// Eclipse (In Node)
        /// </summary>
        public Eclipse Eclipse { get; private set; }

        /// <summary>
        /// Allie (Out Node)
        /// </summary>
        public Allie Allie { get; private set; }

        public System.DateTime? CreationDate { get; private set; }

        public void Assign()
        {
            var query = Transaction.CompiledQuery
                .Match(node.Eclipse.Alias(out var inAlias).In.ECLIPSING.Alias(out var relAlias).Out.Allie.Alias(out var outAlias))
                .Where(inAlias.Id == Eclipse.Id, outAlias.Id == Allie.Id, relAlias.ElementId == _elementId)
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.ECLIPSING_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
        public static List<ECLIPSING> Where(Func<Alias, QueryCondition> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Eclipse.Alias(out var inAlias).In.ECLIPSING.Alias(out var relAlias).Out.Allie.Alias(out var outAlias))
                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<ECLIPSING> Where(Func<Alias, QueryCondition[]> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Eclipse.Alias(out var inAlias).In.ECLIPSING.Alias(out var relAlias).Out.Allie.Alias(out var outAlias))

                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<ECLIPSING> Where(JsNotation<System.DateTime?> CreationDate = default, JsNotation<Eclipse> InNode = default, JsNotation<Allie> OutNode = default)
        {
            return Where(delegate(Alias alias)
            {
                List<QueryCondition> conditions = new List<QueryCondition>();

                if (CreationDate.HasValue) conditions.Add(alias.CreationDate == CreationDate.Value);
                if (InNode.HasValue) conditions.Add(alias.Eclipse(InNode.Value));
                if (OutNode.HasValue) conditions.Add(alias.Allie(OutNode.Value));

                return conditions.ToArray();
            });
        }
        internal static List<ECLIPSING> Load(ICompiled query) => Load(query, null);
        internal static List<ECLIPSING> Load(ICompiled query, params (string name, object value)[] arguments)
        {
            var context = query.GetExecutionContext();
            if (arguments is not null && arguments.Length > 0)
            {
                foreach ((string name, object value) in arguments)
                    context.SetParameter(name, value);
            }

            var results = context.Execute(NodeMapping.AsWritableEntity);

            return results.Select(result => new ECLIPSING(
                result.elementId,
                result.@in,
                result.@out,
                result.properties
            )).ToList();
        }

        public static Relationship Relationship => ThreadSafe.LazyInit(ref _relationship, () => DeckBuilder.Model.Datastore.Model.Relations["ECLIPSING"]);
        private static Relationship _relationship = null;

        /// <summary>
        /// CRUD Specific alias for relationship: (Eclipse)-[ECLIPSING]->(Allie)
        /// </summary>
        public partial class Alias
        {
            internal Alias(q.ECLIPSING_ALIAS relAlias, q.EclipseAlias inAlias, q.AllieAlias outAlias)
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
            /// Eclipse in-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where in-node is the given eclipse
            /// </returns>
            public QueryCondition Eclipse(Eclipse eclipse)
            {
                return _inAlias.Id == eclipse.Id;
            }
            /// <summary>
            /// Eclipse in-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of eclipses
            /// </returns>
            public QueryCondition Eclipses(IEnumerable<Eclipse> eclipses)
            {
                return _inAlias.Id.In(eclipses.Select(item => item.Id));
            }
            /// <summary>
            /// Eclipse in-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of eclipses
            /// </returns>
            public QueryCondition Eclipses(params Eclipse[] eclipses)
            {
                return _inAlias.Id.In(eclipses.Select(item => item.Id));
            }

            /// <summary>
            /// Allie out-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where out-node is the given allie
            /// </returns>
            public QueryCondition Allie(Allie allie)
            {
                return _outAlias.Id == allie.Id;
            }
            /// <summary>
            /// Allie out-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of allies
            /// </returns>
            public QueryCondition Allies(IEnumerable<Allie> allies)
            {
                return _outAlias.Id.In(allies.Select(item => item.Id));
            }
            /// <summary>
            /// Allie out-node: (Eclipse)-[ECLIPSING]->(Allie)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of allies
            /// </returns>
            public QueryCondition Allies(params Allie[] allies)
            {
                return _outAlias.Id.In(allies.Select(item => item.Id));
            }

            private readonly q.ECLIPSING_ALIAS _relAlias;
            private readonly q.EclipseAlias _inAlias;
            private readonly q.AllieAlias _outAlias;
        }
    }

    public static partial class RelationshipAssignmentExtensions
    {
        public static void Assign(this IEnumerable<ECLIPSING> @this)
        {
            var query = Transaction.CompiledQuery
                .Match(node.Eclipse.Alias(out var inAlias).In.ECLIPSING.Alias(out var relAlias).Out.Allie.Alias(out var outAlias))
                .Where(relAlias.ElementId.In(@this.Select(item => item._elementId)))
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.ECLIPSING_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
    }
}
