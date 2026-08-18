#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using System.Collections.Generic;

using Blueprint41;
using Blueprint41.Query;

namespace DeckBuilder.Generated.Query
{
public partial class ECLIPSING_REL : RELATIONSHIP, IFromIn_ECLIPSING_REL, IFromOut_ECLIPSING_REL    {
        public override string NEO4J_TYPE
        {
            get
            {
                return "ECLIPSING";
            }
        }
        public override AliasResult RelationshipAlias { get; protected set; }
        
        internal ECLIPSING_REL(Blueprint41.Query.Node parent, DirectionEnum direction) : base(parent, direction) { }

        public ECLIPSING_REL Alias(out ECLIPSING_ALIAS alias)
        {
            alias = new ECLIPSING_ALIAS(this);
            RelationshipAlias = alias;
            return this;
        } 
        public ECLIPSING_REL Repeat(int maxHops)
        {
            return Repeat(1, maxHops);
        }
        public new ECLIPSING_REL Repeat(int minHops, int maxHops)
        {
            base.Repeat(minHops, maxHops);
            return this;
        }

        IFromIn_ECLIPSING_REL IFromIn_ECLIPSING_REL.Alias(out ECLIPSING_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromOut_ECLIPSING_REL IFromOut_ECLIPSING_REL.Alias(out ECLIPSING_ALIAS alias)
        {
            return Alias(out alias);
        }
        IFromIn_ECLIPSING_REL IFromIn_ECLIPSING_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromIn_ECLIPSING_REL IFromIn_ECLIPSING_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }
        IFromOut_ECLIPSING_REL IFromOut_ECLIPSING_REL.Repeat(int maxHops)
        {
            return Repeat(maxHops);
        }
        IFromOut_ECLIPSING_REL IFromOut_ECLIPSING_REL.Repeat(int minHops, int maxHops)
        {
            return Repeat(minHops, maxHops);
        }


        public ECLIPSING_IN In { get { return new ECLIPSING_IN(this); } }
        public class ECLIPSING_IN
        {
            private ECLIPSING_REL Parent;
            internal ECLIPSING_IN(ECLIPSING_REL parent)
            {
                Parent = parent;
            }

            public EclipseNode Eclipse { get { return new EclipseNode(Parent, DirectionEnum.In); } }
        }

        public ECLIPSING_OUT Out { get { return new ECLIPSING_OUT(this); } }
        public class ECLIPSING_OUT
        {
            private ECLIPSING_REL Parent;
            internal ECLIPSING_OUT(ECLIPSING_REL parent)
            {
                Parent = parent;
            }

            public AllieNode Allie { get { return new AllieNode(Parent, DirectionEnum.Out); } }
        }
    }

    public interface IFromIn_ECLIPSING_REL
    {
        IFromIn_ECLIPSING_REL Alias(out ECLIPSING_ALIAS alias);
        IFromIn_ECLIPSING_REL Repeat(int maxHops);
        IFromIn_ECLIPSING_REL Repeat(int minHops, int maxHops);

        ECLIPSING_REL.ECLIPSING_OUT Out { get; }
    }
    public interface IFromOut_ECLIPSING_REL
    {
        IFromOut_ECLIPSING_REL Alias(out ECLIPSING_ALIAS alias);
        IFromOut_ECLIPSING_REL Repeat(int maxHops);
        IFromOut_ECLIPSING_REL Repeat(int minHops, int maxHops);

        ECLIPSING_REL.ECLIPSING_IN In { get; }
    }

    public class ECLIPSING_ALIAS : AliasResult
    {
        private ECLIPSING_REL Parent;

        internal ECLIPSING_ALIAS(ECLIPSING_REL parent)
        {
            Parent = parent;

            CreationDate = new DateTimeResult(this, "CreationDate", DeckBuilder.Model.Datastore.Model.Relations["ECLIPSING"], DeckBuilder.Model.Datastore.Model.Relations["ECLIPSING"].Properties["CreationDate"]);
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
