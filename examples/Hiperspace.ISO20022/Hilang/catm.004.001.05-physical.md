# catm.004.001.05-physical
```mermaid
classDiagram
    class ISO20022.Catm004001.Document {
        # Uri  : String
        + TermnlMgmtRjctn () : ISO20022.Catm004001.TerminalManagementRejectionV05
        + Validation () = validation(validElement(TermnlMgmtRjctn))
    }
    class ISO20022.Catm004001.TerminalManagementRejectionV05 {
        # owner  : ISO20022.Catm004001.Document
        + Rjct  : ISO20022.Catm004001.AcceptorRejection3
        + Hdr  : ISO20022.Catm004001.TMSHeader1
        + Validation () = validation(validElement(Rjct),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TermnlMgmtRjctn|ISO20022.Catm004001.TerminalManagementRejectionV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TermnlMgmtRjctn))|

---

## AspectImpl ISO20022.Catm004001.TerminalManagementRejectionV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm004001.Document||||
|+|Rjct|ISO20022.Catm004001.AcceptorRejection3||XmlElement()||
|+|Hdr|ISO20022.Catm004001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rjct),validElement(Hdr))|

