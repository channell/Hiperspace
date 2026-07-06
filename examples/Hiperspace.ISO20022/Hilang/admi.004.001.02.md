# admi.004.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Admi004001.Event2 {
        + EvtTm  : DateTime
        + EvtDesc  : String
        + EvtParam  : global::System.Collections.Generic.List~String~
        + EvtCd  : String
    }
    class ISO20022.Admi004001.SystemEventNotificationV02 {
        + EvtInf  : ISO20022.Admi004001.Event2
    }
    ISO20022.Admi004001.SystemEventNotificationV02 *-- ISO20022.Admi004001.Event2
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Hiperspace.Edge
        + Tos (To = this) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Type ISO20022.Admi004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SysEvtNtfctn|ISO20022.Admi004001.SystemEventNotificationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SysEvtNtfctn))|

---

## Value ISO20022.Admi004001.Event2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtTm|DateTime||XmlElement()||
|+|EvtDesc|String||XmlElement()||
|+|EvtParam|global::System.Collections.Generic.List<String>||XmlElement()||
|+|EvtCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""EvtCd""",EvtCd,"""[a-zA-Z0-9]{1,4}"""))|

---

## Aspect ISO20022.Admi004001.SystemEventNotificationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtInf|ISO20022.Admi004001.Event2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtInf))|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

