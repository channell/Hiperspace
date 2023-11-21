using Microsoft.EntityFrameworkCore;
using System.Runtime;

namespace Sparx.EA
{
    public partial class Context : DbContext
    {
        public virtual DbSet<Attribute> Attributes { get; set; }
        
        public virtual DbSet<AttributeConstraint> AttributeConstraints { get; set; }
        
        public virtual DbSet<AttributeTag> AttributeTags { get; set; }
        
        public virtual DbSet<Connector> Connectors { get; set; }
        
         public virtual DbSet<Diagram> Diagrams { get; set; }
        
        public virtual DbSet<DiagramLink> DiagramLinks { get; set; }
        
        public virtual DbSet<DiagramObject> DiagramObjects { get; set; }
        
        public virtual DbSet<ObjectConstraint> ObjectConstraints { get; set; }
        
        public virtual DbSet<ObjectEffort> ObjectEfforts { get; set; }
        
        public virtual DbSet<ElementFiles> ObjectFiles { get; set; }
        
        public virtual DbSet<ElementMetrics> ObjectMetrics { get; set; }
        
        public virtual DbSet<ElementProblems> ObjectProblems { get; set; }
        
        public virtual DbSet<ElementProperties> ObjectProperties { get; set; }
        
        public virtual DbSet<ElementRequirements> ObjectRequires { get; set; }
        
        public virtual DbSet<ElementResources> ObjectResource { get; set; }
        
        public virtual DbSet<ElementRisks> ObjectRisks { get; set; }
        
        public virtual DbSet<ElementScenarions> ObjectScenarios { get; set; }
        
        public virtual DbSet<ElementTests> ObjectTests { get; set; }
        
        public virtual DbSet<ElementTrx> ObjectTrxs { get; set; }
        
        public virtual DbSet<ElementOperations> Operations { get; set; }
        
        public virtual DbSet<ElementOperationsParameters> OperationParams { get; set; }
        
        public virtual DbSet<ElementOperationsPostCondiitons> OperationPostConditions { get; set; }
        
        public virtual DbSet<ElementOperationsPreConditions> OperationPreConditions { get; set; }
        
        public virtual DbSet<ElementOperationsTags> OperationTags { get; set; }
        
        public virtual DbSet<Package> Packages { get; set; }
        
        public virtual DbSet<ConnectorRoleConstraints> RoleConstraints { get; set; }

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

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Diagrams)
                .WithOne(e => e.DBElement)
                .HasForeignKey(e => e.ElementId);
/*
            modelBuilder.Entity<Package>()
                .HasMany<Element>(e => e.Content)
                .WithOne(e => e.Package)
                .HasForeignKey(e => e.PackageId);

            modelBuilder.Entity<Package>()
                .HasMany<Package>(e => e.Children)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Element>()
                .HasMany<Attribute>(e => e.Attributes)
                .WithRequired(e => e.Element)
                .HasForeignKey(e => e.ElementId);

            modelBuilder.Entity<Element>()
                .HasMany<Operation>(e => e.Operations)
                .WithRequired(e => e.Element)
                .HasForeignKey(e => e.ElementId);

            modelBuilder.Entity<Element>()
                .HasMany<Element>(e => e.Children)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Connector>()
                .HasMany<DiagramLink>(e => e.Links)
                .WithOptional(e => e.Connector)
                .HasForeignKey(e => e.ConnectorId);

            modelBuilder.Entity<Connector>()
                .HasMany<ConnectorTag>(e => e.Tags)
                .WithOptional(e => e.Connector)
                .HasForeignKey(e => e.ConnectorId);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Tags)
                .WithRequired(e => e.Operation)
                .HasForeignKey(e => e.OperationId)
                .WillCascadeOnDelete(true);
  
            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithOptional(e => e.Element)
                .HasForeignKey(e => e.ElementId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.Element)
                .HasForeignKey(e => e.ElementId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Connector>()
                .HasMany(e => e.RoleConstraints)
                .WithRequired(e => e.Connector)
                .HasForeignKey(e => e.ConnectorId)
                .WillCascadeOnDelete(true);
            //
            // Generated relationships
            //
            modelBuilder.Entity<Attribute>()
                .HasMany(e => e.Constraints)
                .WithRequired(e => e.Attribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.StartConnectors)
                .WithOptional(e => e.StartElement)
                .HasForeignKey(e => e.StartElementId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.EndConnectors)
                .WithOptional(e => e.EndElement)
                .HasForeignKey(e => e.EndElementId);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Constraint)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Efforts)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Files)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Metrics)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Problems)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Resource)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Risks)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Element>()
                .HasMany(e => e.Trxs)
                .WithRequired(e => e.Element)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ObjectProblem>()
                .Property(e => e.Problem)
                .IsUnicode(false);

            modelBuilder.Entity<ObjectProblem>()
                .Property(e => e.ProblemType)
                .IsUnicode(false);

            modelBuilder.Entity<ObjectResource>()
                .Property(e => e.Resource)
                .IsUnicode(false);

            modelBuilder.Entity<ObjectResource>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Params)
                .WithRequired(e => e.operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.PostConditions)
                .WithRequired(e => e.operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.PreConditions)
                .WithRequired(e => e.operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phase>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Phase>()
                .Property(e => e.PhaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Phase>()
                .Property(e => e.PhaseStyle)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.UserGroups)
                .WithRequired(e => e.secgroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Permissions)
                .WithMany(e => e.Groups)
                .Map(m => m.ToTable("t_secgrouppermission").MapLeftKey("GroupID").MapRightKey("PermissionID"));

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Permissions)
                .Map(m => m.ToTable("t_secuserpermission").MapLeftKey("PermissionID").MapRightKey("UserID"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.Groups)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserGroup>()
                .HasMany(e => e.Locks)
                .WithOptional(e => e.UserGroup)
                .HasForeignKey(e => new { e.UserID, e.GroupID });

            modelBuilder.Entity<StereoType>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<StereoType>()
                .Property(e => e.AppliesTo)
                .IsUnicode(false);

            modelBuilder.Entity<StereoType>()
                .Property(e => e.VisualType)
                .IsUnicode(false);
*/
        }
    }
}
