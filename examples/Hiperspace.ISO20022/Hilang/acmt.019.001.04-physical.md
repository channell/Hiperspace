# acmt.019.001.04-physical
```mermaid
classDiagram
    class ISO20022.Acmt019001.Document {
        # Uri  : String
        + AcctClsgReq () : ISO20022.Acmt019001.AccountClosingRequestV04
        + Validation () = validation(validElement(AcctClsgReq))
    }
    class ISO20022.Acmt019001.AccountClosingRequestV04 {
        # owner  : ISO20022.Acmt019001.Document
        + SplmtryData  : List~ISO20022.Acmt019001.SupplementaryData1~
        + DgtlSgntr  : List~ISO20022.Acmt019001.PartyAndSignature4~
        + TrfAcctSvcrId  : ISO20022.Acmt019001.BranchAndFinancialInstitutionIdentification8
        + BalTrfAcct  : ISO20022.Acmt019001.AccountForAction1
        + CtrctDts  : ISO20022.Acmt019001.AccountContract4
        + OrgId  : ISO20022.Acmt019001.Organisation44
        + AcctSvcrId  : ISO20022.Acmt019001.BranchAndFinancialInstitutionIdentification8
        + AcctId  : ISO20022.Acmt019001.AccountForAction2
        + Fr  : ISO20022.Acmt019001.OrganisationIdentification39
        + Refs  : ISO20022.Acmt019001.References4
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(TrfAcctSvcrId),validElement(BalTrfAcct),validElement(CtrctDts),validElement(OrgId),validElement(AcctSvcrId),validElement(AcctId),validElement(Fr),validElement(Refs))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctClsgReq|ISO20022.Acmt019001.AccountClosingRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctClsgReq))|

---

## AspectImpl ISO20022.Acmt019001.AccountClosingRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Acmt019001.Document||||
|+|SplmtryData|List<ISO20022.Acmt019001.SupplementaryData1>||XmlElement()||
|+|DgtlSgntr|List<ISO20022.Acmt019001.PartyAndSignature4>||XmlElement()||
|+|TrfAcctSvcrId|ISO20022.Acmt019001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|BalTrfAcct|ISO20022.Acmt019001.AccountForAction1||XmlElement()||
|+|CtrctDts|ISO20022.Acmt019001.AccountContract4||XmlElement()||
|+|OrgId|ISO20022.Acmt019001.Organisation44||XmlElement()||
|+|AcctSvcrId|ISO20022.Acmt019001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|AcctId|ISO20022.Acmt019001.AccountForAction2||XmlElement()||
|+|Fr|ISO20022.Acmt019001.OrganisationIdentification39||XmlElement()||
|+|Refs|ISO20022.Acmt019001.References4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(TrfAcctSvcrId),validElement(BalTrfAcct),validElement(CtrctDts),validElement(OrgId),validElement(AcctSvcrId),validElement(AcctId),validElement(Fr),validElement(Refs))|

