# cain.025.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Cain025001.AddendumData6 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData2~
        + TempSvcs  : global::System.Collections.Generic.List~ISO20022.Cain025001.TemporaryServices3~
        + TelecomSvcs  : ISO20022.Cain025001.TelecomServices3
        + ShppgData  : ISO20022.Cain025001.ShippingData3
        + Ldgg  : global::System.Collections.Generic.List~ISO20022.Cain025001.Lodging4~
        + VhclRntl  : global::System.Collections.Generic.List~ISO20022.Cain025001.VehicleRentalService3~
        + PssngrTrnsprt  : ISO20022.Cain025001.PassengerTransport3
        + TrvlAgcy  : global::System.Collections.Generic.List~ISO20022.Cain025001.TravelAgency4~
        + Invc  : ISO20022.Cain025001.Invoice3
        + Fleet  : ISO20022.Cain025001.FleetData6
        + Sale  : ISO20022.Cain025001.Sale3
    }
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.AdditionalData2
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.TemporaryServices3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.TelecomServices3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.ShippingData3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.Lodging4
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.VehicleRentalService3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.PassengerTransport3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.TravelAgency4
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.Invoice3
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.FleetData6
    ISO20022.Cain025001.AddendumData6 *-- ISO20022.Cain025001.Sale3
    class ISO20022.Cain025001.AddendumInitiationV03 {
        + SctyTrlr  : ISO20022.Cain025001.ContentInformationType41
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Cain025001.SupplementaryData1~
        + PrtctdData  : global::System.Collections.Generic.List~ISO20022.Cain025001.ProtectedData2~
        + AdddmData  : ISO20022.Cain025001.AddendumData6
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData2~
        + Rcncltn  : ISO20022.Cain025001.Reconciliation4
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain025001.SettlementService6
        + Jursdctn  : ISO20022.Cain025001.Jurisdiction2
        + Cstmr  : ISO20022.Cain025001.Customer4
        + Accptr  : ISO20022.Cain025001.PartyIdentification288
        + OrgnlDataElmts  : ISO20022.Cain025001.OriginalDataElements3
        + Tkn  : ISO20022.Cain025001.Token2
        + TxId  : ISO20022.Cain025001.TransactionIdentification53
        + Prgrmm  : global::System.Collections.Generic.List~ISO20022.Cain025001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain025001.PartyIdentification286
        + Issr  : ISO20022.Cain025001.PartyIdentification286
        + Rcvr  : ISO20022.Cain025001.PartyIdentification286
        + Card  : ISO20022.Cain025001.CardData14
        + Sndr  : ISO20022.Cain025001.PartyIdentification286
        + Acqrr  : ISO20022.Cain025001.PartyIdentification286
        + Orgtr  : ISO20022.Cain025001.PartyIdentification286
        + TxDesc  : String
        + DataSrc  : String
        + Hdr  : ISO20022.Cain025001.Header71
    }
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.ContentInformationType41
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.SupplementaryData1
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.ProtectedData2
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.AddendumData6
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.AdditionalData2
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.Reconciliation4
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.AdditionalFee3
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.SettlementService6
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.Jurisdiction2
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.Customer4
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification288
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.OriginalDataElements3
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.Token2
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.TransactionIdentification53
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.ProgrammeMode5
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.CardData14
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.PartyIdentification286
    ISO20022.Cain025001.AddendumInitiationV03 *-- ISO20022.Cain025001.Header71
    class ISO20022.Cain025001.AddendumTaxType3Code {
        DPTX = 1
        TNRT = 2
        WITH = 3
        WITL = 4
        WITF = 5
        WESV = 6
        WTAX = 7
        VATB = 8
        VATA = 9
        UUTX = 10
        UNSP = 11
        TRAN = 12
        TRAX = 13
        THTX = 14
        TELT = 15
        TDDT = 16
        CTAX = 17
        SUTX = 18
        STEX = 19
        STSL = 20
        STAT = 21
        SSTX = 22
        SRTX = 23
        SPTG = 24
        SPFT = 25
        SPTS = 26
        STPT = 27
        SETX = 28
        SLTX = 29
        SLST = 30
        STAM = 31
        STTA = 32
        SPTX = 33
        SCTX = 34
        SAUT = 35
        ROVI = 36
        RVAT = 37
        ROTX = 38
        RCSD = 39
        RCSB = 40
        ROCI = 41
        QUST = 42
        PHET = 43
        PROV = 44
        PPTX = 45
        PSTX = 46
        PRTX = 47
        POTX = 48
        LEVY = 49
        OTTX = 50
        OTHP = 51
        OTHN = 52
        OTHR = 53
        OPTX = 54
        OCTX = 55
        NATI = 56
        COUN = 57
        MUDE = 58
        MUTX = 59
        MITX = 60
        METX = 61
        MATX = 62
        LUTX = 63
        LOCL = 64
        LSTX = 65
        LOCO = 66
        LITX = 67
        FLST = 68
        LTTX = 69
        INPO = 70
        INHT = 71
        HWTX = 72
        HSTX = 73
        HATX = 74
        HVAT = 75
        GRTX = 76
        GCAT = 77
        GIFT = 78
        FUVT = 79
        FSFT = 80
        FSTX = 81
        FRTX = 82
        FICA = 83
        FSST = 84
        FIMT = 85
        FVTS = 86
        FVAT = 87
        FETX = 88
        FNST = 89
        FEXT = 90
        EXEC = 91
        EUTR = 92
        EQTX = 93
        EQUL = 94
        ENVT = 95
        ESET = 96
        ENTX = 97
        EMRT = 98
        EMST = 99
        EMET = 100
        EMUT = 101
        EMIT = 102
        DUTY = 103
        DLTX = 104
        CUST = 105
        COTX = 106
        CORT = 107
        CPST = 108
        COAX = 109
        CITX = 110
        CSTX = 111
        CRTX = 112
        NKAP = 113
        KAPA = 114
        BPTX = 115
        ASNT = 116
        ALMI = 117
        TOTL = 118
    }
    class ISO20022.Cain025001.AdditionalData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.AdditionalData2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Tp  : String
    }
    ISO20022.Cain025001.AdditionalData2 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.AdditionalFee3 {
        + Desc  : String
        + OthrAssgnr  : String
        + Assgnr  : String
        + RcncltnFctvXchgRate  : Decimal
        + RcncltnCcy  : String
        + RcncltnAmt  : Decimal
        + Ccy  : String
        + Amt  : Decimal
        + CdtDbt  : String
        + Dscrptr  : String
        + Prgm  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.AdditionalInformation31 {
        + AddtlData  : String
        + AlphaNmrc  : String
        + Nmrc  : String
    }
    class ISO20022.Cain025001.Address2 {
        + Ctry  : String
        + CtrySubDvsnMnrNm  : String
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMjr  : String
        + CtrySubDvsnMnr  : String
        + TwnNm  : String
        + PstlCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine2  : String
        + AdrLine1  : String
    }
    class ISO20022.Cain025001.Adjustment13 {
        + TaxOnOrgnlAmt  : String
        + Amt  : Decimal
        + Pctg  : Decimal
        + PrmtnCd  : String
        + Rsn  : String
        + Desc  : String
        + AddtlTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Adjustment14 {
        + TaxOnOrgnlAmt  : String
        + Amt  : Decimal
        + Pctg  : Decimal
        + UnitPric  : Decimal
        + Qty  : Decimal
        + PrmtnCpnNb  : String
        + PrmtnCd  : String
        + PrmtnElgblty  : String
        + Rsn  : String
        + Desc  : String
        + AddtlTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Cain025001.Algorithm20Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cain025001.Algorithm23Code {
        SD5C = 1
        E36R = 2
        E36C = 3
        E3DR = 4
        EA5R = 5
        EA9R = 6
        EA2R = 7
        EA5C = 8
        EA9C = 9
        E3DC = 10
        EA2C = 11
    }
    class ISO20022.Cain025001.Algorithm5Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cain025001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Cain025001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Cain025001.AlgorithmIdentification25 {
        + Param  : ISO20022.Cain025001.Parameter7
        + Algo  : String
    }
    ISO20022.Cain025001.AlgorithmIdentification25 *-- ISO20022.Cain025001.Parameter7
    class ISO20022.Cain025001.AlgorithmIdentification26 {
        + Param  : String
        + Algo  : String
    }
    class ISO20022.Cain025001.AlgorithmIdentification27 {
        + Param  : ISO20022.Cain025001.Parameter13
        + Algo  : String
    }
    ISO20022.Cain025001.AlgorithmIdentification27 *-- ISO20022.Cain025001.Parameter13
    class ISO20022.Cain025001.AlgorithmIdentification28 {
        + Param  : ISO20022.Cain025001.Parameter14
        + Algo  : String
    }
    ISO20022.Cain025001.AlgorithmIdentification28 *-- ISO20022.Cain025001.Parameter14
    class ISO20022.Cain025001.Amount12 {
        + Hrs  : String
        + Rate  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Amount13 {
        + Amt  : Decimal
        + Desc  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Amount21 {
        + CstmrNtfd  : String
        + CdtDbt  : String
        + Amt  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Amount22 {
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + CdtDbt  : String
        + Amt  : Decimal
        + Desc  : String
    }
    ISO20022.Cain025001.Amount22 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.Amount23 {
        + CdtDbt  : String
        + Amt  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.AmountDetails3 {
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + CdtDbt  : String
        + Amt  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain025001.AmountDetails3 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.AncillaryPurchase3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + Fee  : Decimal
        + CdtDbt  : String
        + Amt  : Decimal
        + SummryCmmdtyId  : String
        + CdtRsnCd  : String
        + SvcPrvdrSvcTp  : String
        + SvcSubCtgyCd  : String
        + SvcCtgyCd  : String
        + RltdDocNb  : String
        + DocNb  : String
    }
    ISO20022.Cain025001.AncillaryPurchase3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.AncillaryPurchase3 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Cain025001.AuthorisedAmount2 {
        + Desc  : String
        + Amt  : Decimal
        + Tm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Cain025001.Authority1 {
        + Nm  : String
        + CtrySubDvsnMnrNm  : String
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnr  : String
        + CtrySubDvsnMjr  : String
        + Ctry  : String
    }
    class ISO20022.Cain025001.BatchManagementInformation1 {
        + MsgChcksmInptVal  : String
        + MsgSeqNb  : String
        + BtchId  : String
        + ColltnId  : String
    }
    class ISO20022.Cain025001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Cain025001.CarRentalActivity1Code {
        OTHR = 1
        OTHN = 2
        OTHP = 3
        PETP = 4
        INDV = 5
        GLBL = 6
        CARS = 7
    }
    class ISO20022.Cain025001.CarRentalServiceType2Code {
        TOWI = 1
        TOLL = 2
        SMOK = 3
        REGD = 4
        PHON = 5
        PFIN = 6
        PRIN = 7
        PARK = 8
        OTHP = 9
        OTHN = 10
        ONEW = 11
        NOSH = 12
        NAVI = 13
        MISC = 14
        LDIN = 15
        LIIN = 16
        LATE = 17
        INSU = 18
        GPSY = 19
        GARA = 20
        FUEL = 21
        FINE = 22
        EXHR = 23
        EXDI = 24
        EXDY = 25
        EXTC = 26
        ENTE = 27
        DPOF = 28
        DLVR = 29
        DMGS = 30
        CLEA = 31
        BAST = 32
        AUTH = 33
        ADJM = 34
    }
    class ISO20022.Cain025001.CardData14 {
        + PrtflIdr  : String
        + PmtAcctRef  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    class ISO20022.Cain025001.CardDataReading5Code {
        CDFL = 1
        ECTL = 2
        CTLS = 3
        DFLE = 4
        CICC = 5
        MGST = 6
        BRCD = 7
        PHYS = 8
        TAGC = 9
    }
    class ISO20022.Cain025001.CardholderName3 {
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain025001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Cain025001.RelativeDistinguishedName1~
    }
    ISO20022.Cain025001.CertificateIssuer1 *-- ISO20022.Cain025001.RelativeDistinguishedName1
    class ISO20022.Cain025001.CompanyAssigner2Code {
        OTHN = 1
        OTHP = 2
        TRAG = 3
        LEII = 4
        CPNY = 5
        AUTH = 6
        ASSO = 7
    }
    class ISO20022.Cain025001.ContactBusiness1 {
        + Lang  : String
        + URL  : String
        + Fax  : String
        + Email  : String
        + TollFreePhne  : String
        + PrprtyPhne  : String
        + Phne  : String
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain025001.ContactPersonal1 {
        + Lang  : String
        + URL  : String
        + BizFax  : String
        + HomeFax  : String
        + OthrEmail  : String
        + BizEmail  : String
        + PrsnlEmail  : String
        + OthrPhne  : String
        + MobPhne  : String
        + BizPhne  : String
        + HomePhne  : String
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain025001.ContentInformationType41 {
        + MAC  : String
        + MACData  : ISO20022.Cain025001.MACData1
    }
    ISO20022.Cain025001.ContentInformationType41 *-- ISO20022.Cain025001.MACData1
    class ISO20022.Cain025001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Cain025001.ContentType3Code {
        IFSE = 1
        EVLP = 2
    }
    class ISO20022.Cain025001.CorporateTaxType1Code {
        CORP = 1
        OTHR = 2
        SMBS = 3
    }
    class ISO20022.Cain025001.Credentials3 {
        + Assgnr  : ISO20022.Cain025001.Authority1
        + XpryDt  : String
        + Val  : String
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain025001.Credentials3 *-- ISO20022.Cain025001.Authority1
    class ISO20022.Cain025001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Cain025001.Customer4 {
        + CstmrRltsh  : String
        + VIPInd  : String
        + AuthrsdCtctPhneNb  : String
        + AuthrsdCtctNm  : String
        + AuthrsdCtctCpny  : String
        + TaxRegnId  : global::System.Collections.Generic.List~String~
        + RefNb  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Customer9 {
        + Ctct  : ISO20022.Cain025001.ContactPersonal1
        + Adr  : ISO20022.Cain025001.Address2
        + Age  : String
        + CstmrFileRefNb  : String
        + Id  : ISO20022.Cain025001.Credentials3
        + Nm  : String
    }
    ISO20022.Cain025001.Customer9 *-- ISO20022.Cain025001.ContactPersonal1
    ISO20022.Cain025001.Customer9 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.Customer9 *-- ISO20022.Cain025001.Credentials3
    class ISO20022.Cain025001.CustomerAssigner1Code {
        TRAY = 1
        OTHR = 2
        ONFL = 3
        CUST = 4
        CRCY = 5
        AUTH = 6
    }
    class ISO20022.Cain025001.CustomerReference1 {
        + Dtl  : String
        + Id  : String
    }
    class ISO20022.Cain025001.CustomerType2Code {
        CPNY = 1
        CSMR = 2
    }
    class ISO20022.Cain025001.DateTime2 {
        + Tm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Cain025001.DepartureOrArrival1 {
        + Tm  : DateTime
        + Dt  : DateTime
        + Desc  : String
        + Lctn  : String
    }
    class ISO20022.Cain025001.DepartureOrArrival2 {
        + Tm  : DateTime
        + Dt  : DateTime
        + RouteNb  : String
        + CrrierCd  : String
    }
    class ISO20022.Cain025001.Discount3 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Distance1 {
        + Rate  : Decimal
        + FreeDstnc  : String
        + TtlDstnc  : String
        + OdmtrRtr  : String
        + OdmtrStart  : String
        + UnitOfMeasr  : String
    }
    class ISO20022.Cain025001.DocumentReference1 {
        + Ref  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Driver3 {
        + AddtlData  : ISO20022.Cain025001.AdditionalData1
        + DtOfBirth  : DateTime
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.TravelDocument2~
        + DeptNb  : String
        + MplyeeId  : String
        + Mplyr  : String
        + LicOthrAuthrty  : String
        + LicCtrySubDvsnMnr  : String
        + LicCtrySubDvsnMjr  : String
        + LicCtry  : String
        + LicXprtnDt  : DateTime
        + LicIssncDt  : DateTime
        + LicAssgnr  : String
        + LicId  : String
        + LicForm  : String
        + LicTp  : String
        + Id  : String
        + Nm  : String
    }
    ISO20022.Cain025001.Driver3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.Driver3 *-- ISO20022.Cain025001.TravelDocument2
    class ISO20022.Cain025001.DriverInParty3 {
        + LicOthrAuthrty  : String
        + LicCtrySubDvsnMnr  : String
        + LicCtrySubDvsnMjr  : String
        + LicCtry  : String
        + LicXprtnDt  : DateTime
        + LicIssncDt  : DateTime
        + LicAssgnr  : String
        + LicId  : String
        + LicForm  : String
        + LicTp  : String
        + DrvrCrdntl  : global::System.Collections.Generic.List~ISO20022.Cain025001.TravelDocument2~
        + Age  : String
        + DtOfBirth  : DateTime
        + Ctct  : ISO20022.Cain025001.ContactPersonal1
        + Adr  : ISO20022.Cain025001.Address2
        + Nm  : String
    }
    ISO20022.Cain025001.DriverInParty3 *-- ISO20022.Cain025001.TravelDocument2
    ISO20022.Cain025001.DriverInParty3 *-- ISO20022.Cain025001.ContactPersonal1
    ISO20022.Cain025001.DriverInParty3 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.EncryptedContent8 {
        + NcrptdDataElmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.EncryptedDataElement2~
        + CnttNcrptnAlgo  : ISO20022.Cain025001.AlgorithmIdentification25
        + CnttTp  : String
    }
    ISO20022.Cain025001.EncryptedContent8 *-- ISO20022.Cain025001.EncryptedDataElement2
    ISO20022.Cain025001.EncryptedContent8 *-- ISO20022.Cain025001.AlgorithmIdentification25
    class ISO20022.Cain025001.EncryptedData2 {
        + NcrptdElmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.EncryptedDataElement2~
        + NcrptdFrmt  : String
        + PddgMtd  : String
        + KeyIndx  : String
        + KeyPrtcn  : String
        + KeyLngth  : String
        + Algo  : String
        + DrvdInf  : String
        + KeySetIdr  : String
        + Ctrl  : String
    }
    ISO20022.Cain025001.EncryptedData2 *-- ISO20022.Cain025001.EncryptedDataElement2
    class ISO20022.Cain025001.EncryptedData2Choice {
        + HexBinry  : String
        + Binry  : String
    }
    class ISO20022.Cain025001.EncryptedDataElement2 {
        + OthrClearTxtFrmt  : String
        + ClearTxtFrmt  : String
        + Data  : ISO20022.Cain025001.EncryptedData2Choice
        + Id  : String
    }
    ISO20022.Cain025001.EncryptedDataElement2 *-- ISO20022.Cain025001.EncryptedData2Choice
    class ISO20022.Cain025001.EncryptedDataFormat1Code {
        OTHP = 1
        OTHN = 2
        HEXF = 3
        EBCD = 4
        BINF = 5
        ASCI = 6
    }
    class ISO20022.Cain025001.EncryptionFormat3Code {
        CBCE = 1
        CTCE = 2
        TR31 = 3
        TR34 = 4
    }
    class ISO20022.Cain025001.EnvelopedData12 {
        + NcrptdCntt  : ISO20022.Cain025001.EncryptedContent8
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Recipient7Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Cain025001.EnvelopedData12 *-- ISO20022.Cain025001.EncryptedContent8
    ISO20022.Cain025001.EnvelopedData12 *-- ISO20022.Cain025001.Recipient7Choice
    class ISO20022.Cain025001.FleetData6 {
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Cain025001.FleetLineItem5~
        + AddtlNtrdData  : ISO20022.Cain025001.AdditionalInformation31
        + TxRltdData  : global::System.Collections.Generic.List~ISO20022.Cain025001.FleetTransactionDetail1~
        + LclAmnty  : global::System.Collections.Generic.List~ISO20022.Cain025001.LocalAmenity1~
        + TripDlvryTcktNb  : String
        + TripCtrlNb  : String
        + TripBllgId  : String
        + TripInvcNb  : String
        + TripWorkOrdr  : String
        + TripJobNb  : String
        + TripNb  : String
        + AgtFuelPrmptCd  : String
        + CardFuelPrmptCd  : Decimal
        + DrvrOrVhclCard  : ISO20022.Cain025001.PlainCardData23
        + Vhcl  : ISO20022.Cain025001.Vehicle6
        + Drvr  : ISO20022.Cain025001.Driver3
    }
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.FleetLineItem5
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.AdditionalInformation31
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.FleetTransactionDetail1
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.LocalAmenity1
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.PlainCardData23
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.Vehicle6
    ISO20022.Cain025001.FleetData6 *-- ISO20022.Cain025001.Driver3
    class ISO20022.Cain025001.FleetLineItem5 {
        + TtlAmtInclgTax  : Decimal
        + TtlAmtExclgTax  : Decimal
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + NonTaxbl  : String
        + DscntAmt  : Decimal
        + PdctQty  : Decimal
        + OthrUnitOfMeasr  : String
        + UnitOfMeasr  : String
        + UnitPric  : Decimal
        + UnitPricTax  : String
        + PdctCdAssgnr  : String
        + PdctQlfr  : String
        + PdctCtgy  : String
        + PdctCd  : String
        + FuelBrndCd  : String
        + SvcTp  : String
        + Fuel  : String
    }
    ISO20022.Cain025001.FleetLineItem5 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.FleetPurchaseType1Code {
        FANF = 1
        NONF = 2
        FUEL = 3
    }
    class ISO20022.Cain025001.FleetServiceType1Code {
        FLSV = 1
        HSDI = 2
        SLSV = 3
    }
    class ISO20022.Cain025001.FleetTransactionDetail1 {
        + TaxTtl  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + TtlAmt  : Decimal
        + DscntTtlNonFuelAmt  : Decimal
        + DscntTtlFuelAmt  : Decimal
        + DscntTtlAmt  : Decimal
        + SummryCmmdtyId  : String
        + PurchsTp  : String
    }
    ISO20022.Cain025001.FleetTransactionDetail1 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.GenericIdentification183 {
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cain025001.Header71 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Traceability10~
        + TracData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + RcptPty  : ISO20022.Cain025001.GenericIdentification183
        + InitgPty  : ISO20022.Cain025001.GenericIdentification183
        + BtchMgmtInf  : ISO20022.Cain025001.BatchManagementInformation1
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : String
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : String
    }
    ISO20022.Cain025001.Header71 *-- ISO20022.Cain025001.Traceability10
    ISO20022.Cain025001.Header71 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.Header71 *-- ISO20022.Cain025001.GenericIdentification183
    ISO20022.Cain025001.Header71 *-- ISO20022.Cain025001.GenericIdentification183
    ISO20022.Cain025001.Header71 *-- ISO20022.Cain025001.BatchManagementInformation1
    class ISO20022.Cain025001.HiredVehicle3 {
        + DstnAdr  : ISO20022.Cain025001.Address2
        + DstnNmAndLctn  : String
        + DrvrTaxId  : String
        + DrvrId  : String
        + VhclId  : String
        + TpOfVhcl  : String
        + CpnyNm  : String
        + CpnyTp  : String
    }
    ISO20022.Cain025001.HiredVehicle3 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.Invoice3 {
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Cain025001.InvoiceLineItem3~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + TaxRclmMtd  : String
        + TaxTtl  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + FrghtAmt  : Decimal
        + BuyrAddtlInf  : String
        + BuyrTaxRegnId  : String
        + BuyrCtct  : ISO20022.Cain025001.ContactBusiness1
        + BuyrAdr  : ISO20022.Cain025001.Address2
        + BuyrId  : ISO20022.Cain025001.PartyIdentification285
        + BuyrNm  : String
        + SellrAddtlInf  : String
        + SellrTaxRegnId  : String
        + SellrCtct  : ISO20022.Cain025001.ContactBusiness1
        + SellrAdr  : ISO20022.Cain025001.Address2
        + SellrId  : ISO20022.Cain025001.PartyIdentification285
        + SellrNm  : String
        + SummryCmmdtyId  : String
        + CreDtTm  : DateTime
        + Dt  : DateTime
        + Nb  : String
    }
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.InvoiceLineItem3
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.PartyIdentification285
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.Invoice3 *-- ISO20022.Cain025001.PartyIdentification285
    class ISO20022.Cain025001.InvoiceLineItem3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + ZeroCostToCstmr  : String
        + CdtDbt  : String
        + TtlAmt  : Decimal
        + VATInvcRef  : String
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + InsrncAmt  : Decimal
        + Insrnc  : String
        + AdjstmntRsn  : String
        + AdjstmntCdtDbt  : String
        + AdjstmntAmt  : Decimal
        + PdctQty  : Decimal
        + UnitPric  : Decimal
        + OthrUnitOfMeasr  : String
        + UnitOfMeasr  : String
        + TpOfSpply  : String
        + Desc  : String
        + PdctQlfr  : String
        + PdctCd  : String
        + ShipToIndstryCd  : String
        + MdclSvcs  : String
        + Rbllg  : String
        + ShppgDt  : DateTime
        + CtrctNb  : String
        + OrdrDt  : DateTime
        + Dt  : DateTime
    }
    ISO20022.Cain025001.InvoiceLineItem3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.InvoiceLineItem3 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Cain025001.CertificateIssuer1
    }
    ISO20022.Cain025001.IssuerAndSerialNumber1 *-- ISO20022.Cain025001.CertificateIssuer1
    class ISO20022.Cain025001.JourneyType1Code {
        VESS = 1
        TRAN = 2
        OTHR = 3
        ONTM = 4
        LATE = 5
        FLGT = 6
        EARL = 7
        COAC = 8
    }
    class ISO20022.Cain025001.Jurisdiction2 {
        + DmstQlfctn  : String
        + DmstInd  : String
    }
    class ISO20022.Cain025001.KEK6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cain025001.AlgorithmIdentification28
        + KEKId  : ISO20022.Cain025001.KEKIdentifier6
        + Vrsn  : Decimal
    }
    ISO20022.Cain025001.KEK6 *-- ISO20022.Cain025001.AlgorithmIdentification28
    ISO20022.Cain025001.KEK6 *-- ISO20022.Cain025001.KEKIdentifier6
    class ISO20022.Cain025001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cain025001.KEKIdentifier6 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cain025001.KeyTransport6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cain025001.AlgorithmIdentification27
        + RcptId  : ISO20022.Cain025001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Cain025001.KeyTransport6 *-- ISO20022.Cain025001.AlgorithmIdentification27
    ISO20022.Cain025001.KeyTransport6 *-- ISO20022.Cain025001.Recipient5Choice
    class ISO20022.Cain025001.LegalStructure1Code {
        NATI = 1
        CNTY = 2
        MUNI = 3
        PVIN = 4
        STAE = 5
    }
    class ISO20022.Cain025001.LifeCycleSupport1Code {
        FINC = 1
        AUTH = 2
    }
    class ISO20022.Cain025001.LocalAddress1 {
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnrNm  : String
        + TwnNm  : String
        + PstlCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine2  : String
        + AdrLine1  : String
    }
    class ISO20022.Cain025001.LocalAmenity1 {
        + AvlblInd  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.LocalData11 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + AddtlCtct  : String
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain025001.LocalAddress1
        + NmAndLctn  : String
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain025001.LocalData11 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.LocalData11 *-- ISO20022.Cain025001.LocalAddress1
    class ISO20022.Cain025001.LocalData12 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain025001.LocalAddress1
        + LglCorpNm  : String
        + CmonNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain025001.LocalData12 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.LocalData12 *-- ISO20022.Cain025001.LocalAddress1
    class ISO20022.Cain025001.LocalData14 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain025001.LocalData14 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.Location6 {
        + LclCcy  : String
        + LclTmZone  : String
        + Adr  : ISO20022.Cain025001.Address2
        + Desc  : String
        + Nm  : String
        + Cd  : String
    }
    ISO20022.Cain025001.Location6 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.LocationAmenity1Code {
        VMRA = 1
        VHPA = 2
        VSWA = 3
        TFHA = 4
        TSSA = 5
        TSRA = 6
        TSHA = 7
        PAPA = 8
        OTHP = 9
        OTHN = 10
        MRLA = 11
        EWAA = 12
        DISA = 13
        CVSA = 14
        CRWA = 15
        AVLA = 16
        AFLA = 17
        AADA = 18
    }
    class ISO20022.Cain025001.Lodging4 {
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Cain025001.LodgingLineItem3~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LltyPrgrmm  : global::System.Collections.Generic.List~ISO20022.Cain025001.LoyaltyProgramme4~
        + SummryCmmdtyId  : String
        + AuthrsdAmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.AuthorisedAmount2~
        + TtlAmt  : Decimal
        + TtlTax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + InsrncAmt  : Decimal
        + Insrnc  : String
        + NoShow  : String
        + Dprture  : ISO20022.Cain025001.DepartureOrArrival1
        + Arrvl  : ISO20022.Cain025001.DepartureOrArrival2
        + Drtn  : String
        + Room  : global::System.Collections.Generic.List~ISO20022.Cain025001.LodgingRoom2~
        + NbOfRooms  : String
        + CstmrCtct  : ISO20022.Cain025001.ContactPersonal1
        + CstmrAdr  : ISO20022.Cain025001.Address2
        + CstmrAge  : String
        + CstmrFileRefNb  : String
        + CstmrId  : ISO20022.Cain025001.Credentials3
        + CstmrNm  : String
        + PrprtyFireSftyAct  : String
        + PrprtyCtry  : String
        + PrprtyCtct  : ISO20022.Cain025001.ContactBusiness1
        + PrprtyAssgnr  : String
        + PrprtyLctn  : ISO20022.Cain025001.Location6
        + PrprtyId  : ISO20022.Cain025001.PartyIdentification285
        + PrprtyNm  : String
        + PrstgsPrprty  : String
        + PrprtyOthrTp  : String
        + PrprtyTp  : String
        + FolioNb  : String
    }
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.LodgingLineItem3
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.LoyaltyProgramme4
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.AuthorisedAmount2
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.DepartureOrArrival1
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.DepartureOrArrival2
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.LodgingRoom2
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.ContactPersonal1
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.Credentials3
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.Location6
    ISO20022.Cain025001.Lodging4 *-- ISO20022.Cain025001.PartyIdentification285
    class ISO20022.Cain025001.LodgingActivity1Code {
        TOSH = 1
        ROAB = 2
        RESO = 3
        OTHP = 4
        OTHN = 5
        MOTL = 6
        LODG = 7
        HOTL = 8
        HOST = 9
        HOME = 10
        CRUI = 11
        COTT = 12
        BEBR = 13
        APTM = 14
    }
    class ISO20022.Cain025001.LodgingLineItem3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + SubTtlAmt  : Decimal
        + Drtn  : String
        + UnitAmt  : Decimal
        + CdtDbt  : String
        + PstChckOut  : String
        + OthrTp  : String
        + Tp  : String
        + Tm  : DateTime
        + Dt  : DateTime
    }
    ISO20022.Cain025001.LodgingLineItem3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.LodgingLineItem3 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.LodgingRoom2 {
        + DalyRate  : Decimal
        + Chldrn  : String
        + Adlts  : String
        + Gsts  : String
        + BedTp  : String
        + Lctn  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.LodgingService1Code {
        VODS = 1
        TRAN = 2
        THRD = 3
        SPAS = 4
        RMSE = 5
        REST = 6
        PHON = 7
        PARK = 8
        OTHR = 9
        NOSH = 10
        MINI = 11
        LONG = 12
        LAUN = 13
        INTE = 14
        HEAL = 15
        GIFT = 16
        GARA = 17
        GAME = 18
        FCAA = 19
        ENTR = 20
        EARD = 21
        EARA = 22
        CONC = 23
        BUSS = 24
        BREK = 25
        BANQ = 26
        AUDI = 27
        ACCO = 28
    }
    class ISO20022.Cain025001.LoyaltyProgramme4 {
        + PtcptId  : String
        + Id  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.LoyaltyProgramme5 {
        + Bal  : String
        + ValToDbt  : String
        + ValToCdt  : String
        + OthrValTp  : String
        + ValTp  : String
        + Val  : String
        + XprtnDt  : DateTime
        + MmbSts  : String
        + MmbId  : String
        + MmbAdr  : ISO20022.Cain025001.Address2
        + MmbNm  : ISO20022.Cain025001.CardholderName3
        + Issr  : String
        + Elgblty  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Cain025001.LoyaltyProgramme5 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.LoyaltyProgramme5 *-- ISO20022.Cain025001.CardholderName3
    class ISO20022.Cain025001.LoyaltyValueType1Code {
        PRIV = 1
        POIN = 2
        OTHR = 3
        MONE = 4
        MILE = 5
    }
    class ISO20022.Cain025001.MACData1 {
        + InitlstnVctr  : String
        + PddgMtd  : String
        + KeyIndx  : String
        + KeyPrtcn  : String
        + KeyLngth  : String
        + Algo  : String
        + DrvdInf  : String
        + KeySetIdr  : String
        + Ctrl  : String
    }
    class ISO20022.Cain025001.MessageClass1Code {
        VERI = 1
        INQY = 2
        FINL = 3
        FEEC = 4
        CBCK = 5
        CMGT = 6
        AUTH = 7
        AMDT = 8
        ADDE = 9
    }
    class ISO20022.Cain025001.MessageFunction16Code {
        REQU = 1
        CANO = 2
        CAAD = 3
        NOTI = 4
        ADVC = 5
    }
    class ISO20022.Cain025001.OfficialDocumentType1Code {
        REFU = 1
        PERM = 2
        VISA = 3
        PASS = 4
        OTHP = 5
        OTHN = 6
        LZPR = 7
        INPO = 8
        INTE = 9
        IDEN = 10
        EURO = 11
        DVLC = 12
        DIPL = 13
        AUTH = 14
        ARNU = 15
    }
    class ISO20022.Cain025001.OnBoardDiagnostics1 {
        + HardAcclrtn  : String
        + HardBrakg  : String
        + BttryVltg  : String
        + CoolntTmprtr  : Decimal
        + RfrgrtnTmprtr  : Decimal
        + RfrgrtnHrs  : Decimal
        + FuelEcnmy  : Decimal
        + FuelGaugeLvl  : String
        + FuelTankLvlStart  : String
        + ChckNgnWrngSts  : String
        + NgnOilLifeRmng  : String
        + NgnOilPrssr  : String
        + NgnOilTmprtr  : Decimal
        + NgnRPM  : String
        + NgnLd  : String
        + NgnTtlTm  : Decimal
        + NgnHrs  : Decimal
        + NgnTtlIdleTm  : Decimal
        + NgnIdleTm  : Decimal
    }
    class ISO20022.Cain025001.OriginalDataElements3 {
        + ApprvlCd  : String
        + RspnCd  : String
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalFee3~
        + TxAmts  : ISO20022.Cain025001.OriginalTransactionAmounts3
        + ConvsDtTm  : ISO20022.Cain025001.DateTime2
        + TxId  : ISO20022.Cain025001.OriginalTransactionIdentification1
        + TxTp  : String
        + SndrId  : String
        + AcqrrId  : String
        + MsgFctn  : String
        + MsgClss  : String
    }
    ISO20022.Cain025001.OriginalDataElements3 *-- ISO20022.Cain025001.AdditionalFee3
    ISO20022.Cain025001.OriginalDataElements3 *-- ISO20022.Cain025001.OriginalTransactionAmounts3
    ISO20022.Cain025001.OriginalDataElements3 *-- ISO20022.Cain025001.DateTime2
    ISO20022.Cain025001.OriginalDataElements3 *-- ISO20022.Cain025001.OriginalTransactionIdentification1
    class ISO20022.Cain025001.OriginalTransactionAmounts3 {
        + RcncltnFctvXchgRate  : Decimal
        + RcncltnCcy  : String
        + RcncltnAmt  : Decimal
        + CrdhldrBllgFctvXchgRate  : Decimal
        + CrdhldrBllgCcy  : String
        + CrdhldrBllgAmt  : Decimal
        + Ccy  : String
        + Amt  : Decimal
        + AmtQlfr  : String
    }
    class ISO20022.Cain025001.OriginalTransactionIdentification1 {
        + IssrRefData  : String
        + AcqrrRefNb  : String
        + AcqrrRefData  : String
        + LifeCyclIdMssng  : String
        + AuthntcnTkn  : String
        + PresntmntSeqCnt  : String
        + PresntmntSeqNb  : String
        + AuthstnSeqNb  : String
        + LifeCyclId  : String
        + LifeCyclSpprt  : String
        + RtrvlRefNb  : String
        + SysTracAudtNb  : String
        + TrnsmssnDtTm  : DateTime
        + PurchsIdr  : String
        + OthrPurchsIdrTp  : String
        + PurchsIdrTp  : String
        + TmZone  : String
        + LclTm  : DateTime
        + LclDt  : DateTime
    }
    class ISO20022.Cain025001.Parameter13 {
        + MskGnrtrAlgo  : ISO20022.Cain025001.AlgorithmIdentification26
        + DgstAlgo  : String
    }
    ISO20022.Cain025001.Parameter13 *-- ISO20022.Cain025001.AlgorithmIdentification26
    class ISO20022.Cain025001.Parameter14 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Cain025001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Cain025001.PartyIdentification285 {
        + LclData  : global::System.Collections.Generic.List~ISO20022.Cain025001.LocalData14~
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain025001.PartyIdentification285 *-- ISO20022.Cain025001.LocalData14
    ISO20022.Cain025001.PartyIdentification285 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.PartyIdentification286 {
        + LclData  : ISO20022.Cain025001.LocalData14
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain025001.PartyIdentification286 *-- ISO20022.Cain025001.LocalData14
    ISO20022.Cain025001.PartyIdentification286 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.PartyIdentification288 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + OwnrEthnctyTpPrvddBy  : String
        + OwnrEthnctyTp  : String
        + CertfctnTpPrvddBy  : String
        + CertfctnTp  : String
        + OwnrTpPrvddBy  : String
        + OwnrTp  : String
        + BizTpPrvddBy  : String
        + BizTp  : String
        + CorpTaxIdTp  : String
        + CorpTaxId  : String
        + AddtlTxRefNb  : String
        + SpnsrdMrchnt  : global::System.Collections.Generic.List~ISO20022.Cain025001.SponsoredMerchant3~
        + LclData  : global::System.Collections.Generic.List~ISO20022.Cain025001.LocalData11~
        + TaxRegnId  : String
        + AddtlCtct  : String
        + CstmrSvc  : String
        + Phne  : String
        + URL  : String
        + Email  : String
        + GeogcLctn  : String
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain025001.Address2
        + NmAndLctn  : String
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain025001.PartyIdentification288 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.PartyIdentification288 *-- ISO20022.Cain025001.SponsoredMerchant3
    ISO20022.Cain025001.PartyIdentification288 *-- ISO20022.Cain025001.LocalData11
    ISO20022.Cain025001.PartyIdentification288 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.PartyIdentification288 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.PartyType17Code {
        AGNT = 1
        CISP = 2
        CISS = 3
        ACQP = 4
        ACQR = 5
        OTHP = 6
        OTHN = 7
    }
    class ISO20022.Cain025001.PartyType18Code {
        AGNT = 1
        CSCH = 2
        CISS = 3
        ACQR = 4
    }
    class ISO20022.Cain025001.PartyType32Code {
        OTHP = 1
        OTHN = 2
        ISUR = 3
        AGNT = 4
        ACQR = 5
    }
    class ISO20022.Cain025001.PassengerTransport3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + HirdVhclDtls  : global::System.Collections.Generic.List~ISO20022.Cain025001.HiredVehicle3~
        + AncllryPurchs  : global::System.Collections.Generic.List~ISO20022.Cain025001.AncillaryPurchase3~
        + TripLeg  : global::System.Collections.Generic.List~ISO20022.Cain025001.TripLeg3~
        + LltyPrgrmm  : ISO20022.Cain025001.LoyaltyProgramme4
        + SummryCmmdtyId  : String
        + TtlAmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.AmountDetails3~
        + Insrnc  : String
        + Drtn  : String
        + Dprture  : ISO20022.Cain025001.DepartureOrArrival1
        + Pssngr  : global::System.Collections.Generic.List~ISO20022.Cain025001.Customer9~
        + CstmrRef  : global::System.Collections.Generic.List~ISO20022.Cain025001.CustomerReference1~
        + OpnTckt  : String
        + TcktIssr  : String
        + TrvlAuthstnCd  : String
        + OrgnlRsvatnNb  : String
        + OrgnlRsvatnSys  : String
        + RsvatnNb  : String
        + RsvatnSys  : String
        + DocNb  : String
    }
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.HiredVehicle3
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.AncillaryPurchase3
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.TripLeg3
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.LoyaltyProgramme4
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.AmountDetails3
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.DepartureOrArrival1
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.Customer9
    ISO20022.Cain025001.PassengerTransport3 *-- ISO20022.Cain025001.CustomerReference1
    class ISO20022.Cain025001.PeriodUnit2Code {
        OTHR = 1
        MINU = 2
        YEAR = 3
        MNTH = 4
        WEEK = 5
        DAYS = 6
        HFDA = 7
        HOUR = 8
    }
    class ISO20022.Cain025001.PeriodUnit3Code {
        EXDY = 1
        DAYS = 2
        YEAR = 3
        WEEK = 4
        MNTH = 5
        OTHN = 6
        OTHP = 7
    }
    class ISO20022.Cain025001.PeriodUnit4Code {
        OTHR = 1
        HOUR = 2
        HFDA = 3
        MINU = 4
        EXDY = 5
        DAYS = 6
        YEAR = 7
        WEEK = 8
        MNTH = 9
        OTHN = 10
        OTHP = 11
    }
    class ISO20022.Cain025001.PlainCardData23 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Id  : String
    }
    ISO20022.Cain025001.PlainCardData23 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.PresentationMedium2Code {
        BOTH = 1
        PAPR = 2
        ELEC = 3
        BIOM = 4
    }
    class ISO20022.Cain025001.Product8 {
        + SummryCmmdtyId  : String
        + Cd  : String
    }
    class ISO20022.Cain025001.ProductCodeType1Code {
        UPCE = 1
        UPCA = 2
        RS14 = 3
        PLUP = 4
        OTHR = 5
        GTIN = 6
        EAN8 = 7
        EA13 = 8
    }
    class ISO20022.Cain025001.ProgrammeMode5 {
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + ApldId  : String
    }
    ISO20022.Cain025001.ProgrammeMode5 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.ProtectedData2 {
        + NcrptdData  : ISO20022.Cain025001.EncryptedData2
        + EnvlpdData  : ISO20022.Cain025001.EnvelopedData12
        + CnttTp  : String
    }
    ISO20022.Cain025001.ProtectedData2 *-- ISO20022.Cain025001.EncryptedData2
    ISO20022.Cain025001.ProtectedData2 *-- ISO20022.Cain025001.EnvelopedData12
    class ISO20022.Cain025001.ProtectionMethod1Code {
        TEEN = 1
        SOFT = 2
        SNCL = 3
        SELM = 4
        OTHP = 5
        OTHN = 6
    }
    class ISO20022.Cain025001.PurchaseIdentifierType2Code {
        TREF = 1
        TRNU = 2
        REAG = 3
        CUPO = 4
        CUOR = 5
        ORNU = 6
        PRNU = 7
        FONU = 8
        CONU = 9
        SUOR = 10
        TINU = 11
        RSNU = 12
        RENU = 13
        PUID = 14
        INNU = 15
        RELO = 16
        SUIN = 17
        OTHP = 18
        OTHN = 19
    }
    class ISO20022.Cain025001.Recipient5Choice {
        + KeyIdr  : ISO20022.Cain025001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Cain025001.IssuerAndSerialNumber1
    }
    ISO20022.Cain025001.Recipient5Choice *-- ISO20022.Cain025001.KEKIdentifier2
    ISO20022.Cain025001.Recipient5Choice *-- ISO20022.Cain025001.IssuerAndSerialNumber1
    class ISO20022.Cain025001.Recipient7Choice {
        + KeyIdr  : ISO20022.Cain025001.KEKIdentifier6
        + KEK  : ISO20022.Cain025001.KEK6
        + KeyTrnsprt  : ISO20022.Cain025001.KeyTransport6
    }
    ISO20022.Cain025001.Recipient7Choice *-- ISO20022.Cain025001.KEKIdentifier6
    ISO20022.Cain025001.Recipient7Choice *-- ISO20022.Cain025001.KEK6
    ISO20022.Cain025001.Recipient7Choice *-- ISO20022.Cain025001.KeyTransport6
    class ISO20022.Cain025001.Reconciliation4 {
        + ChckptRef  : String
        + Dt  : DateTime
        + Id  : String
    }
    class ISO20022.Cain025001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Cain025001.RentalDetails3 {
        + Ccy  : String
        + TmPrdRate  : Decimal
        + TmPrdUnit  : String
        + TmPrd  : global::System.Collections.Generic.List~String~
        + Rtr  : ISO20022.Cain025001.ServiceStartEnd3
        + Start  : ISO20022.Cain025001.ServiceStartEnd3
        + DtTm  : DateTime
        + Id  : String
    }
    ISO20022.Cain025001.RentalDetails3 *-- ISO20022.Cain025001.ServiceStartEnd3
    ISO20022.Cain025001.RentalDetails3 *-- ISO20022.Cain025001.ServiceStartEnd3
    class ISO20022.Cain025001.RentalRate1 {
        + PrdCnt  : String
        + Rate  : Decimal
        + OthrPrd  : String
        + Prd  : String
    }
    class ISO20022.Cain025001.RentalRate2 {
        + PrdCnt  : String
        + Rate  : Decimal
        + OthrPrd  : String
        + Prd  : String
    }
    class ISO20022.Cain025001.Sale3 {
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Cain025001.SaleItem4~
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Adjustment13~
        + LltyPrgrmm  : ISO20022.Cain025001.LoyaltyProgramme4
        + SummryCmmdtyId  : String
    }
    ISO20022.Cain025001.Sale3 *-- ISO20022.Cain025001.SaleItem4
    ISO20022.Cain025001.Sale3 *-- ISO20022.Cain025001.Adjustment13
    ISO20022.Cain025001.Sale3 *-- ISO20022.Cain025001.LoyaltyProgramme4
    class ISO20022.Cain025001.SaleItem4 {
        + TtlAmt  : Decimal
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + InsrncAmt  : Decimal
        + InsrncInd  : String
        + AdjstdAmt  : Decimal
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Adjustment14~
        + NonAdjstdTtlAmt  : Decimal
        + NonAdjstdUnitPric  : Decimal
        + PdctQty  : Decimal
        + OthrUnitOfMeasr  : String
        + UnitOfMeasr  : String
        + PdctDesc  : String
        + PdctCdModfr  : Decimal
        + AddtlPdctCdTp  : String
        + AddtlPdctCd  : String
        + PdctCdTp  : String
        + PdctCd  : String
        + PdctTp  : String
    }
    ISO20022.Cain025001.SaleItem4 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.SaleItem4 *-- ISO20022.Cain025001.Adjustment14
    class ISO20022.Cain025001.ServiceStartEnd3 {
        + JrnyDtAndTm  : DateTime
        + JrnyData  : String
        + JrnyTp  : String
        + TmSgmt  : String
        + DtAndTm  : DateTime
        + Ctct  : ISO20022.Cain025001.ContactBusiness1
        + Adr  : ISO20022.Cain025001.Address2
        + LctnCd  : String
        + Lctn  : String
    }
    ISO20022.Cain025001.ServiceStartEnd3 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.ServiceStartEnd3 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.SettlementService6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + RptgNttyId  : String
        + RptgNttyTp  : String
        + CutOffTm  : DateTime
        + Prd  : String
        + Tm  : DateTime
        + Dt  : DateTime
        + Dfrrd  : String
        + ReqdDt  : DateTime
        + Id  : String
        + Tp  : String
    }
    ISO20022.Cain025001.SettlementService6 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.ShippingData3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Packg  : global::System.Collections.Generic.List~ISO20022.Cain025001.ShippingPackage3~
        + NbOfPackgs  : String
        + SummryCmmdtyId  : String
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + NetAmt  : Decimal
        + InsrncAmt  : Decimal
        + Insrnc  : String
        + MiscExpnss  : Decimal
        + IncntivAmt  : Decimal
        + SvcDscrptrCd  : String
        + InvcCreDtTm  : DateTime
        + InvcNb  : String
    }
    ISO20022.Cain025001.ShippingData3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.ShippingData3 *-- ISO20022.Cain025001.ShippingPackage3
    ISO20022.Cain025001.ShippingData3 *-- ISO20022.Cain025001.Tax41
    class ISO20022.Cain025001.ShippingPackage3 {
        + InsrncAmt  : Decimal
        + Insrnc  : String
        + Pdct  : global::System.Collections.Generic.List~ISO20022.Cain025001.Product8~
        + NbOfUnits  : Decimal
        + OthrWghtUnit  : String
        + WghtUnit  : String
        + DlvryTm  : DateTime
        + DlvryDt  : DateTime
        + DlvryInstrs  : String
        + DlvryCtct  : ISO20022.Cain025001.ContactPersonal1
        + DlvryAdr  : ISO20022.Cain025001.Address2
        + DlvryNoteNb  : String
        + PckpTm  : DateTime
        + PckpDt  : DateTime
        + SpplrInstrs  : String
        + SpplrCtct  : ISO20022.Cain025001.ContactBusiness1
        + SpplrAdr  : ISO20022.Cain025001.Address2
        + SpplrId  : ISO20022.Cain025001.PartyIdentification285
        + SpplrNm  : String
        + TrckgNb  : String
    }
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.Product8
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.ContactPersonal1
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.ShippingPackage3 *-- ISO20022.Cain025001.PartyIdentification285
    class ISO20022.Cain025001.SponsoredMerchant3 {
        + LclData  : global::System.Collections.Generic.List~ISO20022.Cain025001.LocalData12~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + GeogcLctn  : String
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain025001.Address2
        + LglCorpNm  : String
        + CmonNm  : String
        + Frgn  : String
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain025001.SponsoredMerchant3 *-- ISO20022.Cain025001.LocalData12
    ISO20022.Cain025001.SponsoredMerchant3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.SponsoredMerchant3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.SponsoredMerchant3 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.StorageLocation1Code {
        TPWL = 1
        OTHP = 2
        OTHN = 3
        ONFL = 4
        ISWL = 5
        DVCE = 6
        CAWL = 7
    }
    class ISO20022.Cain025001.SupplementaryData1 {
        + Envlp  : ISO20022.Cain025001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Cain025001.SupplementaryData1 *-- ISO20022.Cain025001.SupplementaryDataEnvelope1
    class ISO20022.Cain025001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Cain025001.Tax41 {
        + CdtDbt  : String
        + InclInTtl  : String
        + Rate  : Decimal
        + Amt  : Decimal
        + XmptRsn  : String
        + Xmptn  : String
        + Desc  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.TaxReclaimMethod1Code {
        OTHR = 1
        INSU = 2
        INPS = 3
        INPP = 4
    }
    class ISO20022.Cain025001.TelecomServices3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Cain025001.TelecomServicesLineItem3~
        + TtlTax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + BllgEvt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount22~
        + BllgEnd  : DateTime
        + BllgStart  : DateTime
        + CstmrPhne  : String
        + CstmrNm  : String
        + CstmrAcctNb  : String
    }
    ISO20022.Cain025001.TelecomServices3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.TelecomServices3 *-- ISO20022.Cain025001.TelecomServicesLineItem3
    ISO20022.Cain025001.TelecomServices3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.TelecomServices3 *-- ISO20022.Cain025001.Amount22
    class ISO20022.Cain025001.TelecomServicesLineItem3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Desc  : String
        + TtlAmt  : Decimal
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + Chrg  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount23~
        + CallToCtry  : String
        + CallToCtrySubDvsnMnr  : String
        + CallToCtrySubDvsnMjr  : String
        + CallToCity  : String
        + CallToPhne  : String
        + CallToOthrTp  : String
        + CallToTp  : String
        + CallFrCtry  : String
        + CallFrCtrySubDvsnMnr  : String
        + CallFrCtrySubDvsnMjr  : String
        + CallFrCity  : String
        + CallFrPhne  : String
        + CallFrOthrTp  : String
        + CallFrTp  : String
        + Drtn  : DateTime
        + TmPrd  : String
        + StartDtTm  : DateTime
    }
    ISO20022.Cain025001.TelecomServicesLineItem3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.TelecomServicesLineItem3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.TelecomServicesLineItem3 *-- ISO20022.Cain025001.Amount23
    class ISO20022.Cain025001.TelephonyCallType1Code {
        ICPC = 1
        OTCL = 2
        OTHN = 3
        OTHP = 4
        OGPC = 5
        PAGE = 6
        TFPC = 7
        VCML = 8
    }
    class ISO20022.Cain025001.TemporaryServices3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + SbttlAmt  : Decimal
        + MiscExpnss  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount13~
        + Chrg  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount12~
        + WkEndg  : DateTime
        + TmSheet  : String
        + SummryCmmdtyId  : String
        + DscntAmt  : Decimal
        + FlatRateInd  : String
        + JobEndDt  : DateTime
        + JobDrtn  : String
        + JobStartDt  : DateTime
        + JobDesc  : String
        + JobCd  : String
        + MplyeePrfssnlLvl  : String
        + MplyeeNm  : String
        + MplyeeId  : String
        + MplyeePrsnlId  : String
        + CpnySprvsr  : String
        + CpnyId  : ISO20022.Cain025001.PartyIdentification285
        + CpnyDept  : String
        + CpnyNm  : String
    }
    ISO20022.Cain025001.TemporaryServices3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.TemporaryServices3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.TemporaryServices3 *-- ISO20022.Cain025001.Amount13
    ISO20022.Cain025001.TemporaryServices3 *-- ISO20022.Cain025001.Amount12
    ISO20022.Cain025001.TemporaryServices3 *-- ISO20022.Cain025001.PartyIdentification285
    class ISO20022.Cain025001.TemporaryServicesCharge1Code {
        HAZD = 1
        HOLI = 2
        NITE = 3
        ONCL = 4
        OTHN = 5
        OTHP = 6
        OVRT = 7
        REGL = 8
        WKND = 9
    }
    class ISO20022.Cain025001.TimeSegment1Code {
        PMAN = 1
        AMBN = 2
    }
    class ISO20022.Cain025001.Token2 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + OthrPrtcnMtd  : String
        + PrtcnMtd  : String
        + OthrStorgLctn  : String
        + StorgLctn  : String
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknRqstrId  : String
        + TknXpryDt  : String
        + PmtTkn  : String
    }
    ISO20022.Cain025001.Token2 *-- ISO20022.Cain025001.AdditionalData1
    class ISO20022.Cain025001.Traceability10 {
        + DtTmOut  : DateTime
        + DtTmIn  : DateTime
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cain025001.TransactionIdentification53 {
        + AssoctdDataRef  : String
        + IssrRefData  : String
        + AcqrrRefNb  : String
        + AcqrrRefData  : String
        + AuthntcnTkn  : String
        + PresntmntSeqCnt  : String
        + PresntmntSeqNb  : String
        + AuthstnSeqNb  : String
        + LifeCyclId  : String
        + LifeCyclSpprt  : String
        + RtrvlRefNb  : String
        + SysTracAudtNb  : String
        + TrnsmssnDtTm  : DateTime
        + PurchsIdr  : String
        + OthrPurchsIdrTp  : String
        + PurchsIdrTp  : String
    }
    class ISO20022.Cain025001.TransportType1Code {
        SHIP = 1
        RAIL = 2
        OTHP = 3
        OTHN = 4
        BUSS = 5
        AIRR = 6
    }
    class ISO20022.Cain025001.TravelAgency4 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + TrvlPackg  : global::System.Collections.Generic.List~ISO20022.Cain025001.TravelAgencyPackage2~
        + Ctct  : ISO20022.Cain025001.ContactBusiness1
        + Adr  : ISO20022.Cain025001.Address2
        + ShrtNm  : String
        + Nm  : String
        + IATACd  : String
        + Assgnr  : String
        + Cd  : String
    }
    ISO20022.Cain025001.TravelAgency4 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.TravelAgency4 *-- ISO20022.Cain025001.TravelAgencyPackage2
    ISO20022.Cain025001.TravelAgency4 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.TravelAgency4 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.TravelAgencyPackage2 {
        + Fee  : Decimal
        + InsrncAmt  : Decimal
        + Insrnc  : String
        + CdtCardSlipNb  : String
        + DlvryOrdrNb  : String
        + DataSrc  : String
        + CstmrRef  : global::System.Collections.Generic.List~ISO20022.Cain025001.CustomerReference1~
        + NbInPty  : String
        + Tp  : String
        + RsvatnNb  : String
    }
    ISO20022.Cain025001.TravelAgencyPackage2 *-- ISO20022.Cain025001.CustomerReference1
    class ISO20022.Cain025001.TravelDocument2 {
        + Ctry  : String
        + XprtnDt  : DateTime
        + IssncDt  : DateTime
        + Assgnr  : String
        + Id  : String
        + Form  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.TripLeg3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + LltyPrgrmm  : ISO20022.Cain025001.LoyaltyProgramme4
        + PrcdrId  : String
        + CdtRsnCd  : String
        + Amt  : global::System.Collections.Generic.List~ISO20022.Cain025001.AmountDetails3~
        + Insrnc  : String
        + FairBsisCd  : String
        + NonDrctRouteCd  : String
        + StopOver  : String
        + Drtn  : String
        + Arrvl  : ISO20022.Cain025001.DepartureOrArrival1
        + Dprture  : ISO20022.Cain025001.DepartureOrArrival1
        + SvcClss  : String
        + RouteNb  : String
        + IATACd  : String
        + CrrierCd  : String
        + CrrierNm  : String
        + CmmdtyCd  : String
        + OthrTrnsprtTp  : String
        + TrnsprtTp  : String
        + Doc  : global::System.Collections.Generic.List~ISO20022.Cain025001.DocumentReference1~
        + OrgnlRsvatnNb  : String
        + OrgnlRsvatnSys  : String
        + RsvatnNb  : String
        + RsvatnSys  : String
        + RcrdLctrNb  : String
        + XchgdTcktNb  : String
        + XchgdTckt  : String
        + TcktRstrctns  : String
        + OpnTckt  : String
        + RstrctdTckt  : String
        + CnjnctnTcktNb  : String
        + TcktIsseLctn  : String
        + TcktIsseDt  : DateTime
        + TcktIssr  : String
        + TcktNb  : String
        + SeqNb  : String
    }
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.LoyaltyProgramme4
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.AmountDetails3
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.DepartureOrArrival1
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.DepartureOrArrival1
    ISO20022.Cain025001.TripLeg3 *-- ISO20022.Cain025001.DocumentReference1
    class ISO20022.Cain025001.TypeOfAmount19Code {
        USGE = 1
        OTHP = 2
        OTHN = 3
        MISC = 4
        LNDS = 5
        INSU = 6
        CONN = 7
    }
    class ISO20022.Cain025001.TypeOfAmount21Code {
        MNIF = 1
        MXIF = 2
        CSIF = 3
        FEEA = 4
        OTHP = 5
        OTHN = 6
        FEEP = 7
        INTC = 8
    }
    class ISO20022.Cain025001.TypeOfAmount22Code {
        RESD = 1
        PRXY = 2
        MAXI = 3
        ESTM = 4
        DPST = 5
        DFLT = 6
        ACTL = 7
    }
    class ISO20022.Cain025001.TypeTypeOfAmount23Code {
        FEES = 1
        TKDL = 2
        UPGD = 3
        TOUR = 4
        TOTL = 5
        PRPY = 6
        PHNE = 7
        PETC = 8
        OTHP = 9
        OTHN = 10
        MISC = 11
        INSU = 12
        FDBV = 13
        FARE = 14
        EXTR = 15
        EXTF = 16
        EXTK = 17
        DUTY = 18
        CLUB = 19
        CHTC = 20
        CARG = 21
        BAGG = 22
        AMTH = 23
    }
    class ISO20022.Cain025001.UnitOfMeasure10Code {
        MILE = 1
        KMET = 2
    }
    class ISO20022.Cain025001.UnitOfMeasure1Code {
        ACRE = 1
        SQIN = 2
        SQFO = 3
        SQYA = 4
        SQMI = 5
        SMIL = 6
        SCMT = 7
        SMET = 8
        ARES = 9
        HECT = 10
        SQKI = 11
        YARD = 12
        KMET = 13
        MILE = 14
        USPI = 15
        GBPI = 16
        USQA = 17
        GBQA = 18
        USOU = 19
        GBOU = 20
        MILI = 21
        CELI = 22
        LITR = 23
        MMET = 24
        CMET = 25
        METR = 26
        PUND = 27
        KILO = 28
        INCH = 29
        GRAM = 30
        USGA = 31
        GBGA = 32
        FOOT = 33
        TONS = 34
        PIEC = 35
    }
    class ISO20022.Cain025001.Vehicle2 {
        + Data  : String
        + NtryMd  : String
        + Tp  : String
    }
    class ISO20022.Cain025001.Vehicle6 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.Vehicle2~
        + OnBrdDgnstcs  : ISO20022.Cain025001.OnBoardDiagnostics1
        + MntncId  : String
        + Hbmtr  : Decimal
        + Odmtr  : Decimal
        + Rplcmnt  : String
        + TagNtryMd  : String
        + Tag  : String
        + TrlrNb  : String
        + UnitNb  : String
        + SubFleetNb  : String
        + FleetNb  : String
        + IdNb  : String
        + Nb  : String
    }
    ISO20022.Cain025001.Vehicle6 *-- ISO20022.Cain025001.Vehicle2
    ISO20022.Cain025001.Vehicle6 *-- ISO20022.Cain025001.OnBoardDiagnostics1
    class ISO20022.Cain025001.VehicleRentalAgreement3 {
        + LltyPrgrmm  : global::System.Collections.Generic.List~ISO20022.Cain025001.LoyaltyProgramme5~
        + DscntPrgrmm  : global::System.Collections.Generic.List~ISO20022.Cain025001.Discount3~
        + EstmtdTax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + AddtlAmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount21~
        + Insrnc  : String
        + RntlDtls  : ISO20022.Cain025001.RentalDetails3
        + RntlRate  : global::System.Collections.Generic.List~ISO20022.Cain025001.RentalRate2~
        + TrvlDstnc  : ISO20022.Cain025001.Distance1
        + RegnNb  : String
        + Mdl  : String
        + Make  : String
        + Clss  : String
        + Drtn  : String
        + ChckInTm  : DateTime
        + ChckInDt  : DateTime
        + RtrLctn  : ISO20022.Cain025001.Address2
        + ChckOutTm  : DateTime
        + ChckOutDt  : DateTime
        + PckpLctn  : global::System.Collections.Generic.List~ISO20022.Cain025001.Address2~
        + RntlLctn  : ISO20022.Cain025001.Address2
        + Adjstd  : String
        + Nb  : String
    }
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.LoyaltyProgramme5
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Discount3
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Amount21
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.RentalDetails3
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.RentalRate2
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Distance1
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.VehicleRentalAgreement3 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.VehicleRentalInvoice3 {
        + Tax  : global::System.Collections.Generic.List~ISO20022.Cain025001.Tax41~
        + AddtlAmt  : global::System.Collections.Generic.List~ISO20022.Cain025001.Amount21~
        + Insrnc  : String
        + SummryCmmdtyId  : String
        + Chrg  : global::System.Collections.Generic.List~ISO20022.Cain025001.RentalRate1~
        + DstncRate  : Decimal
        + FreeDstnc  : String
        + TtlDstnc  : String
        + OdmtrRtr  : String
        + OdmtrStart  : String
        + DstncUnit  : String
        + RegnNbPrvdd  : String
        + MdlPrvdd  : String
        + MakePrvdd  : String
        + ClssPrvdd  : String
        + RegnNbInvcd  : String
        + MdlInvcd  : String
        + MakeInvcd  : String
        + ClssInvcd  : String
        + Drtn  : String
        + ChckInTm  : DateTime
        + ChckInDt  : DateTime
        + ChckOutTm  : DateTime
        + ChckOutDt  : DateTime
        + RtrLctn  : ISO20022.Cain025001.Address2
        + Adjstd  : String
        + NoShow  : String
    }
    ISO20022.Cain025001.VehicleRentalInvoice3 *-- ISO20022.Cain025001.Tax41
    ISO20022.Cain025001.VehicleRentalInvoice3 *-- ISO20022.Cain025001.Amount21
    ISO20022.Cain025001.VehicleRentalInvoice3 *-- ISO20022.Cain025001.RentalRate1
    ISO20022.Cain025001.VehicleRentalInvoice3 *-- ISO20022.Cain025001.Address2
    class ISO20022.Cain025001.VehicleRentalService3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain025001.AdditionalData1~
        + RntlInvc  : ISO20022.Cain025001.VehicleRentalInvoice3
        + RntlAgrmt  : ISO20022.Cain025001.VehicleRentalAgreement3
        + SummryCmmdtyId  : String
        + LltyPrgrmm  : ISO20022.Cain025001.LoyaltyProgramme4
        + AddtlDrvr  : global::System.Collections.Generic.List~ISO20022.Cain025001.DriverInParty3~
        + PmryDrvr  : ISO20022.Cain025001.DriverInParty3
        + RntrCorpIdrAssgnr  : String
        + RntrCorpIdr  : String
        + RntrCorpNm  : String
        + RntrNm  : String
        + CpnyOthrTp  : String
        + CpnyTp  : String
        + CpnyCtct  : ISO20022.Cain025001.ContactBusiness1
        + CpnyAdr  : ISO20022.Cain025001.Address2
        + CpnyId  : ISO20022.Cain025001.PartyIdentification285
        + CpnyNm  : String
    }
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.AdditionalData1
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.VehicleRentalInvoice3
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.VehicleRentalAgreement3
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.LoyaltyProgramme4
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.DriverInParty3
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.DriverInParty3
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.ContactBusiness1
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.Address2
    ISO20022.Cain025001.VehicleRentalService3 *-- ISO20022.Cain025001.PartyIdentification285
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

## Value ISO20022.Cain025001.AddendumData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData2>||XmlElement()||
|+|TempSvcs|global::System.Collections.Generic.List<ISO20022.Cain025001.TemporaryServices3>||XmlElement()||
|+|TelecomSvcs|ISO20022.Cain025001.TelecomServices3||XmlElement()||
|+|ShppgData|ISO20022.Cain025001.ShippingData3||XmlElement()||
|+|Ldgg|global::System.Collections.Generic.List<ISO20022.Cain025001.Lodging4>||XmlElement()||
|+|VhclRntl|global::System.Collections.Generic.List<ISO20022.Cain025001.VehicleRentalService3>||XmlElement()||
|+|PssngrTrnsprt|ISO20022.Cain025001.PassengerTransport3||XmlElement()||
|+|TrvlAgcy|global::System.Collections.Generic.List<ISO20022.Cain025001.TravelAgency4>||XmlElement()||
|+|Invc|ISO20022.Cain025001.Invoice3||XmlElement()||
|+|Fleet|ISO20022.Cain025001.FleetData6||XmlElement()||
|+|Sale|ISO20022.Cain025001.Sale3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""TempSvcs""",TempSvcs),validElement(TempSvcs),validElement(TelecomSvcs),validElement(ShppgData),validList("""Ldgg""",Ldgg),validElement(Ldgg),validList("""VhclRntl""",VhclRntl),validElement(VhclRntl),validElement(PssngrTrnsprt),validList("""TrvlAgcy""",TrvlAgcy),validElement(TrvlAgcy),validElement(Invc),validElement(Fleet),validElement(Sale))|

---

## Aspect ISO20022.Cain025001.AddendumInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Cain025001.ContentInformationType41||XmlElement()||
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Cain025001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|global::System.Collections.Generic.List<ISO20022.Cain025001.ProtectedData2>||XmlElement()||
|+|AdddmData|ISO20022.Cain025001.AddendumData6||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Cain025001.Reconciliation4||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain025001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain025001.Jurisdiction2||XmlElement()||
|+|Cstmr|ISO20022.Cain025001.Customer4||XmlElement()||
|+|Accptr|ISO20022.Cain025001.PartyIdentification288||XmlElement()||
|+|OrgnlDataElmts|ISO20022.Cain025001.OriginalDataElements3||XmlElement()||
|+|Tkn|ISO20022.Cain025001.Token2||XmlElement()||
|+|TxId|ISO20022.Cain025001.TransactionIdentification53||XmlElement()||
|+|Prgrmm|global::System.Collections.Generic.List<ISO20022.Cain025001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cain025001.CardData14||XmlElement()||
|+|Sndr|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain025001.PartyIdentification286||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|DataSrc|String||XmlElement()||
|+|Hdr|ISO20022.Cain025001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(AdddmData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Cstmr),validElement(Accptr),validElement(OrgnlDataElmts),validElement(Tkn),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))|

---

## Enum ISO20022.Cain025001.AddendumTaxType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DPTX|Int32||XmlEnum("""DPTX""")|1|
||TNRT|Int32||XmlEnum("""TNRT""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||WITL|Int32||XmlEnum("""WITL""")|4|
||WITF|Int32||XmlEnum("""WITF""")|5|
||WESV|Int32||XmlEnum("""WESV""")|6|
||WTAX|Int32||XmlEnum("""WTAX""")|7|
||VATB|Int32||XmlEnum("""VATB""")|8|
||VATA|Int32||XmlEnum("""VATA""")|9|
||UUTX|Int32||XmlEnum("""UUTX""")|10|
||UNSP|Int32||XmlEnum("""UNSP""")|11|
||TRAN|Int32||XmlEnum("""TRAN""")|12|
||TRAX|Int32||XmlEnum("""TRAX""")|13|
||THTX|Int32||XmlEnum("""THTX""")|14|
||TELT|Int32||XmlEnum("""TELT""")|15|
||TDDT|Int32||XmlEnum("""TDDT""")|16|
||CTAX|Int32||XmlEnum("""CTAX""")|17|
||SUTX|Int32||XmlEnum("""SUTX""")|18|
||STEX|Int32||XmlEnum("""STEX""")|19|
||STSL|Int32||XmlEnum("""STSL""")|20|
||STAT|Int32||XmlEnum("""STAT""")|21|
||SSTX|Int32||XmlEnum("""SSTX""")|22|
||SRTX|Int32||XmlEnum("""SRTX""")|23|
||SPTG|Int32||XmlEnum("""SPTG""")|24|
||SPFT|Int32||XmlEnum("""SPFT""")|25|
||SPTS|Int32||XmlEnum("""SPTS""")|26|
||STPT|Int32||XmlEnum("""STPT""")|27|
||SETX|Int32||XmlEnum("""SETX""")|28|
||SLTX|Int32||XmlEnum("""SLTX""")|29|
||SLST|Int32||XmlEnum("""SLST""")|30|
||STAM|Int32||XmlEnum("""STAM""")|31|
||STTA|Int32||XmlEnum("""STTA""")|32|
||SPTX|Int32||XmlEnum("""SPTX""")|33|
||SCTX|Int32||XmlEnum("""SCTX""")|34|
||SAUT|Int32||XmlEnum("""SAUT""")|35|
||ROVI|Int32||XmlEnum("""ROVI""")|36|
||RVAT|Int32||XmlEnum("""RVAT""")|37|
||ROTX|Int32||XmlEnum("""ROTX""")|38|
||RCSD|Int32||XmlEnum("""RCSD""")|39|
||RCSB|Int32||XmlEnum("""RCSB""")|40|
||ROCI|Int32||XmlEnum("""ROCI""")|41|
||QUST|Int32||XmlEnum("""QUST""")|42|
||PHET|Int32||XmlEnum("""PHET""")|43|
||PROV|Int32||XmlEnum("""PROV""")|44|
||PPTX|Int32||XmlEnum("""PPTX""")|45|
||PSTX|Int32||XmlEnum("""PSTX""")|46|
||PRTX|Int32||XmlEnum("""PRTX""")|47|
||POTX|Int32||XmlEnum("""POTX""")|48|
||LEVY|Int32||XmlEnum("""LEVY""")|49|
||OTTX|Int32||XmlEnum("""OTTX""")|50|
||OTHP|Int32||XmlEnum("""OTHP""")|51|
||OTHN|Int32||XmlEnum("""OTHN""")|52|
||OTHR|Int32||XmlEnum("""OTHR""")|53|
||OPTX|Int32||XmlEnum("""OPTX""")|54|
||OCTX|Int32||XmlEnum("""OCTX""")|55|
||NATI|Int32||XmlEnum("""NATI""")|56|
||COUN|Int32||XmlEnum("""COUN""")|57|
||MUDE|Int32||XmlEnum("""MUDE""")|58|
||MUTX|Int32||XmlEnum("""MUTX""")|59|
||MITX|Int32||XmlEnum("""MITX""")|60|
||METX|Int32||XmlEnum("""METX""")|61|
||MATX|Int32||XmlEnum("""MATX""")|62|
||LUTX|Int32||XmlEnum("""LUTX""")|63|
||LOCL|Int32||XmlEnum("""LOCL""")|64|
||LSTX|Int32||XmlEnum("""LSTX""")|65|
||LOCO|Int32||XmlEnum("""LOCO""")|66|
||LITX|Int32||XmlEnum("""LITX""")|67|
||FLST|Int32||XmlEnum("""FLST""")|68|
||LTTX|Int32||XmlEnum("""LTTX""")|69|
||INPO|Int32||XmlEnum("""INPO""")|70|
||INHT|Int32||XmlEnum("""INHT""")|71|
||HWTX|Int32||XmlEnum("""HWTX""")|72|
||HSTX|Int32||XmlEnum("""HSTX""")|73|
||HATX|Int32||XmlEnum("""HATX""")|74|
||HVAT|Int32||XmlEnum("""HVAT""")|75|
||GRTX|Int32||XmlEnum("""GRTX""")|76|
||GCAT|Int32||XmlEnum("""GCAT""")|77|
||GIFT|Int32||XmlEnum("""GIFT""")|78|
||FUVT|Int32||XmlEnum("""FUVT""")|79|
||FSFT|Int32||XmlEnum("""FSFT""")|80|
||FSTX|Int32||XmlEnum("""FSTX""")|81|
||FRTX|Int32||XmlEnum("""FRTX""")|82|
||FICA|Int32||XmlEnum("""FICA""")|83|
||FSST|Int32||XmlEnum("""FSST""")|84|
||FIMT|Int32||XmlEnum("""FIMT""")|85|
||FVTS|Int32||XmlEnum("""FVTS""")|86|
||FVAT|Int32||XmlEnum("""FVAT""")|87|
||FETX|Int32||XmlEnum("""FETX""")|88|
||FNST|Int32||XmlEnum("""FNST""")|89|
||FEXT|Int32||XmlEnum("""FEXT""")|90|
||EXEC|Int32||XmlEnum("""EXEC""")|91|
||EUTR|Int32||XmlEnum("""EUTR""")|92|
||EQTX|Int32||XmlEnum("""EQTX""")|93|
||EQUL|Int32||XmlEnum("""EQUL""")|94|
||ENVT|Int32||XmlEnum("""ENVT""")|95|
||ESET|Int32||XmlEnum("""ESET""")|96|
||ENTX|Int32||XmlEnum("""ENTX""")|97|
||EMRT|Int32||XmlEnum("""EMRT""")|98|
||EMST|Int32||XmlEnum("""EMST""")|99|
||EMET|Int32||XmlEnum("""EMET""")|100|
||EMUT|Int32||XmlEnum("""EMUT""")|101|
||EMIT|Int32||XmlEnum("""EMIT""")|102|
||DUTY|Int32||XmlEnum("""DUTY""")|103|
||DLTX|Int32||XmlEnum("""DLTX""")|104|
||CUST|Int32||XmlEnum("""CUST""")|105|
||COTX|Int32||XmlEnum("""COTX""")|106|
||CORT|Int32||XmlEnum("""CORT""")|107|
||CPST|Int32||XmlEnum("""CPST""")|108|
||COAX|Int32||XmlEnum("""COAX""")|109|
||CITX|Int32||XmlEnum("""CITX""")|110|
||CSTX|Int32||XmlEnum("""CSTX""")|111|
||CRTX|Int32||XmlEnum("""CRTX""")|112|
||NKAP|Int32||XmlEnum("""NKAP""")|113|
||KAPA|Int32||XmlEnum("""KAPA""")|114|
||BPTX|Int32||XmlEnum("""BPTX""")|115|
||ASNT|Int32||XmlEnum("""ASNT""")|116|
||ALMI|Int32||XmlEnum("""ALMI""")|117|
||TOTL|Int32||XmlEnum("""TOTL""")|118|

---

## Value ISO20022.Cain025001.AdditionalData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.AdditionalData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls))|

---

## Value ISO20022.Cain025001.AdditionalFee3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrAssgnr|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|RcncltnFctvXchgRate|Decimal||XmlElement()||
|+|RcncltnCcy|String||XmlElement()||
|+|RcncltnAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Dscrptr|String||XmlElement()||
|+|Prgm|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RcncltnCcy""",RcncltnCcy,"""[0-9]{3,3}"""),validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain025001.AdditionalInformation31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|String||XmlElement()||
|+|AlphaNmrc|String||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nmrc""",Nmrc,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Cain025001.Address2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMjr|String||XmlElement()||
|+|CtrySubDvsnMnr|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstlCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine2|String||XmlElement()||
|+|AdrLine1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMjr""",CtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMnr""",CtrySubDvsnMnr,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain025001.Adjustment13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxOnOrgnlAmt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|PrmtnCd|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|AddtlTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Adjustment14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxOnOrgnlAmt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|UnitPric|Decimal||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|PrmtnCpnNb|String||XmlElement()||
|+|PrmtnCd|String||XmlElement()||
|+|PrmtnElgblty|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|AddtlTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain025001.Algorithm13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||UKA1|Int32||XmlEnum("""UKA1""")|3|
||UKPT|Int32||XmlEnum("""UKPT""")|4|
||DKP9|Int32||XmlEnum("""DKP9""")|5|
||E3DC|Int32||XmlEnum("""E3DC""")|6|
||EA2C|Int32||XmlEnum("""EA2C""")|7|

---

## Enum ISO20022.Cain025001.Algorithm20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cain025001.Algorithm23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SD5C|Int32||XmlEnum("""SD5C""")|1|
||E36R|Int32||XmlEnum("""E36R""")|2|
||E36C|Int32||XmlEnum("""E36C""")|3|
||E3DR|Int32||XmlEnum("""E3DR""")|4|
||EA5R|Int32||XmlEnum("""EA5R""")|5|
||EA9R|Int32||XmlEnum("""EA9R""")|6|
||EA2R|Int32||XmlEnum("""EA2R""")|7|
||EA5C|Int32||XmlEnum("""EA5C""")|8|
||EA9C|Int32||XmlEnum("""EA9C""")|9|
||E3DC|Int32||XmlEnum("""E3DC""")|10|
||EA2C|Int32||XmlEnum("""EA2C""")|11|

---

## Enum ISO20022.Cain025001.Algorithm5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cain025001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Cain025001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Cain025001.AlgorithmIdentification25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain025001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cain025001.AlgorithmIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|String||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.AlgorithmIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain025001.Parameter13||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cain025001.AlgorithmIdentification28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain025001.Parameter14||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cain025001.Amount12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrs|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Hrs""",Hrs,"""[0-9]{1,6}"""))|

---

## Value ISO20022.Cain025001.Amount13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Decimal||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Amount21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CstmrNtfd|String||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Amount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tax""",Tax),validElement(Tax))|

---

## Value ISO20022.Cain025001.Amount23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.AmountDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tax""",Tax),validElement(Tax))|

---

## Value ISO20022.Cain025001.AncillaryPurchase3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|Fee|Decimal||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|CdtRsnCd|String||XmlElement()||
|+|SvcPrvdrSvcTp|String||XmlElement()||
|+|SvcSubCtgyCd|String||XmlElement()||
|+|SvcCtgyCd|String||XmlElement()||
|+|RltdDocNb|String||XmlElement()||
|+|DocNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Tax""",Tax),validElement(Tax))|

---

## Enum ISO20022.Cain025001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Cain025001.AuthorisedAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Authority1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMnr|String||XmlElement()||
|+|CtrySubDvsnMjr|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtrySubDvsnMnr""",CtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMjr""",CtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain025001.BatchManagementInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgChcksmInptVal|String||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Cain025001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Enum ISO20022.Cain025001.CarRentalActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||PETP|Int32||XmlEnum("""PETP""")|4|
||INDV|Int32||XmlEnum("""INDV""")|5|
||GLBL|Int32||XmlEnum("""GLBL""")|6|
||CARS|Int32||XmlEnum("""CARS""")|7|

---

## Enum ISO20022.Cain025001.CarRentalServiceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOWI|Int32||XmlEnum("""TOWI""")|1|
||TOLL|Int32||XmlEnum("""TOLL""")|2|
||SMOK|Int32||XmlEnum("""SMOK""")|3|
||REGD|Int32||XmlEnum("""REGD""")|4|
||PHON|Int32||XmlEnum("""PHON""")|5|
||PFIN|Int32||XmlEnum("""PFIN""")|6|
||PRIN|Int32||XmlEnum("""PRIN""")|7|
||PARK|Int32||XmlEnum("""PARK""")|8|
||OTHP|Int32||XmlEnum("""OTHP""")|9|
||OTHN|Int32||XmlEnum("""OTHN""")|10|
||ONEW|Int32||XmlEnum("""ONEW""")|11|
||NOSH|Int32||XmlEnum("""NOSH""")|12|
||NAVI|Int32||XmlEnum("""NAVI""")|13|
||MISC|Int32||XmlEnum("""MISC""")|14|
||LDIN|Int32||XmlEnum("""LDIN""")|15|
||LIIN|Int32||XmlEnum("""LIIN""")|16|
||LATE|Int32||XmlEnum("""LATE""")|17|
||INSU|Int32||XmlEnum("""INSU""")|18|
||GPSY|Int32||XmlEnum("""GPSY""")|19|
||GARA|Int32||XmlEnum("""GARA""")|20|
||FUEL|Int32||XmlEnum("""FUEL""")|21|
||FINE|Int32||XmlEnum("""FINE""")|22|
||EXHR|Int32||XmlEnum("""EXHR""")|23|
||EXDI|Int32||XmlEnum("""EXDI""")|24|
||EXDY|Int32||XmlEnum("""EXDY""")|25|
||EXTC|Int32||XmlEnum("""EXTC""")|26|
||ENTE|Int32||XmlEnum("""ENTE""")|27|
||DPOF|Int32||XmlEnum("""DPOF""")|28|
||DLVR|Int32||XmlEnum("""DLVR""")|29|
||DMGS|Int32||XmlEnum("""DMGS""")|30|
||CLEA|Int32||XmlEnum("""CLEA""")|31|
||BAST|Int32||XmlEnum("""BAST""")|32|
||AUTH|Int32||XmlEnum("""AUTH""")|33|
||ADJM|Int32||XmlEnum("""ADJM""")|34|

---

## Value ISO20022.Cain025001.CardData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflIdr|String||XmlElement()||
|+|PmtAcctRef|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{1,19}"""))|

---

## Enum ISO20022.Cain025001.CardDataReading5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDFL|Int32||XmlEnum("""CDFL""")|1|
||ECTL|Int32||XmlEnum("""ECTL""")|2|
||CTLS|Int32||XmlEnum("""CTLS""")|3|
||DFLE|Int32||XmlEnum("""DFLE""")|4|
||CICC|Int32||XmlEnum("""CICC""")|5|
||MGST|Int32||XmlEnum("""MGST""")|6|
||BRCD|Int32||XmlEnum("""BRCD""")|7|
||PHYS|Int32||XmlEnum("""PHYS""")|8|
||TAGC|Int32||XmlEnum("""TAGC""")|9|

---

## Value ISO20022.Cain025001.CardholderName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Cain025001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Enum ISO20022.Cain025001.CompanyAssigner2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHN|Int32||XmlEnum("""OTHN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||TRAG|Int32||XmlEnum("""TRAG""")|3|
||LEII|Int32||XmlEnum("""LEII""")|4|
||CPNY|Int32||XmlEnum("""CPNY""")|5|
||AUTH|Int32||XmlEnum("""AUTH""")|6|
||ASSO|Int32||XmlEnum("""ASSO""")|7|

---

## Value ISO20022.Cain025001.ContactBusiness1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lang|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|Fax|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|TollFreePhne|String||XmlElement()||
|+|PrprtyPhne|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""),validPattern("""Fax""",Fax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""TollFreePhne""",TollFreePhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PrprtyPhne""",PrprtyPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cain025001.ContactPersonal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lang|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|BizFax|String||XmlElement()||
|+|HomeFax|String||XmlElement()||
|+|OthrEmail|String||XmlElement()||
|+|BizEmail|String||XmlElement()||
|+|PrsnlEmail|String||XmlElement()||
|+|OthrPhne|String||XmlElement()||
|+|MobPhne|String||XmlElement()||
|+|BizPhne|String||XmlElement()||
|+|HomePhne|String||XmlElement()||
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""),validPattern("""BizFax""",BizFax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""HomeFax""",HomeFax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""OthrPhne""",OthrPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobPhne""",MobPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""BizPhne""",BizPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""HomePhne""",HomePhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cain025001.ContentInformationType41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|MACData|ISO20022.Cain025001.MACData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MAC""",MAC,"""([0-9A-F][0-9A-F]){1,8}"""),validElement(MACData))|

---

## Enum ISO20022.Cain025001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Enum ISO20022.Cain025001.ContentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IFSE|Int32||XmlEnum("""IFSE""")|1|
||EVLP|Int32||XmlEnum("""EVLP""")|2|

---

## Enum ISO20022.Cain025001.CorporateTaxType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CORP|Int32||XmlEnum("""CORP""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||SMBS|Int32||XmlEnum("""SMBS""")|3|

---

## Value ISO20022.Cain025001.Credentials3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Assgnr|ISO20022.Cain025001.Authority1||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|Val|String||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Assgnr))|

---

## Enum ISO20022.Cain025001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Cain025001.Customer4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CstmrRltsh|String||XmlElement()||
|+|VIPInd|String||XmlElement()||
|+|AuthrsdCtctPhneNb|String||XmlElement()||
|+|AuthrsdCtctNm|String||XmlElement()||
|+|AuthrsdCtctCpny|String||XmlElement()||
|+|TaxRegnId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AuthrsdCtctPhneNb""",AuthrsdCtctPhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cain025001.Customer9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctct|ISO20022.Cain025001.ContactPersonal1||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|Age|String||XmlElement()||
|+|CstmrFileRefNb|String||XmlElement()||
|+|Id|ISO20022.Cain025001.Credentials3||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ctct),validElement(Adr),validPattern("""Age""",Age,"""[0-9]{1,2}"""),validElement(Id))|

---

## Enum ISO20022.Cain025001.CustomerAssigner1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAY|Int32||XmlEnum("""TRAY""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||ONFL|Int32||XmlEnum("""ONFL""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|
||CRCY|Int32||XmlEnum("""CRCY""")|5|
||AUTH|Int32||XmlEnum("""AUTH""")|6|

---

## Value ISO20022.Cain025001.CustomerReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtl|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain025001.CustomerType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CPNY|Int32||XmlEnum("""CPNY""")|1|
||CSMR|Int32||XmlEnum("""CSMR""")|2|

---

## Value ISO20022.Cain025001.DateTime2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.DepartureOrArrival1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Lctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.DepartureOrArrival2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RouteNb|String||XmlElement()||
|+|CrrierCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RouteNb""",RouteNb,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Cain025001.Discount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Distance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|FreeDstnc|String||XmlElement()||
|+|TtlDstnc|String||XmlElement()||
|+|OdmtrRtr|String||XmlElement()||
|+|OdmtrStart|String||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FreeDstnc""",FreeDstnc,"""[0-9]{1,10}"""),validPattern("""TtlDstnc""",TtlDstnc,"""[0-9]{1,10}"""),validPattern("""OdmtrRtr""",OdmtrRtr,"""[0-9]{1,10}"""),validPattern("""OdmtrStart""",OdmtrStart,"""[0-9]{1,10}"""))|

---

## Type ISO20022.Cain025001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdddmInitn|ISO20022.Cain025001.AddendumInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AdddmInitn))|

---

## Value ISO20022.Cain025001.DocumentReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Driver3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|ISO20022.Cain025001.AdditionalData1||XmlElement()||
|+|DtOfBirth|DateTime||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.TravelDocument2>||XmlElement()||
|+|DeptNb|String||XmlElement()||
|+|MplyeeId|String||XmlElement()||
|+|Mplyr|String||XmlElement()||
|+|LicOthrAuthrty|String||XmlElement()||
|+|LicCtrySubDvsnMnr|String||XmlElement()||
|+|LicCtrySubDvsnMjr|String||XmlElement()||
|+|LicCtry|String||XmlElement()||
|+|LicXprtnDt|DateTime||XmlElement()||
|+|LicIssncDt|DateTime||XmlElement()||
|+|LicAssgnr|String||XmlElement()||
|+|LicId|String||XmlElement()||
|+|LicForm|String||XmlElement()||
|+|LicTp|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""LicCtrySubDvsnMnr""",LicCtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""LicCtrySubDvsnMjr""",LicCtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""LicCtry""",LicCtry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain025001.DriverInParty3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LicOthrAuthrty|String||XmlElement()||
|+|LicCtrySubDvsnMnr|String||XmlElement()||
|+|LicCtrySubDvsnMjr|String||XmlElement()||
|+|LicCtry|String||XmlElement()||
|+|LicXprtnDt|DateTime||XmlElement()||
|+|LicIssncDt|DateTime||XmlElement()||
|+|LicAssgnr|String||XmlElement()||
|+|LicId|String||XmlElement()||
|+|LicForm|String||XmlElement()||
|+|LicTp|String||XmlElement()||
|+|DrvrCrdntl|global::System.Collections.Generic.List<ISO20022.Cain025001.TravelDocument2>||XmlElement()||
|+|Age|String||XmlElement()||
|+|DtOfBirth|DateTime||XmlElement()||
|+|Ctct|ISO20022.Cain025001.ContactPersonal1||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LicCtrySubDvsnMnr""",LicCtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""LicCtrySubDvsnMjr""",LicCtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""LicCtry""",LicCtry,"""[A-Z]{2,3}"""),validList("""DrvrCrdntl""",DrvrCrdntl),validElement(DrvrCrdntl),validPattern("""Age""",Age,"""[0-9]{1,2}"""),validElement(Ctct),validElement(Adr))|

---

## Value ISO20022.Cain025001.EncryptedContent8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdDataElmt|global::System.Collections.Generic.List<ISO20022.Cain025001.EncryptedDataElement2>||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Cain025001.AlgorithmIdentification25||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdDataElmt""",NcrptdDataElmt),validList("""NcrptdDataElmt""",NcrptdDataElmt),validElement(NcrptdDataElmt),validElement(CnttNcrptnAlgo))|

---

## Value ISO20022.Cain025001.EncryptedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdElmt|global::System.Collections.Generic.List<ISO20022.Cain025001.EncryptedDataElement2>||XmlElement()||
|+|NcrptdFrmt|String||XmlElement()||
|+|PddgMtd|String||XmlElement()||
|+|KeyIndx|String||XmlElement()||
|+|KeyPrtcn|String||XmlElement()||
|+|KeyLngth|String||XmlElement()||
|+|Algo|String||XmlElement()||
|+|DrvdInf|String||XmlElement()||
|+|KeySetIdr|String||XmlElement()||
|+|Ctrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdElmt""",NcrptdElmt),validList("""NcrptdElmt""",NcrptdElmt),validElement(NcrptdElmt),validPattern("""NcrptdFrmt""",NcrptdFrmt,"""[0-9]{1,2}"""),validPattern("""PddgMtd""",PddgMtd,"""[0-9]{1,2}"""),validPattern("""KeyIndx""",KeyIndx,"""[0-9]{1,5}"""),validPattern("""KeyPrtcn""",KeyPrtcn,"""[0-9]{1,2}"""),validPattern("""KeyLngth""",KeyLngth,"""[0-9]{1,4}"""),validPattern("""Algo""",Algo,"""[0-9]{1,2}"""),validPattern("""DrvdInf""",DrvdInf,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""KeySetIdr""",KeySetIdr,"""[0-9]{1,8}"""),validPattern("""Ctrl""",Ctrl,"""([0-9A-F][0-9A-F]){1}"""))|

---

## Value ISO20022.Cain025001.EncryptedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HexBinry|String||XmlElement()||
|+|Binry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HexBinry""",HexBinry,"""([0-9A-F][0-9A-F]){1,9999}"""),validChoice(HexBinry,Binry))|

---

## Value ISO20022.Cain025001.EncryptedDataElement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClearTxtFrmt|String||XmlElement()||
|+|ClearTxtFrmt|String||XmlElement()||
|+|Data|ISO20022.Cain025001.EncryptedData2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data))|

---

## Enum ISO20022.Cain025001.EncryptedDataFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||HEXF|Int32||XmlEnum("""HEXF""")|3|
||EBCD|Int32||XmlEnum("""EBCD""")|4|
||BINF|Int32||XmlEnum("""BINF""")|5|
||ASCI|Int32||XmlEnum("""ASCI""")|6|

---

## Enum ISO20022.Cain025001.EncryptionFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBCE|Int32||XmlEnum("""CBCE""")|1|
||CTCE|Int32||XmlEnum("""CTCE""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|
||TR34|Int32||XmlEnum("""TR34""")|4|

---

## Value ISO20022.Cain025001.EnvelopedData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Cain025001.EncryptedContent8||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Cain025001.Recipient7Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Cain025001.FleetData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Cain025001.FleetLineItem5>||XmlElement()||
|+|AddtlNtrdData|ISO20022.Cain025001.AdditionalInformation31||XmlElement()||
|+|TxRltdData|global::System.Collections.Generic.List<ISO20022.Cain025001.FleetTransactionDetail1>||XmlElement()||
|+|LclAmnty|global::System.Collections.Generic.List<ISO20022.Cain025001.LocalAmenity1>||XmlElement()||
|+|TripDlvryTcktNb|String||XmlElement()||
|+|TripCtrlNb|String||XmlElement()||
|+|TripBllgId|String||XmlElement()||
|+|TripInvcNb|String||XmlElement()||
|+|TripWorkOrdr|String||XmlElement()||
|+|TripJobNb|String||XmlElement()||
|+|TripNb|String||XmlElement()||
|+|AgtFuelPrmptCd|String||XmlElement()||
|+|CardFuelPrmptCd|Decimal||XmlElement()||
|+|DrvrOrVhclCard|ISO20022.Cain025001.PlainCardData23||XmlElement()||
|+|Vhcl|ISO20022.Cain025001.Vehicle6||XmlElement()||
|+|Drvr|ISO20022.Cain025001.Driver3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineItm""",LineItm),validElement(LineItm),validElement(AddtlNtrdData),validList("""TxRltdData""",TxRltdData),validElement(TxRltdData),validList("""LclAmnty""",LclAmnty),validElement(LclAmnty),validElement(DrvrOrVhclCard),validElement(Vhcl),validElement(Drvr))|

---

## Value ISO20022.Cain025001.FleetLineItem5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlAmtInclgTax|Decimal||XmlElement()||
|+|TtlAmtExclgTax|Decimal||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|NonTaxbl|String||XmlElement()||
|+|DscntAmt|Decimal||XmlElement()||
|+|PdctQty|Decimal||XmlElement()||
|+|OthrUnitOfMeasr|String||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|UnitPric|Decimal||XmlElement()||
|+|UnitPricTax|String||XmlElement()||
|+|PdctCdAssgnr|String||XmlElement()||
|+|PdctQlfr|String||XmlElement()||
|+|PdctCtgy|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
|+|FuelBrndCd|String||XmlElement()||
|+|SvcTp|String||XmlElement()||
|+|Fuel|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tax""",Tax),validElement(Tax))|

---

## Enum ISO20022.Cain025001.FleetPurchaseType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FANF|Int32||XmlEnum("""FANF""")|1|
||NONF|Int32||XmlEnum("""NONF""")|2|
||FUEL|Int32||XmlEnum("""FUEL""")|3|

---

## Enum ISO20022.Cain025001.FleetServiceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLSV|Int32||XmlEnum("""FLSV""")|1|
||HSDI|Int32||XmlEnum("""HSDI""")|2|
||SLSV|Int32||XmlEnum("""SLSV""")|3|

---

## Value ISO20022.Cain025001.FleetTransactionDetail1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTtl|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|DscntTtlNonFuelAmt|Decimal||XmlElement()||
|+|DscntTtlFuelAmt|Decimal||XmlElement()||
|+|DscntTtlAmt|Decimal||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|PurchsTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxTtl""",TaxTtl),validElement(TaxTtl))|

---

## Value ISO20022.Cain025001.GenericIdentification183


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain025001.Header71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Cain025001.Traceability10>||XmlElement()||
|+|TracData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|RcptPty|ISO20022.Cain025001.GenericIdentification183||XmlElement()||
|+|InitgPty|ISO20022.Cain025001.GenericIdentification183||XmlElement()||
|+|BtchMgmtInf|ISO20022.Cain025001.BatchManagementInformation1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|String||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validList("""TracData""",TracData),validElement(TracData),validElement(RcptPty),validElement(InitgPty),validElement(BtchMgmtInf),validPattern("""ReTrnsmssnCntr""",ReTrnsmssnCntr,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Cain025001.HiredVehicle3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DstnAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|DstnNmAndLctn|String||XmlElement()||
|+|DrvrTaxId|String||XmlElement()||
|+|DrvrId|String||XmlElement()||
|+|VhclId|String||XmlElement()||
|+|TpOfVhcl|String||XmlElement()||
|+|CpnyNm|String||XmlElement()||
|+|CpnyTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DstnAdr))|

---

## Value ISO20022.Cain025001.Invoice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Cain025001.InvoiceLineItem3>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|TaxRclmMtd|String||XmlElement()||
|+|TaxTtl|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|FrghtAmt|Decimal||XmlElement()||
|+|BuyrAddtlInf|String||XmlElement()||
|+|BuyrTaxRegnId|String||XmlElement()||
|+|BuyrCtct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|BuyrAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|BuyrId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|BuyrNm|String||XmlElement()||
|+|SellrAddtlInf|String||XmlElement()||
|+|SellrTaxRegnId|String||XmlElement()||
|+|SellrCtct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|SellrAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|SellrId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|SellrNm|String||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineItm""",LineItm),validElement(LineItm),validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""TaxTtl""",TaxTtl),validElement(TaxTtl),validElement(BuyrCtct),validElement(BuyrAdr),validElement(BuyrId),validElement(SellrCtct),validElement(SellrAdr),validElement(SellrId))|

---

## Value ISO20022.Cain025001.InvoiceLineItem3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|ZeroCostToCstmr|String||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|VATInvcRef|String||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|InsrncAmt|Decimal||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|AdjstmntRsn|String||XmlElement()||
|+|AdjstmntCdtDbt|String||XmlElement()||
|+|AdjstmntAmt|Decimal||XmlElement()||
|+|PdctQty|Decimal||XmlElement()||
|+|UnitPric|Decimal||XmlElement()||
|+|OthrUnitOfMeasr|String||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|TpOfSpply|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|PdctQlfr|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
|+|ShipToIndstryCd|String||XmlElement()||
|+|MdclSvcs|String||XmlElement()||
|+|Rbllg|String||XmlElement()||
|+|ShppgDt|DateTime||XmlElement()||
|+|CtrctNb|String||XmlElement()||
|+|OrdrDt|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Tax""",Tax),validElement(Tax))|

