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

## Ancestor Graph

|From| Relation|To|
|-|-|-|
|Adam (Person) |has Father to| Jack (Person)|
|Liz (Person) |has Father to| Adam (Person)|
|Lucy (Person) |has Father to| John (Person)|
|Mark (Person) |has Father to| John (Person)|
|Rob (Person) |has Father to| Burt (Person)|
|Jack (Person) |has Child to| Adam (Person)|
|Adam (Person) |has Child to| Liz (Person)|
|John (Person) |has Child to| Lucy (Person)|
|John (Person) |has Child to| Mark (Person)|
|Burt (Person) |has Child to| Rob (Person)|
|Jane (Person) |has Child to| Burt (Person)|
|Eve (Person) |has Child to| Jack (Person)|
|Eve (Person) |has Child to| Jane (Person)|
|Mary (Person) |has Child to| Lucy (Person)|
|Mary (Person) |has Child to| Mark (Person)|
|Jane (Person) |has Child to| Mary (Person)|
|Burt (Person) |has Mother to| Jane (Person)|
|Jack (Person) |has Mother to| Eve (Person)|
|Jane (Person) |has Mother to| Eve (Person)|
|Lucy (Person) |has Mother to| Mary (Person)|
|Mark (Person) |has Mother to| Mary (Person)|
|Mary (Person) |has Mother to| Jane (Person)|

## Infered Relations

|From| Relation | To|
|-|-|-|
|Adam|Aunt|Jane|
|Adam|Child|Liz|
|Adam|Cousin|Mary|
|Adam|Cousin|Burt|
|Adam|Father|Jack|
|Adam|GrandMother|Eve|
|Adam|relation|Liz|
|Adam|relation|Rob|
|Adam|relation|Mark|
|Adam|relation|Jack|
|Adam|relation|John|
|Adam|relation|Lucy|
|Burt|Child|Rob|
|Burt|Cousin|Adam|
|Burt|GrandMother|Eve|
|Burt|Mother|Jane|
|Burt|Niece|Lucy|
|Burt|Sister|Mary|
|Burt|Uncle|Jack|
|Eve|Child|Jack|
|Eve|Child|Jane|
|Jack|Child|Adam|
|Jack|Graet-Nephew|Rob|
|Jack|Great-Niece|Lucy|
|Jack|Mother|Eve|
|Jack|Nephew|Burt|
|Jack|Niece|Mary|
|Jack|Sister|Jane|
|Jane|Brother|Jack|
|Jane|Child|Burt|
|Jane|Child|Mary|
|Jane|Great-Niece|Liz|
|Jane|Mother|Eve|
|Jane|Nephew|Adam|
|John|Child|Lucy|
|John|Child|Mark|
|John|Parents|Mary|
|Liz|Father|Adam|
|Liz|Grandfather|Jack|
|Liz|Great-Aunt|Jane|
|Liz|Great-GrandMother|Eve|
|Liz|relation|Mark|
|Liz|relation|Mary|
|Liz|relation|Adam|
|Liz|relation|Burt|
|Liz|relation|John|
|Liz|Second-Cousin|Rob|
|Liz|Second-Cousin|Lucy|
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
|Mark|Cousin|Rob|
|Mark|Father|John|
|Mark|GrandMother|Jane|
|Mark|Great-GrandMother|Eve|
|Mark|Great-Uncle|Jack|
|Mark|Mother|Mary|
|Mark|relation|Eve|
|Mark|relation|Liz|
|Mark|relation|Rob|
|Mark|relation|Mary|
|Mark|relation|Adam|
|Mark|relation|Burt|
|Mark|relation|Jack|
|Mark|relation|Jane|
|Mark|relation|John|
|Mark|Second-Cousin|Liz|
|Mark|Sister|Lucy|
|Mark|Uncle|Burt|
|Mary|Brother|Burt|
|Mary|Child|Lucy|
|Mary|Child|Mark|
|Mary|Cousin|Adam|
|Mary|GrandMother|Eve|
|Mary|Mother|Jane|
|Mary|Nephew|Rob|
|Mary|Parents|John|
|Mary|relation|Liz|
|Mary|relation|Jane|
|Mary|Uncle|Jack|
|Rob|Aunt|Mary|
|Rob|Cousin|Lucy|
|Rob|Father|Burt|
|Rob|GrandMother|Jane|
|Rob|Great-GrandMother|Eve|
|Rob|Great-Uncle|Jack|
|Rob|relation|Mark|
|Rob|relation|Adam|
|Rob|relation|Burt|
|Rob|relation|John|
|Rob|Second-Cousin|Liz|
