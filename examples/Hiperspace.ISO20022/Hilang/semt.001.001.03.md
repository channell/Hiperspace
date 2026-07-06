# semt.001.001.03
```mermaid
classDiagram
    class Semt001001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class Semt001001.MessageRejectedReason1Code {
        NALO = 1
        REFE = 2
    }
    class Semt001001.AdditionalReference3 {
        + MsgNm  : String
        + RefIssr  : Semt001001.PartyIdentification2Choice
        + Ref  : String
        + ValidElement_RefIssr () = validElement(RefIssr)
        + Validation () = validation(ValidElement_RefIssr)
    }
    class Semt001001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
        + Validation () = ""
    }
    class Semt001001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
        + Validation () = ""
    }
    class Semt001001.NameAndAddress5 {
        + Adr  : Semt001001.PostalAddress1
        + Nm  : String
        + ValidElement_Adr () = validElement(Adr)
        + Validation () = validation(ValidElement_Adr)
    }
    class Semt001001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : List~String~
        + AdrTp  : String
        + ValidPattern_Ctry () = validPattern("Ctry",Ctry,"[A-Z]{2,2}")
        + ValidListMax_AdrLine () = validListMax("AdrLine",AdrLine,5)
        + Validation () = validation(ValidPattern_Ctry,ValidListMax_AdrLine)
    }
    class Semt001001.RejectionReason23 {
        + LkdMsg  : Semt001001.LinkedMessage1Choice
        + AddtlInf  : String
        + Rsn  : String
        + ValidElement_LkdMsg () = validElement(LkdMsg)
        + Validation () = validation(ValidElement_LkdMsg)
    }
    class Semt001001.Document {
        # Uri  : String
        + SctiesMsgRjctn () : Semt001001.SecuritiesMessageRejectionV03
        + ValidElement_SctiesMsgRjctn () = validElement(SctiesMsgRjctn)
        + Validation () = validation(ValidElement_SctiesMsgRjctn)
    }
    class Semt001001.SecuritiesMessageRejectionV03 {
        + Rsn  : Semt001001.RejectionReason23
        + RltdRef  : Semt001001.AdditionalReference3
        + MsgId  : Semt001001.MessageIdentification1
        + ValidElement_Rsn () = validElement(Rsn)
        + ValidElement_RltdRef () = validElement(RltdRef)
        + ValidElement_MsgId () = validElement(MsgId)
        + Validation () = validation(ValidElement_Rsn,ValidElement_RltdRef,ValidElement_MsgId)
    }
    class Semt001001.LinkedMessage1Choice {
        + RltdRef  : Semt001001.AdditionalReference3
        + OthrRef  : Semt001001.AdditionalReference3
        + PrvsRef  : Semt001001.AdditionalReference3
        + ValidChoice () = validChoice(RltdRef,OthrRef,PrvsRef)
        + ValidElement_RltdRef () = validElement(RltdRef)
        + ValidElement_OthrRef () = validElement(OthrRef)
        + ValidElement_PrvsRef () = validElement(PrvsRef)
        + Validation () = validation(ValidElement_RltdRef,ValidElement_OthrRef,ValidElement_PrvsRef,ValidChoice)
    }
    class Semt001001.PartyIdentification2Choice {
        + NmAndAdr  : Semt001001.NameAndAddress5
        + PrtryId  : Semt001001.GenericIdentification1
        + BICOrBEI  : String
        + ValidChoice () = validChoice(NmAndAdr,PrtryId,BICOrBEI)
        + ValidElement_NmAndAdr () = validElement(NmAndAdr)
        + ValidElement_PrtryId () = validElement(PrtryId)
        + ValidPattern_BICOrBEI () = validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)
    }
    class Edge {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Edge
        + Tos (To = this) : Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## Enum Semt001001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32|||1|
||MLTO|Int32|||2|
||BIZZ|Int32|||3|
||HOME|Int32|||4|
||PBOX|Int32|||5|
||ADDR|Int32|||6|

---

## Enum Semt001001.MessageRejectedReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NALO|Int32|||1|
||REFE|Int32|||2|

---

## Value Semt001001.AdditionalReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|Semt001001.PartyIdentification2Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||ValidElement_RefIssr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RefIssr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RefIssr)|

---

## Value Semt001001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt001001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt001001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|Semt001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||ValidElement_Adr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Adr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Adr)|

---

## Value Semt001001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||ValidPattern_Ctry|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ctry",Ctry,"[A-Z]{2,2}")|
||ValidListMax_AdrLine|Some(String)||XmlIgnore(), JsonIgnore()|validListMax("AdrLine",AdrLine,5)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Ctry,ValidListMax_AdrLine)|

---

## Value Semt001001.RejectionReason23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdMsg|Semt001001.LinkedMessage1Choice||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
||ValidElement_LkdMsg|Some(String)||XmlIgnore(), JsonIgnore()|validElement(LkdMsg)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_LkdMsg)|

---

## Entity Semt001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesMsgRjctn|Semt001001.SecuritiesMessageRejectionV03||XmlElement()||
||ValidElement_SctiesMsgRjctn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SctiesMsgRjctn)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_SctiesMsgRjctn)|

---

## Aspect Semt001001.SecuritiesMessageRejectionV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|Semt001001.RejectionReason23||XmlElement()||
|+|RltdRef|Semt001001.AdditionalReference3||XmlElement()||
|+|MsgId|Semt001001.MessageIdentification1||XmlElement()||
||ValidElement_Rsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Rsn)|
||ValidElement_RltdRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RltdRef)|
||ValidElement_MsgId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(MsgId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Rsn,ValidElement_RltdRef,ValidElement_MsgId)|

---

## Value Semt001001.LinkedMessage1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdRef|Semt001001.AdditionalReference3||XmlElement()||
|+|OthrRef|Semt001001.AdditionalReference3||XmlElement()||
|+|PrvsRef|Semt001001.AdditionalReference3||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(RltdRef,OthrRef,PrvsRef)|
||ValidElement_RltdRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RltdRef)|
||ValidElement_OthrRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OthrRef)|
||ValidElement_PrvsRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrvsRef)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RltdRef,ValidElement_OthrRef,ValidElement_PrvsRef,ValidChoice)|

---

## Value Semt001001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|Semt001001.NameAndAddress5||XmlElement()||
|+|PrtryId|Semt001001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(NmAndAdr,PrtryId,BICOrBEI)|
||ValidElement_NmAndAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NmAndAdr)|
||ValidElement_PrtryId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrtryId)|
||ValidPattern_BICOrBEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)|

---

## View Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Edge|||From = this|
||Tos|Edge|||To = this|