---

## Value ISO20022.Cain025001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Cain025001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Enum ISO20022.Cain025001.JourneyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VESS|Int32||XmlEnum("""VESS""")|1|
||TRAN|Int32||XmlEnum("""TRAN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||ONTM|Int32||XmlEnum("""ONTM""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|
||FLGT|Int32||XmlEnum("""FLGT""")|6|
||EARL|Int32||XmlEnum("""EARL""")|7|
||COAC|Int32||XmlEnum("""COAC""")|8|

---

## Value ISO20022.Cain025001.Jurisdiction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmstQlfctn|String||XmlElement()||
|+|DmstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.KEK6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cain025001.AlgorithmIdentification28||XmlElement()||
|+|KEKId|ISO20022.Cain025001.KEKIdentifier6||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Cain025001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.KEKIdentifier6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.KeyTransport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cain025001.AlgorithmIdentification27||XmlElement()||
|+|RcptId|ISO20022.Cain025001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Cain025001.LegalStructure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NATI|Int32||XmlEnum("""NATI""")|1|
||CNTY|Int32||XmlEnum("""CNTY""")|2|
||MUNI|Int32||XmlEnum("""MUNI""")|3|
||PVIN|Int32||XmlEnum("""PVIN""")|4|
||STAE|Int32||XmlEnum("""STAE""")|5|

---

## Enum ISO20022.Cain025001.LifeCycleSupport1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FINC|Int32||XmlEnum("""FINC""")|1|
||AUTH|Int32||XmlEnum("""AUTH""")|2|

---

## Value ISO20022.Cain025001.LocalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstlCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine2|String||XmlElement()||
|+|AdrLine1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.LocalAmenity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblInd|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.LocalData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain025001.LocalAddress1||XmlElement()||
|+|NmAndLctn|String||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain025001.LocalData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain025001.LocalAddress1||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain025001.LocalData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain025001.Location6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclCcy|String||XmlElement()||
|+|LclTmZone|String||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LclCcy""",LclCcy,"""[0-9]{3,3}"""),validElement(Adr))|

---

## Enum ISO20022.Cain025001.LocationAmenity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VMRA|Int32||XmlEnum("""VMRA""")|1|
||VHPA|Int32||XmlEnum("""VHPA""")|2|
||VSWA|Int32||XmlEnum("""VSWA""")|3|
||TFHA|Int32||XmlEnum("""TFHA""")|4|
||TSSA|Int32||XmlEnum("""TSSA""")|5|
||TSRA|Int32||XmlEnum("""TSRA""")|6|
||TSHA|Int32||XmlEnum("""TSHA""")|7|
||PAPA|Int32||XmlEnum("""PAPA""")|8|
||OTHP|Int32||XmlEnum("""OTHP""")|9|
||OTHN|Int32||XmlEnum("""OTHN""")|10|
||MRLA|Int32||XmlEnum("""MRLA""")|11|
||EWAA|Int32||XmlEnum("""EWAA""")|12|
||DISA|Int32||XmlEnum("""DISA""")|13|
||CVSA|Int32||XmlEnum("""CVSA""")|14|
||CRWA|Int32||XmlEnum("""CRWA""")|15|
||AVLA|Int32||XmlEnum("""AVLA""")|16|
||AFLA|Int32||XmlEnum("""AFLA""")|17|
||AADA|Int32||XmlEnum("""AADA""")|18|

---

## Value ISO20022.Cain025001.Lodging4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Cain025001.LodgingLineItem3>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LltyPrgrmm|global::System.Collections.Generic.List<ISO20022.Cain025001.LoyaltyProgramme4>||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|AuthrsdAmt|global::System.Collections.Generic.List<ISO20022.Cain025001.AuthorisedAmount2>||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|TtlTax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|InsrncAmt|Decimal||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|NoShow|String||XmlElement()||
|+|Dprture|ISO20022.Cain025001.DepartureOrArrival1||XmlElement()||
|+|Arrvl|ISO20022.Cain025001.DepartureOrArrival2||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|Room|global::System.Collections.Generic.List<ISO20022.Cain025001.LodgingRoom2>||XmlElement()||
|+|NbOfRooms|String||XmlElement()||
|+|CstmrCtct|ISO20022.Cain025001.ContactPersonal1||XmlElement()||
|+|CstmrAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|CstmrAge|String||XmlElement()||
|+|CstmrFileRefNb|String||XmlElement()||
|+|CstmrId|ISO20022.Cain025001.Credentials3||XmlElement()||
|+|CstmrNm|String||XmlElement()||
|+|PrprtyFireSftyAct|String||XmlElement()||
|+|PrprtyCtry|String||XmlElement()||
|+|PrprtyCtct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|PrprtyAssgnr|String||XmlElement()||
|+|PrprtyLctn|ISO20022.Cain025001.Location6||XmlElement()||
|+|PrprtyId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|PrprtyNm|String||XmlElement()||
|+|PrstgsPrprty|String||XmlElement()||
|+|PrprtyOthrTp|String||XmlElement()||
|+|PrprtyTp|String||XmlElement()||
|+|FolioNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineItm""",LineItm),validElement(LineItm),validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""LltyPrgrmm""",LltyPrgrmm),validElement(LltyPrgrmm),validList("""AuthrsdAmt""",AuthrsdAmt),validElement(AuthrsdAmt),validList("""TtlTax""",TtlTax),validElement(TtlTax),validElement(Dprture),validElement(Arrvl),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""),validList("""Room""",Room),validElement(Room),validPattern("""NbOfRooms""",NbOfRooms,"""[0-9]{1,4}"""),validElement(CstmrCtct),validElement(CstmrAdr),validPattern("""CstmrAge""",CstmrAge,"""[0-9]{1,2}"""),validElement(CstmrId),validPattern("""PrprtyCtry""",PrprtyCtry,"""[A-Z]{2,3}"""),validElement(PrprtyCtct),validElement(PrprtyLctn),validElement(PrprtyId))|

---

## Enum ISO20022.Cain025001.LodgingActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOSH|Int32||XmlEnum("""TOSH""")|1|
||ROAB|Int32||XmlEnum("""ROAB""")|2|
||RESO|Int32||XmlEnum("""RESO""")|3|
||OTHP|Int32||XmlEnum("""OTHP""")|4|
||OTHN|Int32||XmlEnum("""OTHN""")|5|
||MOTL|Int32||XmlEnum("""MOTL""")|6|
||LODG|Int32||XmlEnum("""LODG""")|7|
||HOTL|Int32||XmlEnum("""HOTL""")|8|
||HOST|Int32||XmlEnum("""HOST""")|9|
||HOME|Int32||XmlEnum("""HOME""")|10|
||CRUI|Int32||XmlEnum("""CRUI""")|11|
||COTT|Int32||XmlEnum("""COTT""")|12|
||BEBR|Int32||XmlEnum("""BEBR""")|13|
||APTM|Int32||XmlEnum("""APTM""")|14|

---

## Value ISO20022.Cain025001.LodgingLineItem3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|SubTtlAmt|Decimal||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|UnitAmt|Decimal||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|PstChckOut|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Tax""",Tax),validElement(Tax),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""))|

