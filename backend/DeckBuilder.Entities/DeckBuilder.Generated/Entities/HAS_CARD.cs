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
    /// Relationship: (CardSet)-[HAS_CARD]->(Card)
    /// </summary>
    public partial class HAS_CARD
    {
        private HAS_CARD(string elementId, CardSet @in, ICard @out, Dictionary<string, object> properties)
        {
            _elementId = elementId;
            
            CardSet = @in;
            Card = @out;
            
            CreationDate = (System.DateTime?)PersistenceProvider.CurrentPersistenceProvider.ConvertFromStoredType(typeof(System.DateTime?), properties.GetValue("CreationDate"));
        }

        internal string _elementId { get; private set; }

        /// <summary>
        /// CardSet (In Node)
        /// </summary>
        public CardSet CardSet { get; private set; }

        /// <summary>
        /// Card (Out Node)
        /// </summary>
        public ICard Card { get; private set; }

        public System.DateTime? CreationDate { get; private set; }

        public void Assign()
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(inAlias.Id == CardSet.Id, outAlias.Id == Card.Id, relAlias.ElementId == _elementId)
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.HAS_CARD_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
        public static List<HAS_CARD> Where(Func<Alias, QueryCondition> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<HAS_CARD> Where(Func<Alias, QueryCondition[]> expression)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))

                .Where(expression.Invoke(new Alias(relAlias, inAlias, outAlias)))
                .Return(relAlias.ElementId.As("elementId"), relAlias.Properties("properties"), inAlias.As("in"), outAlias.As("out"))
                .Compile();

            return Load(query);
        }
        public static List<HAS_CARD> Where(JsNotation<System.DateTime?> CreationDate = default, JsNotation<CardSet> InNode = default, JsNotation<ICard> OutNode = default)
        {
            return Where(delegate(Alias alias)
            {
                List<QueryCondition> conditions = new List<QueryCondition>();

                if (CreationDate.HasValue) conditions.Add(alias.CreationDate == CreationDate.Value);
                if (InNode.HasValue) conditions.Add(alias.CardSet(InNode.Value));
                if (OutNode.HasValue) conditions.Add(alias.Card(OutNode.Value));

                return conditions.ToArray();
            });
        }
        internal static List<HAS_CARD> Load(ICompiled query) => Load(query, null);
        internal static List<HAS_CARD> Load(ICompiled query, params (string name, object value)[] arguments)
        {
            var context = query.GetExecutionContext();
            if (arguments is not null && arguments.Length > 0)
            {
                foreach ((string name, object value) in arguments)
                    context.SetParameter(name, value);
            }

            var results = context.Execute(NodeMapping.AsWritableEntity);

            return results.Select(result => new HAS_CARD(
                result.elementId,
                result.@in,
                result.@out,
                result.properties
            )).ToList();
        }

        public static Relationship Relationship => ThreadSafe.LazyInit(ref _relationship, () => DeckBuilder.Model.Datastore.Model.Relations["HAS_CARD"]);
        private static Relationship _relationship = null;

        /// <summary>
        /// CRUD Specific alias for relationship: (CardSet)-[HAS_CARD]->(Card)
        /// </summary>
        public partial class Alias
        {
            internal Alias(q.HAS_CARD_ALIAS relAlias, q.CardSetAlias inAlias, q.CardAlias outAlias)
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
            /// CardSet in-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where in-node is the given card  set
            /// </returns>
            public QueryCondition CardSet(CardSet cardSet)
            {
                return _inAlias.Id == cardSet.Id;
            }
            /// <summary>
            /// CardSet in-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of card  sets
            /// </returns>
            public QueryCondition CardSets(IEnumerable<CardSet> cardSets)
            {
                return _inAlias.Id.In(cardSets.Select(item => item.Id));
            }
            /// <summary>
            /// CardSet in-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where in-node is in the given set of card  sets
            /// </returns>
            public QueryCondition CardSets(params CardSet[] cardSets)
            {
                return _inAlias.Id.In(cardSets.Select(item => item.Id));
            }

            /// <summary>
            /// Card out-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where out-node is the given card
            /// </returns>
            public QueryCondition Card(ICard card)
            {
                return _outAlias.Id == card.Id;
            }
            /// <summary>
            /// Card out-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of cards
            /// </returns>
            public QueryCondition Cards(IEnumerable<ICard> cards)
            {
                return _outAlias.Id.In(cards.Select(item => item.Id));
            }
            /// <summary>
            /// Card out-node: (CardSet)-[HAS_CARD]->(Card)
            /// </summary>
            /// <returns>
            /// Condition where out-node is in the given set of cards
            /// </returns>
            public QueryCondition Cards(params ICard[] cards)
            {
                return _outAlias.Id.In(cards.Select(item => item.Id));
            }

            private readonly q.HAS_CARD_ALIAS _relAlias;
            private readonly q.CardSetAlias _inAlias;
            private readonly q.CardAlias _outAlias;
        }
    }

    public static partial class RelationshipAssignmentExtensions
    {
        public static void Assign(this IEnumerable<HAS_CARD> @this)
        {
            var query = Transaction.CompiledQuery
                .Match(node.CardSet.Alias(out var inAlias).In.HAS_CARD.Alias(out var relAlias).Out.Card.Alias(out var outAlias))
                .Where(relAlias.ElementId.In(@this.Select(item => item._elementId)))
                .Set(GetAssignments(relAlias))
                .Compile();

            var context = query.GetExecutionContext();
            context.Execute();

            Assignment[] GetAssignments(q.HAS_CARD_ALIAS alias)
            {
                List<Assignment> assignments = new List<Assignment>();
               
                return assignments.ToArray();
            }
        }
    }
}
