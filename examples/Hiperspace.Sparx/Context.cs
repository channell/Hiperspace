using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;

namespace Sparx.EA
{
    public partial class Context : DbContext
    {
        public Context([NotNull] DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Attribute> Attributes { get; set; }
        
        public virtual DbSet<Connector> Connectors { get; set; }
        public virtual DbSet<ConnectorConstraint> ConnectorConstraints { get; set; }
        public virtual DbSet<ConnectorTag> ConnectorTags { get; set; }

        public virtual DbSet<Diagram> Diagrams { get; set; }
        
        public virtual DbSet<DiagramLink> DiagramLinks { get; set; }
        
        public virtual DbSet<DiagramObject> DiagramObjects { get; set; }
        
        public virtual DbSet<Element> Elements { get; set; }
        public virtual DbSet<ObjectFile> ObjectFiles { get; set; }

        public virtual DbSet<ObjectMetric> ObjectMetrics { get; set; }

        public virtual DbSet<ObjectProblem> ObjectProblems { get; set; }
        
        public virtual DbSet<ObjectProperty> ObjectProperties { get; set; }
        
        public virtual DbSet<ObjectRequire> ObjectRequires { get; set; }
        
        public virtual DbSet<ObjectResource> ObjectResource { get; set; }
        
        public virtual DbSet<ObjectRisk> ObjectRisks { get; set; }
        
        public virtual DbSet<ObjectScenario> ObjectScenarios { get; set; }
        
        public virtual DbSet<ObjectTest> ObjectTests { get; set; }
        
//        public virtual DbSet<ElementTrx> ElementTrxs { get; set; }
        
        public virtual DbSet<Operation>  Operations { get; set; }
        
        public virtual DbSet<OperationParam>  OperationParams { get; set; }
        
        public virtual DbSet<OperationPostCondition>  OperationPostConditions { get; set; }
        
        public virtual DbSet<OperationPreCondition>  OperationPreConditions { get; set; }
        
        public virtual DbSet<OperationTag>  OperationTags { get; set; }
        
        public virtual DbSet<Package> Packages { get; set; }
        
        public virtual DbSet<RoleConstraint> RoleConstraints { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .HasKey(e => e.Id)
                ;
            modelBuilder.Ignore<ElementLoaded>();
            modelBuilder.Ignore<PackageLoaded>();

            modelBuilder.Entity<Element>()
                .Property(e => e.Parent_Id)
                .HasColumnName("ParentID");
            
            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Links)
                .WithOne(e => e.Connector)
                .HasForeignKey(e => e.Connector_Id);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Requirements)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.RoleConstraints)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.StartConnectors)
                .WithOne(e => e.StartElement)
                .HasForeignKey(e => e.StartElement_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.EndConnectors)
                .WithOne(e => e.EndElement)
                .HasForeignKey(e => e.EndElement_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Files)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Metrics)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Problems)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Risks)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Links)
                .WithOne(e => e.Element)
                .HasForeignKey(e => e.Element_Id)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.Scenarios)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.Properties)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;
            modelBuilder.Entity<Operation>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID");

            modelBuilder.Entity<Operation>()
                .Property(e => e.Id)
                .HasColumnName("OperationID")
                .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Operation>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID");
            modelBuilder.Entity<Operation>()
                .HasOne(e => e.owner)
                .WithMany(e => e.Operations)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.PostConditions)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.PreConditions)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Attribute>()
                .Property(e => e.Element_Id)
                .HasColumnName("Object_ID");

            modelBuilder.Entity<Attribute>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<Element>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<Connector>()
                .Property(e => e.StartElement_Id)
                .HasColumnName("Start_Object_ID")
                ;
            modelBuilder.Entity<Connector>()
                .Property(e => e.EndElement_Id)
                .HasColumnName("End_Object_ID")
                ;
            modelBuilder.Entity<Connector>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Diagram>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<DiagramLink>()
                .Property(e => e.Connector_Id)
                .HasColumnName("ConnectorID")
                ;
            modelBuilder.Entity<DiagramLink>()
                .Property(e => e.Diagram_Id)
                .HasColumnName("DiagramID")
                ;
            modelBuilder.Entity<DiagramLink>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<DiagramObject>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<DiagramObject>()
                .Property(e => e.Element_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<DiagramObject>()
                .Property(e => e.Id)
                .HasColumnName("Instance_ID")
                ;
            modelBuilder.Entity<DiagramObject>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Package>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ConnectorConstraint>()
                .HasKey(e => new { e.owner_Id, e.Constraint });

            modelBuilder.Entity<ConnectorConstraint>()
                .Property(e => e.owner_Id)
                .HasColumnName("ConnectorID")
                ;
            modelBuilder.Entity<ConnectorConstraint>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ConnectorTag>()
                .Property(e => e.owner_Id)
                .HasColumnName("ElementID")
                ;
            modelBuilder.Entity<ConnectorTag>()
                .Property(e => e.PropertyId)
                .HasColumnName("PropertyID")
                ;
            modelBuilder.Entity<ConnectorTag>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<RoleConstraint>()
                .HasKey(e => new { e.owner_Id, e.Constraint, e.ConnectorEnd, e.ConstraintType});

            modelBuilder.Entity<RoleConstraint>()
                .Property(e => e.owner_Id)
                .HasColumnName("ConnectorID")
                ;
            modelBuilder.Entity<RoleConstraint>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ObjectFile>()
                .HasKey(e => new { e.owner_Id, e.FileName});
            modelBuilder.Entity<ObjectFile>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID");

            modelBuilder.Entity<ObjectFile>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectMetric>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectMetric>()
                .HasKey(e => new { e.owner_Id, e.Metric });

            modelBuilder.Entity<ObjectMetric>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<Operation>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<Operation>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Operation>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<OperationParam>()
                .Property(e => e.owner_Id)
                .HasColumnName("OperationID")
                ;
            modelBuilder.Entity<OperationParam>()
                .HasKey(e => new { e.owner_Id, e.Name });

            modelBuilder.Entity<OperationParam>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<OperationPostCondition>()
                .Property(e => e.owner_Id)
                .HasColumnName("OperationID")
                ;
            modelBuilder.Entity<OperationPostCondition>()
                .HasKey(e => new { e.owner_Id, e.PostCondition });

            modelBuilder.Entity<OperationPostCondition>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<OperationPreCondition>()
                .Property(e => e.owner_Id)
                .HasColumnName("OperationID")
                ;
            modelBuilder.Entity<OperationPreCondition>()
                .HasKey(e => new { e.owner_Id, e.PreCondition });

            modelBuilder.Entity<OperationPreCondition>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<OperationTag>()
                .Property(e => e.owner_Id)
                .HasColumnName("ElementID")
                ;
            modelBuilder.Entity<OperationTag>()
                .Property(e => e.Id)
                .HasColumnName("PropertyID")
                ;
            modelBuilder.Entity<OperationTag>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<OperationTag>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectProblem>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectProblem>()
                .HasKey(e => new { e.owner_Id, e.Problem, e.ProblemType });

            modelBuilder.Entity<ObjectProblem>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectProperty>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectProperty>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectRequire>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectRequire>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ObjectResource>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectResource>()
                .Property(e => e.Resource_Name)
                .HasColumnName("Resource")
                ;
            modelBuilder.Entity<ObjectResource>()
                .HasKey(e => new { e.owner_Id, e.Resource_Name });

            modelBuilder.Entity<ObjectResource>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ObjectRisk>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectRisk>()
                .HasKey(e => new { e.owner_Id, e.Risk });

            modelBuilder.Entity<ObjectRisk>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectScenario>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectScenario>()
                .HasKey(e => new { e.owner_Id, e.Scenario });

            modelBuilder.Entity<ObjectScenario>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ObjectTest>()
                .Property(e => e.owner_Id)
                .HasColumnName("Object_ID")
                ;
            modelBuilder.Entity<ObjectTest>()
                .HasKey(e => new { e.owner_Id, e.Test, e.TestClass });

            modelBuilder.Entity<ObjectTest>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.AsWas)
                .Ignore(t => t.Deleted)
                ;
        }
    }
}