---

## Value ISO20022.Cain025001.LodgingRoom2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DalyRate|Decimal||XmlElement()||
|+|Chldrn|String||XmlElement()||
|+|Adlts|String||XmlElement()||
|+|Gsts|String||XmlElement()||
|+|BedTp|String||XmlElement()||
|+|Lctn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Chldrn""",Chldrn,"""[0-9]{1,3}"""),validPattern("""Adlts""",Adlts,"""[0-9]{1,3}"""),validPattern("""Gsts""",Gsts,"""[0-9]{1,3}"""))|

---

## Enum ISO20022.Cain025001.LodgingService1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VODS|Int32||XmlEnum("""VODS""")|1|
||TRAN|Int32||XmlEnum("""TRAN""")|2|
||THRD|Int32||XmlEnum("""THRD""")|3|
||SPAS|Int32||XmlEnum("""SPAS""")|4|
||RMSE|Int32||XmlEnum("""RMSE""")|5|
||REST|Int32||XmlEnum("""REST""")|6|
||PHON|Int32||XmlEnum("""PHON""")|7|
||PARK|Int32||XmlEnum("""PARK""")|8|
||OTHR|Int32||XmlEnum("""OTHR""")|9|
||NOSH|Int32||XmlEnum("""NOSH""")|10|
||MINI|Int32||XmlEnum("""MINI""")|11|
||LONG|Int32||XmlEnum("""LONG""")|12|
||LAUN|Int32||XmlEnum("""LAUN""")|13|
||INTE|Int32||XmlEnum("""INTE""")|14|
||HEAL|Int32||XmlEnum("""HEAL""")|15|
||GIFT|Int32||XmlEnum("""GIFT""")|16|
||GARA|Int32||XmlEnum("""GARA""")|17|
||GAME|Int32||XmlEnum("""GAME""")|18|
||FCAA|Int32||XmlEnum("""FCAA""")|19|
||ENTR|Int32||XmlEnum("""ENTR""")|20|
||EARD|Int32||XmlEnum("""EARD""")|21|
||EARA|Int32||XmlEnum("""EARA""")|22|
||CONC|Int32||XmlEnum("""CONC""")|23|
||BUSS|Int32||XmlEnum("""BUSS""")|24|
||BREK|Int32||XmlEnum("""BREK""")|25|
||BANQ|Int32||XmlEnum("""BANQ""")|26|
||AUDI|Int32||XmlEnum("""AUDI""")|27|
||ACCO|Int32||XmlEnum("""ACCO""")|28|

---

## Value ISO20022.Cain025001.LoyaltyProgramme4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtcptId|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.LoyaltyProgramme5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|String||XmlElement()||
|+|ValToDbt|String||XmlElement()||
|+|ValToCdt|String||XmlElement()||
|+|OthrValTp|String||XmlElement()||
|+|ValTp|String||XmlElement()||
|+|Val|String||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|MmbSts|String||XmlElement()||
|+|MmbId|String||XmlElement()||
|+|MmbAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|MmbNm|ISO20022.Cain025001.CardholderName3||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Elgblty|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Bal""",Bal,"""[0-9]{1,10}"""),validPattern("""ValToDbt""",ValToDbt,"""[0-9]{1,10}"""),validPattern("""ValToCdt""",ValToCdt,"""[0-9]{1,10}"""),validPattern("""Val""",Val,"""[0-9]{1,10}"""),validElement(MmbAdr),validElement(MmbNm))|

