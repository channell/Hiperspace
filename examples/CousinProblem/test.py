 
from pythonnet import load
load ("coreclr")
import os, sys
sys.path.append("/dev/source/repos/HiperspaceHub/examples/CousinProblem/bin/Debug/net8.0")

import clr
clr.AddReference("Hiperspace")
clr.AddReference("Hiperspace.Heap")
clr.AddReference("Hiperspace.SQL")
clr.AddReference("CousinProblem")

from Hiperspace.Heap import HeapSpace
from Cousins import CousinsSpace
from Cousins import Person
from Cousins import Gender
from Hiperspace.SQL import Engine

from System.Collections.Generic import Dictionary
from System import String
from System import Object
driver = HeapSpace()
space = CousinsSpace (driver)
sql = Engine (space)

query = """
select * from SCHEMA_TABLES;
select * from SCHEMA_COLUMNS;
select * from SCHEMA_PROPERTIES;
"""

pams = { "name" : "Lucy" }
pams = Dictionary[String, Object]()
pams['name'] = 'Lucy'

result = sql.Execute (query, pams)
for query in result:
    print ()
    for column in query:
        str = column.Key + ' : '
        for value in column.Value:
            if value is None :
                str = str + 'na, '
            else :
                str = str + value + ", "
        print (str)


 person helper
def person (name, gender, mother, father) :
    p = Person()
    p.Name = name
    if gender is not None : p.Gender = gender
    if mother is not None : p.Mother = mother
    if father is not None : p.Father = father
    return p

 person reference helper
def name (name) :
    p = Person()
    p.Name = name
    return p

 enumeration helper 
def each (list) :
    for i in list.GetEnumerator() :
        yield i


 sample data
tree =  [ person ('Eve',   Gender.Female, None, None),
          person ('Jane',  Gender.Female, name('Eve'), None),
          person ("Jack",  Gender.Male, name('Eve'), None),
          person ("Adam",  Gender.Male, None, name("Jack")),
          person ("Liz",   Gender.Female, None, name("Adam")),
          person ("Mary",  Gender.Female, name("Jane"), None),
          person ("Burt",  Gender.Male, name("Jane"), None),
          person ("Rob",   Gender.Male, None, name("Burt")),
          person ("John",  Gender.Male, None, None),
          person ("Lucy",  Gender.Female, name('Mary'), name("John")),
          person ("Mark",  Gender.Male,  name('Mary'), name("John"))]

for i in tree : 
    space.Persons.Bind (i, False)

print ("\n Nodes \n")
for n in each(space.Nodes) :
    print ("{skey} {name} ({typename})".format(skey = n.SKey, name = n.Name, typename = n.TypeName ))

print ("\n Edges \n")
for e in each(space.Edges) :
    if not (e.From == None or e.To == None) :
        print ("{fromS} -- {typename} --> {toS}".format(fromS = e.From.Name, toS = e.To.Name, typename = e.TypeName ))

for p in each(space.Persons) :
    for r in p.Relatives :
        if (r.From != None and r.To != None and r.TypeName != "relation") :
            space.Paths.Add (r)

print ("\nImplied relations\n")
for e in each(space.Edges) :
    if not (e.From == None or e.To == None) :
        print ("{fromS} -- {typename} --> {toS}".format(fromS = e.From.Name, toS = e.To.Name, typename = e.TypeName ))

print ("\nJust Lucy\n")
for e in each(space.Edges) :
    if not (e.From == None or e.To == None) and e.From.Name == 'Lucy' :
        print ("{fromS} -- {typename} --> {toS}".format(fromS = e.From.Name, toS = e.To.Name, typename = e.TypeName ))
