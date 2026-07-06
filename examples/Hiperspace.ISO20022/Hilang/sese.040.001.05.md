# sese.040.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese040001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese040001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese040001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese040001.AmountAndDirection51 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese040001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese040001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese040001.AmountAndDirection51 *-- ISO20022.Sese040001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese040001.AmountAndDirection51 *-- ISO20022.Sese040001.ActiveCurrencyAndAmount
    class ISO20022.Sese040001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese040001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese040001.BlockChainAddressWallet3 *-- ISO20022.Sese040001.GenericIdentification30
    class ISO20022.Sese040001.ConsentOrRejectionReason4Choice {
        + Prtry  : ISO20022.Sese040001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese040001.ConsentOrRejectionReason4Choice *-- ISO20022.Sese040001.GenericIdentification30
    class ISO20022.Sese040001.ConsentReason4 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese040001.ConsentOrRejectionReason4Choice
    }
    ISO20022.Sese040001.ConsentReason4 *-- ISO20022.Sese040001.ConsentOrRejectionReason4Choice
    class ISO20022.Sese040001.ConsentStatus4Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese040001.ConsentReason4~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese040001.ConsentStatus4Choice *-- ISO20022.Sese040001.ConsentReason4
    class ISO20022.Sese040001.CounterpartyResponseStatusReason1Code {
        CPMD = 1
        CPCX = 2
        CPTR = 3
    }
    class ISO20022.Sese040001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese040001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese040001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese040001.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese040001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese040001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese040001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese040001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese040001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese040001.NameAndAddress5 {
        + Adr  : ISO20022.Sese040001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese040001.NameAndAddress5 *-- ISO20022.Sese040001.PostalAddress1
    class ISO20022.Sese040001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese040001.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Sese040001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese040001.OtherIdentification1 {
        + Tp  : ISO20022.Sese040001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese040001.OtherIdentification1 *-- ISO20022.Sese040001.IdentificationSource3Choice
    class ISO20022.Sese040001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese040001.NameAndAddress5
        + PrtryId  : ISO20022.Sese040001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese040001.PartyIdentification120Choice *-- ISO20022.Sese040001.NameAndAddress5
    ISO20022.Sese040001.PartyIdentification120Choice *-- ISO20022.Sese040001.GenericIdentification36
    class ISO20022.Sese040001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese040001.NameAndAddress5
        + PrtryId  : ISO20022.Sese040001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese040001.PartyIdentification134Choice *-- ISO20022.Sese040001.NameAndAddress5
    ISO20022.Sese040001.PartyIdentification134Choice *-- ISO20022.Sese040001.GenericIdentification36
    class ISO20022.Sese040001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese040001.PartyIdentification134Choice
    }
    ISO20022.Sese040001.PartyIdentification149 *-- ISO20022.Sese040001.PartyIdentification134Choice
    class ISO20022.Sese040001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese040001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese040001.PartyIdentification257Choice *-- ISO20022.Sese040001.NameAndAddress5
    class ISO20022.Sese040001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese040001.PartyIdentification257Choice
    }
    ISO20022.Sese040001.PartyIdentification314 *-- ISO20022.Sese040001.PartyIdentification257Choice
    class ISO20022.Sese040001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese040001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese040001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Sese040001.PartyIdentification120Choice
    }
    ISO20022.Sese040001.PartyIdentificationAndAccount195 *-- ISO20022.Sese040001.BlockChainAddressWallet3
    ISO20022.Sese040001.PartyIdentificationAndAccount195 *-- ISO20022.Sese040001.SecuritiesAccount19
    ISO20022.Sese040001.PartyIdentificationAndAccount195 *-- ISO20022.Sese040001.PartyIdentification120Choice
    class ISO20022.Sese040001.PendingStatus20Choice {
        + UdrInvstgtn  : ISO20022.Sese040001.NoSpecifiedReason1
        + Fwdd  : ISO20022.Sese040001.NoSpecifiedReason1
    }
    ISO20022.Sese040001.PendingStatus20Choice *-- ISO20022.Sese040001.NoSpecifiedReason1
    ISO20022.Sese040001.PendingStatus20Choice *-- ISO20022.Sese040001.NoSpecifiedReason1
    class ISO20022.Sese040001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese040001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Sese040001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Sese040001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese040001.Quantity51Choice *-- ISO20022.Sese040001.OriginalAndCurrentQuantities1
    ISO20022.Sese040001.Quantity51Choice *-- ISO20022.Sese040001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese040001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese040001.RejectionReason29 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese040001.ConsentOrRejectionReason4Choice
    }
    ISO20022.Sese040001.RejectionReason29 *-- ISO20022.Sese040001.ConsentOrRejectionReason4Choice
    class ISO20022.Sese040001.RejectionStatus20Choice {
        + Rsn  : ISO20022.Sese040001.RejectionReason29
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese040001.RejectionStatus20Choice *-- ISO20022.Sese040001.RejectionReason29
    class ISO20022.Sese040001.ResponseStatus6Choice {
        + Pdg  : ISO20022.Sese040001.PendingStatus20Choice
        + Rjctd  : ISO20022.Sese040001.RejectionStatus20Choice
        + Cnsntd  : ISO20022.Sese040001.ConsentStatus4Choice
    }
    ISO20022.Sese040001.ResponseStatus6Choice *-- ISO20022.Sese040001.PendingStatus20Choice
    ISO20022.Sese040001.ResponseStatus6Choice *-- ISO20022.Sese040001.RejectionStatus20Choice
    ISO20022.Sese040001.ResponseStatus6Choice *-- ISO20022.Sese040001.ConsentStatus4Choice
    class ISO20022.Sese040001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese040001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese040001.SecuritiesAccount19 *-- ISO20022.Sese040001.GenericIdentification30
    class ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese040001.SupplementaryData1~
        + TxDtls  : ISO20022.Sese040001.TransactionDetails173
        + RspnSts  : ISO20022.Sese040001.ResponseStatus6Choice
        + TxId  : ISO20022.Sese040001.TransactionIdentification6
    }
    ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05 *-- ISO20022.Sese040001.SupplementaryData1
    ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05 *-- ISO20022.Sese040001.TransactionDetails173
    ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05 *-- ISO20022.Sese040001.ResponseStatus6Choice
    ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05 *-- ISO20022.Sese040001.TransactionIdentification6
    class ISO20022.Sese040001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese040001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese040001.SecurityIdentification19 *-- ISO20022.Sese040001.OtherIdentification1
    class ISO20022.Sese040001.SettlementDate19Choice {
        + DtCd  : ISO20022.Sese040001.SettlementDateCode8Choice
        + Dt  : ISO20022.Sese040001.DateAndDateTime2Choice
    }
    ISO20022.Sese040001.SettlementDate19Choice *-- ISO20022.Sese040001.SettlementDateCode8Choice
    ISO20022.Sese040001.SettlementDate19Choice *-- ISO20022.Sese040001.DateAndDateTime2Choice
    class ISO20022.Sese040001.SettlementDateCode8Choice {
        + Prtry  : ISO20022.Sese040001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese040001.SettlementDateCode8Choice *-- ISO20022.Sese040001.GenericIdentification30
    class ISO20022.Sese040001.SettlementParties125 {
        + Pty5  : ISO20022.Sese040001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Sese040001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Sese040001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Sese040001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Sese040001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Sese040001.PartyIdentification314
    }
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentificationAndAccount195
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentificationAndAccount195
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentificationAndAccount195
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentificationAndAccount195
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentificationAndAccount195
    ISO20022.Sese040001.SettlementParties125 *-- ISO20022.Sese040001.PartyIdentification314
    class ISO20022.Sese040001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese040001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese040001.SupplementaryData1 *-- ISO20022.Sese040001.SupplementaryDataEnvelope1
    class ISO20022.Sese040001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese040001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese040001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese040001.DateAndDateTime2Choice
    }
    ISO20022.Sese040001.TradeDate8Choice *-- ISO20022.Sese040001.TradeDateCode3Choice
    ISO20022.Sese040001.TradeDate8Choice *-- ISO20022.Sese040001.DateAndDateTime2Choice
    class ISO20022.Sese040001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese040001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese040001.TradeDateCode3Choice *-- ISO20022.Sese040001.GenericIdentification30
    class ISO20022.Sese040001.TransactionDetails173 {
        + Invstr  : ISO20022.Sese040001.PartyIdentification149
        + RcvgSttlmPties  : ISO20022.Sese040001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Sese040001.SettlementParties125
        + TradDt  : ISO20022.Sese040001.TradeDate8Choice
        + SttlmDt  : ISO20022.Sese040001.SettlementDate19Choice
        + SttlmAmt  : ISO20022.Sese040001.AmountAndDirection51
        + BlckChainAdrOrWllt  : ISO20022.Sese040001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese040001.SecuritiesAccount19
        + SttlmQty  : ISO20022.Sese040001.Quantity51Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + FinInstrmId  : ISO20022.Sese040001.SecurityIdentification19
    }
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.PartyIdentification149
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.SettlementParties125
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.SettlementParties125
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.TradeDate8Choice
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.SettlementDate19Choice
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.AmountAndDirection51
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.BlockChainAddressWallet3
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.SecuritiesAccount19
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.Quantity51Choice
    ISO20022.Sese040001.TransactionDetails173 *-- ISO20022.Sese040001.SecurityIdentification19
    class ISO20022.Sese040001.TransactionIdentification6 {
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

## Value ISO20022.Sese040001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese040001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese040001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese040001.AmountAndDirection51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese040001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese040001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese040001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese040001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese040001.ConsentOrRejectionReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040001.ConsentReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese040001.ConsentOrRejectionReason4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese040001.ConsentStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese040001.ConsentReason4>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese040001.CounterpartyResponseStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CPMD|Int32||XmlEnum("""CPMD""")|1|
||CPCX|Int32||XmlEnum("""CPCX""")|2|
||CPTR|Int32||XmlEnum("""CPTR""")|3|

---

## Enum ISO20022.Sese040001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese040001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese040001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese040001.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese040001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese040001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxCtrPtyRspn|ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxCtrPtyRspn))|

---

## Value ISO20022.Sese040001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese040001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese040001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese040001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese040001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese040001.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese040001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese040001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese040001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese040001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese040001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese040001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese040001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese040001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese040001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese040001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese040001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese040001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese040001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese040001.PendingStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UdrInvstgtn|ISO20022.Sese040001.NoSpecifiedReason1||XmlElement()||
|+|Fwdd|ISO20022.Sese040001.NoSpecifiedReason1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrInvstgtn),validElement(Fwdd),validChoice(UdrInvstgtn,Fwdd))|

