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
        
        public virtual DbSet<ElementOperationsPostCondiitons>  ElementOperationPostConditions { get; set; }
        
        public virtual DbSet<ElementOperationsPreConditions>  ElementOperationPreConditions { get; set; }
        
        public virtual DbSet<ElementOperationsTags>  ElementOperationTags { get; set; }
        
        public virtual DbSet<Package> Packages { get; set; }
        
        public virtual DbSet<ConnectorRoleConstraints> RoleConstraints { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diagram>()
                .HasMany(e => e.Parts)
                .WithOne(e => e.DBDiagram)
                .HasForeignKey(e => e.DiagramId);

            modelBuilder.Entity<Diagram>()
                .HasMany(e => e.DiagramLinks)
                .WithOne(e => e.DBDiagram)
                .HasForeignKey(e => e.DiagramId);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.DBContent)
                .WithOne(e => e.DBPackage)
                .HasForeignKey(e => e.PackageId);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.DBChildren)
                .WithOne(e => e.DBParent)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBAttributes)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBOperations)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBChildren)
                .WithOne(e => e.DBParent)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.DBLinks)
                .WithOne(e => e.DBConnector)
                .HasForeignKey(e => e.ConnectorId);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.DBTags)
                .WithOne(e => e.DBConnector)
                .HasForeignKey(e => e.ConnectorId);

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.DBTags)
                .WithOne(e => e.DBOperation)
                .HasForeignKey(e => e.OperationId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBTests)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBRequirements)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.DBRoleConstraints)
                .WithOne(e => e.DBConnector)
                .HasForeignKey(e => e.ConnectorId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBStartConnectors)
                .WithOne(e => e.DBStartElement)
                .HasForeignKey(e => e.StartObjectId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBEndConnectors)
                .WithOne(e => e.DBEndElement)
                .HasForeignKey(e => e.EndObjectId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBFiles)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBMetrics)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBProblems)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.DBObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBResources)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBRisks)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBTests)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBLinks)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBScenarios)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;
            modelBuilder.Entity<Element>()
                .HasMany(e => e.DBProperties)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ObjectId)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.DBParameters)
                .WithOne(e => e.DBOperation)
                .HasForeignKey(e => e.OperationId)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.DBPostCondiitons)
                .WithOne(e => e.DBOperation)
                .HasForeignKey(e => e.OperationId)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.DBPreConditions)
                .WithOne(e => e.DBOperation)
                .HasForeignKey(e => e.OperationId)
                ;

            modelBuilder.Entity<ElementOperations>()
                .HasMany(e => e.DBTags)
                .WithOne(e => e.DBOperation)
                .HasForeignKey(e => e.OperationId)
                ;

            modelBuilder.Entity<Attribute>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Element>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Connector>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Diagram>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<DiagramLink>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<DiagramObject>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                .Ignore(t => t.Id)
                ;
            modelBuilder.Entity<Package>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<Resource>()
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                ;

            modelBuilder.Entity<ConnectorConstraints>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ConnectorTags>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ConnectorRoleConstraints>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementFiles>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementMetrics>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperations>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                .Ignore(t => t.Id)
                ;
            modelBuilder.Entity<ElementOperationsParameters>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsPostCondiitons>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsPreConditions>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementOperationsTags>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementProblems>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementProperties>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementRequirements>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementResources>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementRisks>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementScenarios>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;
            modelBuilder.Entity<ElementTests>()
                .Ignore(t => t.owner)
                .Ignore(t => t.self)
                .Ignore(t => t.SKey)
                .Ignore(t => t.SetSpace)
                .Ignore(t => t.AsAt)
                .Ignore(t => t.Deleted)
                ;

            modelBuilder.Entity<Connector>()
                .Ignore(t => t.Constraints)
                .Ignore(t => t.Tags)
                .Ignore(t => t.RoleConstraints)
                .Ignore(t => t.Links)
                ;
            modelBuilder.Entity<Diagram>()
                .Ignore(t => t.DiagramLinks)
                .Ignore(t => t.Parts)
                ;
            modelBuilder.Entity<Element>()
                .Ignore(t => t.StartConnectors)
                .Ignore(t => t.EndConnectors)
                .Ignore(t => t.Attributes)
                .Ignore(t => t.Links)
                .Ignore(t => t.Files)
                .Ignore(t => t.Metrics)
                .Ignore(t => t.Problems)
                .Ignore(t => t.Properties)
                .Ignore(t => t.Requirements)
                .Ignore(t => t.Resources)
                .Ignore(t => t.Risks)
                .Ignore(t => t.Scenarios)
                .Ignore(t => t.Tests)
                .Ignore(t => t.Operations)
                .Ignore(t => t.Children)
                ;
            modelBuilder.Entity<ElementOperations>()
                .Ignore(t => t.Parameters)
                .Ignore(t => t.PostCondiitons)
                .Ignore(t => t.PreConditions)
                .Ignore(t => t.Tags)
                ;
            modelBuilder.Entity<Package>()
                .Ignore(t => t.Diagrams)
                .Ignore(t => t.Content)
                .Ignore(t => t.Children)
                ;
            //            modelBuilder.Entity<ElementTrx>().Ignore(t => t.owner);
        }
    }
}
