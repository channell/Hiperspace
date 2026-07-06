# sese.040.002.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese040002.AmountAndDirection67 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese040002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese040002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese040002.AmountAndDirection67 *-- ISO20022.Sese040002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese040002.AmountAndDirection67 *-- ISO20022.Sese040002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese040002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese040002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese040002.BlockChainAddressWallet7 *-- ISO20022.Sese040002.GenericIdentification47
    class ISO20022.Sese040002.ConsentOrRejectionReason5Choice {
        + Prtry  : ISO20022.Sese040002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese040002.ConsentOrRejectionReason5Choice *-- ISO20022.Sese040002.GenericIdentification47
    class ISO20022.Sese040002.ConsentReason5 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese040002.ConsentOrRejectionReason5Choice
    }
    ISO20022.Sese040002.ConsentReason5 *-- ISO20022.Sese040002.ConsentOrRejectionReason5Choice
    class ISO20022.Sese040002.ConsentStatus5Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese040002.ConsentReason5~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese040002.ConsentStatus5Choice *-- ISO20022.Sese040002.ConsentReason5
    class ISO20022.Sese040002.CounterpartyResponseStatusReason1Code {
        CPMD = 1
        CPCX = 2
        CPTR = 3
    }
    class ISO20022.Sese040002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese040002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese040002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese040002.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese040002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese040002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese040002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese040002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese040002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese040002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese040002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese040002.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Sese040002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese040002.OtherIdentification2 {
        + Tp  : ISO20022.Sese040002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese040002.OtherIdentification2 *-- ISO20022.Sese040002.IdentificationSource4Choice
    class ISO20022.Sese040002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese040002.NameAndAddress12
        + PrtryId  : ISO20022.Sese040002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese040002.PartyIdentification137Choice *-- ISO20022.Sese040002.NameAndAddress12
    ISO20022.Sese040002.PartyIdentification137Choice *-- ISO20022.Sese040002.GenericIdentification84
    class ISO20022.Sese040002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese040002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese040002.PartyIdentification145Choice *-- ISO20022.Sese040002.NameAndAddress12
    class ISO20022.Sese040002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese040002.PartyIdentification176Choice
    }
    ISO20022.Sese040002.PartyIdentification170 *-- ISO20022.Sese040002.PartyIdentification176Choice
    class ISO20022.Sese040002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese040002.NameAndAddress12
        + PrtryId  : ISO20022.Sese040002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese040002.PartyIdentification176Choice *-- ISO20022.Sese040002.NameAndAddress12
    ISO20022.Sese040002.PartyIdentification176Choice *-- ISO20022.Sese040002.GenericIdentification84
    class ISO20022.Sese040002.PartyIdentification191 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese040002.PartyIdentification145Choice
    }
    ISO20022.Sese040002.PartyIdentification191 *-- ISO20022.Sese040002.PartyIdentification145Choice
    class ISO20022.Sese040002.PartyIdentificationAndAccount215 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese040002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese040002.SecuritiesAccount30
        + LEI  : String
        + Id  : ISO20022.Sese040002.PartyIdentification137Choice
    }
    ISO20022.Sese040002.PartyIdentificationAndAccount215 *-- ISO20022.Sese040002.BlockChainAddressWallet7
    ISO20022.Sese040002.PartyIdentificationAndAccount215 *-- ISO20022.Sese040002.SecuritiesAccount30
    ISO20022.Sese040002.PartyIdentificationAndAccount215 *-- ISO20022.Sese040002.PartyIdentification137Choice
    class ISO20022.Sese040002.PendingStatus20Choice {
        + UdrInvstgtn  : ISO20022.Sese040002.NoSpecifiedReason1
        + Fwdd  : ISO20022.Sese040002.NoSpecifiedReason1
    }
    ISO20022.Sese040002.PendingStatus20Choice *-- ISO20022.Sese040002.NoSpecifiedReason1
    ISO20022.Sese040002.PendingStatus20Choice *-- ISO20022.Sese040002.NoSpecifiedReason1
    class ISO20022.Sese040002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese040002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese040002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese040002.Quantity54Choice *-- ISO20022.Sese040002.OriginalAndCurrentQuantities4
    ISO20022.Sese040002.Quantity54Choice *-- ISO20022.Sese040002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese040002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese040002.RejectionReason40 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese040002.ConsentOrRejectionReason5Choice
    }
    ISO20022.Sese040002.RejectionReason40 *-- ISO20022.Sese040002.ConsentOrRejectionReason5Choice
    class ISO20022.Sese040002.RejectionStatus27Choice {
        + Rsn  : ISO20022.Sese040002.RejectionReason40
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese040002.RejectionStatus27Choice *-- ISO20022.Sese040002.RejectionReason40
    class ISO20022.Sese040002.ResponseStatus8Choice {
        + Pdg  : ISO20022.Sese040002.PendingStatus20Choice
        + Rjctd  : ISO20022.Sese040002.RejectionStatus27Choice
        + Cnsntd  : ISO20022.Sese040002.ConsentStatus5Choice
    }
    ISO20022.Sese040002.ResponseStatus8Choice *-- ISO20022.Sese040002.PendingStatus20Choice
    ISO20022.Sese040002.ResponseStatus8Choice *-- ISO20022.Sese040002.RejectionStatus27Choice
    ISO20022.Sese040002.ResponseStatus8Choice *-- ISO20022.Sese040002.ConsentStatus5Choice
    class ISO20022.Sese040002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese040002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese040002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese040002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese040002.SecuritiesAccount30 *-- ISO20022.Sese040002.GenericIdentification47
    class ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese040002.SupplementaryData1~
        + TxDtls  : ISO20022.Sese040002.TransactionDetails157
        + RspnSts  : ISO20022.Sese040002.ResponseStatus8Choice
        + TxId  : ISO20022.Sese040002.TransactionIdentification7
    }
    ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04 *-- ISO20022.Sese040002.SupplementaryData1
    ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04 *-- ISO20022.Sese040002.TransactionDetails157
    ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04 *-- ISO20022.Sese040002.ResponseStatus8Choice
    ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04 *-- ISO20022.Sese040002.TransactionIdentification7
    class ISO20022.Sese040002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese040002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese040002.SecurityIdentification20 *-- ISO20022.Sese040002.OtherIdentification2
    class ISO20022.Sese040002.SettlementDate32Choice {
        + DtCd  : ISO20022.Sese040002.SettlementDateCode11Choice
        + Dt  : ISO20022.Sese040002.DateAndDateTime2Choice
    }
    ISO20022.Sese040002.SettlementDate32Choice *-- ISO20022.Sese040002.SettlementDateCode11Choice
    ISO20022.Sese040002.SettlementDate32Choice *-- ISO20022.Sese040002.DateAndDateTime2Choice
    class ISO20022.Sese040002.SettlementDateCode11Choice {
        + Prtry  : ISO20022.Sese040002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese040002.SettlementDateCode11Choice *-- ISO20022.Sese040002.GenericIdentification47
    class ISO20022.Sese040002.SettlementParties109 {
        + Pty5  : ISO20022.Sese040002.PartyIdentificationAndAccount215
        + Pty4  : ISO20022.Sese040002.PartyIdentificationAndAccount215
        + Pty3  : ISO20022.Sese040002.PartyIdentificationAndAccount215
        + Pty2  : ISO20022.Sese040002.PartyIdentificationAndAccount215
        + Pty1  : ISO20022.Sese040002.PartyIdentificationAndAccount215
        + Dpstry  : ISO20022.Sese040002.PartyIdentification191
    }
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentificationAndAccount215
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentificationAndAccount215
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentificationAndAccount215
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentificationAndAccount215
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentificationAndAccount215
    ISO20022.Sese040002.SettlementParties109 *-- ISO20022.Sese040002.PartyIdentification191
    class ISO20022.Sese040002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese040002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese040002.SupplementaryData1 *-- ISO20022.Sese040002.SupplementaryDataEnvelope1
    class ISO20022.Sese040002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese040002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese040002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese040002.DateAndDateTime2Choice
    }
    ISO20022.Sese040002.TradeDate9Choice *-- ISO20022.Sese040002.TradeDateCode4Choice
    ISO20022.Sese040002.TradeDate9Choice *-- ISO20022.Sese040002.DateAndDateTime2Choice
    class ISO20022.Sese040002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese040002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese040002.TradeDateCode4Choice *-- ISO20022.Sese040002.GenericIdentification47
    class ISO20022.Sese040002.TransactionDetails157 {
        + Invstr  : ISO20022.Sese040002.PartyIdentification170
        + RcvgSttlmPties  : ISO20022.Sese040002.SettlementParties109
        + DlvrgSttlmPties  : ISO20022.Sese040002.SettlementParties109
        + TradDt  : ISO20022.Sese040002.TradeDate9Choice
        + SttlmDt  : ISO20022.Sese040002.SettlementDate32Choice
        + SttlmAmt  : ISO20022.Sese040002.AmountAndDirection67
        + BlckChainAdrOrWllt  : ISO20022.Sese040002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese040002.SecuritiesAccount30
        + SttlmQty  : ISO20022.Sese040002.Quantity54Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + FinInstrmId  : ISO20022.Sese040002.SecurityIdentification20
    }
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.PartyIdentification170
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.SettlementParties109
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.SettlementParties109
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.TradeDate9Choice
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.SettlementDate32Choice
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.AmountAndDirection67
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.BlockChainAddressWallet7
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.SecuritiesAccount30
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.Quantity54Choice
    ISO20022.Sese040002.TransactionDetails157 *-- ISO20022.Sese040002.SecurityIdentification20
    class ISO20022.Sese040002.TransactionIdentification7 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
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

