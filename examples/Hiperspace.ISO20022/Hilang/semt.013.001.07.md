# semt.013.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt013001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt013001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Semt013001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt013001.BlockChainAddressWallet3 *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Semt013001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt013001.ClassificationType32Choice *-- ISO20022.Semt013001.GenericIdentification36
    class ISO20022.Semt013001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt013001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Semt013001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Semt013001.DocumentNumber5Choice *-- ISO20022.Semt013001.GenericIdentification36
    class ISO20022.Semt013001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt013001.FinancialInstrumentAttributes112 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt013001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Semt013001.Price7
        + ConvsPric  : ISO20022.Semt013001.Price7
        + SbcptPric  : ISO20022.Semt013001.Price7
        + ExrcPric  : ISO20022.Semt013001.Price7
        + MktOrIndctvPric  : ISO20022.Semt013001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt013001.QuantityBreakdown60~
        + PoolNb  : ISO20022.Semt013001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Semt013001.Number22Choice
        + IndxRateBsis  : Decimal
        + NxtIntrstRate  : Decimal
        + YldToMtrtyRate  : Decimal
        + IntrstRate  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + PrvsFctr  : Decimal
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + CpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnTp  : ISO20022.Semt013001.OptionType6Choice
        + OptnStyle  : ISO20022.Semt013001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Semt013001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Semt013001.Frequency23Choice
        + PmtSts  : ISO20022.Semt013001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Semt013001.Frequency23Choice
        + RegnForm  : ISO20022.Semt013001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Semt013001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Semt013001.MarketIdentification3Choice
    }
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.SecurityIdentification19
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Price7
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Price7
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Price7
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Price7
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.PriceType4Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.QuantityBreakdown60
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.GenericIdentification37
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Number22Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.OptionType6Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.OptionStyle8Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.ClassificationType32Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Frequency23Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.SecuritiesPaymentStatus5Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.Frequency23Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.FormOfSecurity6Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.InterestComputationMethodFormat4Choice
    ISO20022.Semt013001.FinancialInstrumentAttributes112 *-- ISO20022.Semt013001.MarketIdentification3Choice
    class ISO20022.Semt013001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt013001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt013001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.FormOfSecurity6Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.Frequency23Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.Frequency23Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt013001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Semt013001.GenericIdentification30
    }
    ISO20022.Semt013001.GenericIdentification78 *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt013001.InterestComputationMethod2Code {
        NARR = 1
        A014 = 2
        A013 = 3
        A012 = 4
        A011 = 5
        A010 = 6
        A009 = 7
        A008 = 8
        A007 = 9
        A006 = 10
        A005 = 11
        A004 = 12
        A003 = 13
        A002 = 14
        A001 = 15
    }
    class ISO20022.Semt013001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.InterestComputationMethodFormat4Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.IntraPositionDetails58 {
        + InstrPrcgAddtlDtls  : String
        + BalTo  : ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5
        + BalFr  : ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5
        + SttlmDt  : ISO20022.Semt013001.DateAndDateTime2Choice
        + SctiesSubBalId  : ISO20022.Semt013001.GenericIdentification37
        + SttlmQty  : ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
        + Prty  : ISO20022.Semt013001.PriorityNumeric4Choice
    }
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.DateAndDateTime2Choice
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.GenericIdentification37
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt013001.IntraPositionDetails58 *-- ISO20022.Semt013001.PriorityNumeric4Choice
    class ISO20022.Semt013001.IntraPositionMovementInstructionV07 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt013001.SupplementaryData1~
        + IntraPosDtls  : ISO20022.Semt013001.IntraPositionDetails58
        + FinInstrmAttrbts  : ISO20022.Semt013001.FinancialInstrumentAttributes112
        + FinInstrmId  : ISO20022.Semt013001.SecurityIdentification19
        + SfkpgPlc  : ISO20022.Semt013001.SafekeepingPlaceFormat41Choice
        + BlckChainAdrOrWllt  : ISO20022.Semt013001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt013001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Semt013001.PartyIdentification127Choice
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Semt013001.Linkages59~
        + NbCounts  : ISO20022.Semt013001.NumberCount1Choice
        + CorpActnEvtId  : String
        + TxId  : String
    }
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.SupplementaryData1
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.IntraPositionDetails58
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.FinancialInstrumentAttributes112
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.SecurityIdentification19
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.SafekeepingPlaceFormat41Choice
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.BlockChainAddressWallet3
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.SecuritiesAccount19
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.PartyIdentification127Choice
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.Linkages59
    ISO20022.Semt013001.IntraPositionMovementInstructionV07 *-- ISO20022.Semt013001.NumberCount1Choice
    class ISO20022.Semt013001.Linkages59 {
        + RefOwnr  : ISO20022.Semt013001.PartyIdentification127Choice
        + Ref  : ISO20022.Semt013001.References41Choice
        + MsgNb  : ISO20022.Semt013001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Semt013001.ProcessingPosition7Choice
    }
    ISO20022.Semt013001.Linkages59 *-- ISO20022.Semt013001.PartyIdentification127Choice
    ISO20022.Semt013001.Linkages59 *-- ISO20022.Semt013001.References41Choice
    ISO20022.Semt013001.Linkages59 *-- ISO20022.Semt013001.DocumentNumber5Choice
    ISO20022.Semt013001.Linkages59 *-- ISO20022.Semt013001.ProcessingPosition7Choice
    class ISO20022.Semt013001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt013001.Number22Choice {
        + Lng  : ISO20022.Semt013001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Semt013001.Number22Choice *-- ISO20022.Semt013001.GenericIdentification1
    class ISO20022.Semt013001.NumberCount1Choice {
        + TtlNb  : ISO20022.Semt013001.TotalNumber1
        + CurInstrNb  : String
    }
    ISO20022.Semt013001.NumberCount1Choice *-- ISO20022.Semt013001.TotalNumber1
    class ISO20022.Semt013001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt013001.OptionStyle8Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.OptionStyle8Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt013001.OptionType6Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.OptionType6Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.OtherIdentification1 {
        + Tp  : ISO20022.Semt013001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt013001.OtherIdentification1 *-- ISO20022.Semt013001.IdentificationSource3Choice
    class ISO20022.Semt013001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt013001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt013001.PartyIdentification127Choice *-- ISO20022.Semt013001.GenericIdentification36
    class ISO20022.Semt013001.Price7 {
        + Val  : ISO20022.Semt013001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Semt013001.YieldedOrValueType1Choice
    }
    ISO20022.Semt013001.Price7 *-- ISO20022.Semt013001.PriceRateOrAmount3Choice
    ISO20022.Semt013001.Price7 *-- ISO20022.Semt013001.YieldedOrValueType1Choice
    class ISO20022.Semt013001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Semt013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt013001.PriceRateOrAmount3Choice *-- ISO20022.Semt013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt013001.PriceType4Choice {
        + Indctv  : ISO20022.Semt013001.Price7
        + Mkt  : ISO20022.Semt013001.Price7
    }
    ISO20022.Semt013001.PriceType4Choice *-- ISO20022.Semt013001.Price7
    ISO20022.Semt013001.PriceType4Choice *-- ISO20022.Semt013001.Price7
    class ISO20022.Semt013001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt013001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Semt013001.PriorityNumeric4Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Semt013001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.ProcessingPosition7Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.QuantityBreakdown60 {
        + LotQty  : ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Semt013001.GenericIdentification37
    }
    ISO20022.Semt013001.QuantityBreakdown60 *-- ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt013001.QuantityBreakdown60 *-- ISO20022.Semt013001.GenericIdentification37
    class ISO20022.Semt013001.QuantityBreakdown61 {
        + SctiesSubBalTp  : ISO20022.Semt013001.GenericIdentification30
        + LotQty  : ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Semt013001.GenericIdentification37
    }
    ISO20022.Semt013001.QuantityBreakdown61 *-- ISO20022.Semt013001.GenericIdentification30
    ISO20022.Semt013001.QuantityBreakdown61 *-- ISO20022.Semt013001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt013001.QuantityBreakdown61 *-- ISO20022.Semt013001.GenericIdentification37
    class ISO20022.Semt013001.References41Choice {
        + OthrTxId  : String
        + PoolId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Semt013001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt013001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt013001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification78
        + TpAndId  : ISO20022.Semt013001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Semt013001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Semt013001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt013001.GenericIdentification78
    ISO20022.Semt013001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt013001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt013001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt013001.SafekeepingPlaceTypeAndText8
    class ISO20022.Semt013001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt013001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt013001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Semt013001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt013001.SecuritiesAccount19 *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.SecuritiesBalanceType11Code {
        LODE = 1
        QUAS = 2
        ISSU = 3
        UNRG = 4
        SPOS = 5
        NOMI = 6
        DIRT = 7
        CLEN = 8
        DRAW = 9
        TRAN = 10
        OTHR = 11
        RSTR = 12
        REGO = 13
        PLED = 14
        PEDA = 15
        PECA = 16
        MARG = 17
        LOAN = 18
        COLA = 19
        COLO = 20
        COLI = 21
        BORR = 22
        BLOV = 23
        BLOT = 24
        BLCA = 25
        AVAI = 26
        AWAS = 27
        BLOK = 28
    }
    class ISO20022.Semt013001.SecuritiesBalanceType6Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.SecuritiesBalanceType6Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt013001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Semt013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt013001.SecuritiesPaymentStatus5Choice *-- ISO20022.Semt013001.GenericIdentification30
    class ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt013001.QuantityBreakdown61~
        + Tp  : ISO20022.Semt013001.SecuritiesBalanceType6Choice
    }
    ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5 *-- ISO20022.Semt013001.QuantityBreakdown61
    ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5 *-- ISO20022.Semt013001.SecuritiesBalanceType6Choice
    class ISO20022.Semt013001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt013001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt013001.SecurityIdentification19 *-- ISO20022.Semt013001.OtherIdentification1
    class ISO20022.Semt013001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt013001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt013001.SupplementaryData1 *-- ISO20022.Semt013001.SupplementaryDataEnvelope1
    class ISO20022.Semt013001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt013001.TotalNumber1 {
        + TtlOfLkdInstrs  : String
        + CurInstrNb  : String
    }
    class ISO20022.Semt013001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
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

## Value ISO20022.Semt013001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt013001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt013001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt013001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Semt013001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Semt013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntInstr|ISO20022.Semt013001.IntraPositionMovementInstructionV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraPosMvmntInstr))|

---

## Value ISO20022.Semt013001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Semt013001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Semt013001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Semt013001.FinancialInstrumentAttributes112


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt013001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Semt013001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt013001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt013001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Semt013001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Semt013001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Semt013001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt013001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt013001.QuantityBreakdown60>||XmlElement()||
|+|PoolNb|ISO20022.Semt013001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt013001.Number22Choice||XmlElement()||
|+|IndxRateBsis|Decimal||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|YldToMtrtyRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|CpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnTp|ISO20022.Semt013001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt013001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt013001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt013001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt013001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt013001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt013001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt013001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt013001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt013001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Semt013001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt013001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt013001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt013001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013001.InterestComputationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NARR|Int32||XmlEnum("""NARR""")|1|
||A014|Int32||XmlEnum("""A014""")|2|
||A013|Int32||XmlEnum("""A013""")|3|
||A012|Int32||XmlEnum("""A012""")|4|
||A011|Int32||XmlEnum("""A011""")|5|
||A010|Int32||XmlEnum("""A010""")|6|
||A009|Int32||XmlEnum("""A009""")|7|
||A008|Int32||XmlEnum("""A008""")|8|
||A007|Int32||XmlEnum("""A007""")|9|
||A006|Int32||XmlEnum("""A006""")|10|
||A005|Int32||XmlEnum("""A005""")|11|
||A004|Int32||XmlEnum("""A004""")|12|
||A003|Int32||XmlEnum("""A003""")|13|
||A002|Int32||XmlEnum("""A002""")|14|
||A001|Int32||XmlEnum("""A001""")|15|

---

## Value ISO20022.Semt013001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.IntraPositionDetails58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|BalTo|ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5||XmlElement()||
|+|BalFr|ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5||XmlElement()||
|+|SttlmDt|ISO20022.Semt013001.DateAndDateTime2Choice||XmlElement()||
|+|SctiesSubBalId|ISO20022.Semt013001.GenericIdentification37||XmlElement()||
|+|SttlmQty|ISO20022.Semt013001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Prty|ISO20022.Semt013001.PriorityNumeric4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BalTo),validElement(BalFr),validElement(SttlmDt),validElement(SctiesSubBalId),validElement(SttlmQty),validElement(Prty))|

