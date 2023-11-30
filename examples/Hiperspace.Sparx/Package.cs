using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparx.EA
{
    public partial class Package
    {
        [JsonIgnore]
        [Column("Parent_ID")]
        public int? ParentId
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
        public virtual Package? DBParent
        {
            get
            {
                return Parent?.Value;
            }
            set
            {
                Parent = new(new() { Id = value?.Id }, value);
            }
        }
        [JsonIgnore]
        public virtual ICollection<Package> DBChildren
        {
            get => Children;
            set => Children.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Diagram> DBDiagrams
        {
            get => Diagrams;
            set => Diagrams.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Element> DBContent
        {
            get => Content;
            set => Content.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<Package> DBPackage
        {
            get => Children;
            set => Children.UnionWith(value);
        }
    }
}
