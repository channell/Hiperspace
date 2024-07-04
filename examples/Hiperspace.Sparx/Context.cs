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
        public virtual DbSet<ElementFile> ElementFiles { get; set; }

        public virtual DbSet<ElementMetric> ElementMetrics { get; set; }
        
        public virtual DbSet<ElementProblem> ElementProblems { get; set; }
        
        public virtual DbSet<ElementPropertie> ElementProperties { get; set; }
        
        public virtual DbSet<ElementRequirement> ElementRequires { get; set; }
        
        public virtual DbSet<ElementResource> ElementResource { get; set; }
        
        public virtual DbSet<ElementRisk> ElementRisks { get; set; }
        
        public virtual DbSet<ElementScenario> ElementScenarios { get; set; }
        
        public virtual DbSet<ElementTest> ElementTests { get; set; }
        
//        public virtual DbSet<ElementTrx> ElementTrxs { get; set; }
        
        public virtual DbSet<ElementOperation>  ElementOperations { get; set; }
        
        public virtual DbSet<ElementOperationParameter>  ElementOperationParams { get; set; }
        
        public virtual DbSet<ElementOperationPostCondition>  ElementOperationPostConditions { get; set; }
        
        public virtual DbSet<ElementOperationPreCondition>  ElementOperationPreConditions { get; set; }
        
        public virtual DbSet<ElementOperationTag>  ElementOperationTags { get; set; }
        
        public virtual DbSet<Package> Packages { get; set; }
        
        public virtual DbSet<ConnectorRoleConstraint> RoleConstraints { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Element>().Property(e => e.Parent_Id).HasColumnName("ParentID");
            
            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Links)
                .WithOne(e => e.Connector)
                .HasForeignKey(e => e.Connector_Id);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<ElementOperation>()
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
                .WithOne(e => e.StartElement_Value)
                .HasForeignKey(e => e.StartElement_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.EndConnectors)
                .WithOne(e => e.EndElement_Value)
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
            modelBuilder.Entity<ElementOperation>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperation>().Property(e => e.Id).HasColumnName("OperationID").HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ElementOperation>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperation>()
                .HasOne(e => e.owner)
                .WithMany(e => e.Operations)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<ElementOperation>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperation>()
                .HasMany(e => e.PostConditions)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperation>()
                .HasMany(e => e.PreConditions)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperation>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Attribute>().Property(e => e.Element_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<Attribute>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Element>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;


            modelBuilder.Entity<Connector>().Property(e => e.StartElement_Id).HasColumnName("Start_Object_ID");
            modelBuilder.Entity<Connector>().Property(e => e.EndElement_Id).HasColumnName("End_Object_ID");
            modelBuilder.Entity<Connector>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Diagram>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<DiagramLink>().Property(e => e.Connector_Id).HasColumnName("ConnectorID");
            modelBuilder.Entity<DiagramLink>().Property(e => e.Diagram_Id).HasColumnName("DiagramID");
            modelBuilder.Entity<DiagramLink>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<DiagramObject>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<DiagramObject>().Property(e => e.Element_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<DiagramObject>().Property(e => e.Id).HasColumnName("Instance_ID");
            modelBuilder.Entity<DiagramObject>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Package>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ConnectorConstraint>()
                .HasKey(e => new { e.owner_Id, e.Constraint });

            modelBuilder.Entity<ConnectorConstraint>().Property(e => e.owner_Id).HasColumnName("ConnectorID");
            modelBuilder.Entity<ConnectorConstraint>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ConnectorTag>().Property(e => e.owner_Id).HasColumnName("ElementID");
            modelBuilder.Entity<ConnectorTag>().Property(e => e.PropertyId).HasColumnName("PropertyID");
            modelBuilder.Entity<ConnectorTag>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ConnectorRoleConstraint>()
                .HasKey(e => new { e.owner_Id, e.Constraint, e.ConnectorEnd, e.ConstraintType});

            modelBuilder.Entity<ConnectorRoleConstraint>().Property(e => e.owner_Id).HasColumnName("ConnectorID");
            modelBuilder.Entity<ConnectorRoleConstraint>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementFile>()
                .HasKey(e => new { e.owner_Id, e.FileName});
            modelBuilder.Entity<ElementFile>().Property(e => e.owner_Id).HasColumnName("Object_ID");

            modelBuilder.Entity<ElementFile>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementMetric>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementMetric>()
                .HasKey(e => new { e.owner_Id, e.Metric });

            modelBuilder.Entity<ElementMetric>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementOperation>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperation>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ElementOperation>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationParameter>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationParameter>()
                .HasKey(e => new { e.owner_Id, e.Name });

            modelBuilder.Entity<ElementOperationParameter>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationPostCondition>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationPostCondition>()
                .HasKey(e => new { e.owner_Id, e.PostCondition });

            modelBuilder.Entity<ElementOperationPostCondition>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationPreCondition>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationPreCondition>()
                .HasKey(e => new { e.owner_Id, e.PreCondition });

            modelBuilder.Entity<ElementOperationPreCondition>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationTag>().Property(e => e.owner_Id).HasColumnName("ElementID");
            modelBuilder.Entity<ElementOperationTag>().Property(e => e.Id).HasColumnName("PropertyID");
            modelBuilder.Entity<ElementOperationTag>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ElementOperationTag>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementProblem>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementProblem>()
                .HasKey(e => new { e.owner_Id, e.Problem, e.ProblemType });

            modelBuilder.Entity<ElementProblem>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementPropertie>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementPropertie>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementRequirement>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementRequirement>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementResource>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementResource>().Property(e => e.Resource_Name).HasColumnName("Resource");
            modelBuilder.Entity<ElementResource>()
                .HasKey(e => new { e.owner_Id, e.Resource_Name });

            modelBuilder.Entity<ElementResource>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementRisk>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementRisk>()
                .HasKey(e => new { e.owner_Id, e.Risk });

            modelBuilder.Entity<ElementRisk>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementScenario>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementScenario>()
                .HasKey(e => new { e.owner_Id, e.Scenario });

            modelBuilder.Entity<ElementScenario>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementTest>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementTest>()
                .HasKey(e => new { e.owner_Id, e.Test, e.TestClass });

            modelBuilder.Entity<ElementTest>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
        }
    }
}