---

## Value ISO20022.Sese040001.PostalAddress1


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

## Value ISO20022.Sese040001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese040001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Sese040001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese040001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese040001.RejectionReason29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese040001.ConsentOrRejectionReason4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese040001.RejectionStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|ISO20022.Sese040001.RejectionReason29||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese040001.ResponseStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pdg|ISO20022.Sese040001.PendingStatus20Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese040001.RejectionStatus20Choice||XmlElement()||
|+|Cnsntd|ISO20022.Sese040001.ConsentStatus4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pdg),validElement(Rjctd),validElement(Cnsntd),validChoice(Pdg,Rjctd,Cnsntd))|

---

## Value ISO20022.Sese040001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese040001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Sese040001.SecuritiesSettlementTransactionCounterpartyResponseV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese040001.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese040001.TransactionDetails173||XmlElement()||
|+|RspnSts|ISO20022.Sese040001.ResponseStatus6Choice||XmlElement()||
|+|TxId|ISO20022.Sese040001.TransactionIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(RspnSts),validElement(TxId))|

---

## Value ISO20022.Sese040001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese040001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese040001.SettlementDate19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese040001.SettlementDateCode8Choice||XmlElement()||
|+|Dt|ISO20022.Sese040001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese040001.SettlementDateCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese040001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Sese040001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Sese040001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Sese040001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Sese040001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Sese040001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese040001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese040001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese040001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese040001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese040001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese040001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese040001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese040001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese040001.TransactionDetails173


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese040001.PartyIdentification149||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese040001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese040001.SettlementParties125||XmlElement()||
|+|TradDt|ISO20022.Sese040001.TradeDate8Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese040001.SettlementDate19Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese040001.AmountAndDirection51||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese040001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese040001.SecuritiesAccount19||XmlElement()||
|+|SttlmQty|ISO20022.Sese040001.Quantity51Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|FinInstrmId|ISO20022.Sese040001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(TradDt),validElement(SttlmDt),validElement(SttlmAmt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(SttlmQty),validElement(FinInstrmId))|

---

## Value ISO20022.Sese040001.TransactionIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
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

