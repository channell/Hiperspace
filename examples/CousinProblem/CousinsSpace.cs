﻿using FluentAssertions.Execution;
using Hiperspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cousins;

public partial class CousinsSpace
{
    public CousinsSpace(string Role, HiperSpace space, DateTime? AsAt = null, DateTime? DeltaFrom = null) : this(space, null, AsAt, DeltaFrom)
    {
        // bootstrap
        var sample = Persons.ToArray().FirstOrDefault();
        if (sample == null)
        {
            var tree = new List<Person>
            {
                new Person {Name = "Eve", Gender = Gender.Female },
                new Person {Name = "Jane", Gender = Gender.Female, Mother = new Person {Name = "Eve" }},
                new Person {Name = "Jack", Gender = Gender.Male, Mother = new Person {Name = "Eve" }},
                new Person {Name = "Adam", Gender = Gender.Male, Father = new Person {Name = "Jack" }},
                new Person {Name = "Liz", Gender = Gender.Female, Father = new Person {Name = "Adam" }},
                new Person {Name = "Mary", Gender = Gender.Female, Mother = new Person {Name = "Jane" }},
                new Person {Name = "Burt", Gender = Gender.Male, Mother= new Person {Name = "Jane" }},
                new Person {Name = "Rob", Gender = Gender.Male, Father = new Person {Name = "Burt" }},
                new Person {Name = "John", Gender = Gender.Male},
                new Person {Name = "Lucy", Gender = Gender.Female, Father = new Person {Name = "John" }, Mother = new Person {Name = "Mary" } },
                new Person {Name = "Mark", Gender = Gender.Male, Father = new Person {Name = "John" }, Mother = new Person {Name = "Mary"} },
            };
            tree.ForEach(p => Persons.Bind(p, false));
        }
    }
}