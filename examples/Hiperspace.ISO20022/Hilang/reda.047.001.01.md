# reda.047.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda047001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda047001.CSDLinkStatus1 {
        + StsRsn  : global::System.Collections.Generic.List~ISO20022.Reda047001.StatusReasonInformation10~
        + Sts  : String
    }
    ISO20022.Reda047001.CSDLinkStatus1 *-- ISO20022.Reda047001.StatusReasonInformation10
    class ISO20022.Reda047001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Reda047001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda047001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda047001.IssuerOrInvestor2Choice {
        + InvstrCSD  : ISO20022.Reda047001.SystemPartyIdentification2Choice
        + IssrCSD  : ISO20022.Reda047001.SystemPartyIdentification2Choice
    }
    ISO20022.Reda047001.IssuerOrInvestor2Choice *-- ISO20022.Reda047001.SystemPartyIdentification2Choice
    ISO20022.Reda047001.IssuerOrInvestor2Choice *-- ISO20022.Reda047001.SystemPartyIdentification2Choice
    class ISO20022.Reda047001.MessageHeader12 {
        + OrgnlBizInstr  : ISO20022.Reda047001.OriginalBusinessInstruction1
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Reda047001.MessageHeader12 *-- ISO20022.Reda047001.OriginalBusinessInstruction1
    class ISO20022.Reda047001.NameAndAddress5 {
        + Adr  : ISO20022.Reda047001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda047001.NameAndAddress5 *-- ISO20022.Reda047001.PostalAddress1
    class ISO20022.Reda047001.OriginalBusinessInstruction1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Reda047001.OtherIdentification1 {
        + Tp  : ISO20022.Reda047001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Reda047001.OtherIdentification1 *-- ISO20022.Reda047001.IdentificationSource3Choice
    class ISO20022.Reda047001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Reda047001.NameAndAddress5
        + PrtryId  : ISO20022.Reda047001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Reda047001.PartyIdentification120Choice *-- ISO20022.Reda047001.NameAndAddress5
    ISO20022.Reda047001.PartyIdentification120Choice *-- ISO20022.Reda047001.GenericIdentification36
    class ISO20022.Reda047001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Reda047001.PartyIdentification120Choice
    }
    ISO20022.Reda047001.PartyIdentification136 *-- ISO20022.Reda047001.PartyIdentification120Choice
    class ISO20022.Reda047001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda047001.SecurityCSDLink9 {
        + VldFr  : ISO20022.Reda047001.DateAndDateTime2Choice
        + IssrInvstrCSD  : ISO20022.Reda047001.IssuerOrInvestor2Choice
        + FinInstrmId  : ISO20022.Reda047001.SecurityIdentification19
    }
    ISO20022.Reda047001.SecurityCSDLink9 *-- ISO20022.Reda047001.DateAndDateTime2Choice
    ISO20022.Reda047001.SecurityCSDLink9 *-- ISO20022.Reda047001.IssuerOrInvestor2Choice
    ISO20022.Reda047001.SecurityCSDLink9 *-- ISO20022.Reda047001.SecurityIdentification19
    class ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda047001.SupplementaryData1~
        + SctyCSDLkId  : ISO20022.Reda047001.SecurityCSDLink9
        + SctyCSDLkSts  : ISO20022.Reda047001.CSDLinkStatus1
        + MsgHdr  : ISO20022.Reda047001.MessageHeader12
    }
    ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01 *-- ISO20022.Reda047001.SupplementaryData1
    ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01 *-- ISO20022.Reda047001.SecurityCSDLink9
    ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01 *-- ISO20022.Reda047001.CSDLinkStatus1
    ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01 *-- ISO20022.Reda047001.MessageHeader12
    class ISO20022.Reda047001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Reda047001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Reda047001.SecurityIdentification19 *-- ISO20022.Reda047001.OtherIdentification1
    class ISO20022.Reda047001.Status6Code {
        QUED = 1
        COMP = 2
        REJT = 3
    }
    class ISO20022.Reda047001.StatusReason6Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda047001.StatusReasonInformation10 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Reda047001.StatusReason6Choice
    }
    ISO20022.Reda047001.StatusReasonInformation10 *-- ISO20022.Reda047001.StatusReason6Choice
    class ISO20022.Reda047001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda047001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda047001.SupplementaryData1 *-- ISO20022.Reda047001.SupplementaryDataEnvelope1
    class ISO20022.Reda047001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda047001.SystemPartyIdentification2Choice {
        + CmbndId  : ISO20022.Reda047001.SystemPartyIdentification8
        + OrgId  : ISO20022.Reda047001.PartyIdentification136
    }
    ISO20022.Reda047001.SystemPartyIdentification2Choice *-- ISO20022.Reda047001.SystemPartyIdentification8
    ISO20022.Reda047001.SystemPartyIdentification2Choice *-- ISO20022.Reda047001.PartyIdentification136
    class ISO20022.Reda047001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Reda047001.PartyIdentification136
        + Id  : ISO20022.Reda047001.PartyIdentification136
    }
    ISO20022.Reda047001.SystemPartyIdentification8 *-- ISO20022.Reda047001.PartyIdentification136
    ISO20022.Reda047001.SystemPartyIdentification8 *-- ISO20022.Reda047001.PartyIdentification136
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

