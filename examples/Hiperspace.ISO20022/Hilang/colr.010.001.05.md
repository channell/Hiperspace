# colr.010.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr010001.AccountIdentification4Choice {
        + Othr  : ISO20022.Colr010001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Colr010001.AccountIdentification4Choice *-- ISO20022.Colr010001.GenericAccountIdentification1
    class ISO20022.Colr010001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr010001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr010001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr010001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Colr010001.Agreement4 {
        + AgrmtFrmwk  : ISO20022.Colr010001.AgreementFramework1Choice
        + BaseCcy  : String
        + AgrmtDt  : DateTime
        + AgrmtId  : String
        + AgrmtDtls  : String
    }
    ISO20022.Colr010001.Agreement4 *-- ISO20022.Colr010001.AgreementFramework1Choice
    class ISO20022.Colr010001.AgreementFramework1Choice {
        + PrtryId  : ISO20022.Colr010001.GenericIdentification30
        + AgrmtFrmwk  : String
    }
    ISO20022.Colr010001.AgreementFramework1Choice *-- ISO20022.Colr010001.GenericIdentification30
    class ISO20022.Colr010001.AgreementFramework1Code {
        NONR = 1
        ISDA = 2
        DERV = 3
        BBAA = 4
        FBAA = 5
    }
    class ISO20022.Colr010001.AlternatePartyIdentification8 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Colr010001.IdentificationType43Choice
    }
    ISO20022.Colr010001.AlternatePartyIdentification8 *-- ISO20022.Colr010001.IdentificationType43Choice
    class ISO20022.Colr010001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Colr010001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr010001.BlockChainAddressWallet3 *-- ISO20022.Colr010001.GenericIdentification30
    class ISO20022.Colr010001.BlockChainAddressWallet5 {
        + Nm  : String
        + Tp  : ISO20022.Colr010001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr010001.BlockChainAddressWallet5 *-- ISO20022.Colr010001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr010001.CashCollateral3 {
        + Hrcut  : Decimal
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + MtrtyDt  : DateTime
        + DpstTp  : String
        + DpstAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + CshAcctId  : ISO20022.Colr010001.AccountIdentification4Choice
        + CollId  : String
    }
    ISO20022.Colr010001.CashCollateral3 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.CashCollateral3 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.CashCollateral3 *-- ISO20022.Colr010001.AccountIdentification4Choice
    class ISO20022.Colr010001.CashCollateral5 {
        + Hrcut  : Decimal
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + MtrtyDt  : DateTime
        + DpstTp  : String
        + DpstAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + AsstNb  : String
        + CshAcctId  : ISO20022.Colr010001.AccountIdentification4Choice
        + CollId  : String
    }
    ISO20022.Colr010001.CashCollateral5 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.CashCollateral5 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.CashCollateral5 *-- ISO20022.Colr010001.AccountIdentification4Choice
    class ISO20022.Colr010001.CollateralAccount3 {
        + Nm  : String
        + Tp  : ISO20022.Colr010001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr010001.CollateralAccount3 *-- ISO20022.Colr010001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr010001.CollateralAccountIdentificationType3Choice {
        + Prtry  : ISO20022.Colr010001.GenericIdentification36
        + Tp  : String
    }
    ISO20022.Colr010001.CollateralAccountIdentificationType3Choice *-- ISO20022.Colr010001.GenericIdentification36
    class ISO20022.Colr010001.CollateralAccountType1Code {
        DFLT = 1
        MGIN = 2
        LIPR = 3
        CLIE = 4
        HOUS = 5
    }
    class ISO20022.Colr010001.CollateralOwnership4 {
        + ClntNm  : ISO20022.Colr010001.PartyIdentification178Choice
        + Prtry  : String
    }
    ISO20022.Colr010001.CollateralOwnership4 *-- ISO20022.Colr010001.PartyIdentification178Choice
    class ISO20022.Colr010001.CollateralSubstitution7 {
        + LkdRefs  : ISO20022.Colr010001.Reference17
        + OthrColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.OtherCollateral11~
        + CshColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.CashCollateral5~
        + SctiesColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.SecuritiesCollateral11~
        + StdSttlmInstrs  : String
        + CollSbstitnTp  : String
        + SbstitnRqrmnt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + CollSbstitnSeq  : String
    }
    ISO20022.Colr010001.CollateralSubstitution7 *-- ISO20022.Colr010001.Reference17
    ISO20022.Colr010001.CollateralSubstitution7 *-- ISO20022.Colr010001.OtherCollateral11
    ISO20022.Colr010001.CollateralSubstitution7 *-- ISO20022.Colr010001.CashCollateral5
    ISO20022.Colr010001.CollateralSubstitution7 *-- ISO20022.Colr010001.SecuritiesCollateral11
    ISO20022.Colr010001.CollateralSubstitution7 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    class ISO20022.Colr010001.CollateralSubstitution8 {
        + LkdRefs  : ISO20022.Colr010001.Reference17
        + OthrColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.OtherCollateral9~
        + CshColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.CashCollateral3~
        + SctiesColl  : global::System.Collections.Generic.List~ISO20022.Colr010001.SecuritiesCollateral12~
        + StdSttlmInstrs  : String
        + CollSbstitnTp  : String
        + SbstitnRqrmnt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + CollSbstitnSeq  : String
    }
    ISO20022.Colr010001.CollateralSubstitution8 *-- ISO20022.Colr010001.Reference17
    ISO20022.Colr010001.CollateralSubstitution8 *-- ISO20022.Colr010001.OtherCollateral9
    ISO20022.Colr010001.CollateralSubstitution8 *-- ISO20022.Colr010001.CashCollateral3
    ISO20022.Colr010001.CollateralSubstitution8 *-- ISO20022.Colr010001.SecuritiesCollateral12
    ISO20022.Colr010001.CollateralSubstitution8 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    class ISO20022.Colr010001.CollateralSubstitutionRequestV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr010001.SupplementaryData1~
        + CollSbstitnDlvr  : ISO20022.Colr010001.CollateralSubstitution8
        + CollSbstitnRtr  : ISO20022.Colr010001.CollateralSubstitution7
        + Agrmt  : ISO20022.Colr010001.Agreement4
        + Oblgtn  : ISO20022.Colr010001.Obligation9
        + TxId  : String
    }
    ISO20022.Colr010001.CollateralSubstitutionRequestV05 *-- ISO20022.Colr010001.SupplementaryData1
    ISO20022.Colr010001.CollateralSubstitutionRequestV05 *-- ISO20022.Colr010001.CollateralSubstitution8
    ISO20022.Colr010001.CollateralSubstitutionRequestV05 *-- ISO20022.Colr010001.CollateralSubstitution7
    ISO20022.Colr010001.CollateralSubstitutionRequestV05 *-- ISO20022.Colr010001.Agreement4
    ISO20022.Colr010001.CollateralSubstitutionRequestV05 *-- ISO20022.Colr010001.Obligation9
    class ISO20022.Colr010001.CollateralSubstitutionSequence1Code {
        UPDD = 1
        INIT = 2
    }
    class ISO20022.Colr010001.CollateralSubstitutionType1Code {
        ASIA = 1
        AVMG = 2
    }
    class ISO20022.Colr010001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Colr010001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr010001.DateCode9Choice {
        + Prtry  : ISO20022.Colr010001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr010001.DateCode9Choice *-- ISO20022.Colr010001.GenericIdentification30
    class ISO20022.Colr010001.DateFormat14Choice {
        + DtCd  : ISO20022.Colr010001.DateCode9Choice
        + Dt  : DateTime
    }
    ISO20022.Colr010001.DateFormat14Choice *-- ISO20022.Colr010001.DateCode9Choice
    class ISO20022.Colr010001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Colr010001.DeliveringPartiesAndAccount19 {
        + Pty2  : ISO20022.Colr010001.PartyIdentificationAndAccount201
        + Pty1  : ISO20022.Colr010001.PartyIdentificationAndAccount200
        + Dpstry  : ISO20022.Colr010001.PartyIdentification239Choice
    }
    ISO20022.Colr010001.DeliveringPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentificationAndAccount201
    ISO20022.Colr010001.DeliveringPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentificationAndAccount200
    ISO20022.Colr010001.DeliveringPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentification239Choice
    class ISO20022.Colr010001.DepositType1Code {
        CALL = 1
        FITE = 2
    }
    class ISO20022.Colr010001.ExposureType11Code {
        SHSL = 1
        REPO = 2
        TRBD = 3
        EQUI = 4
        CCPC = 5
        UDMS = 6
        TRCP = 7
        TBAS = 8
        SWPT = 9
        SCIE = 10
        SCIR = 11
        SLEB = 12
        SCRP = 13
        SBSC = 14
        SLOA = 15
        RVPO = 16
        OTCD = 17
        LIQU = 18
        OPTN = 19
        FUTR = 20
        FORW = 21
        FORX = 22
        FIXI = 23
        EXPT = 24
        EXTD = 25
        EQUS = 26
        EQPT = 27
        CRPR = 28
        CCIR = 29
        CRSP = 30
        CRTL = 31
        CRDS = 32
        COMM = 33
        CBCO = 34
        PAYM = 35
        BFWD = 36
    }
    class ISO20022.Colr010001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr010001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Colr010001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Colr010001.GenericAccountIdentification1 *-- ISO20022.Colr010001.AccountSchemeName1Choice
    class ISO20022.Colr010001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr010001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr010001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Colr010001.GenericIdentification30
    }
    ISO20022.Colr010001.GenericIdentification78 *-- ISO20022.Colr010001.GenericIdentification30
    class ISO20022.Colr010001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr010001.IdentificationType43Choice {
        + Prtry  : ISO20022.Colr010001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Colr010001.IdentificationType43Choice *-- ISO20022.Colr010001.GenericIdentification36
    class ISO20022.Colr010001.NameAndAddress13 {
        + Adr  : ISO20022.Colr010001.PostalAddress8
        + Nm  : String
    }
    ISO20022.Colr010001.NameAndAddress13 *-- ISO20022.Colr010001.PostalAddress8
    class ISO20022.Colr010001.NameAndAddress5 {
        + Adr  : ISO20022.Colr010001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Colr010001.NameAndAddress5 *-- ISO20022.Colr010001.PostalAddress1
    class ISO20022.Colr010001.NameAndAddress6 {
        + Adr  : ISO20022.Colr010001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Colr010001.NameAndAddress6 *-- ISO20022.Colr010001.PostalAddress2
    class ISO20022.Colr010001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Colr010001.Obligation9 {
        + ValtnDt  : ISO20022.Colr010001.DateAndDateTime2Choice
        + XpsrTp  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr010001.BlockChainAddressWallet5
        + CollAcctId  : ISO20022.Colr010001.CollateralAccount3
        + SvcgPtyB  : ISO20022.Colr010001.PartyIdentification178Choice
        + PtyB  : ISO20022.Colr010001.PartyIdentification178Choice
        + SvcgPtyA  : ISO20022.Colr010001.PartyIdentification178Choice
        + PtyA  : ISO20022.Colr010001.PartyIdentification178Choice
    }
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.DateAndDateTime2Choice
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.BlockChainAddressWallet5
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.CollateralAccount3
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.PartyIdentification178Choice
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.PartyIdentification178Choice
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.PartyIdentification178Choice
    ISO20022.Colr010001.Obligation9 *-- ISO20022.Colr010001.PartyIdentification178Choice
    class ISO20022.Colr010001.OtherCollateral11 {
        + BlckChainAdrOrWllt  : ISO20022.Colr010001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr010001.SecuritiesAccount19
        + SfkpgPlc  : ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + Issr  : ISO20022.Colr010001.PartyIdentification178Choice
        + LtdCvrgInd  : String
        + XpryDt  : ISO20022.Colr010001.DateFormat14Choice
        + IsseDt  : ISO20022.Colr010001.DateFormat14Choice
        + OthrTpOfColl  : ISO20022.Colr010001.OtherTypeOfCollateral3
        + GrntAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + LttrOfCdtAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + LttrOfCdtId  : String
        + AsstNb  : String
        + CollId  : String
    }
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.BlockChainAddressWallet3
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.SecuritiesAccount19
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.PartyIdentification178Choice
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.DateFormat14Choice
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.DateFormat14Choice
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.OtherTypeOfCollateral3
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    class ISO20022.Colr010001.OtherCollateral9 {
        + BlckChainAdrOrWllt  : ISO20022.Colr010001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr010001.SecuritiesAccount19
        + SfkpgPlc  : ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + Issr  : ISO20022.Colr010001.PartyIdentification178Choice
        + LtdCvrgInd  : String
        + XpryDt  : ISO20022.Colr010001.DateFormat14Choice
        + IsseDt  : ISO20022.Colr010001.DateFormat14Choice
        + OthrTpOfColl  : ISO20022.Colr010001.OtherTypeOfCollateral3
        + GrntAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + LttrOfCdtAmt  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + LttrOfCdtId  : String
        + CollId  : String
    }
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.BlockChainAddressWallet3
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.SecuritiesAccount19
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.PartyIdentification178Choice
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.DateFormat14Choice
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.DateFormat14Choice
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.OtherTypeOfCollateral3
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.OtherCollateral9 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    class ISO20022.Colr010001.OtherIdentification1 {
        + Tp  : ISO20022.Colr010001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr010001.OtherIdentification1 *-- ISO20022.Colr010001.IdentificationSource3Choice
    class ISO20022.Colr010001.OtherTypeOfCollateral3 {
        + Qty  : ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
        + Desc  : String
    }
    ISO20022.Colr010001.OtherTypeOfCollateral3 *-- ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
    class ISO20022.Colr010001.PartyIdentification178Choice {
        + NmAndAdr  : ISO20022.Colr010001.NameAndAddress6
        + PrtryId  : ISO20022.Colr010001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr010001.PartyIdentification178Choice *-- ISO20022.Colr010001.NameAndAddress6
    ISO20022.Colr010001.PartyIdentification178Choice *-- ISO20022.Colr010001.GenericIdentification36
    class ISO20022.Colr010001.PartyIdentification239Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Colr010001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Colr010001.PartyIdentification239Choice *-- ISO20022.Colr010001.NameAndAddress5
    class ISO20022.Colr010001.PartyIdentification240Choice {
        + NmAndAdr  : ISO20022.Colr010001.NameAndAddress13
        + PrtryId  : ISO20022.Colr010001.GenericIdentification36
        + BIC  : String
    }
    ISO20022.Colr010001.PartyIdentification240Choice *-- ISO20022.Colr010001.NameAndAddress13
    ISO20022.Colr010001.PartyIdentification240Choice *-- ISO20022.Colr010001.GenericIdentification36
    class ISO20022.Colr010001.PartyIdentificationAndAccount200 {
        + CtctPrsn  : ISO20022.Colr010001.ContactIdentification2
        + SubAcct  : ISO20022.Colr010001.SubAccount5
        + PrcgDt  : ISO20022.Colr010001.DateAndDateTime2Choice
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + AcctId  : String
        + PtyId  : ISO20022.Colr010001.PartyIdentification178Choice
    }
    ISO20022.Colr010001.PartyIdentificationAndAccount200 *-- ISO20022.Colr010001.ContactIdentification2
    ISO20022.Colr010001.PartyIdentificationAndAccount200 *-- ISO20022.Colr010001.SubAccount5
    ISO20022.Colr010001.PartyIdentificationAndAccount200 *-- ISO20022.Colr010001.DateAndDateTime2Choice
    ISO20022.Colr010001.PartyIdentificationAndAccount200 *-- ISO20022.Colr010001.PartyIdentification178Choice
    class ISO20022.Colr010001.PartyIdentificationAndAccount201 {
        + AddtlInf  : ISO20022.Colr010001.PartyTextInformation1
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Colr010001.AlternatePartyIdentification8
        + Id  : ISO20022.Colr010001.PartyIdentification240Choice
    }
    ISO20022.Colr010001.PartyIdentificationAndAccount201 *-- ISO20022.Colr010001.PartyTextInformation1
    ISO20022.Colr010001.PartyIdentificationAndAccount201 *-- ISO20022.Colr010001.AlternatePartyIdentification8
    ISO20022.Colr010001.PartyIdentificationAndAccount201 *-- ISO20022.Colr010001.PartyIdentification240Choice
    class ISO20022.Colr010001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Colr010001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr010001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Colr010001.PostalAddress8 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr010001.Price7 {
        + Val  : ISO20022.Colr010001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Colr010001.YieldedOrValueType1Choice
    }
    ISO20022.Colr010001.Price7 *-- ISO20022.Colr010001.PriceRateOrAmount3Choice
    ISO20022.Colr010001.Price7 *-- ISO20022.Colr010001.YieldedOrValueType1Choice
    class ISO20022.Colr010001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Colr010001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Colr010001.PriceRateOrAmount3Choice *-- ISO20022.Colr010001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Colr010001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Colr010001.ReceivingPartiesAndAccount19 {
        + Pty2  : ISO20022.Colr010001.PartyIdentificationAndAccount201
        + Pty1  : ISO20022.Colr010001.PartyIdentificationAndAccount200
        + Dpstry  : ISO20022.Colr010001.PartyIdentification239Choice
    }
    ISO20022.Colr010001.ReceivingPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentificationAndAccount201
    ISO20022.Colr010001.ReceivingPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentificationAndAccount200
    ISO20022.Colr010001.ReceivingPartiesAndAccount19 *-- ISO20022.Colr010001.PartyIdentification239Choice
    class ISO20022.Colr010001.Reference17 {
        + CollSbstitnRspnId  : String
        + CollSbstitnReqId  : String
    }
    class ISO20022.Colr010001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Colr010001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Colr010001.SafekeepingPlaceFormat29Choice {
        + Prtry  : ISO20022.Colr010001.GenericIdentification78
        + TpAndId  : ISO20022.Colr010001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Colr010001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Colr010001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr010001.GenericIdentification78
    ISO20022.Colr010001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr010001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Colr010001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr010001.SafekeepingPlaceTypeAndText8
    class ISO20022.Colr010001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr010001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr010001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr010001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr010001.SecuritiesAccount19 *-- ISO20022.Colr010001.GenericIdentification30
    class ISO20022.Colr010001.SecuritiesCollateral11 {
        + SttlmParams  : ISO20022.Colr010001.SettlementDetails206
        + SfkpgPlc  : ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
        + BlckChainAdrOrWllt  : ISO20022.Colr010001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr010001.SecuritiesAccount19
        + ValDt  : DateTime
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Pric  : ISO20022.Colr010001.Price7
        + Qty  : ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
        + LtdCvrgInd  : String
        + MtrtyDt  : ISO20022.Colr010001.DateAndDateTime2Choice
        + SctyId  : ISO20022.Colr010001.SecurityIdentification19
        + AsstNb  : String
        + CollId  : String
    }
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.SettlementDetails206
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.BlockChainAddressWallet3
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.SecuritiesAccount19
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.Price7
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.DateAndDateTime2Choice
    ISO20022.Colr010001.SecuritiesCollateral11 *-- ISO20022.Colr010001.SecurityIdentification19
    class ISO20022.Colr010001.SecuritiesCollateral12 {
        + SttlmParams  : ISO20022.Colr010001.SettlementDetails206
        + SfkpgPlc  : ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
        + BlckChainAdrOrWllt  : ISO20022.Colr010001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr010001.SecuritiesAccount19
        + ValDt  : DateTime
        + CollVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr010001.ActiveCurrencyAndAmount
        + Pric  : ISO20022.Colr010001.Price7
        + Qty  : ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
        + LtdCvrgInd  : String
        + MtrtyDt  : ISO20022.Colr010001.DateAndDateTime2Choice
        + SctyId  : ISO20022.Colr010001.SecurityIdentification19
        + CollId  : String
    }
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.SettlementDetails206
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.BlockChainAddressWallet3
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.SecuritiesAccount19
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.ActiveCurrencyAndAmount
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.Price7
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.DateAndDateTime2Choice
    ISO20022.Colr010001.SecuritiesCollateral12 *-- ISO20022.Colr010001.SecurityIdentification19
    class ISO20022.Colr010001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr010001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr010001.SecurityIdentification19 *-- ISO20022.Colr010001.OtherIdentification1
    class ISO20022.Colr010001.SettlementDetails206 {
        + CollOwnrsh  : ISO20022.Colr010001.CollateralOwnership4
        + SttlmPties  : ISO20022.Colr010001.SettlementParties36Choice
        + TradDt  : DateTime
    }
    ISO20022.Colr010001.SettlementDetails206 *-- ISO20022.Colr010001.CollateralOwnership4
    ISO20022.Colr010001.SettlementDetails206 *-- ISO20022.Colr010001.SettlementParties36Choice
    class ISO20022.Colr010001.SettlementParties36Choice {
        + RcvgSttlmPties  : ISO20022.Colr010001.ReceivingPartiesAndAccount19
        + DlvrgSttlmPties  : ISO20022.Colr010001.DeliveringPartiesAndAccount19
    }
    ISO20022.Colr010001.SettlementParties36Choice *-- ISO20022.Colr010001.ReceivingPartiesAndAccount19
    ISO20022.Colr010001.SettlementParties36Choice *-- ISO20022.Colr010001.DeliveringPartiesAndAccount19
    class ISO20022.Colr010001.SubAccount5 {
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Colr010001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr010001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr010001.SupplementaryData1 *-- ISO20022.Colr010001.SupplementaryDataEnvelope1
    class ISO20022.Colr010001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr010001.TypeOfIdentification2Code {
        TXID = 1
        FIIN = 2
        CORP = 3
        CHTY = 4
        ARNU = 5
    }
    class ISO20022.Colr010001.YieldedOrValueType1Choice {
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

## Value ISO20022.Colr010001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Colr010001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Colr010001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr010001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr010001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Colr010001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Colr010001.Agreement4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgrmtFrmwk|ISO20022.Colr010001.AgreementFramework1Choice||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|AgrmtDt|DateTime||XmlElement()||
|+|AgrmtId|String||XmlElement()||
|+|AgrmtDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgrmtFrmwk),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr010001.AgreementFramework1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Colr010001.GenericIdentification30||XmlElement()||
|+|AgrmtFrmwk|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validChoice(PrtryId,AgrmtFrmwk))|

---

## Enum ISO20022.Colr010001.AgreementFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONR|Int32||XmlEnum("""NONR""")|1|
||ISDA|Int32||XmlEnum("""ISDA""")|2|
||DERV|Int32||XmlEnum("""DERV""")|3|
||BBAA|Int32||XmlEnum("""BBAA""")|4|
||FBAA|Int32||XmlEnum("""FBAA""")|5|

---

## Value ISO20022.Colr010001.AlternatePartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Colr010001.IdentificationType43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Colr010001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr010001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.BlockChainAddressWallet5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr010001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.CashCollateral3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrcut|Decimal||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|DpstTp|String||XmlElement()||
|+|DpstAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshAcctId|ISO20022.Colr010001.AccountIdentification4Choice||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(DpstAmt),validElement(CshAcctId))|

---

## Value ISO20022.Colr010001.CashCollateral5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrcut|Decimal||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|DpstTp|String||XmlElement()||
|+|DpstAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|AsstNb|String||XmlElement()||
|+|CshAcctId|ISO20022.Colr010001.AccountIdentification4Choice||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(DpstAmt),validElement(CshAcctId))|

---

## Value ISO20022.Colr010001.CollateralAccount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr010001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.CollateralAccountIdentificationType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr010001.GenericIdentification36||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Enum ISO20022.Colr010001.CollateralAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFLT|Int32||XmlEnum("""DFLT""")|1|
||MGIN|Int32||XmlEnum("""MGIN""")|2|
||LIPR|Int32||XmlEnum("""LIPR""")|3|
||CLIE|Int32||XmlEnum("""CLIE""")|4|
||HOUS|Int32||XmlEnum("""HOUS""")|5|

---

## Value ISO20022.Colr010001.CollateralOwnership4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClntNm|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|Prtry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClntNm))|

---

## Value ISO20022.Colr010001.CollateralSubstitution7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdRefs|ISO20022.Colr010001.Reference17||XmlElement()||
|+|OthrColl|global::System.Collections.Generic.List<ISO20022.Colr010001.OtherCollateral11>||XmlElement()||
|+|CshColl|global::System.Collections.Generic.List<ISO20022.Colr010001.CashCollateral5>||XmlElement()||
|+|SctiesColl|global::System.Collections.Generic.List<ISO20022.Colr010001.SecuritiesCollateral11>||XmlElement()||
|+|StdSttlmInstrs|String||XmlElement()||
|+|CollSbstitnTp|String||XmlElement()||
|+|SbstitnRqrmnt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CollSbstitnSeq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkdRefs),validList("""OthrColl""",OthrColl),validElement(OthrColl),validList("""CshColl""",CshColl),validElement(CshColl),validList("""SctiesColl""",SctiesColl),validElement(SctiesColl),validElement(SbstitnRqrmnt))|

---

## Value ISO20022.Colr010001.CollateralSubstitution8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdRefs|ISO20022.Colr010001.Reference17||XmlElement()||
|+|OthrColl|global::System.Collections.Generic.List<ISO20022.Colr010001.OtherCollateral9>||XmlElement()||
|+|CshColl|global::System.Collections.Generic.List<ISO20022.Colr010001.CashCollateral3>||XmlElement()||
|+|SctiesColl|global::System.Collections.Generic.List<ISO20022.Colr010001.SecuritiesCollateral12>||XmlElement()||
|+|StdSttlmInstrs|String||XmlElement()||
|+|CollSbstitnTp|String||XmlElement()||
|+|SbstitnRqrmnt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CollSbstitnSeq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkdRefs),validList("""OthrColl""",OthrColl),validElement(OthrColl),validList("""CshColl""",CshColl),validElement(CshColl),validList("""SctiesColl""",SctiesColl),validElement(SctiesColl),validElement(SbstitnRqrmnt))|

---

## Aspect ISO20022.Colr010001.CollateralSubstitutionRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr010001.SupplementaryData1>||XmlElement()||
|+|CollSbstitnDlvr|ISO20022.Colr010001.CollateralSubstitution8||XmlElement()||
|+|CollSbstitnRtr|ISO20022.Colr010001.CollateralSubstitution7||XmlElement()||
|+|Agrmt|ISO20022.Colr010001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr010001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollSbstitnDlvr),validElement(CollSbstitnRtr),validElement(Agrmt),validElement(Oblgtn))|

