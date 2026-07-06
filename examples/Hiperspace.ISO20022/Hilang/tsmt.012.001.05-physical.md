# tsmt.012.001.05-physical
```mermaid
classDiagram
    class ISO20022.Tsmt012001.Document {
        # Uri  : String
        + BaselnReSubmissn () : ISO20022.Tsmt012001.BaselineReSubmissionV05
        + Validation () = validation(validElement(BaselnReSubmissn))
    }
    class ISO20022.Tsmt012001.BaselineReSubmissionV05 {
        # owner  : ISO20022.Tsmt012001.Document
        + OthrBkCtctPrsn  : List~ISO20022.Tsmt012001.ContactIdentification3~
        + BkCtctPrsn  : ISO20022.Tsmt012001.BankContactPerson1Choice
        + SellrCtctPrsn  : List~ISO20022.Tsmt012001.ContactIdentification1~
        + BuyrCtctPrsn  : List~ISO20022.Tsmt012001.ContactIdentification1~
        + Baseln  : ISO20022.Tsmt012001.Baseline5
        + SubmitrTxRef  : ISO20022.Tsmt012001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt012001.SimpleIdentificationInformation
        + SubmissnId  : ISO20022.Tsmt012001.MessageIdentification1
        + Validation () = validation(validList("""OthrBkCtctPrsn""",OthrBkCtctPrsn),validElement(OthrBkCtctPrsn),validElement(BkCtctPrsn),validList("""SellrCtctPrsn""",SellrCtctPrsn),validElement(SellrCtctPrsn),validList("""BuyrCtctPrsn""",BuyrCtctPrsn),validElement(BuyrCtctPrsn),validElement(Baseln),validElement(SubmitrTxRef),validElement(TxId),validElement(SubmissnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BaselnReSubmissn|ISO20022.Tsmt012001.BaselineReSubmissionV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BaselnReSubmissn))|

---

## AspectImpl ISO20022.Tsmt012001.BaselineReSubmissionV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt012001.Document||||
|+|OthrBkCtctPrsn|List<ISO20022.Tsmt012001.ContactIdentification3>||XmlElement()||
|+|BkCtctPrsn|ISO20022.Tsmt012001.BankContactPerson1Choice||XmlElement()||
|+|SellrCtctPrsn|List<ISO20022.Tsmt012001.ContactIdentification1>||XmlElement()||
|+|BuyrCtctPrsn|List<ISO20022.Tsmt012001.ContactIdentification1>||XmlElement()||
|+|Baseln|ISO20022.Tsmt012001.Baseline5||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt012001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt012001.SimpleIdentificationInformation||XmlElement()||
|+|SubmissnId|ISO20022.Tsmt012001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrBkCtctPrsn""",OthrBkCtctPrsn),validElement(OthrBkCtctPrsn),validElement(BkCtctPrsn),validList("""SellrCtctPrsn""",SellrCtctPrsn),validElement(SellrCtctPrsn),validList("""BuyrCtctPrsn""",BuyrCtctPrsn),validElement(BuyrCtctPrsn),validElement(Baseln),validElement(SubmitrTxRef),validElement(TxId),validElement(SubmissnId))|

