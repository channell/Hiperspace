# camt.008.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt008001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt008001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt008001.AccountIdentification4Choice *-- ISO20022.Camt008001.GenericAccountIdentification1
    class ISO20022.Camt008001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt008001.AddressType3Choice {
        + Prtry  : ISO20022.Camt008001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt008001.AddressType3Choice *-- ISO20022.Camt008001.GenericIdentification30
    class ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt008001.BranchData5
        + FinInstnId  : ISO20022.Camt008001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt008001.BranchData5
    ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt008001.FinancialInstitutionIdentification23
    class ISO20022.Camt008001.BranchData5 {
        + PstlAdr  : ISO20022.Camt008001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt008001.BranchData5 *-- ISO20022.Camt008001.PostalAddress27
    class ISO20022.Camt008001.CancelTransactionV11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt008001.SupplementaryData1~
        + CxlRsn  : ISO20022.Camt008001.PaymentCancellationReason6
        + CshAcct  : ISO20022.Camt008001.CashAccount40
        + PmtId  : ISO20022.Camt008001.PaymentIdentification8Choice
        + MsgHdr  : ISO20022.Camt008001.MessageHeader9
    }
    ISO20022.Camt008001.CancelTransactionV11 *-- ISO20022.Camt008001.SupplementaryData1
    ISO20022.Camt008001.CancelTransactionV11 *-- ISO20022.Camt008001.PaymentCancellationReason6
    ISO20022.Camt008001.CancelTransactionV11 *-- ISO20022.Camt008001.CashAccount40
    ISO20022.Camt008001.CancelTransactionV11 *-- ISO20022.Camt008001.PaymentIdentification8Choice
    ISO20022.Camt008001.CancelTransactionV11 *-- ISO20022.Camt008001.MessageHeader9
    class ISO20022.Camt008001.CancellationReason33Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.CashAccount40 {
        + Prxy  : ISO20022.Camt008001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt008001.CashAccountType2Choice
        + Id  : ISO20022.Camt008001.AccountIdentification4Choice
    }
    ISO20022.Camt008001.CashAccount40 *-- ISO20022.Camt008001.ProxyAccountIdentification1
    ISO20022.Camt008001.CashAccount40 *-- ISO20022.Camt008001.CashAccountType2Choice
    ISO20022.Camt008001.CashAccount40 *-- ISO20022.Camt008001.AccountIdentification4Choice
    class ISO20022.Camt008001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt008001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt008001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt008001.ClearingSystemIdentification2Choice
    class ISO20022.Camt008001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt008001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + URLAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    ISO20022.Camt008001.Contact13 *-- ISO20022.Camt008001.OtherContact1
    class ISO20022.Camt008001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt008001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt008001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt008001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt008001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt008001.FinancialInstitutionIdentification23 *-- ISO20022.Camt008001.GenericFinancialIdentification1
    ISO20022.Camt008001.FinancialInstitutionIdentification23 *-- ISO20022.Camt008001.PostalAddress27
    ISO20022.Camt008001.FinancialInstitutionIdentification23 *-- ISO20022.Camt008001.ClearingSystemMemberIdentification2
    class ISO20022.Camt008001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt008001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt008001.GenericAccountIdentification1 *-- ISO20022.Camt008001.AccountSchemeName1Choice
    class ISO20022.Camt008001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt008001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt008001.GenericFinancialIdentification1 *-- ISO20022.Camt008001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt008001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt008001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt008001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt008001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt008001.GenericOrganisationIdentification3 *-- ISO20022.Camt008001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt008001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt008001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt008001.GenericPersonIdentification2 *-- ISO20022.Camt008001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt008001.LongPaymentIdentification4 {
        + EndToEndId  : String
        + NtryTp  : String
        + InstdAgt  : ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
        + PmtMtd  : ISO20022.Camt008001.PaymentOrigin1Choice
        + IntrBkSttlmDt  : DateTime
        + IntrBkSttlmAmt  : Decimal
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt008001.LongPaymentIdentification4 *-- ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt008001.LongPaymentIdentification4 *-- ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt008001.LongPaymentIdentification4 *-- ISO20022.Camt008001.PaymentOrigin1Choice
    class ISO20022.Camt008001.MessageHeader9 {
        + ReqTp  : ISO20022.Camt008001.RequestType4Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt008001.MessageHeader9 *-- ISO20022.Camt008001.RequestType4Choice
    class ISO20022.Camt008001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt008001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt008001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt008001.OrganisationIdentification39 *-- ISO20022.Camt008001.GenericOrganisationIdentification3
    class ISO20022.Camt008001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt008001.Party52Choice {
        + PrvtId  : ISO20022.Camt008001.PersonIdentification18
        + OrgId  : ISO20022.Camt008001.OrganisationIdentification39
    }
    ISO20022.Camt008001.Party52Choice *-- ISO20022.Camt008001.PersonIdentification18
    ISO20022.Camt008001.Party52Choice *-- ISO20022.Camt008001.OrganisationIdentification39
    class ISO20022.Camt008001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt008001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt008001.Party52Choice
        + PstlAdr  : ISO20022.Camt008001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt008001.PartyIdentification272 *-- ISO20022.Camt008001.Contact13
    ISO20022.Camt008001.PartyIdentification272 *-- ISO20022.Camt008001.Party52Choice
    ISO20022.Camt008001.PartyIdentification272 *-- ISO20022.Camt008001.PostalAddress27
    class ISO20022.Camt008001.PaymentCancellationReason6 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Camt008001.CancellationReason33Choice
        + Orgtr  : ISO20022.Camt008001.PartyIdentification272
    }
    ISO20022.Camt008001.PaymentCancellationReason6 *-- ISO20022.Camt008001.CancellationReason33Choice
    ISO20022.Camt008001.PaymentCancellationReason6 *-- ISO20022.Camt008001.PartyIdentification272
    class ISO20022.Camt008001.PaymentIdentification8Choice {
        + PrtryId  : String
        + ShrtBizId  : ISO20022.Camt008001.ShortPaymentIdentification4
        + LngBizId  : ISO20022.Camt008001.LongPaymentIdentification4
        + QId  : ISO20022.Camt008001.QueueTransactionIdentification1
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt008001.PaymentIdentification8Choice *-- ISO20022.Camt008001.ShortPaymentIdentification4
    ISO20022.Camt008001.PaymentIdentification8Choice *-- ISO20022.Camt008001.LongPaymentIdentification4
    ISO20022.Camt008001.PaymentIdentification8Choice *-- ISO20022.Camt008001.QueueTransactionIdentification1
    class ISO20022.Camt008001.PaymentInstrument1Code {
        CAN = 1
        RTI = 2
        CCP = 3
        DCP = 4
        BKT = 5
        CHK = 6
        CCT = 7
        CDT = 8
        BCT = 9
        BDT = 10
    }
    class ISO20022.Camt008001.PaymentOrigin1Choice {
        + Instrm  : String
        + Prtry  : String
        + XMLMsgNm  : String
        + FINMT  : String
    }
    class ISO20022.Camt008001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt008001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt008001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt008001.PersonIdentification18 *-- ISO20022.Camt008001.GenericPersonIdentification2
    ISO20022.Camt008001.PersonIdentification18 *-- ISO20022.Camt008001.DateAndPlaceOfBirth1
    class ISO20022.Camt008001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.PostalAddress27 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + UnitNb  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + CareOf  : String
        + AdrTp  : ISO20022.Camt008001.AddressType3Choice
    }
    ISO20022.Camt008001.PostalAddress27 *-- ISO20022.Camt008001.AddressType3Choice
    class ISO20022.Camt008001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt008001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt008001.ProxyAccountType1Choice
    }
    ISO20022.Camt008001.ProxyAccountIdentification1 *-- ISO20022.Camt008001.ProxyAccountType1Choice
    class ISO20022.Camt008001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt008001.QueueTransactionIdentification1 {
        + PosInQ  : String
        + QId  : String
    }
    class ISO20022.Camt008001.RequestType4Choice {
        + Prtry  : ISO20022.Camt008001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Camt008001.RequestType4Choice *-- ISO20022.Camt008001.GenericIdentification1
    class ISO20022.Camt008001.ShortPaymentIdentification4 {
        + InstgAgt  : ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
        + IntrBkSttlmDt  : DateTime
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt008001.ShortPaymentIdentification4 *-- ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt008001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt008001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt008001.SupplementaryData1 *-- ISO20022.Camt008001.SupplementaryDataEnvelope1
    class ISO20022.Camt008001.SupplementaryDataEnvelope1 {
    }
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

## Value ISO20022.Camt008001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt008001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt008001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt008001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt008001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt008001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt008001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt008001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt008001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt008001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Aspect ISO20022.Camt008001.CancelTransactionV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt008001.SupplementaryData1>||XmlElement()||
|+|CxlRsn|ISO20022.Camt008001.PaymentCancellationReason6||XmlElement()||
|+|CshAcct|ISO20022.Camt008001.CashAccount40||XmlElement()||
|+|PmtId|ISO20022.Camt008001.PaymentIdentification8Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt008001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CxlRsn),validElement(CshAcct),validElement(PmtId),validElement(MsgHdr))|

---

## Value ISO20022.Camt008001.CancellationReason33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt008001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt008001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt008001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt008001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt008001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt008001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt008001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Camt008001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Camt008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CclTx|ISO20022.Camt008001.CancelTransactionV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CclTx))|

---

## Value ISO20022.Camt008001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt008001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt008001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt008001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt008001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt008001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt008001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt008001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt008001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt008001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt008001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt008001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt008001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt008001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt008001.LongPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndToEndId|String||XmlElement()||
|+|NtryTp|String||XmlElement()||
|+|InstdAgt|ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|PmtMtd|ISO20022.Camt008001.PaymentOrigin1Choice||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|IntrBkSttlmAmt|Decimal||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NtryTp""",NtryTp,"""[BEOVW]{1,1}[0-9]{2,2}\|DUM"""),validElement(InstdAgt),validElement(InstgAgt),validElement(PmtMtd),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt008001.MessageHeader9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Camt008001.RequestType4Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Enum ISO20022.Camt008001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt008001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt008001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt008001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt008001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt008001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt008001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt008001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt008001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt008001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt008001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt008001.PaymentCancellationReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Camt008001.CancellationReason33Choice||XmlElement()||
|+|Orgtr|ISO20022.Camt008001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Orgtr))|

---

## Value ISO20022.Camt008001.PaymentIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ShrtBizId|ISO20022.Camt008001.ShortPaymentIdentification4||XmlElement()||
|+|LngBizId|ISO20022.Camt008001.LongPaymentIdentification4||XmlElement()||
|+|QId|ISO20022.Camt008001.QueueTransactionIdentification1||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ShrtBizId),validElement(LngBizId),validElement(QId),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validChoice(PrtryId,ShrtBizId,LngBizId,QId,UETR,TxId))|

---

## Enum ISO20022.Camt008001.PaymentInstrument1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CAN|Int32||XmlEnum("""CAN""")|1|
||RTI|Int32||XmlEnum("""RTI""")|2|
||CCP|Int32||XmlEnum("""CCP""")|3|
||DCP|Int32||XmlEnum("""DCP""")|4|
||BKT|Int32||XmlEnum("""BKT""")|5|
||CHK|Int32||XmlEnum("""CHK""")|6|
||CCT|Int32||XmlEnum("""CCT""")|7|
||CDT|Int32||XmlEnum("""CDT""")|8|
||BCT|Int32||XmlEnum("""BCT""")|9|
||BDT|Int32||XmlEnum("""BDT""")|10|

---

## Value ISO20022.Camt008001.PaymentOrigin1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Instrm|String||XmlElement()||
|+|Prtry|String||XmlElement()||
|+|XMLMsgNm|String||XmlElement()||
|+|FINMT|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FINMT""",FINMT,"""[0-9]{1,3}"""),validChoice(Instrm,Prtry,XMLMsgNm,FINMT))|

---

## Value ISO20022.Camt008001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt008001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt008001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt008001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.PostalAddress27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|AdrTp|ISO20022.Camt008001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt008001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt008001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt008001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt008001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt008001.QueueTransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PosInQ|String||XmlElement()||
|+|QId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt008001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt008001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Value ISO20022.Camt008001.ShortPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstgAgt|ISO20022.Camt008001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstgAgt),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt008001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt008001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt008001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

