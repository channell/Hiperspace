# Cousins Problem

Cousin Problem that highlights the different perspectives of ancestor relationships 
seen from the perspective of parents, and individual with their {siblings, 
cousins, uncles, aunts, grandparents}:

* A genealogical perspective is concerned with the mothers, fathers and children
* A person perspective views relations as a star, with the individual at the center, and cousins around them

There's an ontological choice between modeling modelling all relations between people as `Node` and `Edge`
or add `transitive edge` that are impled by `path` following a number of edges. 
The decision is often made based for performance reasons, since recursive queries in graph databases 
become very complex when the edge type changes when traversing the graph

![Model](cousins.svg "Title")

This simple diagram shows parental relations and *some* of the implied relationships.
Only a subset of implied relations is shown,including them all would resemble a 
spider-web rather than a reaable graph.

## Example using hiperspace

Hiperspace makes it easier to resolve the conflict of ancestoral or cousins view because

* Node traversal in Hiperspace is very quick and performed in parallel for views (like Node)
* HiLang models allow extensions to be added: [Helper](./Helper.cs) add graph search

### Model

The ancestoral model can be expressed in HiLang as an Entity `Person` witha `Father` and `Mother` reference.
The person provides the `Node` view and four `Edge` views for graph traversal.  For this sample the key is just `Name`.

```
entity Cousins.Person                                                       /* define Persion                       */
    = Node (),                                                              /* Person has a Node View               */
      Edge  (From = this,   To = Mother, Name = Name, TypeName = "Mother"), /* Person provides Edge to Mother       */
      Edge2 (From = this,   To = Father, Name = Name, TypeName = "Father"), /* Person provides Edge to Father       */
      Edge3 (From = Father, To = this,   Name = Name, TypeName = "Child"),  /* Person provides Edge from Father     */
      Edge4 (From = Mother, To = this,   Name = Name, TypeName = "Child")   /* Person provides Edge from Mother     */
(                                                                           /* Keys                                 */
    Name        : String                                                    /* Person has Name as key               */
)
{                                                                           /* Values                               */
    Gender      : Cousins.Gender,                                           /* Person has Gender {}Female, Male     */

    Mother      : Cousins.Person,                                           /* Person has reference to Mother       */
    Father      : Cousins.Person                                            /* Person has reference to Father       */
}
[                                                                           /* Extent properties not stored         */
    TypeName    = "Person",                                                 /* TypeName for Node View               */

    FatherChild : Cousins.Person (Father = this),                           /* navigation to children               */
    MotherChild : Cousins.Person (Mother = this),                           /* navigation to children               */
    @Once
    Relatives   = relation (this)                                           /* function to navigate to all relatives*/
];
```

The graph above is loaded inot Hiperspace in the [Test cases](./Test.cs). In this example there are no Horizon constraints, 
parents do not need to be loaded first `Mother = new Person {Name "Eve"}` provides the reference to a parent that will be lazy 
loaded when referenced
```
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
```

**11** row of data becomes **22** Edges when viewed as a graph. The code `Relatives = relation (this)` uses a native C# function to 
provide the **106** infered relations that would be unmaintainable if stored in a graph database.

The advantgage of the Hiperspace graph view are

* Only the source data is stored and changed, with Edges projected as needed
* Edge projections are loaded in parallel and cached in the Session 
* Transative relations are projected as needd

|Person|Father|Mother|
|-|-|-|
|Lucy|John|Mary|

is projected as graph edges

|From|Edge|To|
|-|-|-|
|Lucy|Father|John|
|Lucy|Mother|Mary|
|John|Child|Lucy|
|Mary|Child|Lucy|