---

## Enum ISO20022.Cain025001.LoyaltyValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIV|Int32||XmlEnum("""PRIV""")|1|
||POIN|Int32||XmlEnum("""POIN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||MONE|Int32||XmlEnum("""MONE""")|4|
||MILE|Int32||XmlEnum("""MILE""")|5|

---

## Value ISO20022.Cain025001.MACData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InitlstnVctr|String||XmlElement()||
|+|PddgMtd|String||XmlElement()||
|+|KeyIndx|String||XmlElement()||
|+|KeyPrtcn|String||XmlElement()||
|+|KeyLngth|String||XmlElement()||
|+|Algo|String||XmlElement()||
|+|DrvdInf|String||XmlElement()||
|+|KeySetIdr|String||XmlElement()||
|+|Ctrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""InitlstnVctr""",InitlstnVctr,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""PddgMtd""",PddgMtd,"""[0-9]{1,2}"""),validPattern("""KeyIndx""",KeyIndx,"""[0-9]{1,5}"""),validPattern("""KeyPrtcn""",KeyPrtcn,"""[0-9]{1,2}"""),validPattern("""KeyLngth""",KeyLngth,"""[0-9]{1,4}"""),validPattern("""Algo""",Algo,"""[0-9]{1,2}"""),validPattern("""DrvdInf""",DrvdInf,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""KeySetIdr""",KeySetIdr,"""[0-9]{1,8}"""),validPattern("""Ctrl""",Ctrl,"""([0-9A-F][0-9A-F]){1}"""))|