## Enum ISO20022.Reda047001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Reda047001.CSDLinkStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsRsn|global::System.Collections.Generic.List<ISO20022.Reda047001.StatusReasonInformation10>||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StsRsn""",StsRsn),validElement(StsRsn))|

---

## Value ISO20022.Reda047001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Reda047001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyCSDLkStsAdvc|ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyCSDLkStsAdvc))|

---

## Value ISO20022.Reda047001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda047001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda047001.IssuerOrInvestor2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstrCSD|ISO20022.Reda047001.SystemPartyIdentification2Choice||XmlElement()||
|+|IssrCSD|ISO20022.Reda047001.SystemPartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvstrCSD),validElement(IssrCSD),validChoice(InvstrCSD,IssrCSD))|

---

## Value ISO20022.Reda047001.MessageHeader12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlBizInstr|ISO20022.Reda047001.OriginalBusinessInstruction1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlBizInstr))|

---

## Value ISO20022.Reda047001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda047001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda047001.OriginalBusinessInstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda047001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Reda047001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Reda047001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda047001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda047001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda047001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Reda047001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda047001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Reda047001.SecurityCSDLink9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldFr|ISO20022.Reda047001.DateAndDateTime2Choice||XmlElement()||
|+|IssrInvstrCSD|ISO20022.Reda047001.IssuerOrInvestor2Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Reda047001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VldFr),validElement(IssrInvstrCSD),validElement(FinInstrmId))|

---

## Aspect ISO20022.Reda047001.SecurityCSDLinkStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda047001.SupplementaryData1>||XmlElement()||
|+|SctyCSDLkId|ISO20022.Reda047001.SecurityCSDLink9||XmlElement()||
|+|SctyCSDLkSts|ISO20022.Reda047001.CSDLinkStatus1||XmlElement()||
|+|MsgHdr|ISO20022.Reda047001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctyCSDLkId),validElement(SctyCSDLkSts),validElement(MsgHdr))|

---

## Value ISO20022.Reda047001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Reda047001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Reda047001.Status6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QUED|Int32||XmlEnum("""QUED""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|
||REJT|Int32||XmlEnum("""REJT""")|3|

---

## Value ISO20022.Reda047001.StatusReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda047001.StatusReasonInformation10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Reda047001.StatusReason6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Reda047001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda047001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda047001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda047001.SystemPartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmbndId|ISO20022.Reda047001.SystemPartyIdentification8||XmlElement()||
|+|OrgId|ISO20022.Reda047001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CmbndId),validElement(OrgId),validChoice(CmbndId,OrgId))|

---

## Value ISO20022.Reda047001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Reda047001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Reda047001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

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

