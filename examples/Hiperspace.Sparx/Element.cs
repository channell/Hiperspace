using System.IO;

namespace Sparx.EA
{
    public partial class Element
    {
        [JsonIgnore]
        public virtual Package? DBPackage
        {
            get
            {
                return Package?.Value;
            }
            set
            {
                if (value != null)
                    Package = new(new() { Id = value?.Id }, value);
            }
        }
        [JsonIgnore]
        public virtual Element? DBParent
        {
            get
            {
                return Parent?.Value;
            }
            set
            {
                if (value != null)
                    Parent = new(new() { Id = value?.Id }, value);
            }
        }
        [JsonIgnore]
        [Column("Package_ID")]
        public int? PackageId
        {
            get
            {
                return Package?.Key.Id;
            }
            set
            {
                Package = new(new() { Id = value });
            }
        }
        [JsonIgnore]
        [Column("ParentID")]
        public int? ParentID
        {
            get
            {
                return Parent?.Key.Id;
            }
            set
            {
                Parent = new(new() { Id = value });
            }
        }
        [JsonIgnore]
        public virtual ICollection<Connector> DBStartConnectors
        {
            get => StartConnectors;
            set => StartConnectors.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Connector> DBEndConnectors
        {
            get => EndConnectors;
            set => EndConnectors.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Attribute> DBAttributes
        {
            get => Attributes;
            set => Attributes.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<DiagramObject> DBLinks
        {
            get => Links;
            set => Links.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementFiles> DBFiles
        {
            get => Files;
            set => Files.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementMetrics> DBMetrics
        {
            get => Metrics;
            set => Metrics.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementProblems> DBProblems
        {
            get => Problems;
            set => Problems.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementProperties> DBProperties
        {
            get => Properties;
            set => Properties.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementRequirements> DBRequirements
        {
            get => Requirements;
            set => Requirements.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementResources> DBResources
        {
            get => Resources;
            set => Resources.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementRisks> DBRisks
        {
            get => Risks;
            set => Risks.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementScenarios> DBScenarios
        {
            get => Scenarios;
            set => Scenarios.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementTests> DBTests
        {
            get => Tests;
            set => Tests.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementOperations> DBOperations
        {
            get => Operations;
            set => Operations.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Element> DBChildren
        {
            get => Children;
            set => Children.UnionWith(value);
        }
    }
}
