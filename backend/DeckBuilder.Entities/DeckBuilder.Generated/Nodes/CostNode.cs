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
        [Obsolete("This entity is virtual, consider making entity Cost concrete or use another entity as your starting point.", true)]
        public static CostNode Cost { get { return new CostNode(); } }
    }

    public partial class CostNode : Blueprint41.Query.Node
    {
        public static implicit operator QueryCondition(CostNode a)
        {
            return new QueryCondition(a);
        }
        public static QueryCondition operator !(CostNode a)
        {
            return new QueryCondition(a, true);
        } 

        protected override string GetNeo4jLabel()
        {
            return null;
        }

        protected override Entity GetEntity()
        {
            return null;
        }

        internal CostNode() { }
        internal CostNode(CostAlias alias, bool isReference = false)
        {
            NodeAlias = alias;
            IsReference = isReference;
        }
        internal CostNode(RELATIONSHIP relationship, DirectionEnum direction, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity) { }
        internal CostNode(RELATIONSHIP relationship, DirectionEnum direction, AliasResult nodeAlias, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity)
        {
            NodeAlias = nodeAlias;
        }

        public CostNode Where(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<CostAlias> alias = new Lazy<CostAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<QueryCondition> conditions = new List<QueryCondition>();
            if (ActivationEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.ActivationEffect, Operator.Equals, ((IValue)ActivationEffect).GetValue()));
            if (BaseEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.BaseEffect, Operator.Equals, ((IValue)BaseEffect).GetValue()));
            if (EnteringEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.EnteringEffect, Operator.Equals, ((IValue)EnteringEffect).GetValue()));
            if (Id.HasValue) conditions.Add(new QueryCondition(alias.Value.Id, Operator.Equals, ((IValue)Id).GetValue()));
            if (LeavingEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.LeavingEffect, Operator.Equals, ((IValue)LeavingEffect).GetValue()));
            if (LoosingEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.LoosingEffect, Operator.Equals, ((IValue)LoosingEffect).GetValue()));
            if (Lore.HasValue) conditions.Add(new QueryCondition(alias.Value.Lore, Operator.Equals, ((IValue)Lore).GetValue()));
            if (MandatoryActivationEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.MandatoryActivationEffect, Operator.Equals, ((IValue)MandatoryActivationEffect).GetValue()));
            if (Name.HasValue) conditions.Add(new QueryCondition(alias.Value.Name, Operator.Equals, ((IValue)Name).GetValue()));
            if (PermanentEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.PermanentEffect, Operator.Equals, ((IValue)PermanentEffect).GetValue()));
            if (ReactionEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.ReactionEffect, Operator.Equals, ((IValue)ReactionEffect).GetValue()));

            InlineConditions = conditions.ToArray();

            return this;
        }
        public CostNode Assign(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<CostAlias> alias = new Lazy<CostAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<Assignment> assignments = new List<Assignment>();
            if (ActivationEffect.HasValue) assignments.Add(new Assignment(alias.Value.ActivationEffect, ActivationEffect));
            if (BaseEffect.HasValue) assignments.Add(new Assignment(alias.Value.BaseEffect, BaseEffect));
            if (EnteringEffect.HasValue) assignments.Add(new Assignment(alias.Value.EnteringEffect, EnteringEffect));
            if (Id.HasValue) assignments.Add(new Assignment(alias.Value.Id, Id));
            if (LeavingEffect.HasValue) assignments.Add(new Assignment(alias.Value.LeavingEffect, LeavingEffect));
            if (LoosingEffect.HasValue) assignments.Add(new Assignment(alias.Value.LoosingEffect, LoosingEffect));
            if (Lore.HasValue) assignments.Add(new Assignment(alias.Value.Lore, Lore));
            if (MandatoryActivationEffect.HasValue) assignments.Add(new Assignment(alias.Value.MandatoryActivationEffect, MandatoryActivationEffect));
            if (Name.HasValue) assignments.Add(new Assignment(alias.Value.Name, Name));
            if (PermanentEffect.HasValue) assignments.Add(new Assignment(alias.Value.PermanentEffect, PermanentEffect));
            if (ReactionEffect.HasValue) assignments.Add(new Assignment(alias.Value.ReactionEffect, ReactionEffect));

            InlineAssignments = assignments.ToArray();

            return this;
        }

        public CostNode Alias(out CostAlias alias)
        {
            if (NodeAlias is CostAlias a)
            {
                alias = a;
            }
            else
            {
                alias = new CostAlias(this);
                NodeAlias = alias;
            }
            return this;
        }
        public CostNode Alias(out CostAlias alias, string name)
        {
            if (NodeAlias is CostAlias a)
            {
                a.SetAlias(name);
                alias = a;
            }
            else
            {
                alias = new CostAlias(this, name);
                NodeAlias = alias;
            }
            return this;
        }

        public CostNode UseExistingAlias(AliasResult alias)
        {
            NodeAlias = alias;
            IsReference = true;
            return this;
        }

        public SbireNode CastToSbire()
        {
            if (this.Neo4jLabel is null)
                throw new InvalidOperationException("Casting is not supported for virtual entities.");

            if (FromRelationship is null)
                throw new InvalidOperationException("Please use the right type immediately, casting is only support after you have match through a relationship.");

            return new SbireNode(FromRelationship, Direction, NodeAlias, this.Neo4jLabel, this.Entity);
        }

        public SbireUniqueNode CastToSbireUnique()
        {
            if (this.Neo4jLabel is null)
                throw new InvalidOperationException("Casting is not supported for virtual entities.");

            if (FromRelationship is null)
                throw new InvalidOperationException("Please use the right type immediately, casting is only support after you have match through a relationship.");

            return new SbireUniqueNode(FromRelationship, Direction, NodeAlias, this.Neo4jLabel, this.Entity);
        }

        public CostIn  In  { get { return new CostIn(this); } }
        public class CostIn
        {
            private CostNode Parent;
            internal CostIn(CostNode parent)
            {
                Parent = parent;
            }
            public IFromIn_HAS_VALUE_TOKEN_REL HAS_VALUE_TOKEN { get { return new HAS_VALUE_TOKEN_REL(Parent, DirectionEnum.In); } }

        }

        public CostOut Out { get { return new CostOut(this); } }
        public class CostOut
        {
            private CostNode Parent;
            internal CostOut(CostNode parent)
            {
                Parent = parent;
            }
            public IFromOut_HAS_CARD_REL HAS_CARD { get { return new HAS_CARD_REL(Parent, DirectionEnum.Out); } }
        }
    }

    public class CostAlias : AliasResult<CostAlias, CostListAlias>
    {
        internal CostAlias(CostNode parent)
        {
            Node = parent;
        }
        internal CostAlias(CostNode parent, string name)
        {
            Node = parent;
            AliasName = name;
        }
        internal void SetAlias(string name) => AliasName = name;

        private  CostAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private  CostAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private  CostAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type)
        {
            Node = alias.Node;
        }

        public Assignment[] Assign(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            List<Assignment> assignments = new List<Assignment>();
            if (ActivationEffect.HasValue) assignments.Add(new Assignment(this.ActivationEffect, ActivationEffect));
            if (BaseEffect.HasValue) assignments.Add(new Assignment(this.BaseEffect, BaseEffect));
            if (EnteringEffect.HasValue) assignments.Add(new Assignment(this.EnteringEffect, EnteringEffect));
            if (Id.HasValue) assignments.Add(new Assignment(this.Id, Id));
            if (LeavingEffect.HasValue) assignments.Add(new Assignment(this.LeavingEffect, LeavingEffect));
            if (LoosingEffect.HasValue) assignments.Add(new Assignment(this.LoosingEffect, LoosingEffect));
            if (Lore.HasValue) assignments.Add(new Assignment(this.Lore, Lore));
            if (MandatoryActivationEffect.HasValue) assignments.Add(new Assignment(this.MandatoryActivationEffect, MandatoryActivationEffect));
            if (Name.HasValue) assignments.Add(new Assignment(this.Name, Name));
            if (PermanentEffect.HasValue) assignments.Add(new Assignment(this.PermanentEffect, PermanentEffect));
            if (ReactionEffect.HasValue) assignments.Add(new Assignment(this.ReactionEffect, ReactionEffect));
            
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
                        { "Name", new StringResult(this, "Name", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Name"]) },
                        { "BaseEffect", new StringResult(this, "BaseEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["BaseEffect"]) },
                        { "ReactionEffect", new StringResult(this, "ReactionEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ReactionEffect"]) },
                        { "EnteringEffect", new StringResult(this, "EnteringEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["EnteringEffect"]) },
                        { "LeavingEffect", new StringResult(this, "LeavingEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LeavingEffect"]) },
                        { "ActivationEffect", new StringResult(this, "ActivationEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ActivationEffect"]) },
                        { "MandatoryActivationEffect", new StringResult(this, "MandatoryActivationEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["MandatoryActivationEffect"]) },
                        { "PermanentEffect", new StringResult(this, "PermanentEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["PermanentEffect"]) },
                        { "LoosingEffect", new StringResult(this, "LoosingEffect", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LoosingEffect"]) },
                        { "Lore", new StringResult(this, "Lore", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Lore"]) },
                        { "Id", new StringResult(this, "Id", DeckBuilder.Model.Datastore.Model.Entities["Cost"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Id"]) },
                    };
                }
                return m_AliasFields;
            }
        }
        private IReadOnlyDictionary<string, FieldResult> m_AliasFields = null;

        public CostNode.CostIn In { get { return new CostNode.CostIn(new CostNode(this, true)); } }
        public CostNode.CostOut Out { get { return new CostNode.CostOut(new CostNode(this, true)); } }

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
        public StringResult BaseEffect
        {
            get
            {
                if (m_BaseEffect is null)
                    m_BaseEffect = (StringResult)AliasFields["BaseEffect"];

                return m_BaseEffect;
            }
        }
        private StringResult m_BaseEffect = null;
        public StringResult ReactionEffect
        {
            get
            {
                if (m_ReactionEffect is null)
                    m_ReactionEffect = (StringResult)AliasFields["ReactionEffect"];

                return m_ReactionEffect;
            }
        }
        private StringResult m_ReactionEffect = null;
        public StringResult EnteringEffect
        {
            get
            {
                if (m_EnteringEffect is null)
                    m_EnteringEffect = (StringResult)AliasFields["EnteringEffect"];

                return m_EnteringEffect;
            }
        }
        private StringResult m_EnteringEffect = null;
        public StringResult LeavingEffect
        {
            get
            {
                if (m_LeavingEffect is null)
                    m_LeavingEffect = (StringResult)AliasFields["LeavingEffect"];

                return m_LeavingEffect;
            }
        }
        private StringResult m_LeavingEffect = null;
        public StringResult ActivationEffect
        {
            get
            {
                if (m_ActivationEffect is null)
                    m_ActivationEffect = (StringResult)AliasFields["ActivationEffect"];

                return m_ActivationEffect;
            }
        }
        private StringResult m_ActivationEffect = null;
        public StringResult MandatoryActivationEffect
        {
            get
            {
                if (m_MandatoryActivationEffect is null)
                    m_MandatoryActivationEffect = (StringResult)AliasFields["MandatoryActivationEffect"];

                return m_MandatoryActivationEffect;
            }
        }
        private StringResult m_MandatoryActivationEffect = null;
        public StringResult PermanentEffect
        {
            get
            {
                if (m_PermanentEffect is null)
                    m_PermanentEffect = (StringResult)AliasFields["PermanentEffect"];

                return m_PermanentEffect;
            }
        }
        private StringResult m_PermanentEffect = null;
        public StringResult LoosingEffect
        {
            get
            {
                if (m_LoosingEffect is null)
                    m_LoosingEffect = (StringResult)AliasFields["LoosingEffect"];

                return m_LoosingEffect;
            }
        }
        private StringResult m_LoosingEffect = null;
        public StringResult Lore
        {
            get
            {
                if (m_Lore is null)
                    m_Lore = (StringResult)AliasFields["Lore"];

                return m_Lore;
            }
        }
        private StringResult m_Lore = null;
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
        public AsResult As(string aliasName, out CostAlias alias)
        {
            alias = new CostAlias((CostNode)Node)
            {
                AliasName = aliasName
            };
            return this.As(aliasName);
        }
    }

    public class CostListAlias : ListResult<CostListAlias, CostAlias>, IAliasListResult
    {
        private CostListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private CostListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private CostListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
    public class CostJaggedListAlias : ListResult<CostJaggedListAlias, CostListAlias>, IAliasJaggedListResult
    {
        private CostJaggedListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private CostJaggedListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private CostJaggedListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
}
