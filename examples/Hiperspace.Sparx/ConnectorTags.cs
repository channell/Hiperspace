namespace Sparx.EA
{
    public partial class ConnectorTags
    {
        [JsonIgnore]
        public virtual Connector? DBConnector
        {
            get
            {
                if (owner.HasValue)
                    return owner.Value.Value;
                return null;
            }
            set
            {
                if (value != null)
                    owner = new(value._key, value);
            }
        }

    }
}