---

## Enum ISO20022.Cain025001.MessageClass1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VERI|Int32||XmlEnum("""VERI""")|1|
||INQY|Int32||XmlEnum("""INQY""")|2|
||FINL|Int32||XmlEnum("""FINL""")|3|
||FEEC|Int32||XmlEnum("""FEEC""")|4|
||CBCK|Int32||XmlEnum("""CBCK""")|5|
||CMGT|Int32||XmlEnum("""CMGT""")|6|
||AUTH|Int32||XmlEnum("""AUTH""")|7|
||AMDT|Int32||XmlEnum("""AMDT""")|8|
||ADDE|Int32||XmlEnum("""ADDE""")|9|

---

## Enum ISO20022.Cain025001.MessageFunction16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REQU|Int32||XmlEnum("""REQU""")|1|
||CANO|Int32||XmlEnum("""CANO""")|2|
||CAAD|Int32||XmlEnum("""CAAD""")|3|
||NOTI|Int32||XmlEnum("""NOTI""")|4|
||ADVC|Int32||XmlEnum("""ADVC""")|5|

---

## Enum ISO20022.Cain025001.OfficialDocumentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REFU|Int32||XmlEnum("""REFU""")|1|
||PERM|Int32||XmlEnum("""PERM""")|2|
||VISA|Int32||XmlEnum("""VISA""")|3|
||PASS|Int32||XmlEnum("""PASS""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||LZPR|Int32||XmlEnum("""LZPR""")|7|
||INPO|Int32||XmlEnum("""INPO""")|8|
||INTE|Int32||XmlEnum("""INTE""")|9|
||IDEN|Int32||XmlEnum("""IDEN""")|10|
||EURO|Int32||XmlEnum("""EURO""")|11|
||DVLC|Int32||XmlEnum("""DVLC""")|12|
||DIPL|Int32||XmlEnum("""DIPL""")|13|
||AUTH|Int32||XmlEnum("""AUTH""")|14|
||ARNU|Int32||XmlEnum("""ARNU""")|15|

---

## Value ISO20022.Cain025001.OnBoardDiagnostics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HardAcclrtn|String||XmlElement()||
|+|HardBrakg|String||XmlElement()||
|+|BttryVltg|String||XmlElement()||
|+|CoolntTmprtr|Decimal||XmlElement()||
|+|RfrgrtnTmprtr|Decimal||XmlElement()||
|+|RfrgrtnHrs|Decimal||XmlElement()||
|+|FuelEcnmy|Decimal||XmlElement()||
|+|FuelGaugeLvl|String||XmlElement()||
|+|FuelTankLvlStart|String||XmlElement()||
|+|ChckNgnWrngSts|String||XmlElement()||
|+|NgnOilLifeRmng|String||XmlElement()||
|+|NgnOilPrssr|String||XmlElement()||
|+|NgnOilTmprtr|Decimal||XmlElement()||
|+|NgnRPM|String||XmlElement()||
|+|NgnLd|String||XmlElement()||
|+|NgnTtlTm|Decimal||XmlElement()||
|+|NgnHrs|Decimal||XmlElement()||
|+|NgnTtlIdleTm|Decimal||XmlElement()||
|+|NgnIdleTm|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HardAcclrtn""",HardAcclrtn,"""[0-9]{1,4}"""),validPattern("""HardBrakg""",HardBrakg,"""[0-9]{1,4}"""),validPattern("""BttryVltg""",BttryVltg,"""[0-9]{1,4}"""),validPattern("""FuelGaugeLvl""",FuelGaugeLvl,"""[0-9]{1,4}"""),validPattern("""FuelTankLvlStart""",FuelTankLvlStart,"""[0-9]{1,4}"""),validPattern("""NgnOilLifeRmng""",NgnOilLifeRmng,"""[0-9]{1,3}"""),validPattern("""NgnOilPrssr""",NgnOilPrssr,"""[0-9]{1,3}"""),validPattern("""NgnRPM""",NgnRPM,"""[0-9]{1,5}"""),validPattern("""NgnLd""",NgnLd,"""[0-9]{1,12}"""))|

