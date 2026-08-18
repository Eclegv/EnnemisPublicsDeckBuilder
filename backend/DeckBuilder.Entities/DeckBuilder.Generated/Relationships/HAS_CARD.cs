#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using System.Collections.Generic;

using Blueprint41;
using Blueprint41.Query;

namespace DeckBuilder.Generated.Query
{
public partial class HAS_CARD_REL : RELATIONSHIP, IFromIn_HAS_CARD_REL, IFromOut_HAS_CARD_REL    {
        public override string NEO4J_TYPE
        {
            get
            {
                return "HAS_CARD";
            }
        }
        public override AliasResult RelationshipAlias { get; protected set; }
        
        internal HAS_CARD_REL(Blueprint41.Query.Node parent, DirectionEnum direction) : base(parent, direction) { }

        public HAS_CARD_REL Alias(out HAS_CARD_ALIAS alias)
        {
            alias = new HAS_CARD_ALIAS(this);
            RelationshipAlias = alias;
            return this;
        } 
        public HAS_CARD_REL Repeat(int maxHops)
        {
            return Repeat(1, maxHops);
        }
        public new HAS_CARD_REL Repeat(int minHops, int maxHops)
        {
            base.Repeat(minHops, maxHops);
            return this;
        }

        IFromIn_HAS_CARD_REL IFromIn_HAS_CARD_REL.Alias(out HAS_CARD_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromOut_HAS_CARD_REL IFromOut_HAS_CARD_REL.Alias(out HAS_CARD_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromIn_HAS_CARD_REL IFromIn_HAS_CARD_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromIn_HAS_CARD_REL IFromIn_HAS_CARD_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }
        IFromOut_HAS_CARD_REL IFromOut_HAS_CARD_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromOut_HAS_CARD_REL IFromOut_HAS_CARD_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }


        public HAS_CARD_IN In { get { return new HAS_CARD_IN(this); } }
        public class HAS_CARD_IN
        {
            private HAS_CARD_REL Parent;
            internal HAS_CARD_IN(HAS_CARD_REL parent)
            {
                Parent = parent;
            }

            public CardSetNode CardSet { get { return new CardSetNode(Parent, DirectionEnum.In); } }
        }

        public HAS_CARD_OUT Out { get { return new HAS_CARD_OUT(this); } }
        public class HAS_CARD_OUT
        {
            private HAS_CARD_REL Parent;
            internal HAS_CARD_OUT(HAS_CARD_REL parent)
            {
                Parent = parent;
            }

            public CardNode Card { get { return new CardNode(Parent, DirectionEnum.Out); } }
            public BossNode Boss { get { return new BossNode(Parent, DirectionEnum.Out); } }
            public ActionNode Action { get { return new ActionNode(Parent, DirectionEnum.Out); } }
            public SbireNode Sbire { get { return new SbireNode(Parent, DirectionEnum.Out); } }
            public SbireUniqueNode SbireUnique { get { return new SbireUniqueNode(Parent, DirectionEnum.Out); } }
            public AllieNode Allie { get { return new AllieNode(Parent, DirectionEnum.Out); } }
            public EclipseNode Eclipse { get { return new EclipseNode(Parent, DirectionEnum.Out); } }
            public ValiseNode Valise { get { return new ValiseNode(Parent, DirectionEnum.Out); } }
            public ReactionNode Reaction { get { return new ReactionNode(Parent, DirectionEnum.Out); } }
        }
    }

    public interface IFromIn_HAS_CARD_REL
    {
        IFromIn_HAS_CARD_REL Alias(out HAS_CARD_ALIAS alias);
        IFromIn_HAS_CARD_REL Repeat(int maxHops);
        IFromIn_HAS_CARD_REL Repeat(int minHops, int maxHops);

        HAS_CARD_REL.HAS_CARD_OUT Out { get; }
    }
    public interface IFromOut_HAS_CARD_REL
    {
        IFromOut_HAS_CARD_REL Alias(out HAS_CARD_ALIAS alias);
        IFromOut_HAS_CARD_REL Repeat(int maxHops);
        IFromOut_HAS_CARD_REL Repeat(int minHops, int maxHops);

        HAS_CARD_REL.HAS_CARD_IN In { get; }
    }

    public class HAS_CARD_ALIAS : AliasResult
    {
        private HAS_CARD_REL Parent;

        internal HAS_CARD_ALIAS(HAS_CARD_REL parent)
        {
            Parent = parent;

            CreationDate = new DateTimeResult(this, "CreationDate", DeckBuilder.Model.Datastore.Model.Relations["HAS_CARD"], DeckBuilder.Model.Datastore.Model.Relations["HAS_CARD"].Properties["CreationDate"]);
        }

        public Assignment[] Assign(JsNotation<System.DateTime?> CreationDate = default)
        {
            List<Assignment> assignments = new List<Assignment>();
            if (CreationDate.HasValue) assignments.Add(new Assignment(this.CreationDate, CreationDate));

            return assignments.ToArray();
        }

        public DateTimeResult CreationDate { get; private set; } 
    }
}
