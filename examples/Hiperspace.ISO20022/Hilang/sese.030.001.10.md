# sese.030.001.10
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese030001.AdditionalInformation26 {
        + TxSbjtToBuyIn  : String
        + RcvgPty1  : ISO20022.Sese030001.PartyIdentificationAndAccount195
        + DlvrgPty1  : ISO20022.Sese030001.PartyIdentificationAndAccount195
        + Invstr  : ISO20022.Sese030001.PartyIdentification136
        + CutOffDt  : ISO20022.Sese030001.DateAndDateTime2Choice
        + XpryDt  : ISO20022.Sese030001.DateAndDateTime2Choice
        + FctvDt  : ISO20022.Sese030001.DateAndDateTime2Choice
        + Qty  : ISO20022.Sese030001.FinancialInstrumentQuantity33Choice
        + FinInstrmId  : ISO20022.Sese030001.SecurityIdentification19
        + BlckChainAdrOrWllt  : ISO20022.Sese030001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese030001.SecuritiesAccount19
        + ClssfctnTp  : ISO20022.Sese030001.ClassificationType32Choice
        + AcctOwnrTxId  : String
    }
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.PartyIdentificationAndAccount195
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.PartyIdentificationAndAccount195
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.PartyIdentification136
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.DateAndDateTime2Choice
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.DateAndDateTime2Choice
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.DateAndDateTime2Choice
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.SecurityIdentification19
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.BlockChainAddressWallet3
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.SecuritiesAccount19
    ISO20022.Sese030001.AdditionalInformation26 *-- ISO20022.Sese030001.ClassificationType32Choice
    class ISO20022.Sese030001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese030001.AutoBorrowing2Code {
        RTRN = 1
        YBOR = 2
        NBOR = 3
        LAMI = 4
    }
    class ISO20022.Sese030001.AutomaticBorrowing7Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.AutomaticBorrowing7Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese030001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese030001.BlockChainAddressWallet3 *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese030001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese030001.ClassificationType32Choice *-- ISO20022.Sese030001.GenericIdentification36
    class ISO20022.Sese030001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese030001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Sese030001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese030001.DocumentNumber5Choice *-- ISO20022.Sese030001.GenericIdentification36
    class ISO20022.Sese030001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese030001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese030001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese030001.HoldIndicator6 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese030001.RegistrationReason5~
        + Ind  : String
    }
    ISO20022.Sese030001.HoldIndicator6 *-- ISO20022.Sese030001.RegistrationReason5
    class ISO20022.Sese030001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese030001.LinkageType1Code {
        SOFT = 1
        UNLK = 2
        LINK = 3
    }
    class ISO20022.Sese030001.LinkageType3Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.LinkageType3Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.Linkages73 {
        + RefOwnr  : ISO20022.Sese030001.PartyIdentification127Choice
        + Ref  : ISO20022.Sese030001.References80Choice
        + MsgNb  : ISO20022.Sese030001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Sese030001.ProcessingPosition8Choice
    }
    ISO20022.Sese030001.Linkages73 *-- ISO20022.Sese030001.PartyIdentification127Choice
    ISO20022.Sese030001.Linkages73 *-- ISO20022.Sese030001.References80Choice
    ISO20022.Sese030001.Linkages73 *-- ISO20022.Sese030001.DocumentNumber5Choice
    ISO20022.Sese030001.Linkages73 *-- ISO20022.Sese030001.ProcessingPosition8Choice
    class ISO20022.Sese030001.MatchingDenied3Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.MatchingDenied3Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.MatchingProcess1Code {
        MTRE = 1
        UNMT = 2
    }
    class ISO20022.Sese030001.NameAndAddress5 {
        + Adr  : ISO20022.Sese030001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese030001.NameAndAddress5 *-- ISO20022.Sese030001.PostalAddress1
    class ISO20022.Sese030001.OtherIdentification1 {
        + Tp  : ISO20022.Sese030001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese030001.OtherIdentification1 *-- ISO20022.Sese030001.IdentificationSource3Choice
    class ISO20022.Sese030001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese030001.NameAndAddress5
        + PrtryId  : ISO20022.Sese030001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese030001.PartyIdentification120Choice *-- ISO20022.Sese030001.NameAndAddress5
    ISO20022.Sese030001.PartyIdentification120Choice *-- ISO20022.Sese030001.GenericIdentification36
    class ISO20022.Sese030001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese030001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese030001.PartyIdentification127Choice *-- ISO20022.Sese030001.GenericIdentification36
    class ISO20022.Sese030001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Sese030001.PartyIdentification120Choice
    }
    ISO20022.Sese030001.PartyIdentification136 *-- ISO20022.Sese030001.PartyIdentification120Choice
    class ISO20022.Sese030001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese030001.PartyIdentification127Choice
    }
    ISO20022.Sese030001.PartyIdentification144 *-- ISO20022.Sese030001.PartyIdentification127Choice
    class ISO20022.Sese030001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese030001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese030001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Sese030001.PartyIdentification120Choice
    }
    ISO20022.Sese030001.PartyIdentificationAndAccount195 *-- ISO20022.Sese030001.BlockChainAddressWallet3
    ISO20022.Sese030001.PartyIdentificationAndAccount195 *-- ISO20022.Sese030001.SecuritiesAccount19
    ISO20022.Sese030001.PartyIdentificationAndAccount195 *-- ISO20022.Sese030001.PartyIdentification120Choice
    class ISO20022.Sese030001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese030001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Sese030001.PriorityNumeric4Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.ProcessingPosition4Code {
        WITH = 1
        BEFO = 2
        AFTE = 3
    }
    class ISO20022.Sese030001.ProcessingPosition8Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.ProcessingPosition8Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.References29 {
        + UnqTxIdr  : String
        + TradId  : String
        + CmonId  : String
        + PoolId  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Sese030001.References80Choice {
        + OthrTxId  : String
        + UnqTxIdr  : String
        + TradId  : String
        + CmonId  : String
        + PoolId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Sese030001.Registration10Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.Registration10Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.Registration2Code {
        CVAL = 1
        CDEL = 2
        CSDH = 3
        PTYH = 4
    }
    class ISO20022.Sese030001.RegistrationReason5 {
        + AddtlInf  : String
        + Cd  : ISO20022.Sese030001.Registration10Choice
    }
    ISO20022.Sese030001.RegistrationReason5 *-- ISO20022.Sese030001.Registration10Choice
    class ISO20022.Sese030001.RequestDetails31 {
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese030001.Linkages73~
        + UnltrlSplt  : ISO20022.Sese030001.UnilateralSplit3Choice
        + MtchgDnl  : ISO20022.Sese030001.MatchingDenied3Choice
        + HldInd  : ISO20022.Sese030001.HoldIndicator6
        + SctiesRTGS  : ISO20022.Sese030001.SecuritiesRTGS4Choice
        + PrtlSttlmInd  : String
        + OthrPrcg  : global::System.Collections.Generic.List~ISO20022.Sese030001.GenericIdentification30~
        + Prty  : ISO20022.Sese030001.PriorityNumeric4Choice
        + Lkg  : ISO20022.Sese030001.LinkageType3Choice
        + RtnInd  : String
        + AutomtcBrrwg  : ISO20022.Sese030001.AutomaticBorrowing7Choice
        + RstrctnRef  : global::System.Collections.Generic.List~ISO20022.Sese030001.RestrictionIdentification1~
        + Ref  : ISO20022.Sese030001.References29
    }
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.Linkages73
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.UnilateralSplit3Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.MatchingDenied3Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.HoldIndicator6
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.SecuritiesRTGS4Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.GenericIdentification30
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.PriorityNumeric4Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.LinkageType3Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.AutomaticBorrowing7Choice
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.RestrictionIdentification1
    ISO20022.Sese030001.RequestDetails31 *-- ISO20022.Sese030001.References29
    class ISO20022.Sese030001.RestrictionIdentification1 {
        + Id  : String
        + Cd  : String
    }
    class ISO20022.Sese030001.RestrictionReference1Code {
        REMS = 1
        REMC = 2
        ADDS = 3
        ADDC = 4
    }
    class ISO20022.Sese030001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese030001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese030001.SecuritiesAccount19 *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese030001.SecuritiesRTGS4Choice *-- ISO20022.Sese030001.GenericIdentification30
    class ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese030001.SupplementaryData1~
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese030001.AdditionalInformation26~
        + ReqDtls  : global::System.Collections.Generic.List~ISO20022.Sese030001.RequestDetails31~
        + BlckChainAdrOrWllt  : ISO20022.Sese030001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese030001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese030001.PartyIdentification144
    }
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.SupplementaryData1
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.AdditionalInformation26
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.RequestDetails31
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.BlockChainAddressWallet3
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.SecuritiesAccount19
    ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10 *-- ISO20022.Sese030001.PartyIdentification144
    class ISO20022.Sese030001.SecuritiesTransactionType5Code {
        TRAD = 1
    }
    class ISO20022.Sese030001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese030001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese030001.SecurityIdentification19 *-- ISO20022.Sese030001.OtherIdentification1
    class ISO20022.Sese030001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese030001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese030001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese030001.SupplementaryData1 *-- ISO20022.Sese030001.SupplementaryDataEnvelope1
    class ISO20022.Sese030001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese030001.UnilateralSplit3Choice {
        + Prtry  : ISO20022.Sese030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese030001.UnilateralSplit3Choice *-- ISO20022.Sese030001.GenericIdentification30
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

## Value ISO20022.Sese030001.AdditionalInformation26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxSbjtToBuyIn|String||XmlElement()||
|+|RcvgPty1|ISO20022.Sese030001.PartyIdentificationAndAccount195||XmlElement()||
|+|DlvrgPty1|ISO20022.Sese030001.PartyIdentificationAndAccount195||XmlElement()||
|+|Invstr|ISO20022.Sese030001.PartyIdentification136||XmlElement()||
|+|CutOffDt|ISO20022.Sese030001.DateAndDateTime2Choice||XmlElement()||
|+|XpryDt|ISO20022.Sese030001.DateAndDateTime2Choice||XmlElement()||
|+|FctvDt|ISO20022.Sese030001.DateAndDateTime2Choice||XmlElement()||
|+|Qty|ISO20022.Sese030001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese030001.SecurityIdentification19||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese030001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese030001.SecuritiesAccount19||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese030001.ClassificationType32Choice||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgPty1),validElement(DlvrgPty1),validElement(Invstr),validElement(CutOffDt),validElement(XpryDt),validElement(FctvDt),validElement(Qty),validElement(FinInstrmId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(ClssfctnTp))|

---

## Enum ISO20022.Sese030001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Sese030001.AutoBorrowing2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RTRN|Int32||XmlEnum("""RTRN""")|1|
||YBOR|Int32||XmlEnum("""YBOR""")|2|
||NBOR|Int32||XmlEnum("""NBOR""")|3|
||LAMI|Int32||XmlEnum("""LAMI""")|4|

---

## Value ISO20022.Sese030001.AutomaticBorrowing7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese030001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese030001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese030001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese030001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Sese030001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmCondsModReq|ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmCondsModReq))|

---

## Value ISO20022.Sese030001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese030001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Sese030001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese030001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese030001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese030001.HoldIndicator6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese030001.RegistrationReason5>||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Sese030001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese030001.LinkageType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|
||UNLK|Int32||XmlEnum("""UNLK""")|2|
||LINK|Int32||XmlEnum("""LINK""")|3|

---

## Value ISO20022.Sese030001.LinkageType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese030001.Linkages73


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Sese030001.PartyIdentification127Choice||XmlElement()||
|+|Ref|ISO20022.Sese030001.References80Choice||XmlElement()||
|+|MsgNb|ISO20022.Sese030001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Sese030001.ProcessingPosition8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Value ISO20022.Sese030001.MatchingDenied3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese030001.MatchingProcess1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MTRE|Int32||XmlEnum("""MTRE""")|1|
||UNMT|Int32||XmlEnum("""UNMT""")|2|

---

## Value ISO20022.Sese030001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese030001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese030001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese030001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese030001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese030001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese030001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese030001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese030001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese030001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese030001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese030001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese030001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese030001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese030001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese030001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese030001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese030001.PostalAddress1


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

## Value ISO20022.Sese030001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Enum ISO20022.Sese030001.ProcessingPosition4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WITH|Int32||XmlEnum("""WITH""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||AFTE|Int32||XmlEnum("""AFTE""")|3|

---

## Value ISO20022.Sese030001.ProcessingPosition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese030001.References29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Value ISO20022.Sese030001.References80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(OthrTxId,UnqTxIdr,TradId,CmonId,PoolId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Sese030001.Registration10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese030001.Registration2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CVAL|Int32||XmlEnum("""CVAL""")|1|
||CDEL|Int32||XmlEnum("""CDEL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||PTYH|Int32||XmlEnum("""PTYH""")|4|

---

## Value ISO20022.Sese030001.RegistrationReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Sese030001.Registration10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese030001.RequestDetails31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese030001.Linkages73>||XmlElement()||
|+|UnltrlSplt|ISO20022.Sese030001.UnilateralSplit3Choice||XmlElement()||
|+|MtchgDnl|ISO20022.Sese030001.MatchingDenied3Choice||XmlElement()||
|+|HldInd|ISO20022.Sese030001.HoldIndicator6||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese030001.SecuritiesRTGS4Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|OthrPrcg|global::System.Collections.Generic.List<ISO20022.Sese030001.GenericIdentification30>||XmlElement()||
|+|Prty|ISO20022.Sese030001.PriorityNumeric4Choice||XmlElement()||
|+|Lkg|ISO20022.Sese030001.LinkageType3Choice||XmlElement()||
|+|RtnInd|String||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese030001.AutomaticBorrowing7Choice||XmlElement()||
|+|RstrctnRef|global::System.Collections.Generic.List<ISO20022.Sese030001.RestrictionIdentification1>||XmlElement()||
|+|Ref|ISO20022.Sese030001.References29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(UnltrlSplt),validElement(MtchgDnl),validElement(HldInd),validElement(SctiesRTGS),validList("""OthrPrcg""",OthrPrcg),validElement(OthrPrcg),validElement(Prty),validElement(Lkg),validElement(AutomtcBrrwg),validList("""RstrctnRef""",RstrctnRef),validElement(RstrctnRef),validElement(Ref))|

---

## Value ISO20022.Sese030001.RestrictionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese030001.RestrictionReference1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REMS|Int32||XmlEnum("""REMS""")|1|
||REMC|Int32||XmlEnum("""REMC""")|2|
||ADDS|Int32||XmlEnum("""ADDS""")|3|
||ADDC|Int32||XmlEnum("""ADDC""")|4|

---

## Value ISO20022.Sese030001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese030001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese030001.SecuritiesSettlementConditionsModificationRequestV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese030001.SupplementaryData1>||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese030001.AdditionalInformation26>||XmlElement()||
|+|ReqDtls|global::System.Collections.Generic.List<ISO20022.Sese030001.RequestDetails31>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese030001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese030001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese030001.PartyIdentification144||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validRequired("""ReqDtls""",ReqDtls),validList("""ReqDtls""",ReqDtls),validElement(ReqDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Enum ISO20022.Sese030001.SecuritiesTransactionType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|

---

## Value ISO20022.Sese030001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese030001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Sese030001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Value ISO20022.Sese030001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese030001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese030001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese030001.UnilateralSplit3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese030001.GenericIdentification30||XmlElement()||
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