---

## Value ISO20022.Cain025001.OriginalDataElements3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ApprvlCd|String||XmlElement()||
|+|RspnCd|String||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalFee3>||XmlElement()||
|+|TxAmts|ISO20022.Cain025001.OriginalTransactionAmounts3||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain025001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain025001.OriginalTransactionIdentification1||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|SndrId|String||XmlElement()||
|+|AcqrrId|String||XmlElement()||
|+|MsgFctn|String||XmlElement()||
|+|MsgClss|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ApprvlCd""",ApprvlCd,"""[a-zA-Z0-9\s]{6}"""),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validPattern("""TxTp""",TxTp,"""[0-9A-Z]{2,2}"""),validPattern("""SndrId""",SndrId,"""[0-9]{1,11}"""),validPattern("""AcqrrId""",AcqrrId,"""[0-9]{1,11}"""))|

---

## Value ISO20022.Cain025001.OriginalTransactionAmounts3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcncltnFctvXchgRate|Decimal||XmlElement()||
|+|RcncltnCcy|String||XmlElement()||
|+|RcncltnAmt|Decimal||XmlElement()||
|+|CrdhldrBllgFctvXchgRate|Decimal||XmlElement()||
|+|CrdhldrBllgCcy|String||XmlElement()||
|+|CrdhldrBllgAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|AmtQlfr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RcncltnCcy""",RcncltnCcy,"""[0-9]{3,3}"""),validPattern("""CrdhldrBllgCcy""",CrdhldrBllgCcy,"""[0-9]{3,3}"""),validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain025001.OriginalTransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssrRefData|String||XmlElement()||
|+|AcqrrRefNb|String||XmlElement()||
|+|AcqrrRefData|String||XmlElement()||
|+|LifeCyclIdMssng|String||XmlElement()||
|+|AuthntcnTkn|String||XmlElement()||
|+|PresntmntSeqCnt|String||XmlElement()||
|+|PresntmntSeqNb|String||XmlElement()||
|+|AuthstnSeqNb|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|LifeCyclSpprt|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|PurchsIdr|String||XmlElement()||
|+|OthrPurchsIdrTp|String||XmlElement()||
|+|PurchsIdrTp|String||XmlElement()||
|+|TmZone|String||XmlElement()||
|+|LclTm|DateTime||XmlElement()||
|+|LclDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcqrrRefNb""",AcqrrRefNb,"""[0-9]{1,23}"""),validPattern("""PresntmntSeqCnt""",PresntmntSeqCnt,"""[0-9]{2}"""),validPattern("""PresntmntSeqNb""",PresntmntSeqNb,"""[0-9]{2}"""),validPattern("""AuthstnSeqNb""",AuthstnSeqNb,"""[0-9]{2}"""),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""))|

---

## Value ISO20022.Cain025001.Parameter13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Cain025001.AlgorithmIdentification26||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Cain025001.Parameter14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.PartyIdentification285


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|global::System.Collections.Generic.List<ISO20022.Cain025001.LocalData14>||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LclData""",LclData),validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain025001.PartyIdentification286


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cain025001.LocalData14||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""),validPattern("""Id""",Id,"""[0-9]{1,11}"""))|

