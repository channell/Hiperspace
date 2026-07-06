# tsmt.005.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt005001.Document {
        # Uri  : String
        + AmdmntAccptnc () : ISO20022.Tsmt005001.AmendmentAcceptanceV02
        + Validation () = validation(validElement(AmdmntAccptnc))
    }
    class ISO20022.Tsmt005001.AmendmentAcceptanceV02 {
        # owner  : ISO20022.Tsmt005001.Document
        + AccptdAmdmntNb  : ISO20022.Tsmt005001.Count1
        + DltaRptRef  : ISO20022.Tsmt005001.MessageIdentification1
        + SubmitrTxRef  : ISO20022.Tsmt005001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt005001.SimpleIdentificationInformation
        + AccptncId  : ISO20022.Tsmt005001.MessageIdentification1
        + Validation () = validation(validElement(AccptdAmdmntNb),validElement(DltaRptRef),validElement(SubmitrTxRef),validElement(TxId),validElement(AccptncId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AmdmntAccptnc|ISO20022.Tsmt005001.AmendmentAcceptanceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmdmntAccptnc))|

---

## AspectImpl ISO20022.Tsmt005001.AmendmentAcceptanceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt005001.Document||||
|+|AccptdAmdmntNb|ISO20022.Tsmt005001.Count1||XmlElement()||
|+|DltaRptRef|ISO20022.Tsmt005001.MessageIdentification1||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt005001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt005001.SimpleIdentificationInformation||XmlElement()||
|+|AccptncId|ISO20022.Tsmt005001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptdAmdmntNb),validElement(DltaRptRef),validElement(SubmitrTxRef),validElement(TxId),validElement(AccptncId))|

