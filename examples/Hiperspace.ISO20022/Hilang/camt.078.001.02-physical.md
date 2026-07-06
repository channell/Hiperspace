# camt.078.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt078001.Document {
        # Uri  : String
        + IntraBalMvmntQry () : ISO20022.Camt078001.IntraBalanceMovementQueryV02
        + Validation () = validation(validElement(IntraBalMvmntQry))
    }
    class ISO20022.Camt078001.IntraBalanceMovementQueryV02 {
        # owner  : ISO20022.Camt078001.Document
        + SplmtryData  : List~ISO20022.Camt078001.SupplementaryData1~
        + QryDef  : ISO20022.Camt078001.IntraBalanceQueryDefinition11
        + Id  : ISO20022.Camt078001.DocumentIdentification51
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(QryDef),validElement(Id))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt078001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|IntraBalMvmntQry|ISO20022.Camt078001.IntraBalanceMovementQueryV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraBalMvmntQry))|

---

## AspectImpl ISO20022.Camt078001.IntraBalanceMovementQueryV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt078001.Document||||
|+|SplmtryData|List<ISO20022.Camt078001.SupplementaryData1>||XmlElement()||
|+|QryDef|ISO20022.Camt078001.IntraBalanceQueryDefinition11||XmlElement()||
|+|Id|ISO20022.Camt078001.DocumentIdentification51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(QryDef),validElement(Id))|