---

## Value ISO20022.Cain025001.PartyIdentification288


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|OwnrEthnctyTpPrvddBy|String||XmlElement()||
|+|OwnrEthnctyTp|String||XmlElement()||
|+|CertfctnTpPrvddBy|String||XmlElement()||
|+|CertfctnTp|String||XmlElement()||
|+|OwnrTpPrvddBy|String||XmlElement()||
|+|OwnrTp|String||XmlElement()||
|+|BizTpPrvddBy|String||XmlElement()||
|+|BizTp|String||XmlElement()||
|+|CorpTaxIdTp|String||XmlElement()||
|+|CorpTaxId|String||XmlElement()||
|+|AddtlTxRefNb|String||XmlElement()||
|+|SpnsrdMrchnt|global::System.Collections.Generic.List<ISO20022.Cain025001.SponsoredMerchant3>||XmlElement()||
|+|LclData|global::System.Collections.Generic.List<ISO20022.Cain025001.LocalData11>||XmlElement()||
|+|TaxRegnId|String||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|CstmrSvc|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|GeogcLctn|String||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|NmAndLctn|String||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""SpnsrdMrchnt""",SpnsrdMrchnt),validElement(SpnsrdMrchnt),validList("""LclData""",LclData),validElement(LclData),validPattern("""GeogcLctn""",GeogcLctn,"""(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?"""),validElement(Adr),validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Enum ISO20022.Cain025001.PartyType17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CISP|Int32||XmlEnum("""CISP""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQP|Int32||XmlEnum("""ACQP""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|
||OTHP|Int32||XmlEnum("""OTHP""")|6|
||OTHN|Int32||XmlEnum("""OTHN""")|7|

---

## Enum ISO20022.Cain025001.PartyType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|

---

## Enum ISO20022.Cain025001.PartyType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||ISUR|Int32||XmlEnum("""ISUR""")|3|
||AGNT|Int32||XmlEnum("""AGNT""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Value ISO20022.Cain025001.PassengerTransport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|HirdVhclDtls|global::System.Collections.Generic.List<ISO20022.Cain025001.HiredVehicle3>||XmlElement()||
|+|AncllryPurchs|global::System.Collections.Generic.List<ISO20022.Cain025001.AncillaryPurchase3>||XmlElement()||
|+|TripLeg|global::System.Collections.Generic.List<ISO20022.Cain025001.TripLeg3>||XmlElement()||
|+|LltyPrgrmm|ISO20022.Cain025001.LoyaltyProgramme4||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|TtlAmt|global::System.Collections.Generic.List<ISO20022.Cain025001.AmountDetails3>||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|Dprture|ISO20022.Cain025001.DepartureOrArrival1||XmlElement()||
|+|Pssngr|global::System.Collections.Generic.List<ISO20022.Cain025001.Customer9>||XmlElement()||
|+|CstmrRef|global::System.Collections.Generic.List<ISO20022.Cain025001.CustomerReference1>||XmlElement()||
|+|OpnTckt|String||XmlElement()||
|+|TcktIssr|String||XmlElement()||
|+|TrvlAuthstnCd|String||XmlElement()||
|+|OrgnlRsvatnNb|String||XmlElement()||
|+|OrgnlRsvatnSys|String||XmlElement()||
|+|RsvatnNb|String||XmlElement()||
|+|RsvatnSys|String||XmlElement()||
|+|DocNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""HirdVhclDtls""",HirdVhclDtls),validElement(HirdVhclDtls),validList("""AncllryPurchs""",AncllryPurchs),validElement(AncllryPurchs),validList("""TripLeg""",TripLeg),validElement(TripLeg),validElement(LltyPrgrmm),validList("""TtlAmt""",TtlAmt),validElement(TtlAmt),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""),validElement(Dprture),validList("""Pssngr""",Pssngr),validElement(Pssngr),validList("""CstmrRef""",CstmrRef),validElement(CstmrRef))|

---

## Enum ISO20022.Cain025001.PeriodUnit2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MINU|Int32||XmlEnum("""MINU""")|2|
||YEAR|Int32||XmlEnum("""YEAR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||WEEK|Int32||XmlEnum("""WEEK""")|5|
||DAYS|Int32||XmlEnum("""DAYS""")|6|
||HFDA|Int32||XmlEnum("""HFDA""")|7|
||HOUR|Int32||XmlEnum("""HOUR""")|8|

---

## Enum ISO20022.Cain025001.PeriodUnit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXDY|Int32||XmlEnum("""EXDY""")|1|
||DAYS|Int32||XmlEnum("""DAYS""")|2|
||YEAR|Int32||XmlEnum("""YEAR""")|3|
||WEEK|Int32||XmlEnum("""WEEK""")|4|
||MNTH|Int32||XmlEnum("""MNTH""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||OTHP|Int32||XmlEnum("""OTHP""")|7|

---

## Enum ISO20022.Cain025001.PeriodUnit4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||HOUR|Int32||XmlEnum("""HOUR""")|2|
||HFDA|Int32||XmlEnum("""HFDA""")|3|
||MINU|Int32||XmlEnum("""MINU""")|4|
||EXDY|Int32||XmlEnum("""EXDY""")|5|
||DAYS|Int32||XmlEnum("""DAYS""")|6|
||YEAR|Int32||XmlEnum("""YEAR""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||OTHN|Int32||XmlEnum("""OTHN""")|10|
||OTHP|Int32||XmlEnum("""OTHP""")|11|

---

## Value ISO20022.Cain025001.PlainCardData23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData))|

---

## Enum ISO20022.Cain025001.PresentationMedium2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||PAPR|Int32||XmlEnum("""PAPR""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|
||BIOM|Int32||XmlEnum("""BIOM""")|4|

---

## Value ISO20022.Cain025001.Product8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SummryCmmdtyId|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain025001.ProductCodeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPCE|Int32||XmlEnum("""UPCE""")|1|
||UPCA|Int32||XmlEnum("""UPCA""")|2|
||RS14|Int32||XmlEnum("""RS14""")|3|
||PLUP|Int32||XmlEnum("""PLUP""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||GTIN|Int32||XmlEnum("""GTIN""")|6|
||EAN8|Int32||XmlEnum("""EAN8""")|7|
||EA13|Int32||XmlEnum("""EA13""")|8|

---

## Value ISO20022.Cain025001.ProgrammeMode5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|ApldId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Cain025001.ProtectedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|ISO20022.Cain025001.EncryptedData2||XmlElement()||
|+|EnvlpdData|ISO20022.Cain025001.EnvelopedData12||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdData),validElement(EnvlpdData))|

---

## Enum ISO20022.Cain025001.ProtectionMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEEN|Int32||XmlEnum("""TEEN""")|1|
||SOFT|Int32||XmlEnum("""SOFT""")|2|
||SNCL|Int32||XmlEnum("""SNCL""")|3|
||SELM|Int32||XmlEnum("""SELM""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|

---

## Enum ISO20022.Cain025001.PurchaseIdentifierType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TREF|Int32||XmlEnum("""TREF""")|1|
||TRNU|Int32||XmlEnum("""TRNU""")|2|
||REAG|Int32||XmlEnum("""REAG""")|3|
||CUPO|Int32||XmlEnum("""CUPO""")|4|
||CUOR|Int32||XmlEnum("""CUOR""")|5|
||ORNU|Int32||XmlEnum("""ORNU""")|6|
||PRNU|Int32||XmlEnum("""PRNU""")|7|
||FONU|Int32||XmlEnum("""FONU""")|8|
||CONU|Int32||XmlEnum("""CONU""")|9|
||SUOR|Int32||XmlEnum("""SUOR""")|10|
||TINU|Int32||XmlEnum("""TINU""")|11|
||RSNU|Int32||XmlEnum("""RSNU""")|12|
||RENU|Int32||XmlEnum("""RENU""")|13|
||PUID|Int32||XmlEnum("""PUID""")|14|
||INNU|Int32||XmlEnum("""INNU""")|15|
||RELO|Int32||XmlEnum("""RELO""")|16|
||SUIN|Int32||XmlEnum("""SUIN""")|17|
||OTHP|Int32||XmlEnum("""OTHP""")|18|
||OTHN|Int32||XmlEnum("""OTHN""")|19|

---

## Value ISO20022.Cain025001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cain025001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Cain025001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Cain025001.Recipient7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cain025001.KEKIdentifier6||XmlElement()||
|+|KEK|ISO20022.Cain025001.KEK6||XmlElement()||
|+|KeyTrnsprt|ISO20022.Cain025001.KeyTransport6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Cain025001.Reconciliation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChckptRef|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.RentalDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|TmPrdRate|Decimal||XmlElement()||
|+|TmPrdUnit|String||XmlElement()||
|+|TmPrd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rtr|ISO20022.Cain025001.ServiceStartEnd3||XmlElement()||
|+|Start|ISO20022.Cain025001.ServiceStartEnd3||XmlElement()||
|+|DtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""),validPattern("""TmPrdUnit""",TmPrdUnit,"""[0-9]{1,4}"""),validElement(Rtr),validElement(Start))|

---

## Value ISO20022.Cain025001.RentalRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrdCnt|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|OthrPrd|String||XmlElement()||
|+|Prd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrdCnt""",PrdCnt,"""[0-9]{1,4}"""))|

---

## Value ISO20022.Cain025001.RentalRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrdCnt|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|OthrPrd|String||XmlElement()||
|+|Prd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrdCnt""",PrdCnt,"""[0-9]{1,4}"""))|

---

## Value ISO20022.Cain025001.Sale3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Cain025001.SaleItem4>||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Cain025001.Adjustment13>||XmlElement()||
|+|LltyPrgrmm|ISO20022.Cain025001.LoyaltyProgramme4||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineItm""",LineItm),validElement(LineItm),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt),validElement(LltyPrgrmm))|

---

## Value ISO20022.Cain025001.SaleItem4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlAmt|Decimal||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|InsrncAmt|Decimal||XmlElement()||
|+|InsrncInd|String||XmlElement()||
|+|AdjstdAmt|Decimal||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Cain025001.Adjustment14>||XmlElement()||
|+|NonAdjstdTtlAmt|Decimal||XmlElement()||
|+|NonAdjstdUnitPric|Decimal||XmlElement()||
|+|PdctQty|Decimal||XmlElement()||
|+|OthrUnitOfMeasr|String||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|PdctDesc|String||XmlElement()||
|+|PdctCdModfr|Decimal||XmlElement()||
|+|AddtlPdctCdTp|String||XmlElement()||
|+|AddtlPdctCd|String||XmlElement()||
|+|PdctCdTp|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
|+|PdctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tax""",Tax),validElement(Tax),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt))|

---

## Value ISO20022.Cain025001.ServiceStartEnd3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|JrnyDtAndTm|DateTime||XmlElement()||
|+|JrnyData|String||XmlElement()||
|+|JrnyTp|String||XmlElement()||
|+|TmSgmt|String||XmlElement()||
|+|DtAndTm|DateTime||XmlElement()||
|+|Ctct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|LctnCd|String||XmlElement()||
|+|Lctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ctct),validElement(Adr))|

---

## Value ISO20022.Cain025001.SettlementService6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|RptgNttyId|String||XmlElement()||
|+|RptgNttyTp|String||XmlElement()||
|+|CutOffTm|DateTime||XmlElement()||
|+|Prd|String||XmlElement()||
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Dfrrd|String||XmlElement()||
|+|ReqdDt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf))|

---

## Value ISO20022.Cain025001.ShippingData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Packg|global::System.Collections.Generic.List<ISO20022.Cain025001.ShippingPackage3>||XmlElement()||
|+|NbOfPackgs|String||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|NetAmt|Decimal||XmlElement()||
|+|InsrncAmt|Decimal||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|MiscExpnss|Decimal||XmlElement()||
|+|IncntivAmt|Decimal||XmlElement()||
|+|SvcDscrptrCd|String||XmlElement()||
|+|InvcCreDtTm|DateTime||XmlElement()||
|+|InvcNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Packg""",Packg),validElement(Packg),validPattern("""NbOfPackgs""",NbOfPackgs,"""[0-9]{1,6}"""),validList("""Tax""",Tax),validElement(Tax))|

---

## Value ISO20022.Cain025001.ShippingPackage3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InsrncAmt|Decimal||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|Pdct|global::System.Collections.Generic.List<ISO20022.Cain025001.Product8>||XmlElement()||
|+|NbOfUnits|Decimal||XmlElement()||
|+|OthrWghtUnit|String||XmlElement()||
|+|WghtUnit|String||XmlElement()||
|+|DlvryTm|DateTime||XmlElement()||
|+|DlvryDt|DateTime||XmlElement()||
|+|DlvryInstrs|String||XmlElement()||
|+|DlvryCtct|ISO20022.Cain025001.ContactPersonal1||XmlElement()||
|+|DlvryAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|DlvryNoteNb|String||XmlElement()||
|+|PckpTm|DateTime||XmlElement()||
|+|PckpDt|DateTime||XmlElement()||
|+|SpplrInstrs|String||XmlElement()||
|+|SpplrCtct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|SpplrAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|SpplrId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|SpplrNm|String||XmlElement()||
|+|TrckgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Pdct""",Pdct),validElement(Pdct),validElement(DlvryCtct),validElement(DlvryAdr),validElement(SpplrCtct),validElement(SpplrAdr),validElement(SpplrId))|

---

## Value ISO20022.Cain025001.SponsoredMerchant3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|global::System.Collections.Generic.List<ISO20022.Cain025001.LocalData12>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|GeogcLctn|String||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
|+|Frgn|String||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LclData""",LclData),validElement(LclData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""GeogcLctn""",GeogcLctn,"""(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?"""),validElement(Adr),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Enum ISO20022.Cain025001.StorageLocation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPWL|Int32||XmlEnum("""TPWL""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||ONFL|Int32||XmlEnum("""ONFL""")|4|
||ISWL|Int32||XmlEnum("""ISWL""")|5|
||DVCE|Int32||XmlEnum("""DVCE""")|6|
||CAWL|Int32||XmlEnum("""CAWL""")|7|

---

## Value ISO20022.Cain025001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Cain025001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Cain025001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Tax41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|InclInTtl|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|XmptRsn|String||XmlElement()||
|+|Xmptn|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain025001.TaxReclaimMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||INSU|Int32||XmlEnum("""INSU""")|2|
||INPS|Int32||XmlEnum("""INPS""")|3|
||INPP|Int32||XmlEnum("""INPP""")|4|

---

## Value ISO20022.Cain025001.TelecomServices3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Cain025001.TelecomServicesLineItem3>||XmlElement()||
|+|TtlTax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|BllgEvt|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount22>||XmlElement()||
|+|BllgEnd|DateTime||XmlElement()||
|+|BllgStart|DateTime||XmlElement()||
|+|CstmrPhne|String||XmlElement()||
|+|CstmrNm|String||XmlElement()||
|+|CstmrAcctNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""LineItm""",LineItm),validElement(LineItm),validList("""TtlTax""",TtlTax),validElement(TtlTax),validList("""BllgEvt""",BllgEvt),validElement(BllgEvt),validPattern("""CstmrPhne""",CstmrPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cain025001.TelecomServicesLineItem3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|Chrg|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount23>||XmlElement()||
|+|CallToCtry|String||XmlElement()||
|+|CallToCtrySubDvsnMnr|String||XmlElement()||
|+|CallToCtrySubDvsnMjr|String||XmlElement()||
|+|CallToCity|String||XmlElement()||
|+|CallToPhne|String||XmlElement()||
|+|CallToOthrTp|String||XmlElement()||
|+|CallToTp|String||XmlElement()||
|+|CallFrCtry|String||XmlElement()||
|+|CallFrCtrySubDvsnMnr|String||XmlElement()||
|+|CallFrCtrySubDvsnMjr|String||XmlElement()||
|+|CallFrCity|String||XmlElement()||
|+|CallFrPhne|String||XmlElement()||
|+|CallFrOthrTp|String||XmlElement()||
|+|CallFrTp|String||XmlElement()||
|+|Drtn|DateTime||XmlElement()||
|+|TmPrd|String||XmlElement()||
|+|StartDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Tax""",Tax),validElement(Tax),validList("""Chrg""",Chrg),validElement(Chrg),validPattern("""CallToCtry""",CallToCtry,"""[A-Z]{2,3}"""),validPattern("""CallToCtrySubDvsnMnr""",CallToCtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""CallToCtrySubDvsnMjr""",CallToCtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""CallToPhne""",CallToPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""CallFrCtry""",CallFrCtry,"""[A-Z]{2,3}"""),validPattern("""CallFrCtrySubDvsnMnr""",CallFrCtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""CallFrCtrySubDvsnMjr""",CallFrCtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""CallFrPhne""",CallFrPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Cain025001.TelephonyCallType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICPC|Int32||XmlEnum("""ICPC""")|1|
||OTCL|Int32||XmlEnum("""OTCL""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||OTHP|Int32||XmlEnum("""OTHP""")|4|
||OGPC|Int32||XmlEnum("""OGPC""")|5|
||PAGE|Int32||XmlEnum("""PAGE""")|6|
||TFPC|Int32||XmlEnum("""TFPC""")|7|
||VCML|Int32||XmlEnum("""VCML""")|8|

---

## Value ISO20022.Cain025001.TemporaryServices3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|SbttlAmt|Decimal||XmlElement()||
|+|MiscExpnss|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount13>||XmlElement()||
|+|Chrg|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount12>||XmlElement()||
|+|WkEndg|DateTime||XmlElement()||
|+|TmSheet|String||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|DscntAmt|Decimal||XmlElement()||
|+|FlatRateInd|String||XmlElement()||
|+|JobEndDt|DateTime||XmlElement()||
|+|JobDrtn|String||XmlElement()||
|+|JobStartDt|DateTime||XmlElement()||
|+|JobDesc|String||XmlElement()||
|+|JobCd|String||XmlElement()||
|+|MplyeePrfssnlLvl|String||XmlElement()||
|+|MplyeeNm|String||XmlElement()||
|+|MplyeeId|String||XmlElement()||
|+|MplyeePrsnlId|String||XmlElement()||
|+|CpnySprvsr|String||XmlElement()||
|+|CpnyId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|CpnyDept|String||XmlElement()||
|+|CpnyNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Tax""",Tax),validElement(Tax),validList("""MiscExpnss""",MiscExpnss),validElement(MiscExpnss),validList("""Chrg""",Chrg),validElement(Chrg),validPattern("""JobDrtn""",JobDrtn,"""[0-9]{1,5}"""),validPattern("""MplyeeId""",MplyeeId,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(CpnyId))|

---

## Enum ISO20022.Cain025001.TemporaryServicesCharge1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HAZD|Int32||XmlEnum("""HAZD""")|1|
||HOLI|Int32||XmlEnum("""HOLI""")|2|
||NITE|Int32||XmlEnum("""NITE""")|3|
||ONCL|Int32||XmlEnum("""ONCL""")|4|
||OTHN|Int32||XmlEnum("""OTHN""")|5|
||OTHP|Int32||XmlEnum("""OTHP""")|6|
||OVRT|Int32||XmlEnum("""OVRT""")|7|
||REGL|Int32||XmlEnum("""REGL""")|8|
||WKND|Int32||XmlEnum("""WKND""")|9|

---

## Enum ISO20022.Cain025001.TimeSegment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PMAN|Int32||XmlEnum("""PMAN""")|1|
||AMBN|Int32||XmlEnum("""AMBN""")|2|

---

## Value ISO20022.Cain025001.Token2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|OthrPrtcnMtd|String||XmlElement()||
|+|PrtcnMtd|String||XmlElement()||
|+|OthrStorgLctn|String||XmlElement()||
|+|StorgLctn|String||XmlElement()||
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknRqstrId|String||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|PmtTkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validPattern("""TknRqstrId""",TknRqstrId,"""[0-9]{1,11}"""),validPattern("""PmtTkn""",PmtTkn,"""[0-9]{1,19}"""))|

