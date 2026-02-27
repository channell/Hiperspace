# readme
```mermaid
classDiagram
    class Book {
        # Id  : Int32
        + Name  : String
        + Balance  : Double
    }
    Book --|> Hierarchy~Book~
```

---

## Type Hierarchy<TParent>


||Name|Type|*|@|=|
|-|-|-|-|-|
|+|Parent|TParent||||
||Children|TParent|||Parent = this|

---

## Entity Book


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Int32||||
|+|Name|String||||
|+|Balance|Double||||

