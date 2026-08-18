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
        public static EclipseNode Eclipse { get { return new EclipseNode(); } }
    }

    public partial class EclipseNode : Blueprint41.Query.Node
    {
        public static implicit operator QueryCondition(EclipseNode a)
        {
            return new QueryCondition(a);
        }
        public static QueryCondition operator !(EclipseNode a)
        {
            return new QueryCondition(a, true);
        } 

        protected override string GetNeo4jLabel()
        {
            return "Eclipse";
        }

        protected override Entity GetEntity()
        {
            return m.Eclipse.Entity;
        }
        public FunctionalId FunctionalId
        {
            get
            {
                return m.Eclipse.Entity.FunctionalId;
            }
        }

        internal EclipseNode() { }
        internal EclipseNode(EclipseAlias alias, bool isReference = false)
        {
            NodeAlias = alias;
            IsReference = isReference;
        }
        internal EclipseNode(RELATIONSHIP relationship, DirectionEnum direction, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity) { }
        internal EclipseNode(RELATIONSHIP relationship, DirectionEnum direction, AliasResult nodeAlias, string neo4jLabel = null, Entity entity = null) : base(relationship, direction, neo4jLabel, entity)
        {
            NodeAlias = nodeAlias;
        }

        public EclipseNode Where(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EclipseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<EclipseAlias> alias = new Lazy<EclipseAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<QueryCondition> conditions = new List<QueryCondition>();
            if (ActivationEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.ActivationEffect, Operator.Equals, ((IValue)ActivationEffect).GetValue()));
            if (BaseEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.BaseEffect, Operator.Equals, ((IValue)BaseEffect).GetValue()));
            if (EclipseEffect.HasValue) conditions.Add(new QueryCondition(alias.Value.EclipseEffect, Operator.Equals, ((IValue)EclipseEffect).GetValue()));
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
        public EclipseNode Assign(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EclipseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            if (InlineConditions is not null || InlineAssignments is not null)
                throw new NotSupportedException("You cannot, at the same time, have inline-assignments and inline-conditions defined on a node.");

            Lazy<EclipseAlias> alias = new Lazy<EclipseAlias>(delegate()
            {
                this.Alias(out var a);
                return a;
            });
            List<Assignment> assignments = new List<Assignment>();
            if (ActivationEffect.HasValue) assignments.Add(new Assignment(alias.Value.ActivationEffect, ActivationEffect));
            if (BaseEffect.HasValue) assignments.Add(new Assignment(alias.Value.BaseEffect, BaseEffect));
            if (EclipseEffect.HasValue) assignments.Add(new Assignment(alias.Value.EclipseEffect, EclipseEffect));
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

        public EclipseNode Alias(out EclipseAlias alias)
        {
            if (NodeAlias is EclipseAlias a)
            {
                alias = a;
            }
            else
            {
                alias = new EclipseAlias(this);
                NodeAlias = alias;
            }
            return this;
        }
        public EclipseNode Alias(out EclipseAlias alias, string name)
        {
            if (NodeAlias is EclipseAlias a)
            {
                a.SetAlias(name);
                alias = a;
            }
            else
            {
                alias = new EclipseAlias(this, name);
                NodeAlias = alias;
            }
            return this;
        }

        public EclipseNode UseExistingAlias(AliasResult alias)
        {
            NodeAlias = alias;
            IsReference = true;
            return this;
        }

        public EclipseIn  In  { get { return new EclipseIn(this); } }
        public class EclipseIn
        {
            private EclipseNode Parent;
            internal EclipseIn(EclipseNode parent)
            {
                Parent = parent;
            }
            public IFromIn_ECLIPSING_REL ECLIPSING { get { return new ECLIPSING_REL(Parent, DirectionEnum.In); } }

        }

        public EclipseOut Out { get { return new EclipseOut(this); } }
        public class EclipseOut
        {
            private EclipseNode Parent;
            internal EclipseOut(EclipseNode parent)
            {
                Parent = parent;
            }
            public IFromOut_HAS_CARD_REL HAS_CARD { get { return new HAS_CARD_REL(Parent, DirectionEnum.Out); } }
        }
    }

    public class EclipseAlias : AliasResult<EclipseAlias, EclipseListAlias>
    {
        internal EclipseAlias(EclipseNode parent)
        {
            Node = parent;
        }
        internal EclipseAlias(EclipseNode parent, string name)
        {
            Node = parent;
            AliasName = name;
        }
        internal void SetAlias(string name) => AliasName = name;

        private  EclipseAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private  EclipseAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private  EclipseAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type)
        {
            Node = alias.Node;
        }

        public Assignment[] Assign(JsNotation<string> ActivationEffect = default, JsNotation<string> BaseEffect = default, JsNotation<string> EclipseEffect = default, JsNotation<string> EnteringEffect = default, JsNotation<string> Id = default, JsNotation<string> LeavingEffect = default, JsNotation<string> LoosingEffect = default, JsNotation<string> Lore = default, JsNotation<string> MandatoryActivationEffect = default, JsNotation<string> Name = default, JsNotation<string> PermanentEffect = default, JsNotation<string> ReactionEffect = default)
        {
            List<Assignment> assignments = new List<Assignment>();
            if (ActivationEffect.HasValue) assignments.Add(new Assignment(this.ActivationEffect, ActivationEffect));
            if (BaseEffect.HasValue) assignments.Add(new Assignment(this.BaseEffect, BaseEffect));
            if (EclipseEffect.HasValue) assignments.Add(new Assignment(this.EclipseEffect, EclipseEffect));
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
                        { "EclipseEffect", new StringResult(this, "EclipseEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Eclipse"].Properties["EclipseEffect"]) },
                        { "Name", new StringResult(this, "Name", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Name"]) },
                        { "BaseEffect", new StringResult(this, "BaseEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["BaseEffect"]) },
                        { "ReactionEffect", new StringResult(this, "ReactionEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ReactionEffect"]) },
                        { "EnteringEffect", new StringResult(this, "EnteringEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["EnteringEffect"]) },
                        { "LeavingEffect", new StringResult(this, "LeavingEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LeavingEffect"]) },
                        { "ActivationEffect", new StringResult(this, "ActivationEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["ActivationEffect"]) },
                        { "MandatoryActivationEffect", new StringResult(this, "MandatoryActivationEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["MandatoryActivationEffect"]) },
                        { "PermanentEffect", new StringResult(this, "PermanentEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["PermanentEffect"]) },
                        { "LoosingEffect", new StringResult(this, "LoosingEffect", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["LoosingEffect"]) },
                        { "Lore", new StringResult(this, "Lore", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Lore"]) },
                        { "Id", new StringResult(this, "Id", DeckBuilder.Model.Datastore.Model.Entities["Eclipse"], DeckBuilder.Model.Datastore.Model.Entities["Card"].Properties["Id"]) },
                    };
                }
                return m_AliasFields;
            }
        }
        private IReadOnlyDictionary<string, FieldResult> m_AliasFields = null;

        public EclipseNode.EclipseIn In { get { return new EclipseNode.EclipseIn(new EclipseNode(this, true)); } }
        public EclipseNode.EclipseOut Out { get { return new EclipseNode.EclipseOut(new EclipseNode(this, true)); } }

        public StringResult EclipseEffect
        {
            get
            {
                if (m_EclipseEffect is null)
                    m_EclipseEffect = (StringResult)AliasFields["EclipseEffect"];

                return m_EclipseEffect;
            }
        }
        private StringResult m_EclipseEffect = null;
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
        public AsResult As(string aliasName, out EclipseAlias alias)
        {
            alias = new EclipseAlias((EclipseNode)Node)
            {
                AliasName = aliasName
            };
            return this.As(aliasName);
        }
    }

    public class EclipseListAlias : ListResult<EclipseListAlias, EclipseAlias>, IAliasListResult
    {
        private EclipseListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private EclipseListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private EclipseListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
    public class EclipseJaggedListAlias : ListResult<EclipseJaggedListAlias, EclipseListAlias>, IAliasJaggedListResult
    {
        private EclipseJaggedListAlias(Func<QueryTranslator, string> function, object[] arguments, Type type) : base(function, arguments, type) { }
        private EclipseJaggedListAlias(FieldResult parent, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(parent, function, arguments, type) { }
        private EclipseJaggedListAlias(AliasResult alias, Func<QueryTranslator, string> function, object[] arguments = null, Type type = null) : base(alias, function, arguments, type) { }
    }
}