## Value ISO20022.Sese040002.AmountAndDirection67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese040002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese040002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese040002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese040002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese040002.ConsentOrRejectionReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040002.ConsentReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese040002.ConsentOrRejectionReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese040002.ConsentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese040002.ConsentReason5>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese040002.CounterpartyResponseStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CPMD|Int32||XmlEnum("""CPMD""")|1|
||CPCX|Int32||XmlEnum("""CPCX""")|2|
||CPTR|Int32||XmlEnum("""CPTR""")|3|

---

## Enum ISO20022.Sese040002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese040002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese040002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese040002.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese040002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese040002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxCtrPtyRspn|ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxCtrPtyRspn))|

---

## Value ISO20022.Sese040002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese040002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese040002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese040002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese040002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese040002.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese040002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese040002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese040002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese040002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese040002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese040002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese040002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese040002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese040002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese040002.PartyIdentification191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040002.PartyIdentificationAndAccount215


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese040002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese040002.SecuritiesAccount30||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040002.PendingStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UdrInvstgtn|ISO20022.Sese040002.NoSpecifiedReason1||XmlElement()||
|+|Fwdd|ISO20022.Sese040002.NoSpecifiedReason1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrInvstgtn),validElement(Fwdd),validChoice(UdrInvstgtn,Fwdd))|