---

## Enum ISO20022.Colr010001.CollateralSubstitutionSequence1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDD|Int32||XmlEnum("""UPDD""")|1|
||INIT|Int32||XmlEnum("""INIT""")|2|

---

## Enum ISO20022.Colr010001.CollateralSubstitutionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ASIA|Int32||XmlEnum("""ASIA""")|1|
||AVMG|Int32||XmlEnum("""AVMG""")|2|

---

## Value ISO20022.Colr010001.ContactIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Colr010001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Colr010001.DateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr010001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr010001.DateFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Colr010001.DateCode9Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Colr010001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Value ISO20022.Colr010001.DeliveringPartiesAndAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty2|ISO20022.Colr010001.PartyIdentificationAndAccount201||XmlElement()||
|+|Pty1|ISO20022.Colr010001.PartyIdentificationAndAccount200||XmlElement()||
|+|Dpstry|ISO20022.Colr010001.PartyIdentification239Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Colr010001.DepositType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CALL|Int32||XmlEnum("""CALL""")|1|
||FITE|Int32||XmlEnum("""FITE""")|2|

---

## Type ISO20022.Colr010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollSbstitnReq|ISO20022.Colr010001.CollateralSubstitutionRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollSbstitnReq))|

---

## Enum ISO20022.Colr010001.ExposureType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHSL|Int32||XmlEnum("""SHSL""")|1|
||REPO|Int32||XmlEnum("""REPO""")|2|
||TRBD|Int32||XmlEnum("""TRBD""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CCPC|Int32||XmlEnum("""CCPC""")|5|
||UDMS|Int32||XmlEnum("""UDMS""")|6|
||TRCP|Int32||XmlEnum("""TRCP""")|7|
||TBAS|Int32||XmlEnum("""TBAS""")|8|
||SWPT|Int32||XmlEnum("""SWPT""")|9|
||SCIE|Int32||XmlEnum("""SCIE""")|10|
||SCIR|Int32||XmlEnum("""SCIR""")|11|
||SLEB|Int32||XmlEnum("""SLEB""")|12|
||SCRP|Int32||XmlEnum("""SCRP""")|13|
||SBSC|Int32||XmlEnum("""SBSC""")|14|
||SLOA|Int32||XmlEnum("""SLOA""")|15|
||RVPO|Int32||XmlEnum("""RVPO""")|16|
||OTCD|Int32||XmlEnum("""OTCD""")|17|
||LIQU|Int32||XmlEnum("""LIQU""")|18|
||OPTN|Int32||XmlEnum("""OPTN""")|19|
||FUTR|Int32||XmlEnum("""FUTR""")|20|
||FORW|Int32||XmlEnum("""FORW""")|21|
||FORX|Int32||XmlEnum("""FORX""")|22|
||FIXI|Int32||XmlEnum("""FIXI""")|23|
||EXPT|Int32||XmlEnum("""EXPT""")|24|
||EXTD|Int32||XmlEnum("""EXTD""")|25|
||EQUS|Int32||XmlEnum("""EQUS""")|26|
||EQPT|Int32||XmlEnum("""EQPT""")|27|
||CRPR|Int32||XmlEnum("""CRPR""")|28|
||CCIR|Int32||XmlEnum("""CCIR""")|29|
||CRSP|Int32||XmlEnum("""CRSP""")|30|
||CRTL|Int32||XmlEnum("""CRTL""")|31|
||CRDS|Int32||XmlEnum("""CRDS""")|32|
||COMM|Int32||XmlEnum("""COMM""")|33|
||CBCO|Int32||XmlEnum("""CBCO""")|34|
||PAYM|Int32||XmlEnum("""PAYM""")|35|
||BFWD|Int32||XmlEnum("""BFWD""")|36|

---

## Value ISO20022.Colr010001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr010001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Colr010001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Colr010001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr010001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr010001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Colr010001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr010001.IdentificationType43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr010001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr010001.NameAndAddress13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr010001.PostalAddress8||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr010001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr010001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr010001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr010001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Colr010001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Colr010001.Obligation9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValtnDt|ISO20022.Colr010001.DateAndDateTime2Choice||XmlElement()||
|+|XpsrTp|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr010001.BlockChainAddressWallet5||XmlElement()||
|+|CollAcctId|ISO20022.Colr010001.CollateralAccount3||XmlElement()||
|+|SvcgPtyB|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|PtyB|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|SvcgPtyA|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|PtyA|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnDt),validElement(BlckChainAdrOrWllt),validElement(CollAcctId),validElement(SvcgPtyB),validElement(PtyB),validElement(SvcgPtyA),validElement(PtyA))|

---

## Value ISO20022.Colr010001.OtherCollateral11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BlckChainAdrOrWllt|ISO20022.Colr010001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr010001.SecuritiesAccount19||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr010001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|Issr|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|XpryDt|ISO20022.Colr010001.DateFormat14Choice||XmlElement()||
|+|IsseDt|ISO20022.Colr010001.DateFormat14Choice||XmlElement()||
|+|OthrTpOfColl|ISO20022.Colr010001.OtherTypeOfCollateral3||XmlElement()||
|+|GrntAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtId|String||XmlElement()||
|+|AsstNb|String||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(SfkpgPlc),validElement(CollVal),validElement(MktVal),validElement(Issr),validElement(XpryDt),validElement(IsseDt),validElement(OthrTpOfColl),validElement(GrntAmt),validElement(LttrOfCdtAmt))|

---

## Value ISO20022.Colr010001.OtherCollateral9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BlckChainAdrOrWllt|ISO20022.Colr010001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr010001.SecuritiesAccount19||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr010001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|Issr|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|XpryDt|ISO20022.Colr010001.DateFormat14Choice||XmlElement()||
|+|IsseDt|ISO20022.Colr010001.DateFormat14Choice||XmlElement()||
|+|OthrTpOfColl|ISO20022.Colr010001.OtherTypeOfCollateral3||XmlElement()||
|+|GrntAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtAmt|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtId|String||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(SfkpgPlc),validElement(CollVal),validElement(MktVal),validElement(Issr),validElement(XpryDt),validElement(IsseDt),validElement(OthrTpOfColl),validElement(GrntAmt),validElement(LttrOfCdtAmt))|

---

## Value ISO20022.Colr010001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr010001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.OtherTypeOfCollateral3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Colr010001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Colr010001.PartyIdentification178Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr010001.NameAndAddress6||XmlElement()||
|+|PrtryId|ISO20022.Colr010001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr010001.PartyIdentification239Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Colr010001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Colr010001.PartyIdentification240Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr010001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Colr010001.GenericIdentification36||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BIC))|

---

## Value ISO20022.Colr010001.PartyIdentificationAndAccount200


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Colr010001.ContactIdentification2||XmlElement()||
|+|SubAcct|ISO20022.Colr010001.SubAccount5||XmlElement()||
|+|PrcgDt|ISO20022.Colr010001.DateAndDateTime2Choice||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|PtyId|ISO20022.Colr010001.PartyIdentification178Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(SubAcct),validElement(PrcgDt),validElement(PtyId))|

---

## Value ISO20022.Colr010001.PartyIdentificationAndAccount201


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Colr010001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Colr010001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Colr010001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Colr010001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr010001.PostalAddress1


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

## Value ISO20022.Colr010001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Colr010001.PostalAddress8


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

## Value ISO20022.Colr010001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Colr010001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Colr010001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Colr010001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Colr010001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Colr010001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Colr010001.ReceivingPartiesAndAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty2|ISO20022.Colr010001.PartyIdentificationAndAccount201||XmlElement()||
|+|Pty1|ISO20022.Colr010001.PartyIdentificationAndAccount200||XmlElement()||
|+|Dpstry|ISO20022.Colr010001.PartyIdentification239Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Colr010001.Reference17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollSbstitnRspnId|String||XmlElement()||
|+|CollSbstitnReqId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr010001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Colr010001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Colr010001.SafekeepingPlaceFormat29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr010001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Colr010001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Colr010001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Colr010001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Colr010001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr010001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr010001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr010001.SecuritiesCollateral11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmParams|ISO20022.Colr010001.SettlementDetails206||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr010001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr010001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr010001.SecuritiesAccount19||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Pric|ISO20022.Colr010001.Price7||XmlElement()||
|+|Qty|ISO20022.Colr010001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|MtrtyDt|ISO20022.Colr010001.DateAndDateTime2Choice||XmlElement()||
|+|SctyId|ISO20022.Colr010001.SecurityIdentification19||XmlElement()||
|+|AsstNb|String||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmParams),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(CollVal),validElement(MktVal),validElement(Pric),validElement(Qty),validElement(MtrtyDt),validElement(SctyId))|

---

## Value ISO20022.Colr010001.SecuritiesCollateral12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmParams|ISO20022.Colr010001.SettlementDetails206||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr010001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr010001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr010001.SecuritiesAccount19||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|CollVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Pric|ISO20022.Colr010001.Price7||XmlElement()||
|+|Qty|ISO20022.Colr010001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|MtrtyDt|ISO20022.Colr010001.DateAndDateTime2Choice||XmlElement()||
|+|SctyId|ISO20022.Colr010001.SecurityIdentification19||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmParams),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(CollVal),validElement(MktVal),validElement(Pric),validElement(Qty),validElement(MtrtyDt),validElement(SctyId))|

---

## Value ISO20022.Colr010001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr010001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Colr010001.SettlementDetails206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollOwnrsh|ISO20022.Colr010001.CollateralOwnership4||XmlElement()||
|+|SttlmPties|ISO20022.Colr010001.SettlementParties36Choice||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollOwnrsh),validElement(SttlmPties))|

---

## Value ISO20022.Colr010001.SettlementParties36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgSttlmPties|ISO20022.Colr010001.ReceivingPartiesAndAccount19||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Colr010001.DeliveringPartiesAndAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validChoice(RcvgSttlmPties,DlvrgSttlmPties))|

---

## Value ISO20022.Colr010001.SubAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr010001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr010001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr010001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr010001.TypeOfIdentification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||CORP|Int32||XmlEnum("""CORP""")|3|
||CHTY|Int32||XmlEnum("""CHTY""")|4|
||ARNU|Int32||XmlEnum("""ARNU""")|5|

---

## Value ISO20022.Colr010001.YieldedOrValueType1Choice


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

