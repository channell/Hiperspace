using Social.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public class Questions (SocialMediaSpace Space)
    {

        public IEnumerable<Person> Q1 (Person person)
        {
            if (person.Location == null) return Enumerable.Empty<Person>();
            return 
                (from friend in person.Friends
                 where friend.Person!.Location != null
                    && friend.Person.FirstName == person.FirstName
                    && friend.Distance < 3.0
                 orderby friend.Distance, friend.Person!.LastName
                 select friend.Person
                ).Take(20);
        }

        public IEnumerable<Post> Q2 (Person person, DateTime since)
        {
            return
                (from friend in person.Friends
                 join post in Space.Posts on friend.Person equals post.Creator
                 where post.CreatedDate >= since
                 orderby post.CreatedDate descending
                 select post
                ).Take(20);
        }
    }
}
