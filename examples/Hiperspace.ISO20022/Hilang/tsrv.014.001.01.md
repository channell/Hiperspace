# tsrv.014.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsrv014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsrv014001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Tsrv014001.BankInstructions1 {
        + LastDtForRspn  : DateTime
        + Txt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Tsrv014001.ContactDetails2 {
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsrv014001.Contacts3 {
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsrv014001.DateAndPlaceOfBirth {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Tsrv014001.Demand2 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Amt  : ISO20022.Tsrv014001.ActiveCurrencyAndAmount
        + SubmissnDtTm  : DateTime
        + Id  : String
    }
    ISO20022.Tsrv014001.Demand2 *-- ISO20022.Tsrv014001.ActiveCurrencyAndAmount
    class ISO20022.Tsrv014001.Document9 {
        + DgtlSgntr  : ISO20022.Tsrv014001.PartyAndSignature2
        + Nclsr  : String
        + Frmt  : ISO20022.Tsrv014001.DocumentFormat1Choice
        + Id  : String
        + Tp  : ISO20022.Tsrv014001.UndertakingDocumentType1Choice
    }
    ISO20022.Tsrv014001.Document9 *-- ISO20022.Tsrv014001.PartyAndSignature2
    ISO20022.Tsrv014001.Document9 *-- ISO20022.Tsrv014001.DocumentFormat1Choice
    ISO20022.Tsrv014001.Document9 *-- ISO20022.Tsrv014001.UndertakingDocumentType1Choice
    class ISO20022.Tsrv014001.DocumentFormat1Choice {
        + Prtry  : ISO20022.Tsrv014001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv014001.DocumentFormat1Choice *-- ISO20022.Tsrv014001.GenericIdentification1
    class ISO20022.Tsrv014001.ExtendOrPayQuery1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + NclsdFile  : global::System.Collections.Generic.List~ISO20022.Tsrv014001.Document9~
        + BkCtct  : global::System.Collections.Generic.List~ISO20022.Tsrv014001.Contacts3~
        + BkInstrs  : ISO20022.Tsrv014001.BankInstructions1
        + ReqdXpryDt  : DateTime
        + DmndDtls  : ISO20022.Tsrv014001.Demand2
        + UdrtkgId  : ISO20022.Tsrv014001.Undertaking9
    }
    ISO20022.Tsrv014001.ExtendOrPayQuery1 *-- ISO20022.Tsrv014001.Document9
    ISO20022.Tsrv014001.ExtendOrPayQuery1 *-- ISO20022.Tsrv014001.Contacts3
    ISO20022.Tsrv014001.ExtendOrPayQuery1 *-- ISO20022.Tsrv014001.BankInstructions1
    ISO20022.Tsrv014001.ExtendOrPayQuery1 *-- ISO20022.Tsrv014001.Demand2
    ISO20022.Tsrv014001.ExtendOrPayQuery1 *-- ISO20022.Tsrv014001.Undertaking9
    class ISO20022.Tsrv014001.ExtendOrPayRequestV01 {
        + DgtlSgntr  : ISO20022.Tsrv014001.PartyAndSignature2
        + XtndOrPayReqDtls  : ISO20022.Tsrv014001.ExtendOrPayQuery1
    }
    ISO20022.Tsrv014001.ExtendOrPayRequestV01 *-- ISO20022.Tsrv014001.PartyAndSignature2
    ISO20022.Tsrv014001.ExtendOrPayRequestV01 *-- ISO20022.Tsrv014001.ExtendOrPayQuery1
    class ISO20022.Tsrv014001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsrv014001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv014001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv014001.GenericOrganisationIdentification1 *-- ISO20022.Tsrv014001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Tsrv014001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv014001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv014001.GenericPersonIdentification1 *-- ISO20022.Tsrv014001.PersonIdentificationSchemeName1Choice
    class ISO20022.Tsrv014001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Tsrv014001.OrganisationIdentification8 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv014001.GenericOrganisationIdentification1~
        + AnyBIC  : String
    }
    ISO20022.Tsrv014001.OrganisationIdentification8 *-- ISO20022.Tsrv014001.GenericOrganisationIdentification1
    class ISO20022.Tsrv014001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv014001.Party11Choice {
        + PrvtId  : ISO20022.Tsrv014001.PersonIdentification5
        + OrgId  : ISO20022.Tsrv014001.OrganisationIdentification8
    }
    ISO20022.Tsrv014001.Party11Choice *-- ISO20022.Tsrv014001.PersonIdentification5
    ISO20022.Tsrv014001.Party11Choice *-- ISO20022.Tsrv014001.OrganisationIdentification8
    class ISO20022.Tsrv014001.PartyAndSignature2 {
        + Sgntr  : ISO20022.Tsrv014001.ProprietaryData3
        + Pty  : ISO20022.Tsrv014001.PartyIdentification43
    }
    ISO20022.Tsrv014001.PartyAndSignature2 *-- ISO20022.Tsrv014001.ProprietaryData3
    ISO20022.Tsrv014001.PartyAndSignature2 *-- ISO20022.Tsrv014001.PartyIdentification43
    class ISO20022.Tsrv014001.PartyIdentification43 {
        + CtctDtls  : ISO20022.Tsrv014001.ContactDetails2
        + CtryOfRes  : String
        + Id  : ISO20022.Tsrv014001.Party11Choice
        + PstlAdr  : ISO20022.Tsrv014001.PostalAddress6
        + Nm  : String
    }
    ISO20022.Tsrv014001.PartyIdentification43 *-- ISO20022.Tsrv014001.ContactDetails2
    ISO20022.Tsrv014001.PartyIdentification43 *-- ISO20022.Tsrv014001.Party11Choice
    ISO20022.Tsrv014001.PartyIdentification43 *-- ISO20022.Tsrv014001.PostalAddress6
    class ISO20022.Tsrv014001.PersonIdentification5 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv014001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Tsrv014001.DateAndPlaceOfBirth
    }
    ISO20022.Tsrv014001.PersonIdentification5 *-- ISO20022.Tsrv014001.GenericPersonIdentification1
    ISO20022.Tsrv014001.PersonIdentification5 *-- ISO20022.Tsrv014001.DateAndPlaceOfBirth
    class ISO20022.Tsrv014001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv014001.PostalAddress6 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Tsrv014001.ProprietaryData3 {
    }
    class ISO20022.Tsrv014001.Undertaking9 {
        + ApplcntRefNb  : String
        + Issr  : ISO20022.Tsrv014001.PartyIdentification43
        + Id  : String
    }
    ISO20022.Tsrv014001.Undertaking9 *-- ISO20022.Tsrv014001.PartyIdentification43
    class ISO20022.Tsrv014001.UndertakingDocumentType1Choice {
        + Prtry  : ISO20022.Tsrv014001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv014001.UndertakingDocumentType1Choice *-- ISO20022.Tsrv014001.GenericIdentification1
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

## Value ISO20022.Tsrv014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Tsrv014001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Tsrv014001.BankInstructions1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastDtForRspn|DateTime||XmlElement()||
|+|Txt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""Txt""",Txt,5))|

---

## Value ISO20022.Tsrv014001.ContactDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Tsrv014001.Contacts3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|Othr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Tsrv014001.DateAndPlaceOfBirth


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv014001.Demand2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Amt|ISO20022.Tsrv014001.ActiveCurrencyAndAmount||XmlElement()||
|+|SubmissnDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validElement(Amt))|

---

## Type ISO20022.Tsrv014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndOrPayReq|ISO20022.Tsrv014001.ExtendOrPayRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XtndOrPayReq))|

---

## Value ISO20022.Tsrv014001.Document9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv014001.PartyAndSignature2||XmlElement()||
|+|Nclsr|String||XmlElement()||
|+|Frmt|ISO20022.Tsrv014001.DocumentFormat1Choice||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Tsrv014001.UndertakingDocumentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(Frmt),validElement(Tp))|

---

## Value ISO20022.Tsrv014001.DocumentFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv014001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv014001.ExtendOrPayQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NclsdFile|global::System.Collections.Generic.List<ISO20022.Tsrv014001.Document9>||XmlElement()||
|+|BkCtct|global::System.Collections.Generic.List<ISO20022.Tsrv014001.Contacts3>||XmlElement()||
|+|BkInstrs|ISO20022.Tsrv014001.BankInstructions1||XmlElement()||
|+|ReqdXpryDt|DateTime||XmlElement()||
|+|DmndDtls|ISO20022.Tsrv014001.Demand2||XmlElement()||
|+|UdrtkgId|ISO20022.Tsrv014001.Undertaking9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validList("""NclsdFile""",NclsdFile),validElement(NclsdFile),validList("""BkCtct""",BkCtct),validElement(BkCtct),validElement(BkInstrs),validElement(DmndDtls),validElement(UdrtkgId))|

---

## Aspect ISO20022.Tsrv014001.ExtendOrPayRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv014001.PartyAndSignature2||XmlElement()||
|+|XtndOrPayReqDtls|ISO20022.Tsrv014001.ExtendOrPayQuery1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(XtndOrPayReqDtls))|

---

## Value ISO20022.Tsrv014001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv014001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv014001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsrv014001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv014001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Enum ISO20022.Tsrv014001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Tsrv014001.OrganisationIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv014001.GenericOrganisationIdentification1>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsrv014001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv014001.Party11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Tsrv014001.PersonIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsrv014001.OrganisationIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsrv014001.PartyAndSignature2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Tsrv014001.ProprietaryData3||XmlElement()||
|+|Pty|ISO20022.Tsrv014001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Tsrv014001.PartyIdentification43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Tsrv014001.ContactDetails2||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Tsrv014001.Party11Choice||XmlElement()||
|+|PstlAdr|ISO20022.Tsrv014001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Tsrv014001.PersonIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv014001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Tsrv014001.DateAndPlaceOfBirth||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Tsrv014001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv014001.PostalAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv014001.ProprietaryData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv014001.Undertaking9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ApplcntRefNb|String||XmlElement()||
|+|Issr|ISO20022.Tsrv014001.PartyIdentification43||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Tsrv014001.UndertakingDocumentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv014001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

