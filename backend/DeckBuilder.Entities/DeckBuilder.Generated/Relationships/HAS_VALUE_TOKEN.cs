#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using System.Collections.Generic;

using Blueprint41;
using Blueprint41.Query;

namespace DeckBuilder.Generated.Query
{
public partial class HAS_VALUE_TOKEN_REL : RELATIONSHIP, IFromIn_HAS_VALUE_TOKEN_REL, IFromOut_HAS_VALUE_TOKEN_REL    {
        public override string NEO4J_TYPE
        {
            get
            {
                return "HAS_VALUE_TOKEN";
            }
        }
        public override AliasResult RelationshipAlias { get; protected set; }
        
        internal HAS_VALUE_TOKEN_REL(Blueprint41.Query.Node parent, DirectionEnum direction) : base(parent, direction) { }

        public HAS_VALUE_TOKEN_REL Alias(out HAS_VALUE_TOKEN_ALIAS alias)
        {
            alias = new HAS_VALUE_TOKEN_ALIAS(this);
            RelationshipAlias = alias;
            return this;
        } 
        public HAS_VALUE_TOKEN_REL Repeat(int maxHops)
        {
            return Repeat(1, maxHops);
        }
        public new HAS_VALUE_TOKEN_REL Repeat(int minHops, int maxHops)
        {
            base.Repeat(minHops, maxHops);
            return this;
        }

        IFromIn_HAS_VALUE_TOKEN_REL IFromIn_HAS_VALUE_TOKEN_REL.Alias(out HAS_VALUE_TOKEN_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromOut_HAS_VALUE_TOKEN_REL IFromOut_HAS_VALUE_TOKEN_REL.Alias(out HAS_VALUE_TOKEN_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromIn_HAS_VALUE_TOKEN_REL IFromIn_HAS_VALUE_TOKEN_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromIn_HAS_VALUE_TOKEN_REL IFromIn_HAS_VALUE_TOKEN_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }
        IFromOut_HAS_VALUE_TOKEN_REL IFromOut_HAS_VALUE_TOKEN_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromOut_HAS_VALUE_TOKEN_REL IFromOut_HAS_VALUE_TOKEN_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }


        public HAS_VALUE_TOKEN_IN In { get { return new HAS_VALUE_TOKEN_IN(this); } }
        public class HAS_VALUE_TOKEN_IN
        {
            private HAS_VALUE_TOKEN_REL Parent;
            internal HAS_VALUE_TOKEN_IN(HAS_VALUE_TOKEN_REL parent)
            {
                Parent = parent;
            }

            public SbireNode Sbire { get { return new SbireNode(Parent, DirectionEnum.In); } }
        }

        public HAS_VALUE_TOKEN_OUT Out { get { return new HAS_VALUE_TOKEN_OUT(this); } }
        public class HAS_VALUE_TOKEN_OUT
        {
            private HAS_VALUE_TOKEN_REL Parent;
            internal HAS_VALUE_TOKEN_OUT(HAS_VALUE_TOKEN_REL parent)
            {
                Parent = parent;
            }

            public TokenNode Token { get { return new TokenNode(Parent, DirectionEnum.Out); } }
        }
    }

    public interface IFromIn_HAS_VALUE_TOKEN_REL
    {
        IFromIn_HAS_VALUE_TOKEN_REL Alias(out HAS_VALUE_TOKEN_ALIAS alias);
        IFromIn_HAS_VALUE_TOKEN_REL Repeat(int maxHops);
        IFromIn_HAS_VALUE_TOKEN_REL Repeat(int minHops, int maxHops);

        HAS_VALUE_TOKEN_REL.HAS_VALUE_TOKEN_OUT Out { get; }
    }
    public interface IFromOut_HAS_VALUE_TOKEN_REL
    {
        IFromOut_HAS_VALUE_TOKEN_REL Alias(out HAS_VALUE_TOKEN_ALIAS alias);
        IFromOut_HAS_VALUE_TOKEN_REL Repeat(int maxHops);
        IFromOut_HAS_VALUE_TOKEN_REL Repeat(int minHops, int maxHops);

        HAS_VALUE_TOKEN_REL.HAS_VALUE_TOKEN_IN In { get; }
    }

    public class HAS_VALUE_TOKEN_ALIAS : AliasResult
    {
        private HAS_VALUE_TOKEN_REL Parent;

        internal HAS_VALUE_TOKEN_ALIAS(HAS_VALUE_TOKEN_REL parent)
        {
            Parent = parent;

            CreationDate = new DateTimeResult(this, "CreationDate", DeckBuilder.Model.Datastore.Model.Relations["HAS_VALUE_TOKEN"], DeckBuilder.Model.Datastore.Model.Relations["HAS_VALUE_TOKEN"].Properties["CreationDate"]);
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
