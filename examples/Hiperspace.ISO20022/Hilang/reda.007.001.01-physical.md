# reda.007.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda007001.Document {
        # Uri  : String
        + SctyMntncReq () : ISO20022.Reda007001.SecurityMaintenanceRequestV01
        + Validation () = validation(validElement(SctyMntncReq))
    }
    class ISO20022.Reda007001.SecurityMaintenanceRequestV01 {
        # owner  : ISO20022.Reda007001.Document
        + SplmtryData  : List~ISO20022.Reda007001.SupplementaryData1~
        + FinInstrmId  : ISO20022.Reda007001.SecurityIdentification39
        + UpdRsn  : ISO20022.Reda007001.SecuritiesUpdateReason1Choice
        + UpdTp  : ISO20022.Reda007001.UpdateType36Choice
        + MsgHdr  : ISO20022.Reda007001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(UpdRsn),validElement(UpdTp),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyMntncReq|ISO20022.Reda007001.SecurityMaintenanceRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyMntncReq))|

---

## AspectImpl ISO20022.Reda007001.SecurityMaintenanceRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda007001.Document||||
|+|SplmtryData|List<ISO20022.Reda007001.SupplementaryData1>||XmlElement()||
|+|FinInstrmId|ISO20022.Reda007001.SecurityIdentification39||XmlElement()||
|+|UpdRsn|ISO20022.Reda007001.SecuritiesUpdateReason1Choice||XmlElement()||
|+|UpdTp|ISO20022.Reda007001.UpdateType36Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda007001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(UpdRsn),validElement(UpdTp),validElement(MsgHdr))|

