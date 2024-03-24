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
        public virtual DbSet<ConnectorConstraints> ConnectorConstraints { get; set; }
        public virtual DbSet<ConnectorTags> ConnectorTags { get; set; }

        public virtual DbSet<Diagram> Diagrams { get; set; }
        
        public virtual DbSet<DiagramLink> DiagramLinks { get; set; }
        
        public virtual DbSet<DiagramObject> DiagramObjects { get; set; }
        
        public virtual DbSet<Element> Elements { get; set; }
        public virtual DbSet<ElementFiles> ElementFiles { get; set; }

        public virtual DbSet<ElementMetrics> ElementMetrics { get; set; }
        
        public virtual DbSet<ElementProblems> ElementProblems { get; set; }
        
        public virtual DbSet<ElementProperties> ElementProperties { get; set; }
        
        public virtual DbSet<ElementRequirements> ElementRequires { get; set; }
        
        public virtual DbSet<ElementResources> ElementResource { get; set; }
        
        public virtual DbSet<ElementRisks> ElementRisks { get; set; }
        
        public virtual DbSet<ElementScenarios> ElementScenarios { get; set; }
        
        public virtual DbSet<ElementTests> ElementTests { get; set; }
        
//        public virtual DbSet<ElementTrx> ElementTrxs { get; set; }
        
        public virtual DbSet<ElementOperations>  ElementOperations { get; set; }
        
        public virtual DbSet<ElementOperationsParameters>  ElementOperationParams { get; set; }
        
        public virtual DbSet<ElementOperationsPostConditions>  ElementOperationPostConditions { get; set; }
        
        public virtual DbSet<ElementOperationsPreConditions>  ElementOperationPreConditions { get; set; }
        
        public virtual DbSet<ElementOperationsTags>  ElementOperationTags { get; set; }
        
        public virtual DbSet<Package> Packages { get; set; }
        
        public virtual DbSet<ConnectorRoleConstraints> RoleConstraints { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Element>().Property(e => e.Parent_Id).HasColumnName("ParentID");
            
            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Links)
                .WithOne(e => e.Connector_Value)
                .HasForeignKey(e => e.Connector_Id);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Requirements)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.RoleConstraints)
                .WithOne(e => e.owner_Value)
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
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Metrics)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Problems)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Risks)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Links)
                .WithOne(e => e.Element_Value)
                .HasForeignKey(e => e.Element_Id)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.Scenarios)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.Properties)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;
            modelBuilder.Entity<ElementOperations>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperations>().Property(e => e.Id).HasColumnName("OperationID").HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ElementOperations>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperations>()
                .HasOne(e => e.owner_Value)
                .WithMany(e => e.Operations)
                .HasForeignKey(e => e.owner_Id);

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.PostConditions)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.PreConditions)
                .WithOne(e => e.owner_Value)
                .HasForeignKey(e => e.owner_Id)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.Tags)
                .WithOne(e => e.owner_Value)
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

            modelBuilder.Entity<ConnectorConstraints>()
                .HasKey(e => new { e.owner_Id, e.Constraint });

            modelBuilder.Entity<ConnectorConstraints>().Property(e => e.owner_Id).HasColumnName("ConnectorID");
            modelBuilder.Entity<ConnectorConstraints>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ConnectorTags>().Property(e => e.owner_Id).HasColumnName("ElementID");
            modelBuilder.Entity<ConnectorTags>().Property(e => e.PropertyId).HasColumnName("PropertyID");
            modelBuilder.Entity<ConnectorTags>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ConnectorRoleConstraints>()
                .HasKey(e => new { e.owner_Id, e.Constraint, e.ConnectorEnd, e.ConstraintType});

            modelBuilder.Entity<ConnectorRoleConstraints>().Property(e => e.owner_Id).HasColumnName("ConnectorID");
            modelBuilder.Entity<ConnectorRoleConstraints>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementFiles>()
                .HasKey(e => new { e.owner_Id, e.FileName});
            modelBuilder.Entity<ElementFiles>().Property(e => e.owner_Id).HasColumnName("Object_ID");

            modelBuilder.Entity<ElementFiles>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementMetrics>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementMetrics>()
                .HasKey(e => new { e.owner_Id, e.Metric });

            modelBuilder.Entity<ElementMetrics>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementOperations>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementOperations>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ElementOperations>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsParameters>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationsParameters>()
                .HasKey(e => new { e.owner_Id, e.Name });

            modelBuilder.Entity<ElementOperationsParameters>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsPostConditions>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationsPostConditions>()
                .HasKey(e => new { e.owner_Id, e.PostCondition });

            modelBuilder.Entity<ElementOperationsPostConditions>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsPreConditions>().Property(e => e.owner_Id).HasColumnName("OperationID");
            modelBuilder.Entity<ElementOperationsPreConditions>()
                .HasKey(e => new { e.owner_Id, e.PreCondition });

            modelBuilder.Entity<ElementOperationsPreConditions>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsTags>().Property(e => e.owner_Id).HasColumnName("ElementID");
            modelBuilder.Entity<ElementOperationsTags>().Property(e => e.Id).HasColumnName("PropertyID");
            modelBuilder.Entity<ElementOperationsTags>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ElementOperationsTags>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementProblems>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementProblems>()
                .HasKey(e => new { e.owner_Id, e.Problem, e.ProblemType });

            modelBuilder.Entity<ElementProblems>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementProperties>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementProperties>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementRequirements>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementRequirements>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementResources>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementResources>().Property(e => e.Resource_Name).HasColumnName("Resource");
            modelBuilder.Entity<ElementResources>()
                .HasKey(e => new { e.owner_Id, e.Resource_Name });

            modelBuilder.Entity<ElementResources>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<ElementRisks>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementRisks>()
                .HasKey(e => new { e.owner_Id, e.Risk });

            modelBuilder.Entity<ElementRisks>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementScenarios>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementScenarios>()
                .HasKey(e => new { e.owner_Id, e.Scenario });

            modelBuilder.Entity<ElementScenarios>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementTests>().Property(e => e.owner_Id).HasColumnName("Object_ID");
            modelBuilder.Entity<ElementTests>()
                .HasKey(e => new { e.owner_Id, e.Test, e.TestClass });

            modelBuilder.Entity<ElementTests>()
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
        }
    }
}
