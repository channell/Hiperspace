# sese.014.001.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese014001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese014001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese014001.AdditionalReference10 *-- ISO20022.Sese014001.PartyIdentification139
    class ISO20022.Sese014001.AdditionalReference11 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese014001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese014001.AdditionalReference11 *-- ISO20022.Sese014001.PartyIdentification139
    class ISO20022.Sese014001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese014001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese014001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Sese014001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Sese014001.NameAndAddress5 {
        + Adr  : ISO20022.Sese014001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese014001.NameAndAddress5 *-- ISO20022.Sese014001.PostalAddress1
    class ISO20022.Sese014001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Sese014001.NameAndAddress5
        + PrtryId  : ISO20022.Sese014001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese014001.PartyIdentification125Choice *-- ISO20022.Sese014001.NameAndAddress5
    ISO20022.Sese014001.PartyIdentification125Choice *-- ISO20022.Sese014001.GenericIdentification1
    class ISO20022.Sese014001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Sese014001.PartyIdentification125Choice
    }
    ISO20022.Sese014001.PartyIdentification139 *-- ISO20022.Sese014001.PartyIdentification125Choice
    class ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 {
        + MktPrctcVrsn  : ISO20022.Sese014001.MarketPracticeVersion1
        + TrfRefs  : ISO20022.Sese014001.TransferReference14
        + MstrRef  : String
        + RltdRef  : ISO20022.Sese014001.AdditionalReference10
        + PrvsRef  : ISO20022.Sese014001.AdditionalReference10
        + PoolRef  : ISO20022.Sese014001.AdditionalReference11
        + MsgRef  : ISO20022.Sese014001.MessageIdentification1
    }
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.MarketPracticeVersion1
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.TransferReference14
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.AdditionalReference10
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.AdditionalReference10
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.AdditionalReference11
    ISO20022.Sese014001.PortfolioTransferCancellationRequestV09 *-- ISO20022.Sese014001.MessageIdentification1
    class ISO20022.Sese014001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese014001.TransferReference14 {
        + CxlRsn  : String
        + CxlRef  : String
        + TrfConfRef  : String
        + CtrPtyRef  : ISO20022.Sese014001.AdditionalReference10
        + ClntRef  : ISO20022.Sese014001.AdditionalReference10
        + TrfRef  : String
    }
    ISO20022.Sese014001.TransferReference14 *-- ISO20022.Sese014001.AdditionalReference10
    ISO20022.Sese014001.TransferReference14 *-- ISO20022.Sese014001.AdditionalReference10
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

## Value ISO20022.Sese014001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese014001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Sese014001.AdditionalReference11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese014001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Sese014001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Type ISO20022.Sese014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTrfCxlReq|ISO20022.Sese014001.PortfolioTransferCancellationRequestV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtflTrfCxlReq))|

---

## Value ISO20022.Sese014001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese014001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese014001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese014001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese014001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese014001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese014001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese014001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese014001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese014001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Aspect ISO20022.Sese014001.PortfolioTransferCancellationRequestV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPrctcVrsn|ISO20022.Sese014001.MarketPracticeVersion1||XmlElement()||
|+|TrfRefs|ISO20022.Sese014001.TransferReference14||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|RltdRef|ISO20022.Sese014001.AdditionalReference10||XmlElement()||
|+|PrvsRef|ISO20022.Sese014001.AdditionalReference10||XmlElement()||
|+|PoolRef|ISO20022.Sese014001.AdditionalReference11||XmlElement()||
|+|MsgRef|ISO20022.Sese014001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPrctcVrsn),validElement(TrfRefs),validElement(RltdRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgRef))|

---

## Value ISO20022.Sese014001.PostalAddress1


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

## Value ISO20022.Sese014001.TransferReference14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlRsn|String||XmlElement()||
|+|CxlRef|String||XmlElement()||
|+|TrfConfRef|String||XmlElement()||
|+|CtrPtyRef|ISO20022.Sese014001.AdditionalReference10||XmlElement()||
|+|ClntRef|ISO20022.Sese014001.AdditionalReference10||XmlElement()||
|+|TrfRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrPtyRef),validElement(ClntRef))|

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

