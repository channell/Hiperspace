namespace Sparx.EA
{
    public partial class Connector
    {
        [JsonIgnore]
        [Key, Column("Connector_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConnectorId
        {
            get
            {
                if (Id.HasValue)
                    return Id.Value;
                return default;
            }
            set
            {
                Id = value;
            }
        }
        [JsonIgnore]
        [Column("Start_Object_ID")]
        public int? StartObjectId
        {
            get
            {
                if (StartElement.HasValue)
                    return StartElement.Value.Key.Id;
                return null;
            }
            set
            {
                StartElement = new(new() { Id = value });
            }
        }
        [JsonIgnore]
        public virtual Element? DBStartElement
        {
            get
            {
                if (StartElement.HasValue)
                    return StartElement.Value.Value;
                return null;
            }
            set
            {
                StartElement = new(new() { Id = value?.Id }, value);
            }
        }

        [JsonIgnore]
        [Column("End_Object_ID")]
        public int? EndObjectId
        {
            get
            {
                if (EndElement.HasValue)
                    return EndElement.Value.Key.Id;
                return null;
            }
            set
            {
                EndElement = new(new() { Id = value });
            }
        }
        [JsonIgnore]
        public virtual Element? DBEndElement
        {
            get
            {
                if (EndElement.HasValue)
                    return EndElement.Value.Value;
                return null;
            }
            set
            {
                EndElement = new(new() { Id = value?.Id }, value);
            }
        }
        [JsonIgnore]
        public virtual ICollection<ConnectorConstraints> DBConstraints
        {
            get => Constraints;
            set => Constraints.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ConnectorTags> DBTags
        {
            get => Tags;
            set => Tags.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ConnectorRoleConstraints> DBRoleConstraints
        {
            get => RoleConstraints;
            set => RoleConstraints.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<DiagramLink> DBLinks
        {
            get => Links;
            set => Links.UnionWith(value);
        }
    }
}