```mermaid
flowchart TD 
    UgYKBEFkYW0("Adam (Person)")
    UgYKBEJ1cnQ("Burt (Person)")
    UgUKA0V2ZQ("Eve (Person)")
    UgYKBEphY2s("Jack (Person)")
    UgYKBEphbmU("Jane (Person)")
    UgYKBEpvaG4("John (Person)")
    UgUKA0xpeg("Liz (Person)")
    UgYKBEx1Y3k("Lucy (Person)")
    UgYKBE1hcms("Mark (Person)")
    UgYKBE1hcnk("Mary (Person)")
    UgUKA1JvYg("Rob (Person)")

    UgYKBEFkYW0 -- Father --> UgYKBEphY2s
    UgUKA0xpeg -- Father --> UgYKBEFkYW0
    UgYKBEx1Y3k -- Father --> UgYKBEpvaG4
    UgYKBE1hcms -- Father --> UgYKBEpvaG4
    UgUKA1JvYg -- Father --> UgYKBEJ1cnQ
    UgYKBEphY2s -- Child --> UgYKBEFkYW0
    UgYKBEFkYW0 -- Child --> UgUKA0xpeg
    UgYKBEpvaG4 -- Child --> UgYKBEx1Y3k
    UgYKBEpvaG4 -- Child --> UgYKBE1hcms
    UgYKBEJ1cnQ -- Child --> UgUKA1JvYg
    UgYKBEphbmU -- Child --> UgYKBEJ1cnQ
    UgUKA0V2ZQ -- Child --> UgYKBEphY2s
    UgUKA0V2ZQ -- Child --> UgYKBEphbmU
    UgYKBE1hcnk -- Child --> UgYKBEx1Y3k
    UgYKBE1hcnk -- Child --> UgYKBE1hcms
    UgYKBEphbmU -- Child --> UgYKBE1hcnk
    UgYKBEJ1cnQ -- Mother --> UgYKBEphbmU
    UgYKBEphY2s -- Mother --> UgUKA0V2ZQ
    UgYKBEphbmU -- Mother --> UgUKA0V2ZQ
    UgYKBEx1Y3k -- Mother --> UgYKBE1hcnk
    UgYKBE1hcms -- Mother --> UgYKBE1hcnk
    UgYKBE1hcnk -- Mother --> UgYKBEphbmU
```
and transitively infered to 

|From|Edge|To|
|-|-|-|
|Lucy|Brother|Mark|
|Lucy|Cousin|Rob|
|Lucy|Father|John|
|Lucy|GrandMother|Jane|
|Lucy|Great-GrandMother|Eve|
|Lucy|Great-Uncle|Jack|
|Lucy|Mother|Mary|
|Lucy|relation|Eve|
|Lucy|relation|Liz|
|Lucy|relation|Rob|
|Lucy|relation|Mary|
|Lucy|relation|Adam|
|Lucy|relation|Burt|
|Lucy|relation|Jack|
|Lucy|relation|Jane|
|Lucy|relation|John|
|Lucy|Second-Cousin|Liz|
|Lucy|Uncle|Burt|
|Adam|relation|Lucy|
|Burt|Niece|Lucy|
|Jack|Great-Niece|Lucy|
|John|Child|Lucy|
|Liz|Second-Cousin|Lucy|
|Mark|Sister|Lucy|
|Mary|Child|Lucy|
|Rob|Cousin|Lucy|

