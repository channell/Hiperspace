using Hiperspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Social.Media;

namespace SocialMedia
{
    public partial class SocialMediaSpace
    {
        public override Horizon[]? Horizon =>
            new Horizon[]
            {
                new Horizon<Friend>((element, _, _, _) =>  element.owner != null && element.Person != null, "must have owner and person"),
                new Horizon<Person>((element, _, _, _) =>  element.FirstName != null  && element.LastName != null, "must have owner and person")
            };
    }
}