---

## Value ISO20022.Cain025001.Traceability10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmOut|DateTime||XmlElement()||
|+|DtTmIn|DateTime||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain025001.TransactionIdentification53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AssoctdDataRef|String||XmlElement()||
|+|IssrRefData|String||XmlElement()||
|+|AcqrrRefNb|String||XmlElement()||
|+|AcqrrRefData|String||XmlElement()||
|+|AuthntcnTkn|String||XmlElement()||
|+|PresntmntSeqCnt|String||XmlElement()||
|+|PresntmntSeqNb|String||XmlElement()||
|+|AuthstnSeqNb|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|LifeCyclSpprt|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|PurchsIdr|String||XmlElement()||
|+|OthrPurchsIdrTp|String||XmlElement()||
|+|PurchsIdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcqrrRefNb""",AcqrrRefNb,"""[0-9]{1,23}"""),validPattern("""PresntmntSeqCnt""",PresntmntSeqCnt,"""[0-9]{2}"""),validPattern("""PresntmntSeqNb""",PresntmntSeqNb,"""[0-9]{2}"""),validPattern("""AuthstnSeqNb""",AuthstnSeqNb,"""[0-9]{2}"""),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""))|

---

## Enum ISO20022.Cain025001.TransportType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHIP|Int32||XmlEnum("""SHIP""")|1|
||RAIL|Int32||XmlEnum("""RAIL""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||BUSS|Int32||XmlEnum("""BUSS""")|5|
||AIRR|Int32||XmlEnum("""AIRR""")|6|

---

## Value ISO20022.Cain025001.TravelAgency4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|TrvlPackg|global::System.Collections.Generic.List<ISO20022.Cain025001.TravelAgencyPackage2>||XmlElement()||
|+|Ctct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|Adr|ISO20022.Cain025001.Address2||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|IATACd|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""TrvlPackg""",TrvlPackg),validElement(TrvlPackg),validElement(Ctct),validElement(Adr))|

---

## Value ISO20022.Cain025001.TravelAgencyPackage2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fee|Decimal||XmlElement()||
|+|InsrncAmt|Decimal||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|CdtCardSlipNb|String||XmlElement()||
|+|DlvryOrdrNb|String||XmlElement()||
|+|DataSrc|String||XmlElement()||
|+|CstmrRef|global::System.Collections.Generic.List<ISO20022.Cain025001.CustomerReference1>||XmlElement()||
|+|NbInPty|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|RsvatnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CstmrRef""",CstmrRef),validElement(CstmrRef),validPattern("""NbInPty""",NbInPty,"""[0-9]{1,10}"""))|

---

## Value ISO20022.Cain025001.TravelDocument2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|IssncDt|DateTime||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|Form|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain025001.TripLeg3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|LltyPrgrmm|ISO20022.Cain025001.LoyaltyProgramme4||XmlElement()||
|+|PrcdrId|String||XmlElement()||
|+|CdtRsnCd|String||XmlElement()||
|+|Amt|global::System.Collections.Generic.List<ISO20022.Cain025001.AmountDetails3>||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|FairBsisCd|String||XmlElement()||
|+|NonDrctRouteCd|String||XmlElement()||
|+|StopOver|String||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|Arrvl|ISO20022.Cain025001.DepartureOrArrival1||XmlElement()||
|+|Dprture|ISO20022.Cain025001.DepartureOrArrival1||XmlElement()||
|+|SvcClss|String||XmlElement()||
|+|RouteNb|String||XmlElement()||
|+|IATACd|String||XmlElement()||
|+|CrrierCd|String||XmlElement()||
|+|CrrierNm|String||XmlElement()||
|+|CmmdtyCd|String||XmlElement()||
|+|OthrTrnsprtTp|String||XmlElement()||
|+|TrnsprtTp|String||XmlElement()||
|+|Doc|global::System.Collections.Generic.List<ISO20022.Cain025001.DocumentReference1>||XmlElement()||
|+|OrgnlRsvatnNb|String||XmlElement()||
|+|OrgnlRsvatnSys|String||XmlElement()||
|+|RsvatnNb|String||XmlElement()||
|+|RsvatnSys|String||XmlElement()||
|+|RcrdLctrNb|String||XmlElement()||
|+|XchgdTcktNb|String||XmlElement()||
|+|XchgdTckt|String||XmlElement()||
|+|TcktRstrctns|String||XmlElement()||
|+|OpnTckt|String||XmlElement()||
|+|RstrctdTckt|String||XmlElement()||
|+|CnjnctnTcktNb|String||XmlElement()||
|+|TcktIsseLctn|String||XmlElement()||
|+|TcktIsseDt|DateTime||XmlElement()||
|+|TcktIssr|String||XmlElement()||
|+|TcktNb|String||XmlElement()||
|+|SeqNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(LltyPrgrmm),validList("""Amt""",Amt),validElement(Amt),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""),validElement(Arrvl),validElement(Dprture),validList("""Doc""",Doc),validElement(Doc),validPattern("""SeqNb""",SeqNb,"""[0-9]{1,35}"""))|

---

## Enum ISO20022.Cain025001.TypeOfAmount19Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USGE|Int32||XmlEnum("""USGE""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||MISC|Int32||XmlEnum("""MISC""")|4|
||LNDS|Int32||XmlEnum("""LNDS""")|5|
||INSU|Int32||XmlEnum("""INSU""")|6|
||CONN|Int32||XmlEnum("""CONN""")|7|

---

## Enum ISO20022.Cain025001.TypeOfAmount21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MNIF|Int32||XmlEnum("""MNIF""")|1|
||MXIF|Int32||XmlEnum("""MXIF""")|2|
||CSIF|Int32||XmlEnum("""CSIF""")|3|
||FEEA|Int32||XmlEnum("""FEEA""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||FEEP|Int32||XmlEnum("""FEEP""")|7|
||INTC|Int32||XmlEnum("""INTC""")|8|

---

## Enum ISO20022.Cain025001.TypeOfAmount22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESD|Int32||XmlEnum("""RESD""")|1|
||PRXY|Int32||XmlEnum("""PRXY""")|2|
||MAXI|Int32||XmlEnum("""MAXI""")|3|
||ESTM|Int32||XmlEnum("""ESTM""")|4|
||DPST|Int32||XmlEnum("""DPST""")|5|
||DFLT|Int32||XmlEnum("""DFLT""")|6|
||ACTL|Int32||XmlEnum("""ACTL""")|7|

---

## Enum ISO20022.Cain025001.TypeTypeOfAmount23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FEES|Int32||XmlEnum("""FEES""")|1|
||TKDL|Int32||XmlEnum("""TKDL""")|2|
||UPGD|Int32||XmlEnum("""UPGD""")|3|
||TOUR|Int32||XmlEnum("""TOUR""")|4|
||TOTL|Int32||XmlEnum("""TOTL""")|5|
||PRPY|Int32||XmlEnum("""PRPY""")|6|
||PHNE|Int32||XmlEnum("""PHNE""")|7|
||PETC|Int32||XmlEnum("""PETC""")|8|
||OTHP|Int32||XmlEnum("""OTHP""")|9|
||OTHN|Int32||XmlEnum("""OTHN""")|10|
||MISC|Int32||XmlEnum("""MISC""")|11|
||INSU|Int32||XmlEnum("""INSU""")|12|
||FDBV|Int32||XmlEnum("""FDBV""")|13|
||FARE|Int32||XmlEnum("""FARE""")|14|
||EXTR|Int32||XmlEnum("""EXTR""")|15|
||EXTF|Int32||XmlEnum("""EXTF""")|16|
||EXTK|Int32||XmlEnum("""EXTK""")|17|
||DUTY|Int32||XmlEnum("""DUTY""")|18|
||CLUB|Int32||XmlEnum("""CLUB""")|19|
||CHTC|Int32||XmlEnum("""CHTC""")|20|
||CARG|Int32||XmlEnum("""CARG""")|21|
||BAGG|Int32||XmlEnum("""BAGG""")|22|
||AMTH|Int32||XmlEnum("""AMTH""")|23|

---

## Enum ISO20022.Cain025001.UnitOfMeasure10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MILE|Int32||XmlEnum("""MILE""")|1|
||KMET|Int32||XmlEnum("""KMET""")|2|

---

## Enum ISO20022.Cain025001.UnitOfMeasure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACRE|Int32||XmlEnum("""ACRE""")|1|
||SQIN|Int32||XmlEnum("""SQIN""")|2|
||SQFO|Int32||XmlEnum("""SQFO""")|3|
||SQYA|Int32||XmlEnum("""SQYA""")|4|
||SQMI|Int32||XmlEnum("""SQMI""")|5|
||SMIL|Int32||XmlEnum("""SMIL""")|6|
||SCMT|Int32||XmlEnum("""SCMT""")|7|
||SMET|Int32||XmlEnum("""SMET""")|8|
||ARES|Int32||XmlEnum("""ARES""")|9|
||HECT|Int32||XmlEnum("""HECT""")|10|
||SQKI|Int32||XmlEnum("""SQKI""")|11|
||YARD|Int32||XmlEnum("""YARD""")|12|
||KMET|Int32||XmlEnum("""KMET""")|13|
||MILE|Int32||XmlEnum("""MILE""")|14|
||USPI|Int32||XmlEnum("""USPI""")|15|
||GBPI|Int32||XmlEnum("""GBPI""")|16|
||USQA|Int32||XmlEnum("""USQA""")|17|
||GBQA|Int32||XmlEnum("""GBQA""")|18|
||USOU|Int32||XmlEnum("""USOU""")|19|
||GBOU|Int32||XmlEnum("""GBOU""")|20|
||MILI|Int32||XmlEnum("""MILI""")|21|
||CELI|Int32||XmlEnum("""CELI""")|22|
||LITR|Int32||XmlEnum("""LITR""")|23|
||MMET|Int32||XmlEnum("""MMET""")|24|
||CMET|Int32||XmlEnum("""CMET""")|25|
||METR|Int32||XmlEnum("""METR""")|26|
||PUND|Int32||XmlEnum("""PUND""")|27|
||KILO|Int32||XmlEnum("""KILO""")|28|
||INCH|Int32||XmlEnum("""INCH""")|29|
||GRAM|Int32||XmlEnum("""GRAM""")|30|
||USGA|Int32||XmlEnum("""USGA""")|31|
||GBGA|Int32||XmlEnum("""GBGA""")|32|
||FOOT|Int32||XmlEnum("""FOOT""")|33|
||TONS|Int32||XmlEnum("""TONS""")|34|
||PIEC|Int32||XmlEnum("""PIEC""")|35|

---

## Value ISO20022.Cain025001.Vehicle2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain025001.Vehicle6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.Vehicle2>||XmlElement()||
|+|OnBrdDgnstcs|ISO20022.Cain025001.OnBoardDiagnostics1||XmlElement()||
|+|MntncId|String||XmlElement()||
|+|Hbmtr|Decimal||XmlElement()||
|+|Odmtr|Decimal||XmlElement()||
|+|Rplcmnt|String||XmlElement()||
|+|TagNtryMd|String||XmlElement()||
|+|Tag|String||XmlElement()||
|+|TrlrNb|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|SubFleetNb|String||XmlElement()||
|+|FleetNb|String||XmlElement()||
|+|IdNb|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(OnBrdDgnstcs),validPattern("""TrlrNb""",TrlrNb,"""[0-9]{1,35}"""),validPattern("""UnitNb""",UnitNb,"""[0-9]{1,35}"""),validPattern("""IdNb""",IdNb,"""[0-9]{1,35}"""),validPattern("""Nb""",Nb,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Cain025001.VehicleRentalAgreement3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LltyPrgrmm|global::System.Collections.Generic.List<ISO20022.Cain025001.LoyaltyProgramme5>||XmlElement()||
|+|DscntPrgrmm|global::System.Collections.Generic.List<ISO20022.Cain025001.Discount3>||XmlElement()||
|+|EstmtdTax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|AddtlAmt|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount21>||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|RntlDtls|ISO20022.Cain025001.RentalDetails3||XmlElement()||
|+|RntlRate|global::System.Collections.Generic.List<ISO20022.Cain025001.RentalRate2>||XmlElement()||
|+|TrvlDstnc|ISO20022.Cain025001.Distance1||XmlElement()||
|+|RegnNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Make|String||XmlElement()||
|+|Clss|String||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|ChckInTm|DateTime||XmlElement()||
|+|ChckInDt|DateTime||XmlElement()||
|+|RtrLctn|ISO20022.Cain025001.Address2||XmlElement()||
|+|ChckOutTm|DateTime||XmlElement()||
|+|ChckOutDt|DateTime||XmlElement()||
|+|PckpLctn|global::System.Collections.Generic.List<ISO20022.Cain025001.Address2>||XmlElement()||
|+|RntlLctn|ISO20022.Cain025001.Address2||XmlElement()||
|+|Adjstd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LltyPrgrmm""",LltyPrgrmm),validElement(LltyPrgrmm),validList("""DscntPrgrmm""",DscntPrgrmm),validElement(DscntPrgrmm),validList("""EstmtdTax""",EstmtdTax),validElement(EstmtdTax),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(RntlDtls),validList("""RntlRate""",RntlRate),validElement(RntlRate),validElement(TrvlDstnc),validPattern("""Mdl""",Mdl,"""[0-9]{1,35}"""),validPattern("""Make""",Make,"""[0-9]{1,35}"""),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""),validElement(RtrLctn),validList("""PckpLctn""",PckpLctn),validElement(PckpLctn),validElement(RntlLctn))|

---

## Value ISO20022.Cain025001.VehicleRentalInvoice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|global::System.Collections.Generic.List<ISO20022.Cain025001.Tax41>||XmlElement()||
|+|AddtlAmt|global::System.Collections.Generic.List<ISO20022.Cain025001.Amount21>||XmlElement()||
|+|Insrnc|String||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|Chrg|global::System.Collections.Generic.List<ISO20022.Cain025001.RentalRate1>||XmlElement()||
|+|DstncRate|Decimal||XmlElement()||
|+|FreeDstnc|String||XmlElement()||
|+|TtlDstnc|String||XmlElement()||
|+|OdmtrRtr|String||XmlElement()||
|+|OdmtrStart|String||XmlElement()||
|+|DstncUnit|String||XmlElement()||
|+|RegnNbPrvdd|String||XmlElement()||
|+|MdlPrvdd|String||XmlElement()||
|+|MakePrvdd|String||XmlElement()||
|+|ClssPrvdd|String||XmlElement()||
|+|RegnNbInvcd|String||XmlElement()||
|+|MdlInvcd|String||XmlElement()||
|+|MakeInvcd|String||XmlElement()||
|+|ClssInvcd|String||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|ChckInTm|DateTime||XmlElement()||
|+|ChckInDt|DateTime||XmlElement()||
|+|ChckOutTm|DateTime||XmlElement()||
|+|ChckOutDt|DateTime||XmlElement()||
|+|RtrLctn|ISO20022.Cain025001.Address2||XmlElement()||
|+|Adjstd|String||XmlElement()||
|+|NoShow|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tax""",Tax),validElement(Tax),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validList("""Chrg""",Chrg),validElement(Chrg),validPattern("""FreeDstnc""",FreeDstnc,"""[0-9]{1,10}"""),validPattern("""TtlDstnc""",TtlDstnc,"""[0-9]{1,10}"""),validPattern("""OdmtrRtr""",OdmtrRtr,"""[0-9]{1,10}"""),validPattern("""OdmtrStart""",OdmtrStart,"""[0-9]{1,10}"""),validPattern("""MdlPrvdd""",MdlPrvdd,"""[0-9]{1,35}"""),validPattern("""MakePrvdd""",MakePrvdd,"""[0-9]{1,35}"""),validPattern("""MdlInvcd""",MdlInvcd,"""[0-9]{1,35}"""),validPattern("""MakeInvcd""",MakeInvcd,"""[0-9]{1,35}"""),validPattern("""Drtn""",Drtn,"""[0-9]{1,4}"""),validElement(RtrLctn))|

---

## Value ISO20022.Cain025001.VehicleRentalService3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain025001.AdditionalData1>||XmlElement()||
|+|RntlInvc|ISO20022.Cain025001.VehicleRentalInvoice3||XmlElement()||
|+|RntlAgrmt|ISO20022.Cain025001.VehicleRentalAgreement3||XmlElement()||
|+|SummryCmmdtyId|String||XmlElement()||
|+|LltyPrgrmm|ISO20022.Cain025001.LoyaltyProgramme4||XmlElement()||
|+|AddtlDrvr|global::System.Collections.Generic.List<ISO20022.Cain025001.DriverInParty3>||XmlElement()||
|+|PmryDrvr|ISO20022.Cain025001.DriverInParty3||XmlElement()||
|+|RntrCorpIdrAssgnr|String||XmlElement()||
|+|RntrCorpIdr|String||XmlElement()||
|+|RntrCorpNm|String||XmlElement()||
|+|RntrNm|String||XmlElement()||
|+|CpnyOthrTp|String||XmlElement()||
|+|CpnyTp|String||XmlElement()||
|+|CpnyCtct|ISO20022.Cain025001.ContactBusiness1||XmlElement()||
|+|CpnyAdr|ISO20022.Cain025001.Address2||XmlElement()||
|+|CpnyId|ISO20022.Cain025001.PartyIdentification285||XmlElement()||
|+|CpnyNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(RntlInvc),validElement(RntlAgrmt),validElement(LltyPrgrmm),validList("""AddtlDrvr""",AddtlDrvr),validElement(AddtlDrvr),validElement(PmryDrvr),validElement(CpnyCtct),validElement(CpnyAdr),validElement(CpnyId))|

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