```mermaid
flowchart TD 
    UgYKBEFkYW0("Adam (Person)")
    UgYKBEJ1cnQ("Burt (Person)")
    UgUKA0V2ZQ("Eve (Person)")
    UgYKBEphY2s("Jack (Person)")
    UgYKBEphbmU("Jane (Person)")
    UgYKBEpvaG4("John (Person)")
    UgUKA0xpeg("Liz (Person)")
    UgYKBEx1Y3k("Lucy (Person)")
    UgYKBE1hcms("Mark (Person)")
    UgYKBE1hcnk("Mary (Person)")
    UgUKA1JvYg("Rob (Person)")

    UgYKBEFkYW0 -- Father --> UgYKBEphY2s
    UgUKA0xpeg -- Father --> UgYKBEFkYW0
    UgYKBEx1Y3k -- Father --> UgYKBEpvaG4
    UgYKBE1hcms -- Father --> UgYKBEpvaG4
    UgUKA1JvYg -- Father --> UgYKBEJ1cnQ
    UgYKBEphY2s -- Child --> UgYKBEFkYW0
    UgYKBEFkYW0 -- Child --> UgUKA0xpeg
    UgYKBEpvaG4 -- Child --> UgYKBEx1Y3k
    UgYKBEpvaG4 -- Child --> UgYKBE1hcms
    UgYKBEJ1cnQ -- Child --> UgUKA1JvYg
    UgYKBEphbmU -- Child --> UgYKBEJ1cnQ
    UgUKA0V2ZQ -- Child --> UgYKBEphY2s
    UgUKA0V2ZQ -- Child --> UgYKBEphbmU
    UgYKBE1hcnk -- Child --> UgYKBEx1Y3k
    UgYKBE1hcnk -- Child --> UgYKBE1hcms
    UgYKBEphbmU -- Child --> UgYKBE1hcnk
    UgYKBEJ1cnQ -- Mother --> UgYKBEphbmU
    UgYKBEphY2s -- Mother --> UgUKA0V2ZQ
    UgYKBEphbmU -- Mother --> UgUKA0V2ZQ
    UgYKBEx1Y3k -- Mother --> UgYKBE1hcnk
    UgYKBE1hcms -- Mother --> UgYKBE1hcnk
    UgYKBE1hcnk -- Mother --> UgYKBEphbmU
    UgUKA0xpeg .- Great-GrandMother .-> UgUKA0V2ZQ
    UgUKA0xpeg .- Second-Cousin .-> UgUKA1JvYg
    UgUKA0xpeg .- Grandfather .-> UgYKBEphY2s
    UgUKA0xpeg .- Great-Aunt .-> UgYKBEphbmU
    UgUKA0xpeg .- Second-Cousin .-> UgYKBEx1Y3k
    UgUKA1JvYg .- Great-GrandMother .-> UgUKA0V2ZQ
    UgUKA1JvYg .- Second-Cousin .-> UgUKA0xpeg
    UgUKA1JvYg .- Aunt .-> UgYKBE1hcnk
    UgUKA1JvYg .- Great-Uncle .-> UgYKBEphY2s
    UgUKA1JvYg .- GrandMother .-> UgYKBEphbmU
    UgUKA1JvYg .- Cousin .-> UgYKBEx1Y3k
    UgYKBE1hcms .- Great-GrandMother .-> UgUKA0V2ZQ
    UgYKBE1hcms .- Second-Cousin .-> UgUKA0xpeg
    UgYKBE1hcms .- Cousin .-> UgUKA1JvYg
    UgYKBE1hcms .- Uncle .-> UgYKBEJ1cnQ
    UgYKBE1hcms .- Great-Uncle .-> UgYKBEphY2s
    UgYKBE1hcms .- GrandMother .-> UgYKBEphbmU
    UgYKBE1hcms .- Sister .-> UgYKBEx1Y3k
    UgYKBE1hcnk .- GrandMother .-> UgUKA0V2ZQ
    UgYKBE1hcnk .- Nephew .-> UgUKA1JvYg
    UgYKBE1hcnk .- Cousin .-> UgYKBEFkYW0
    UgYKBE1hcnk .- Brother .-> UgYKBEJ1cnQ
    UgYKBE1hcnk .- Uncle .-> UgYKBEphY2s
    UgYKBE1hcnk .- Parents .-> UgYKBEpvaG4
    UgYKBEFkYW0 .- GrandMother .-> UgUKA0V2ZQ
    UgYKBEFkYW0 .- Cousin .-> UgYKBE1hcnk
    UgYKBEFkYW0 .- Cousin .-> UgYKBEJ1cnQ
    UgYKBEFkYW0 .- Aunt .-> UgYKBEphbmU
    UgYKBEJ1cnQ .- GrandMother .-> UgUKA0V2ZQ
    UgYKBEJ1cnQ .- Sister .-> UgYKBE1hcnk
    UgYKBEJ1cnQ .- Cousin .-> UgYKBEFkYW0
    UgYKBEJ1cnQ .- Uncle .-> UgYKBEphY2s
    UgYKBEJ1cnQ .- Niece .-> UgYKBEx1Y3k
    UgYKBEphY2s .- Great-Nephew .-> UgUKA1JvYg
    UgYKBEphY2s .- Niece .-> UgYKBE1hcnk
    UgYKBEphY2s .- Nephew .-> UgYKBEJ1cnQ
    UgYKBEphY2s .- Sister .-> UgYKBEphbmU
    UgYKBEphY2s .- Great-Niece .-> UgYKBEx1Y3k
    UgYKBEphbmU .- Great-Niece .-> UgUKA0xpeg
    UgYKBEphbmU .- Nephew .-> UgYKBEFkYW0
    UgYKBEphbmU .- Brother .-> UgYKBEphY2s
    UgYKBEpvaG4 .- Parents .-> UgYKBE1hcnk
    UgYKBEx1Y3k .- Great-GrandMother .-> UgUKA0V2ZQ
    UgYKBEx1Y3k .- Second-Cousin .-> UgUKA0xpeg
    UgYKBEx1Y3k .- Cousin .-> UgUKA1JvYg
    UgYKBEx1Y3k .- Brother .-> UgYKBE1hcms
    UgYKBEx1Y3k .- Uncle .-> UgYKBEJ1cnQ
    UgYKBEx1Y3k .- Great-Uncle .-> UgYKBEphY2s
    UgYKBEx1Y3k .- GrandMother .-> UgYKBEphbmU
```