---

## Aspect ISO20022.Semt013001.IntraPositionMovementInstructionV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt013001.SupplementaryData1>||XmlElement()||
|+|IntraPosDtls|ISO20022.Semt013001.IntraPositionDetails58||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt013001.FinancialInstrumentAttributes112||XmlElement()||
|+|FinInstrmId|ISO20022.Semt013001.SecurityIdentification19||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt013001.SafekeepingPlaceFormat41Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt013001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt013001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Semt013001.PartyIdentification127Choice||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Semt013001.Linkages59>||XmlElement()||
|+|NbCounts|ISO20022.Semt013001.NumberCount1Choice||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(IntraPosDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(NbCounts))|

---

## Value ISO20022.Semt013001.Linkages59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Semt013001.PartyIdentification127Choice||XmlElement()||
|+|Ref|ISO20022.Semt013001.References41Choice||XmlElement()||
|+|MsgNb|ISO20022.Semt013001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Semt013001.ProcessingPosition7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Value ISO20022.Semt013001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt013001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt013001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt013001.NumberCount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNb|ISO20022.Semt013001.TotalNumber1||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNb),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""),validChoice(TtlNb,CurInstrNb))|

---

## Enum ISO20022.Semt013001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt013001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt013001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt013001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt013001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt013001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt013001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt013001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Semt013001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt013001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt013001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt013001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt013001.Price7||XmlElement()||
|+|Mkt|ISO20022.Semt013001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt013001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt013001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Enum ISO20022.Semt013001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Semt013001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.QuantityBreakdown60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotQty|ISO20022.Semt013001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Semt013001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt013001.QuantityBreakdown61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSubBalTp|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|LotQty|ISO20022.Semt013001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Semt013001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSubBalTp),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt013001.References41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,PoolId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Enum ISO20022.Semt013001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt013001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt013001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Semt013001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt013001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Semt013001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt013001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt013001.SecuritiesBalanceType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LODE|Int32||XmlEnum("""LODE""")|1|
||QUAS|Int32||XmlEnum("""QUAS""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||UNRG|Int32||XmlEnum("""UNRG""")|4|
||SPOS|Int32||XmlEnum("""SPOS""")|5|
||NOMI|Int32||XmlEnum("""NOMI""")|6|
||DIRT|Int32||XmlEnum("""DIRT""")|7|
||CLEN|Int32||XmlEnum("""CLEN""")|8|
||DRAW|Int32||XmlEnum("""DRAW""")|9|
||TRAN|Int32||XmlEnum("""TRAN""")|10|
||OTHR|Int32||XmlEnum("""OTHR""")|11|
||RSTR|Int32||XmlEnum("""RSTR""")|12|
||REGO|Int32||XmlEnum("""REGO""")|13|
||PLED|Int32||XmlEnum("""PLED""")|14|
||PEDA|Int32||XmlEnum("""PEDA""")|15|
||PECA|Int32||XmlEnum("""PECA""")|16|
||MARG|Int32||XmlEnum("""MARG""")|17|
||LOAN|Int32||XmlEnum("""LOAN""")|18|
||COLA|Int32||XmlEnum("""COLA""")|19|
||COLO|Int32||XmlEnum("""COLO""")|20|
||COLI|Int32||XmlEnum("""COLI""")|21|
||BORR|Int32||XmlEnum("""BORR""")|22|
||BLOV|Int32||XmlEnum("""BLOV""")|23|
||BLOT|Int32||XmlEnum("""BLOT""")|24|
||BLCA|Int32||XmlEnum("""BLCA""")|25|
||AVAI|Int32||XmlEnum("""AVAI""")|26|
||AWAS|Int32||XmlEnum("""AWAS""")|27|
||BLOK|Int32||XmlEnum("""BLOK""")|28|

---

## Value ISO20022.Semt013001.SecuritiesBalanceType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt013001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013001.SecuritiesSubBalanceTypeAndQuantityBreakdown5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt013001.QuantityBreakdown61>||XmlElement()||
|+|Tp|ISO20022.Semt013001.SecuritiesBalanceType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Value ISO20022.Semt013001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt013001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt013001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt013001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt013001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013001.TotalNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlOfLkdInstrs|String||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TtlOfLkdInstrs""",TtlOfLkdInstrs,"""[0-9]{3}"""),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Semt013001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

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

