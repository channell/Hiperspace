# colr.001.001.02-physical
```mermaid
classDiagram
    class ISO20022.Colr001001.Document {
        # Uri  : String
        + CollValQry () : ISO20022.Colr001001.CollateralValueQueryV02
        + Validation () = validation(validElement(CollValQry))
    }
    class ISO20022.Colr001001.CollateralValueQueryV02 {
        # owner  : ISO20022.Colr001001.Document
        + SplmtryData  : List~ISO20022.Colr001001.SupplementaryData1~
        + CollValQryDef  : ISO20022.Colr001001.CollateralValueCriteriaDefinition4Choice
        + MsgHdr  : ISO20022.Colr001001.MessageHeader3
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollValQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollValQry|ISO20022.Colr001001.CollateralValueQueryV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollValQry))|

---

## AspectImpl ISO20022.Colr001001.CollateralValueQueryV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr001001.Document||||
|+|SplmtryData|List<ISO20022.Colr001001.SupplementaryData1>||XmlElement()||
|+|CollValQryDef|ISO20022.Colr001001.CollateralValueCriteriaDefinition4Choice||XmlElement()||
|+|MsgHdr|ISO20022.Colr001001.MessageHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollValQryDef),validElement(MsgHdr))|