---

## Value ISO20022.Sese040002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese040002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese040002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese040002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese040002.RejectionReason40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese040002.ConsentOrRejectionReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese040002.RejectionStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|ISO20022.Sese040002.RejectionReason40||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese040002.ResponseStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pdg|ISO20022.Sese040002.PendingStatus20Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese040002.RejectionStatus27Choice||XmlElement()||
|+|Cnsntd|ISO20022.Sese040002.ConsentStatus5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pdg),validElement(Rjctd),validElement(Cnsntd),validChoice(Pdg,Rjctd,Cnsntd))|

---

## Value ISO20022.Sese040002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese040002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese040002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese040002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Sese040002.SecuritiesSettlementTransactionCounterpartyResponse002V04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese040002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese040002.TransactionDetails157||XmlElement()||
|+|RspnSts|ISO20022.Sese040002.ResponseStatus8Choice||XmlElement()||
|+|TxId|ISO20022.Sese040002.TransactionIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(RspnSts),validElement(TxId))|

---

## Value ISO20022.Sese040002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese040002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese040002.SettlementDate32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese040002.SettlementDateCode11Choice||XmlElement()||
|+|Dt|ISO20022.Sese040002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese040002.SettlementDateCode11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040002.SettlementParties109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese040002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty4|ISO20022.Sese040002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty3|ISO20022.Sese040002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty2|ISO20022.Sese040002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty1|ISO20022.Sese040002.PartyIdentificationAndAccount215||XmlElement()||
|+|Dpstry|ISO20022.Sese040002.PartyIdentification191||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese040002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese040002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese040002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese040002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese040002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese040002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040002.TransactionDetails157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese040002.PartyIdentification170||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese040002.SettlementParties109||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese040002.SettlementParties109||XmlElement()||
|+|TradDt|ISO20022.Sese040002.TradeDate9Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese040002.SettlementDate32Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese040002.AmountAndDirection67||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese040002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese040002.SecuritiesAccount30||XmlElement()||
|+|SttlmQty|ISO20022.Sese040002.Quantity54Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|FinInstrmId|ISO20022.Sese040002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(TradDt),validElement(SttlmDt),validElement(SttlmAmt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(SttlmQty),validElement(FinInstrmId))|

---

## Value ISO20022.Sese040002.TransactionIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

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

