# catm.003.001.14
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Catm003001.AcceptorConfiguration14 {
        + DataSet  : global::System.Collections.Generic.List~ISO20022.Catm003001.AcceptorConfigurationDataSet6~
        + POIGrpId  : global::System.Collections.Generic.List~String~
        + TermnlMgrId  : ISO20022.Catm003001.GenericIdentification176
    }
    ISO20022.Catm003001.AcceptorConfiguration14 *-- ISO20022.Catm003001.AcceptorConfigurationDataSet6
    ISO20022.Catm003001.AcceptorConfiguration14 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.AcceptorConfigurationContent14 {
        + TermnlPackg  : global::System.Collections.Generic.List~ISO20022.Catm003001.TerminalPackageType5~
        + SaleToPOIParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.SaleToPOIProtocolParameter3~
        + SctyParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.SecurityParameters16~
        + HstComParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.HostCommunicationParameter7~
        + ApplParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.ApplicationParameters13~
        + TermnlParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.PaymentTerminalParameters8~
        + MrchntParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.MerchantConfigurationParameters6~
        + SvcPrvdrParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.ServiceProviderParameters4~
        + AcqrrPrtcolParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.AcquirerProtocolParameters17~
        + TMSPrtcolParams  : global::System.Collections.Generic.List~ISO20022.Catm003001.TMSProtocolParameters7~
        + RplcCfgtn  : String
    }
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.TerminalPackageType5
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.SaleToPOIProtocolParameter3
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.SecurityParameters16
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.HostCommunicationParameter7
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.ApplicationParameters13
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.PaymentTerminalParameters8
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.MerchantConfigurationParameters6
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.ServiceProviderParameters4
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.AcquirerProtocolParameters17
    ISO20022.Catm003001.AcceptorConfigurationContent14 *-- ISO20022.Catm003001.TMSProtocolParameters7
    class ISO20022.Catm003001.AcceptorConfigurationDataSet6 {
        + Cntt  : ISO20022.Catm003001.AcceptorConfigurationContent14
        + CfgtnScp  : String
        + POIId  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericIdentification176~
        + LastSeq  : String
        + SeqCntr  : String
        + Id  : ISO20022.Catm003001.DataSetIdentification11
    }
    ISO20022.Catm003001.AcceptorConfigurationDataSet6 *-- ISO20022.Catm003001.AcceptorConfigurationContent14
    ISO20022.Catm003001.AcceptorConfigurationDataSet6 *-- ISO20022.Catm003001.GenericIdentification176
    ISO20022.Catm003001.AcceptorConfigurationDataSet6 *-- ISO20022.Catm003001.DataSetIdentification11
    class ISO20022.Catm003001.AcceptorConfigurationUpdateV14 {
        + SctyTrlr  : ISO20022.Catm003001.ContentInformationType38
        + AccptrCfgtn  : ISO20022.Catm003001.AcceptorConfiguration14
        + Hdr  : ISO20022.Catm003001.TMSHeader1
    }
    ISO20022.Catm003001.AcceptorConfigurationUpdateV14 *-- ISO20022.Catm003001.ContentInformationType38
    ISO20022.Catm003001.AcceptorConfigurationUpdateV14 *-- ISO20022.Catm003001.AcceptorConfiguration14
    ISO20022.Catm003001.AcceptorConfigurationUpdateV14 *-- ISO20022.Catm003001.TMSHeader1
    class ISO20022.Catm003001.AcquirerHostConfiguration10 {
        + XtrnlyTpSpprtd  : global::System.Collections.Generic.List~String~
        + PrtcolVrsn  : String
        + MsgToSnd  : global::System.Collections.Generic.List~String~
        + HstId  : String
    }
    class ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2 {
        + CxlXchg  : String
        + CmpltnXchg  : ISO20022.Catm003001.ExchangeConfiguration10
        + BtchTrf  : ISO20022.Catm003001.ExchangeConfiguration9
        + FinCaptr  : String
    }
    ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2 *-- ISO20022.Catm003001.ExchangeConfiguration10
    ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2 *-- ISO20022.Catm003001.ExchangeConfiguration9
    class ISO20022.Catm003001.AcquirerProtocolParameters17 {
        + MndtrySctyTrlr  : String
        + PrvtCardData  : String
        + PrtctCardData  : String
        + MsgItm  : global::System.Collections.Generic.List~ISO20022.Catm003001.MessageItemCondition2~
        + BtchDgtlSgntr  : String
        + FileTrfBtch  : String
        + BtchTrfCntt  : global::System.Collections.Generic.List~String~
        + NtfyOffLineCxl  : String
        + CardDataVrfctn  : String
        + RcncltnErr  : String
        + AmtQlfrForRsvatn  : global::System.Collections.Generic.List~String~
        + CmpltnAdvcMndtd  : String
        + SpltTtlCrit  : global::System.Collections.Generic.List~String~
        + SpltTtls  : String
        + TtlsPerCcy  : String
        + RcncltnByAcqrr  : String
        + RcncltnXchg  : ISO20022.Catm003001.ExchangeConfiguration9
        + OffLineTx  : ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2
        + OnLineTx  : ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2
        + Hst  : global::System.Collections.Generic.List~ISO20022.Catm003001.AcquirerHostConfiguration10~
        + ApplId  : global::System.Collections.Generic.List~String~
        + Vrsn  : String
        + AcqrrId  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericIdentification176~
        + ActnTp  : String
    }
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.MessageItemCondition2
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.ExchangeConfiguration9
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.AcquirerHostConfiguration10
    ISO20022.Catm003001.AcquirerProtocolParameters17 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.Algorithm26Code {
        SMS3 = 1
        SHK2 = 2
        SHK1 = 3
        SH35 = 4
        SH33 = 5
        SH32 = 6
        SH31 = 7
        HS01 = 8
        HS51 = 9
        HS38 = 10
        HS25 = 11
    }
    class ISO20022.Catm003001.Algorithm27Code {
        S34R = 1
        S34C = 2
        CCA3 = 3
        CCA2 = 4
        CCA1 = 5
        MCS3 = 6
        CM33 = 7
        CM32 = 8
        CM31 = 9
        CMA2 = 10
        CMA5 = 11
        CMA9 = 12
        MCC1 = 13
        CMA1 = 14
        MCCS = 15
        MACC = 16
    }
    class ISO20022.Catm003001.Algorithm28Code {
        SM4R = 1
        SM4C = 2
        UKA3 = 3
        UKA1 = 4
        SD5C = 5
        E36R = 6
        E36C = 7
        E3DR = 8
        EA2R = 9
        EA9R = 10
        EA5R = 11
        N108 = 12
        DA25 = 13
        DA19 = 14
        DA12 = 15
        EA5C = 16
        EA9C = 17
        UKA2 = 18
        UKPT = 19
        DKP9 = 20
        E3DC = 21
        EA2C = 22
    }
    class ISO20022.Catm003001.Algorithm29Code {
        S2S3 = 1
        SM25 = 2
        SM23 = 3
        SM35 = 4
        SM32 = 5
        SM33 = 6
        SM22 = 7
        DD25 = 8
        DD23 = 9
        DD35 = 10
        DD33 = 11
        DD32 = 12
        DD22 = 13
        EO25 = 14
        EO23 = 15
        EO35 = 16
        EO22 = 17
        EO32 = 18
        EF25 = 19
        EO33 = 20
        EF23 = 21
        EF35 = 22
        EF33 = 23
        EF22 = 24
        EF32 = 25
        ED22 = 26
        ES25 = 27
        ES23 = 28
        ES35 = 29
        ES33 = 30
        ES32 = 31
        ES22 = 32
        ED25 = 33
        ED23 = 34
        ED35 = 35
        ED33 = 36
        ED32 = 37
        ERS3 = 38
        RPSS = 39
        ERS1 = 40
        ERS2 = 41
    }
    class ISO20022.Catm003001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Catm003001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Catm003001.AlgorithmIdentification31 {
        + Param  : ISO20022.Catm003001.Parameter7
        + Algo  : String
    }
    ISO20022.Catm003001.AlgorithmIdentification31 *-- ISO20022.Catm003001.Parameter7
    class ISO20022.Catm003001.AlgorithmIdentification32 {
        + Param  : ISO20022.Catm003001.Parameter12
        + Algo  : String
    }
    ISO20022.Catm003001.AlgorithmIdentification32 *-- ISO20022.Catm003001.Parameter12
    class ISO20022.Catm003001.AlgorithmIdentification33 {
        + Param  : ISO20022.Catm003001.Parameter16
        + Algo  : String
    }
    ISO20022.Catm003001.AlgorithmIdentification33 *-- ISO20022.Catm003001.Parameter16
    class ISO20022.Catm003001.AlgorithmIdentification34 {
        + Param  : ISO20022.Catm003001.Parameter18
        + Algo  : String
    }
    ISO20022.Catm003001.AlgorithmIdentification34 *-- ISO20022.Catm003001.Parameter18
    class ISO20022.Catm003001.AlgorithmIdentification35 {
        + Param  : ISO20022.Catm003001.Parameter17
        + Algo  : String
    }
    ISO20022.Catm003001.AlgorithmIdentification35 *-- ISO20022.Catm003001.Parameter17
    class ISO20022.Catm003001.AlgorithmIdentification36 {
        + Algo  : String
    }
    class ISO20022.Catm003001.ApplicationParameters13 {
        + NcrptdParams  : ISO20022.Catm003001.ContentInformationType40
        + Params  : global::System.Collections.Generic.List~String~
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + ParamsLngth  : Decimal
        + ParamFrmtIdr  : String
        + Vrsn  : String
        + ApplId  : String
        + ActnTp  : String
    }
    ISO20022.Catm003001.ApplicationParameters13 *-- ISO20022.Catm003001.ContentInformationType40
    class ISO20022.Catm003001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Catm003001.AuthenticatedData10 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Catm003001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Catm003001.AlgorithmIdentification31
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catm003001.Recipient15Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.AuthenticatedData10 *-- ISO20022.Catm003001.EncapsulatedContent3
    ISO20022.Catm003001.AuthenticatedData10 *-- ISO20022.Catm003001.AlgorithmIdentification31
    ISO20022.Catm003001.AuthenticatedData10 *-- ISO20022.Catm003001.Recipient15Choice
    class ISO20022.Catm003001.BatchTransactionType1Code {
        DCLN = 1
        FAIL = 2
        CNCL = 3
        DTCT = 4
    }
    class ISO20022.Catm003001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Catm003001.CAPEEncodingMode1Code {
        JSON = 1
        XMLE = 2
    }
    class ISO20022.Catm003001.CAPEExchangeMode1Code {
        MSGE = 1
        APIE = 2
    }
    class ISO20022.Catm003001.CancellationProcess2Code {
        APPL = 1
        REQU = 2
        NALW = 3
        ADVC = 4
    }
    class ISO20022.Catm003001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Catm003001.RelativeDistinguishedName1~
    }
    ISO20022.Catm003001.CertificateIssuer1 *-- ISO20022.Catm003001.RelativeDistinguishedName1
    class ISO20022.Catm003001.ClockSynchronisation3 {
        + Dely  : DateTime
        + SynctnSvr  : global::System.Collections.Generic.List~ISO20022.Catm003001.NetworkParameters7~
        + POITmZone  : String
    }
    ISO20022.Catm003001.ClockSynchronisation3 *-- ISO20022.Catm003001.NetworkParameters7
    class ISO20022.Catm003001.ContentInformationType38 {
        + SgndData  : ISO20022.Catm003001.SignedData9
        + AuthntcdData  : ISO20022.Catm003001.AuthenticatedData10
        + CnttTp  : String
    }
    ISO20022.Catm003001.ContentInformationType38 *-- ISO20022.Catm003001.SignedData9
    ISO20022.Catm003001.ContentInformationType38 *-- ISO20022.Catm003001.AuthenticatedData10
    class ISO20022.Catm003001.ContentInformationType39 {
        + DgstdData  : ISO20022.Catm003001.DigestedData6
        + SgndData  : ISO20022.Catm003001.SignedData9
        + AuthntcdData  : ISO20022.Catm003001.AuthenticatedData10
        + EnvlpdData  : ISO20022.Catm003001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Catm003001.ContentInformationType39 *-- ISO20022.Catm003001.DigestedData6
    ISO20022.Catm003001.ContentInformationType39 *-- ISO20022.Catm003001.SignedData9
    ISO20022.Catm003001.ContentInformationType39 *-- ISO20022.Catm003001.AuthenticatedData10
    ISO20022.Catm003001.ContentInformationType39 *-- ISO20022.Catm003001.EnvelopedData11
    class ISO20022.Catm003001.ContentInformationType40 {
        + EnvlpdData  : ISO20022.Catm003001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Catm003001.ContentInformationType40 *-- ISO20022.Catm003001.EnvelopedData11
    class ISO20022.Catm003001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Catm003001.CryptographicKey18 {
        + AddtlMgmtInf  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericInformation1~
        + KeyChckVal  : String
        + PrtctdCmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Catm003001.ContentInformationType39~
        + CmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericIdentification186~
        + KeyVal  : ISO20022.Catm003001.ContentInformationType39
        + DeactvtnDt  : DateTime
        + ActvtnDt  : DateTime
        + Fctn  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + Vrsn  : String
        + ItmNb  : String
        + SctyPrfl  : String
        + Nm  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Catm003001.CryptographicKey18 *-- ISO20022.Catm003001.GenericInformation1
    ISO20022.Catm003001.CryptographicKey18 *-- ISO20022.Catm003001.ContentInformationType39
    ISO20022.Catm003001.CryptographicKey18 *-- ISO20022.Catm003001.GenericIdentification186
    ISO20022.Catm003001.CryptographicKey18 *-- ISO20022.Catm003001.ContentInformationType39
    class ISO20022.Catm003001.CryptographicKeyType3Code {
        EDE4 = 1
        AES5 = 2
        AES9 = 3
        DKP9 = 4
        EDE3 = 5
        AES2 = 6
    }
    class ISO20022.Catm003001.DataSetCategory10Code {
        TMSP = 1
        CRTF = 2
        TRPR = 3
        SWPK = 4
        SCPR = 5
        MTOR = 6
        MRPR = 7
        MTMG = 8
        APPR = 9
        AQPR = 10
    }
    class ISO20022.Catm003001.DataSetCategory20Code {
        PROB = 1
        SPRP = 2
        SAPR = 3
        RPFL = 4
        CONF = 5
        MDFL = 6
        CMRQ = 7
        LOGF = 8
        CRTF = 9
        TMSP = 10
        PARA = 11
        VDPR = 12
        TRPR = 13
        STRP = 14
        SWPK = 15
        SCPR = 16
        MRPR = 17
        MGTP = 18
        DLGT = 19
        AKCP = 20
        TXCP = 21
        APPR = 22
        AQPR = 23
    }
    class ISO20022.Catm003001.DataSetIdentification11 {
        + CreDtTm  : DateTime
        + Vrsn  : String
        + Tp  : String
        + Nm  : String
    }
    class ISO20022.Catm003001.DigestedData6 {
        + Dgst  : String
        + NcpsltdCntt  : ISO20022.Catm003001.EncapsulatedContent3
        + DgstAlgo  : ISO20022.Catm003001.AlgorithmIdentification36
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.DigestedData6 *-- ISO20022.Catm003001.EncapsulatedContent3
    ISO20022.Catm003001.DigestedData6 *-- ISO20022.Catm003001.AlgorithmIdentification36
    class ISO20022.Catm003001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Catm003001.EncryptedContent7 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Catm003001.AlgorithmIdentification32
        + CnttTp  : String
    }
    ISO20022.Catm003001.EncryptedContent7 *-- ISO20022.Catm003001.AlgorithmIdentification32
    class ISO20022.Catm003001.EncryptionFormat2Code {
        I238 = 1
        TR34 = 2
        TR31 = 3
    }
    class ISO20022.Catm003001.EnvelopedData11 {
        + NcrptdCntt  : ISO20022.Catm003001.EncryptedContent7
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catm003001.Recipient15Choice~
        + OrgtrInf  : ISO20022.Catm003001.OriginatorInformation1
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.EnvelopedData11 *-- ISO20022.Catm003001.EncryptedContent7
    ISO20022.Catm003001.EnvelopedData11 *-- ISO20022.Catm003001.Recipient15Choice
    ISO20022.Catm003001.EnvelopedData11 *-- ISO20022.Catm003001.OriginatorInformation1
    class ISO20022.Catm003001.ExchangeConfiguration10 {
        + XchgDclnd  : String
        + XchgFaild  : String
        + TmCond  : ISO20022.Catm003001.ProcessTiming6
        + ReTry  : ISO20022.Catm003001.ProcessRetry3
        + MaxAmt  : Decimal
        + MaxNb  : Decimal
        + XchgPlcy  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catm003001.ExchangeConfiguration10 *-- ISO20022.Catm003001.ProcessTiming6
    ISO20022.Catm003001.ExchangeConfiguration10 *-- ISO20022.Catm003001.ProcessRetry3
    class ISO20022.Catm003001.ExchangeConfiguration9 {
        + TmCond  : ISO20022.Catm003001.ProcessTiming6
        + ReTry  : ISO20022.Catm003001.ProcessRetry3
        + MaxAmt  : Decimal
        + MaxNb  : Decimal
        + XchgPlcy  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catm003001.ExchangeConfiguration9 *-- ISO20022.Catm003001.ProcessTiming6
    ISO20022.Catm003001.ExchangeConfiguration9 *-- ISO20022.Catm003001.ProcessRetry3
    class ISO20022.Catm003001.ExchangePolicy2Code {
        BLCK = 1
        NONE = 2
        CYCL = 3
        TTLT = 4
        NBLT = 5
        AGRP = 6
        ASAP = 7
        IMMD = 8
        ONDM = 9
    }
    class ISO20022.Catm003001.ExternallyDefinedData5 {
        + Tp  : String
        + PrtctdVal  : ISO20022.Catm003001.ContentInformationType39
        + Val  : String
        + Id  : String
    }
    ISO20022.Catm003001.ExternallyDefinedData5 *-- ISO20022.Catm003001.ContentInformationType39
    class ISO20022.Catm003001.FinancialCapture1Code {
        BTCH = 1
        COMP = 2
        AUTH = 3
    }
    class ISO20022.Catm003001.GenericIdentification176 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catm003001.GenericIdentification177 {
        + Glctn  : ISO20022.Catm003001.Geolocation1
        + RmotAccs  : ISO20022.Catm003001.NetworkParameters7
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    ISO20022.Catm003001.GenericIdentification177 *-- ISO20022.Catm003001.Geolocation1
    ISO20022.Catm003001.GenericIdentification177 *-- ISO20022.Catm003001.NetworkParameters7
    class ISO20022.Catm003001.GenericIdentification186 {
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catm003001.GenericInformation1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Catm003001.Geolocation1 {
        + UTMCordints  : ISO20022.Catm003001.GeolocationUTMCoordinates1
        + GeogcCordints  : ISO20022.Catm003001.GeolocationGeographicCoordinates1
    }
    ISO20022.Catm003001.Geolocation1 *-- ISO20022.Catm003001.GeolocationUTMCoordinates1
    ISO20022.Catm003001.Geolocation1 *-- ISO20022.Catm003001.GeolocationGeographicCoordinates1
    class ISO20022.Catm003001.GeolocationGeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Catm003001.GeolocationUTMCoordinates1 {
        + UTMNrthwrd  : String
        + UTMEstwrd  : String
        + UTMZone  : String
    }
    class ISO20022.Catm003001.HostCommunicationParameter7 {
        + NcodgMd  : String
        + XchgMd  : String
        + PhysIntrfc  : ISO20022.Catm003001.PhysicalInterfaceParameter1
        + NtwkSvcPrvdr  : ISO20022.Catm003001.NetworkParameters7
        + Key  : global::System.Collections.Generic.List~ISO20022.Catm003001.KEKIdentifier5~
        + Adr  : ISO20022.Catm003001.NetworkParameters7
        + HstId  : String
        + ActnTp  : String
    }
    ISO20022.Catm003001.HostCommunicationParameter7 *-- ISO20022.Catm003001.PhysicalInterfaceParameter1
    ISO20022.Catm003001.HostCommunicationParameter7 *-- ISO20022.Catm003001.NetworkParameters7
    ISO20022.Catm003001.HostCommunicationParameter7 *-- ISO20022.Catm003001.KEKIdentifier5
    ISO20022.Catm003001.HostCommunicationParameter7 *-- ISO20022.Catm003001.NetworkParameters7
    class ISO20022.Catm003001.IssuerAndSerialNumber2 {
        + SrlNb  : String
        + Issr  : ISO20022.Catm003001.CertificateIssuer1
    }
    ISO20022.Catm003001.IssuerAndSerialNumber2 *-- ISO20022.Catm003001.CertificateIssuer1
    class ISO20022.Catm003001.KEK9 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catm003001.AlgorithmIdentification32
        + KEKId  : ISO20022.Catm003001.KEKIdentifier7
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.KEK9 *-- ISO20022.Catm003001.AlgorithmIdentification32
    ISO20022.Catm003001.KEK9 *-- ISO20022.Catm003001.KEKIdentifier7
    class ISO20022.Catm003001.KEKIdentifier5 {
        + Fctn  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catm003001.KEKIdentifier7 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catm003001.KeyTransport10 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catm003001.AlgorithmIdentification35
        + RcptId  : ISO20022.Catm003001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.KeyTransport10 *-- ISO20022.Catm003001.AlgorithmIdentification35
    ISO20022.Catm003001.KeyTransport10 *-- ISO20022.Catm003001.Recipient13Choice
    class ISO20022.Catm003001.KeyUsage1Code {
        KEYD = 1
        KEYX = 2
        KEYI = 3
        KEYG = 4
        PINV = 5
        PIND = 6
        PINE = 7
        SUGV = 8
        SIGG = 9
        MACV = 10
        MACG = 11
        TRNX = 12
        TRNI = 13
        DDEC = 14
        DENC = 15
        DCPT = 16
        ENCR = 17
    }
    class ISO20022.Catm003001.LocalDateTime1 {
        + UTCOffset  : Decimal
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Catm003001.MerchantConfigurationParameters6 {
        + OthrParams  : String
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + OthrParamsLngth  : Decimal
        + Prxy  : ISO20022.Catm003001.NetworkParameters8
        + ParamFrmtIdr  : String
        + Vrsn  : String
        + MrchntId  : String
        + ActnTp  : String
    }
    ISO20022.Catm003001.MerchantConfigurationParameters6 *-- ISO20022.Catm003001.NetworkParameters8
    class ISO20022.Catm003001.MessageFunction47Code {
        ATAF = 1
        TRPQ = 2
        NFRQ = 3
        TRNA = 4
        DCAV = 5
        RVRA = 6
        DCCQ = 7
        FCMV = 8
        AUTQ = 9
        FRVA = 10
        BTCH = 11
        CCAV = 12
        RCLQ = 13
        DGNP = 14
        CMPV = 15
        CCAQ = 16
        FAUQ = 17
    }
    class ISO20022.Catm003001.MessageItemCondition2 {
        + Val  : global::System.Collections.Generic.List~String~
        + Cond  : String
        + ItmId  : String
    }
    class ISO20022.Catm003001.MessageItemCondition2Code {
        LMNV = 1
        UNSP = 2
        COPY = 3
        IFAV = 4
        ALWV = 5
        DFLT = 6
        CFVL = 7
        MNDT = 8
    }
    class ISO20022.Catm003001.NetworkParameters7 {
        + SctyPrfl  : String
        + ClntCert  : global::System.Collections.Generic.List~String~
        + SvrCertIdr  : global::System.Collections.Generic.List~String~
        + SvrCert  : global::System.Collections.Generic.List~String~
        + AccsCd  : String
        + UsrNm  : String
        + Adr  : global::System.Collections.Generic.List~ISO20022.Catm003001.NetworkParameters9~
    }
    ISO20022.Catm003001.NetworkParameters7 *-- ISO20022.Catm003001.NetworkParameters9
    class ISO20022.Catm003001.NetworkParameters8 {
        + Accs  : ISO20022.Catm003001.NetworkParameters7
        + Tp  : String
    }
    ISO20022.Catm003001.NetworkParameters8 *-- ISO20022.Catm003001.NetworkParameters7
    class ISO20022.Catm003001.NetworkParameters9 {
        + AdrVal  : String
        + NtwkTp  : String
    }
    class ISO20022.Catm003001.NetworkType1Code {
        PSTN = 1
        IPNW = 2
    }
    class ISO20022.Catm003001.NetworkType2Code {
        HTTP = 1
        SCK4 = 2
        SCK5 = 3
    }
    class ISO20022.Catm003001.NonFinancialRequestType2Code {
        INSM = 1
        ADDR = 2
        TOKN = 3
        RISK = 4
        PARQ = 5
        ACQR = 6
    }
    class ISO20022.Catm003001.Organisation26 {
        + RegdIdr  : String
        + MrchntCtgyCd  : String
        + CtryCd  : String
        + Adr  : String
        + CmonNm  : String
    }
    class ISO20022.Catm003001.OriginatorInformation1 {
        + Cert  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Catm003001.POICommunicationType2Code {
        WT5G = 1
        WT4G = 2
        WT3G = 3
        WT2G = 4
        WIFI = 5
        USBH = 6
        USBD = 7
        RS23 = 8
        PSTN = 9
        GSMF = 10
        GPRS = 11
        ETHR = 12
        BLTH = 13
    }
    class ISO20022.Catm003001.PackageType5 {
        + PackgBlck  : global::System.Collections.Generic.List~ISO20022.Catm003001.ExternallyDefinedData5~
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + PackgLngth  : Decimal
        + PackgId  : ISO20022.Catm003001.GenericIdentification176
    }
    ISO20022.Catm003001.PackageType5 *-- ISO20022.Catm003001.ExternallyDefinedData5
    ISO20022.Catm003001.PackageType5 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.Parameter12 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Catm003001.Parameter16 {
        + OIDCrvNm  : String
        + TrlrFld  : Decimal
        + SaltLngth  : Decimal
        + MskGnrtrAlgo  : ISO20022.Catm003001.AlgorithmIdentification34
        + DgstAlgo  : String
    }
    ISO20022.Catm003001.Parameter16 *-- ISO20022.Catm003001.AlgorithmIdentification34
    class ISO20022.Catm003001.Parameter17 {
        + MskGnrtrAlgo  : ISO20022.Catm003001.AlgorithmIdentification34
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Catm003001.Parameter17 *-- ISO20022.Catm003001.AlgorithmIdentification34
    class ISO20022.Catm003001.Parameter18 {
        + DgstAlgo  : String
    }
    class ISO20022.Catm003001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Catm003001.PartyType15Code {
        PSNG = 1
        PSYS = 2
        PGRP = 3
    }
    class ISO20022.Catm003001.PartyType33Code {
        TMGT = 1
        TAXH = 2
        MTMG = 3
        DLIS = 4
        CISS = 5
        ACQR = 6
        ITAG = 7
        ACCP = 8
        MERC = 9
        OPOI = 10
    }
    class ISO20022.Catm003001.PartyType7Code {
        SALE = 1
        TMGT = 2
        PCPT = 3
        ITAG = 4
        ACQR = 5
    }
    class ISO20022.Catm003001.PaymentTerminalParameters8 {
        + OthrParams  : String
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + OthrParamsLngth  : Decimal
        + LclDtTm  : global::System.Collections.Generic.List~ISO20022.Catm003001.LocalDateTime1~
        + TmZoneLine  : global::System.Collections.Generic.List~String~
        + ClckSynctn  : ISO20022.Catm003001.ClockSynchronisation3
        + ParamFrmtIdr  : String
        + Vrsn  : String
        + VndrId  : String
        + ActnTp  : String
    }
    ISO20022.Catm003001.PaymentTerminalParameters8 *-- ISO20022.Catm003001.LocalDateTime1
    ISO20022.Catm003001.PaymentTerminalParameters8 *-- ISO20022.Catm003001.ClockSynchronisation3
    class ISO20022.Catm003001.PhysicalInterfaceParameter1 {
        + AddtlParams  : String
        + SctyPrfl  : String
        + AccsCd  : String
        + UsrNm  : String
        + IntrfcTp  : String
        + IntrfcNm  : String
    }
    class ISO20022.Catm003001.PointOfInteractionComponentIdentification2 {
        + SrlNb  : String
        + Id  : String
        + PrvdrId  : String
        + ItmNb  : String
    }
    class ISO20022.Catm003001.ProcessRetry3 {
        + UnitOfTm  : String
        + MaxNb  : Decimal
        + Dely  : String
    }
    class ISO20022.Catm003001.ProcessTiming6 {
        + UnitOfTm  : String
        + Prd  : String
        + EndTm  : DateTime
        + StartTm  : DateTime
    }
    class ISO20022.Catm003001.Recipient13Choice {
        + SbjtKeyIdr  : String
        + IssrAndSrlNb  : ISO20022.Catm003001.IssuerAndSerialNumber2
    }
    ISO20022.Catm003001.Recipient13Choice *-- ISO20022.Catm003001.IssuerAndSerialNumber2
    class ISO20022.Catm003001.Recipient15Choice {
        + KeyIdr  : ISO20022.Catm003001.KEKIdentifier7
        + KEK  : ISO20022.Catm003001.KEK9
        + KeyTrnsprt  : ISO20022.Catm003001.KeyTransport10
    }
    ISO20022.Catm003001.Recipient15Choice *-- ISO20022.Catm003001.KEKIdentifier7
    ISO20022.Catm003001.Recipient15Choice *-- ISO20022.Catm003001.KEK9
    ISO20022.Catm003001.Recipient15Choice *-- ISO20022.Catm003001.KeyTransport10
    class ISO20022.Catm003001.ReconciliationCriteria1Code {
        GRUP = 1
        PROF = 2
        BRND = 3
    }
    class ISO20022.Catm003001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catm003001.RetailerMessage1Code {
        SASP = 1
        SASQ = 2
        SFSP = 3
        SFSQ = 4
        SFRQ = 5
        SFRP = 6
        SARP = 7
        SARQ = 8
        SSRJ = 9
        SSMR = 10
        SSMQ = 11
        SSEN = 12
        SDDP = 13
        SDDR = 14
        SAAP = 15
        SAAQ = 16
        SSAB = 17
    }
    class ISO20022.Catm003001.RetailerService2Code {
        FSCQ = 1
        FSAQ = 2
        FSEQ = 3
        FSVQ = 4
        FSLQ = 5
        FSBQ = 6
        FSIQ = 7
        FSRQ = 8
        FSPQ = 9
    }
    class ISO20022.Catm003001.RetailerService8Code {
        DINO = 1
        DCOQ = 2
        DCPQ = 3
        DCAQ = 4
        DCIQ = 5
        DSIQ = 6
        DSOQ = 7
        DPRQ = 8
        DINQ = 9
        DDYQ = 10
    }
    class ISO20022.Catm003001.SaleToPOIProtocolParameter3 {
        + XtrnlyTpSpprtd  : global::System.Collections.Generic.List~String~
        + AllwdSaleDvc  : global::System.Collections.Generic.List~String~
        + AllwdPOISvc  : global::System.Collections.Generic.List~String~
        + AllwdPOIMsg  : global::System.Collections.Generic.List~String~
        + AllwdSaleMsg  : global::System.Collections.Generic.List~String~
        + SaleId  : String
        + MrchntPOIId  : String
        + HstId  : String
        + Vrsn  : String
        + MrchntId  : ISO20022.Catm003001.Organisation26
        + ActnTp  : String
    }
    ISO20022.Catm003001.SaleToPOIProtocolParameter3 *-- ISO20022.Catm003001.Organisation26
    class ISO20022.Catm003001.SecurityParameters16 {
        + SctyElmt  : global::System.Collections.Generic.List~ISO20022.Catm003001.CryptographicKey18~
        + TMChllng  : String
        + POIChllng  : String
        + Vrsn  : String
        + ActnTp  : String
    }
    ISO20022.Catm003001.SecurityParameters16 *-- ISO20022.Catm003001.CryptographicKey18
    class ISO20022.Catm003001.ServiceProviderParameters4 {
        + NonFinActnSpprtd  : global::System.Collections.Generic.List~String~
        + Hst  : global::System.Collections.Generic.List~ISO20022.Catm003001.AcquirerHostConfiguration10~
        + ApplId  : global::System.Collections.Generic.List~String~
        + Vrsn  : String
        + SvcPrvdrId  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericIdentification176~
        + ActnTp  : String
    }
    ISO20022.Catm003001.ServiceProviderParameters4 *-- ISO20022.Catm003001.AcquirerHostConfiguration10
    ISO20022.Catm003001.ServiceProviderParameters4 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.SignedData9 {
        + Sgnr  : global::System.Collections.Generic.List~ISO20022.Catm003001.Signer8~
        + Cert  : global::System.Collections.Generic.List~String~
        + NcpsltdCntt  : ISO20022.Catm003001.EncapsulatedContent3
        + DgstAlgo  : global::System.Collections.Generic.List~ISO20022.Catm003001.AlgorithmIdentification36~
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.SignedData9 *-- ISO20022.Catm003001.Signer8
    ISO20022.Catm003001.SignedData9 *-- ISO20022.Catm003001.EncapsulatedContent3
    ISO20022.Catm003001.SignedData9 *-- ISO20022.Catm003001.AlgorithmIdentification36
    class ISO20022.Catm003001.Signer8 {
        + Sgntr  : String
        + SgntrAlgo  : ISO20022.Catm003001.AlgorithmIdentification33
        + SgndAttrbts  : global::System.Collections.Generic.List~ISO20022.Catm003001.GenericInformation1~
        + DgstAlgo  : ISO20022.Catm003001.AlgorithmIdentification36
        + SgnrId  : ISO20022.Catm003001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catm003001.Signer8 *-- ISO20022.Catm003001.AlgorithmIdentification33
    ISO20022.Catm003001.Signer8 *-- ISO20022.Catm003001.GenericInformation1
    ISO20022.Catm003001.Signer8 *-- ISO20022.Catm003001.AlgorithmIdentification36
    ISO20022.Catm003001.Signer8 *-- ISO20022.Catm003001.Recipient13Choice
    class ISO20022.Catm003001.TMSHeader1 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Catm003001.Traceability8~
        + RcptPty  : ISO20022.Catm003001.GenericIdentification177
        + InitgPty  : ISO20022.Catm003001.GenericIdentification176
        + CreDtTm  : DateTime
        + XchgId  : Decimal
        + FrmtVrsn  : String
        + DwnldTrf  : String
    }
    ISO20022.Catm003001.TMSHeader1 *-- ISO20022.Catm003001.Traceability8
    ISO20022.Catm003001.TMSHeader1 *-- ISO20022.Catm003001.GenericIdentification177
    ISO20022.Catm003001.TMSHeader1 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.TMSProtocolParameters7 {
        + XtrnlyTpSpprtd  : global::System.Collections.Generic.List~String~
        + MsgItm  : global::System.Collections.Generic.List~ISO20022.Catm003001.MessageItemCondition2~
        + FileTrf  : String
        + RcptPtyId  : String
        + InitgPtyId  : String
        + POIId  : String
        + HstId  : String
        + ApplId  : global::System.Collections.Generic.List~String~
        + Vrsn  : String
        + MntncSvc  : global::System.Collections.Generic.List~String~
        + PrtcolVrsn  : String
        + TermnlMgrId  : ISO20022.Catm003001.GenericIdentification176
        + ActnTp  : String
    }
    ISO20022.Catm003001.TMSProtocolParameters7 *-- ISO20022.Catm003001.MessageItemCondition2
    ISO20022.Catm003001.TMSProtocolParameters7 *-- ISO20022.Catm003001.GenericIdentification176
    class ISO20022.Catm003001.TerminalManagementAction3Code {
        UPDT = 1
        DELT = 2
        CREA = 3
    }
    class ISO20022.Catm003001.TerminalPackageType5 {
        + Packg  : global::System.Collections.Generic.List~ISO20022.Catm003001.PackageType5~
        + POICmpntId  : global::System.Collections.Generic.List~ISO20022.Catm003001.PointOfInteractionComponentIdentification2~
    }
    ISO20022.Catm003001.TerminalPackageType5 *-- ISO20022.Catm003001.PackageType5
    ISO20022.Catm003001.TerminalPackageType5 *-- ISO20022.Catm003001.PointOfInteractionComponentIdentification2
    class ISO20022.Catm003001.TimeUnit1Code {
        YEAR = 1
        WEEK = 2
        SECO = 3
        MNTH = 4
        MINU = 5
        HOUR = 6
        DAYC = 7
    }
    class ISO20022.Catm003001.Traceability8 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + PrtcolVrsn  : String
        + PrtcolNm  : String
        + RlayId  : ISO20022.Catm003001.GenericIdentification177
    }
    ISO20022.Catm003001.Traceability8 *-- ISO20022.Catm003001.GenericIdentification177
    class ISO20022.Catm003001.TypeOfAmount8Code {
        RESD = 1
        DECR = 2
        INCR = 3
        RPLT = 4
        DFLT = 5
        MAXI = 6
        ESTM = 7
        ACTL = 8
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

## Value ISO20022.Catm003001.AcceptorConfiguration14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSet|global::System.Collections.Generic.List<ISO20022.Catm003001.AcceptorConfigurationDataSet6>||XmlElement()||
|+|POIGrpId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TermnlMgrId|ISO20022.Catm003001.GenericIdentification176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""DataSet""",DataSet),validList("""DataSet""",DataSet),validElement(DataSet),validElement(TermnlMgrId))|

---

## Value ISO20022.Catm003001.AcceptorConfigurationContent14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermnlPackg|global::System.Collections.Generic.List<ISO20022.Catm003001.TerminalPackageType5>||XmlElement()||
|+|SaleToPOIParams|global::System.Collections.Generic.List<ISO20022.Catm003001.SaleToPOIProtocolParameter3>||XmlElement()||
|+|SctyParams|global::System.Collections.Generic.List<ISO20022.Catm003001.SecurityParameters16>||XmlElement()||
|+|HstComParams|global::System.Collections.Generic.List<ISO20022.Catm003001.HostCommunicationParameter7>||XmlElement()||
|+|ApplParams|global::System.Collections.Generic.List<ISO20022.Catm003001.ApplicationParameters13>||XmlElement()||
|+|TermnlParams|global::System.Collections.Generic.List<ISO20022.Catm003001.PaymentTerminalParameters8>||XmlElement()||
|+|MrchntParams|global::System.Collections.Generic.List<ISO20022.Catm003001.MerchantConfigurationParameters6>||XmlElement()||
|+|SvcPrvdrParams|global::System.Collections.Generic.List<ISO20022.Catm003001.ServiceProviderParameters4>||XmlElement()||
|+|AcqrrPrtcolParams|global::System.Collections.Generic.List<ISO20022.Catm003001.AcquirerProtocolParameters17>||XmlElement()||
|+|TMSPrtcolParams|global::System.Collections.Generic.List<ISO20022.Catm003001.TMSProtocolParameters7>||XmlElement()||
|+|RplcCfgtn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TermnlPackg""",TermnlPackg),validElement(TermnlPackg),validList("""SaleToPOIParams""",SaleToPOIParams),validElement(SaleToPOIParams),validList("""SctyParams""",SctyParams),validElement(SctyParams),validList("""HstComParams""",HstComParams),validElement(HstComParams),validList("""ApplParams""",ApplParams),validElement(ApplParams),validList("""TermnlParams""",TermnlParams),validElement(TermnlParams),validList("""MrchntParams""",MrchntParams),validElement(MrchntParams),validList("""SvcPrvdrParams""",SvcPrvdrParams),validElement(SvcPrvdrParams),validList("""AcqrrPrtcolParams""",AcqrrPrtcolParams),validElement(AcqrrPrtcolParams),validList("""TMSPrtcolParams""",TMSPrtcolParams),validElement(TMSPrtcolParams))|

---

## Value ISO20022.Catm003001.AcceptorConfigurationDataSet6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|ISO20022.Catm003001.AcceptorConfigurationContent14||XmlElement()||
|+|CfgtnScp|String||XmlElement()||
|+|POIId|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericIdentification176>||XmlElement()||
|+|LastSeq|String||XmlElement()||
|+|SeqCntr|String||XmlElement()||
|+|Id|ISO20022.Catm003001.DataSetIdentification11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cntt),validList("""POIId""",POIId),validElement(POIId),validPattern("""SeqCntr""",SeqCntr,"""[0-9]{1,9}"""),validElement(Id))|

---

## Aspect ISO20022.Catm003001.AcceptorConfigurationUpdateV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Catm003001.ContentInformationType38||XmlElement()||
|+|AccptrCfgtn|ISO20022.Catm003001.AcceptorConfiguration14||XmlElement()||
|+|Hdr|ISO20022.Catm003001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(AccptrCfgtn),validElement(Hdr))|

---

## Value ISO20022.Catm003001.AcquirerHostConfiguration10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtrnlyTpSpprtd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgToSnd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|HstId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlXchg|String||XmlElement()||
|+|CmpltnXchg|ISO20022.Catm003001.ExchangeConfiguration10||XmlElement()||
|+|BtchTrf|ISO20022.Catm003001.ExchangeConfiguration9||XmlElement()||
|+|FinCaptr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CmpltnXchg),validElement(BtchTrf))|

---

## Value ISO20022.Catm003001.AcquirerProtocolParameters17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtrySctyTrlr|String||XmlElement()||
|+|PrvtCardData|String||XmlElement()||
|+|PrtctCardData|String||XmlElement()||
|+|MsgItm|global::System.Collections.Generic.List<ISO20022.Catm003001.MessageItemCondition2>||XmlElement()||
|+|BtchDgtlSgntr|String||XmlElement()||
|+|FileTrfBtch|String||XmlElement()||
|+|BtchTrfCntt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NtfyOffLineCxl|String||XmlElement()||
|+|CardDataVrfctn|String||XmlElement()||
|+|RcncltnErr|String||XmlElement()||
|+|AmtQlfrForRsvatn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CmpltnAdvcMndtd|String||XmlElement()||
|+|SpltTtlCrit|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SpltTtls|String||XmlElement()||
|+|TtlsPerCcy|String||XmlElement()||
|+|RcncltnByAcqrr|String||XmlElement()||
|+|RcncltnXchg|ISO20022.Catm003001.ExchangeConfiguration9||XmlElement()||
|+|OffLineTx|ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2||XmlElement()||
|+|OnLineTx|ISO20022.Catm003001.AcquirerProtocolExchangeBehavior2||XmlElement()||
|+|Hst|global::System.Collections.Generic.List<ISO20022.Catm003001.AcquirerHostConfiguration10>||XmlElement()||
|+|ApplId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|AcqrrId|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericIdentification176>||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MsgItm""",MsgItm),validElement(MsgItm),validElement(RcncltnXchg),validElement(OffLineTx),validElement(OnLineTx),validList("""Hst""",Hst),validElement(Hst),validRequired("""AcqrrId""",AcqrrId),validList("""AcqrrId""",AcqrrId),validElement(AcqrrId))|

---

## Enum ISO20022.Catm003001.Algorithm26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMS3|Int32||XmlEnum("""SMS3""")|1|
||SHK2|Int32||XmlEnum("""SHK2""")|2|
||SHK1|Int32||XmlEnum("""SHK1""")|3|
||SH35|Int32||XmlEnum("""SH35""")|4|
||SH33|Int32||XmlEnum("""SH33""")|5|
||SH32|Int32||XmlEnum("""SH32""")|6|
||SH31|Int32||XmlEnum("""SH31""")|7|
||HS01|Int32||XmlEnum("""HS01""")|8|
||HS51|Int32||XmlEnum("""HS51""")|9|
||HS38|Int32||XmlEnum("""HS38""")|10|
||HS25|Int32||XmlEnum("""HS25""")|11|

---

## Enum ISO20022.Catm003001.Algorithm27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S34R|Int32||XmlEnum("""S34R""")|1|
||S34C|Int32||XmlEnum("""S34C""")|2|
||CCA3|Int32||XmlEnum("""CCA3""")|3|
||CCA2|Int32||XmlEnum("""CCA2""")|4|
||CCA1|Int32||XmlEnum("""CCA1""")|5|
||MCS3|Int32||XmlEnum("""MCS3""")|6|
||CM33|Int32||XmlEnum("""CM33""")|7|
||CM32|Int32||XmlEnum("""CM32""")|8|
||CM31|Int32||XmlEnum("""CM31""")|9|
||CMA2|Int32||XmlEnum("""CMA2""")|10|
||CMA5|Int32||XmlEnum("""CMA5""")|11|
||CMA9|Int32||XmlEnum("""CMA9""")|12|
||MCC1|Int32||XmlEnum("""MCC1""")|13|
||CMA1|Int32||XmlEnum("""CMA1""")|14|
||MCCS|Int32||XmlEnum("""MCCS""")|15|
||MACC|Int32||XmlEnum("""MACC""")|16|

---

## Enum ISO20022.Catm003001.Algorithm28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SM4R|Int32||XmlEnum("""SM4R""")|1|
||SM4C|Int32||XmlEnum("""SM4C""")|2|
||UKA3|Int32||XmlEnum("""UKA3""")|3|
||UKA1|Int32||XmlEnum("""UKA1""")|4|
||SD5C|Int32||XmlEnum("""SD5C""")|5|
||E36R|Int32||XmlEnum("""E36R""")|6|
||E36C|Int32||XmlEnum("""E36C""")|7|
||E3DR|Int32||XmlEnum("""E3DR""")|8|
||EA2R|Int32||XmlEnum("""EA2R""")|9|
||EA9R|Int32||XmlEnum("""EA9R""")|10|
||EA5R|Int32||XmlEnum("""EA5R""")|11|
||N108|Int32||XmlEnum("""N108""")|12|
||DA25|Int32||XmlEnum("""DA25""")|13|
||DA19|Int32||XmlEnum("""DA19""")|14|
||DA12|Int32||XmlEnum("""DA12""")|15|
||EA5C|Int32||XmlEnum("""EA5C""")|16|
||EA9C|Int32||XmlEnum("""EA9C""")|17|
||UKA2|Int32||XmlEnum("""UKA2""")|18|
||UKPT|Int32||XmlEnum("""UKPT""")|19|
||DKP9|Int32||XmlEnum("""DKP9""")|20|
||E3DC|Int32||XmlEnum("""E3DC""")|21|
||EA2C|Int32||XmlEnum("""EA2C""")|22|

---

## Enum ISO20022.Catm003001.Algorithm29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S2S3|Int32||XmlEnum("""S2S3""")|1|
||SM25|Int32||XmlEnum("""SM25""")|2|
||SM23|Int32||XmlEnum("""SM23""")|3|
||SM35|Int32||XmlEnum("""SM35""")|4|
||SM32|Int32||XmlEnum("""SM32""")|5|
||SM33|Int32||XmlEnum("""SM33""")|6|
||SM22|Int32||XmlEnum("""SM22""")|7|
||DD25|Int32||XmlEnum("""DD25""")|8|
||DD23|Int32||XmlEnum("""DD23""")|9|
||DD35|Int32||XmlEnum("""DD35""")|10|
||DD33|Int32||XmlEnum("""DD33""")|11|
||DD32|Int32||XmlEnum("""DD32""")|12|
||DD22|Int32||XmlEnum("""DD22""")|13|
||EO25|Int32||XmlEnum("""EO25""")|14|
||EO23|Int32||XmlEnum("""EO23""")|15|
||EO35|Int32||XmlEnum("""EO35""")|16|
||EO22|Int32||XmlEnum("""EO22""")|17|
||EO32|Int32||XmlEnum("""EO32""")|18|
||EF25|Int32||XmlEnum("""EF25""")|19|
||EO33|Int32||XmlEnum("""EO33""")|20|
||EF23|Int32||XmlEnum("""EF23""")|21|
||EF35|Int32||XmlEnum("""EF35""")|22|
||EF33|Int32||XmlEnum("""EF33""")|23|
||EF22|Int32||XmlEnum("""EF22""")|24|
||EF32|Int32||XmlEnum("""EF32""")|25|
||ED22|Int32||XmlEnum("""ED22""")|26|
||ES25|Int32||XmlEnum("""ES25""")|27|
||ES23|Int32||XmlEnum("""ES23""")|28|
||ES35|Int32||XmlEnum("""ES35""")|29|
||ES33|Int32||XmlEnum("""ES33""")|30|
||ES32|Int32||XmlEnum("""ES32""")|31|
||ES22|Int32||XmlEnum("""ES22""")|32|
||ED25|Int32||XmlEnum("""ED25""")|33|
||ED23|Int32||XmlEnum("""ED23""")|34|
||ED35|Int32||XmlEnum("""ED35""")|35|
||ED33|Int32||XmlEnum("""ED33""")|36|
||ED32|Int32||XmlEnum("""ED32""")|37|
||ERS3|Int32||XmlEnum("""ERS3""")|38|
||RPSS|Int32||XmlEnum("""RPSS""")|39|
||ERS1|Int32||XmlEnum("""ERS1""")|40|
||ERS2|Int32||XmlEnum("""ERS2""")|41|

---

## Enum ISO20022.Catm003001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Catm003001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Catm003001.AlgorithmIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm003001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm003001.AlgorithmIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm003001.Parameter12||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm003001.AlgorithmIdentification33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm003001.Parameter16||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm003001.AlgorithmIdentification34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm003001.Parameter18||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm003001.AlgorithmIdentification35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm003001.Parameter17||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm003001.AlgorithmIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.ApplicationParameters13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdParams|ISO20022.Catm003001.ContentInformationType40||XmlElement()||
|+|Params|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|ParamsLngth|Decimal||XmlElement()||
|+|ParamFrmtIdr|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|ApplId|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdParams))|

---

## Enum ISO20022.Catm003001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Catm003001.AuthenticatedData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catm003001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Catm003001.AlgorithmIdentification31||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catm003001.Recipient15Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Catm003001.BatchTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DCLN|Int32||XmlEnum("""DCLN""")|1|
||FAIL|Int32||XmlEnum("""FAIL""")|2|
||CNCL|Int32||XmlEnum("""CNCL""")|3|
||DTCT|Int32||XmlEnum("""DTCT""")|4|

---

## Enum ISO20022.Catm003001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Enum ISO20022.Catm003001.CAPEEncodingMode1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||JSON|Int32||XmlEnum("""JSON""")|1|
||XMLE|Int32||XmlEnum("""XMLE""")|2|

---

## Enum ISO20022.Catm003001.CAPEExchangeMode1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MSGE|Int32||XmlEnum("""MSGE""")|1|
||APIE|Int32||XmlEnum("""APIE""")|2|

---

## Enum ISO20022.Catm003001.CancellationProcess2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APPL|Int32||XmlEnum("""APPL""")|1|
||REQU|Int32||XmlEnum("""REQU""")|2|
||NALW|Int32||XmlEnum("""NALW""")|3|
||ADVC|Int32||XmlEnum("""ADVC""")|4|

---

## Value ISO20022.Catm003001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Catm003001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Catm003001.ClockSynchronisation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dely|DateTime||XmlElement()||
|+|SynctnSvr|global::System.Collections.Generic.List<ISO20022.Catm003001.NetworkParameters7>||XmlElement()||
|+|POITmZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SynctnSvr""",SynctnSvr),validElement(SynctnSvr))|

---

## Value ISO20022.Catm003001.ContentInformationType38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndData|ISO20022.Catm003001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Catm003001.AuthenticatedData10||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndData),validElement(AuthntcdData))|

---

## Value ISO20022.Catm003001.ContentInformationType39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstdData|ISO20022.Catm003001.DigestedData6||XmlElement()||
|+|SgndData|ISO20022.Catm003001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Catm003001.AuthenticatedData10||XmlElement()||
|+|EnvlpdData|ISO20022.Catm003001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgstdData),validElement(SgndData),validElement(AuthntcdData),validElement(EnvlpdData))|

---

## Value ISO20022.Catm003001.ContentInformationType40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Catm003001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Enum ISO20022.Catm003001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Catm003001.CryptographicKey18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlMgmtInf|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericInformation1>||XmlElement()||
|+|KeyChckVal|String||XmlElement()||
|+|PrtctdCmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Catm003001.ContentInformationType39>||XmlElement()||
|+|CmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericIdentification186>||XmlElement()||
|+|KeyVal|ISO20022.Catm003001.ContentInformationType39||XmlElement()||
|+|DeactvtnDt|DateTime||XmlElement()||
|+|ActvtnDt|DateTime||XmlElement()||
|+|Fctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlMgmtInf""",AddtlMgmtInf),validElement(AddtlMgmtInf),validList("""PrtctdCmpntWthAuthrsdAccs""",PrtctdCmpntWthAuthrsdAccs),validElement(PrtctdCmpntWthAuthrsdAccs),validList("""CmpntWthAuthrsdAccs""",CmpntWthAuthrsdAccs),validElement(CmpntWthAuthrsdAccs),validElement(KeyVal))|

---

## Enum ISO20022.Catm003001.CryptographicKeyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EDE4|Int32||XmlEnum("""EDE4""")|1|
||AES5|Int32||XmlEnum("""AES5""")|2|
||AES9|Int32||XmlEnum("""AES9""")|3|
||DKP9|Int32||XmlEnum("""DKP9""")|4|
||EDE3|Int32||XmlEnum("""EDE3""")|5|
||AES2|Int32||XmlEnum("""AES2""")|6|

---

## Enum ISO20022.Catm003001.DataSetCategory10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMSP|Int32||XmlEnum("""TMSP""")|1|
||CRTF|Int32||XmlEnum("""CRTF""")|2|
||TRPR|Int32||XmlEnum("""TRPR""")|3|
||SWPK|Int32||XmlEnum("""SWPK""")|4|
||SCPR|Int32||XmlEnum("""SCPR""")|5|
||MTOR|Int32||XmlEnum("""MTOR""")|6|
||MRPR|Int32||XmlEnum("""MRPR""")|7|
||MTMG|Int32||XmlEnum("""MTMG""")|8|
||APPR|Int32||XmlEnum("""APPR""")|9|
||AQPR|Int32||XmlEnum("""AQPR""")|10|

---

## Enum ISO20022.Catm003001.DataSetCategory20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROB|Int32||XmlEnum("""PROB""")|1|
||SPRP|Int32||XmlEnum("""SPRP""")|2|
||SAPR|Int32||XmlEnum("""SAPR""")|3|
||RPFL|Int32||XmlEnum("""RPFL""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||MDFL|Int32||XmlEnum("""MDFL""")|6|
||CMRQ|Int32||XmlEnum("""CMRQ""")|7|
||LOGF|Int32||XmlEnum("""LOGF""")|8|
||CRTF|Int32||XmlEnum("""CRTF""")|9|
||TMSP|Int32||XmlEnum("""TMSP""")|10|
||PARA|Int32||XmlEnum("""PARA""")|11|
||VDPR|Int32||XmlEnum("""VDPR""")|12|
||TRPR|Int32||XmlEnum("""TRPR""")|13|
||STRP|Int32||XmlEnum("""STRP""")|14|
||SWPK|Int32||XmlEnum("""SWPK""")|15|
||SCPR|Int32||XmlEnum("""SCPR""")|16|
||MRPR|Int32||XmlEnum("""MRPR""")|17|
||MGTP|Int32||XmlEnum("""MGTP""")|18|
||DLGT|Int32||XmlEnum("""DLGT""")|19|
||AKCP|Int32||XmlEnum("""AKCP""")|20|
||TXCP|Int32||XmlEnum("""TXCP""")|21|
||APPR|Int32||XmlEnum("""APPR""")|22|
||AQPR|Int32||XmlEnum("""AQPR""")|23|

---

## Value ISO20022.Catm003001.DataSetIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.DigestedData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dgst|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catm003001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|ISO20022.Catm003001.AlgorithmIdentification36||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(DgstAlgo))|

---

## Type ISO20022.Catm003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AccptrCfgtnUpd|ISO20022.Catm003001.AcceptorConfigurationUpdateV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCfgtnUpd))|

---

## Value ISO20022.Catm003001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.EncryptedContent7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Catm003001.AlgorithmIdentification32||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Catm003001.EncryptionFormat2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||I238|Int32||XmlEnum("""I238""")|1|
||TR34|Int32||XmlEnum("""TR34""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|

---

## Value ISO20022.Catm003001.EnvelopedData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Catm003001.EncryptedContent7||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catm003001.Recipient15Choice>||XmlElement()||
|+|OrgtrInf|ISO20022.Catm003001.OriginatorInformation1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt),validElement(OrgtrInf))|

---

## Value ISO20022.Catm003001.ExchangeConfiguration10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgDclnd|String||XmlElement()||
|+|XchgFaild|String||XmlElement()||
|+|TmCond|ISO20022.Catm003001.ProcessTiming6||XmlElement()||
|+|ReTry|ISO20022.Catm003001.ProcessRetry3||XmlElement()||
|+|MaxAmt|Decimal||XmlElement()||
|+|MaxNb|Decimal||XmlElement()||
|+|XchgPlcy|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmCond),validElement(ReTry),validRequired("""XchgPlcy""",XchgPlcy))|

---

## Value ISO20022.Catm003001.ExchangeConfiguration9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmCond|ISO20022.Catm003001.ProcessTiming6||XmlElement()||
|+|ReTry|ISO20022.Catm003001.ProcessRetry3||XmlElement()||
|+|MaxAmt|Decimal||XmlElement()||
|+|MaxNb|Decimal||XmlElement()||
|+|XchgPlcy|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmCond),validElement(ReTry),validRequired("""XchgPlcy""",XchgPlcy))|

---

## Enum ISO20022.Catm003001.ExchangePolicy2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCK|Int32||XmlEnum("""BLCK""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||CYCL|Int32||XmlEnum("""CYCL""")|3|
||TTLT|Int32||XmlEnum("""TTLT""")|4|
||NBLT|Int32||XmlEnum("""NBLT""")|5|
||AGRP|Int32||XmlEnum("""AGRP""")|6|
||ASAP|Int32||XmlEnum("""ASAP""")|7|
||IMMD|Int32||XmlEnum("""IMMD""")|8|
||ONDM|Int32||XmlEnum("""ONDM""")|9|

---

## Value ISO20022.Catm003001.ExternallyDefinedData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|PrtctdVal|ISO20022.Catm003001.ContentInformationType39||XmlElement()||
|+|Val|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdVal))|

---

## Enum ISO20022.Catm003001.FinancialCapture1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BTCH|Int32||XmlEnum("""BTCH""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|
||AUTH|Int32||XmlEnum("""AUTH""")|3|

---

## Value ISO20022.Catm003001.GenericIdentification176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catm003001.GenericIdentification177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Glctn|ISO20022.Catm003001.Geolocation1||XmlElement()||
|+|RmotAccs|ISO20022.Catm003001.NetworkParameters7||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Glctn),validElement(RmotAccs),validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catm003001.GenericIdentification186


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.GenericInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.Geolocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Catm003001.GeolocationUTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Catm003001.GeolocationGeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints))|

---

## Value ISO20022.Catm003001.GeolocationGeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.GeolocationUTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|String||XmlElement()||
|+|UTMEstwrd|String||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.HostCommunicationParameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcodgMd|String||XmlElement()||
|+|XchgMd|String||XmlElement()||
|+|PhysIntrfc|ISO20022.Catm003001.PhysicalInterfaceParameter1||XmlElement()||
|+|NtwkSvcPrvdr|ISO20022.Catm003001.NetworkParameters7||XmlElement()||
|+|Key|global::System.Collections.Generic.List<ISO20022.Catm003001.KEKIdentifier5>||XmlElement()||
|+|Adr|ISO20022.Catm003001.NetworkParameters7||XmlElement()||
|+|HstId|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PhysIntrfc),validElement(NtwkSvcPrvdr),validList("""Key""",Key),validElement(Key),validElement(Adr))|

---

## Value ISO20022.Catm003001.IssuerAndSerialNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Catm003001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Catm003001.KEK9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catm003001.AlgorithmIdentification32||XmlElement()||
|+|KEKId|ISO20022.Catm003001.KEKIdentifier7||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Catm003001.KEKIdentifier5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.KEKIdentifier7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.KeyTransport10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catm003001.AlgorithmIdentification35||XmlElement()||
|+|RcptId|ISO20022.Catm003001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Catm003001.KeyUsage1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||KEYD|Int32||XmlEnum("""KEYD""")|1|
||KEYX|Int32||XmlEnum("""KEYX""")|2|
||KEYI|Int32||XmlEnum("""KEYI""")|3|
||KEYG|Int32||XmlEnum("""KEYG""")|4|
||PINV|Int32||XmlEnum("""PINV""")|5|
||PIND|Int32||XmlEnum("""PIND""")|6|
||PINE|Int32||XmlEnum("""PINE""")|7|
||SUGV|Int32||XmlEnum("""SUGV""")|8|
||SIGG|Int32||XmlEnum("""SIGG""")|9|
||MACV|Int32||XmlEnum("""MACV""")|10|
||MACG|Int32||XmlEnum("""MACG""")|11|
||TRNX|Int32||XmlEnum("""TRNX""")|12|
||TRNI|Int32||XmlEnum("""TRNI""")|13|
||DDEC|Int32||XmlEnum("""DDEC""")|14|
||DENC|Int32||XmlEnum("""DENC""")|15|
||DCPT|Int32||XmlEnum("""DCPT""")|16|
||ENCR|Int32||XmlEnum("""ENCR""")|17|

---

## Value ISO20022.Catm003001.LocalDateTime1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTCOffset|Decimal||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.MerchantConfigurationParameters6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrParams|String||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|OthrParamsLngth|Decimal||XmlElement()||
|+|Prxy|ISO20022.Catm003001.NetworkParameters8||XmlElement()||
|+|ParamFrmtIdr|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|MrchntId|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy))|

---

## Enum ISO20022.Catm003001.MessageFunction47Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ATAF|Int32||XmlEnum("""ATAF""")|1|
||TRPQ|Int32||XmlEnum("""TRPQ""")|2|
||NFRQ|Int32||XmlEnum("""NFRQ""")|3|
||TRNA|Int32||XmlEnum("""TRNA""")|4|
||DCAV|Int32||XmlEnum("""DCAV""")|5|
||RVRA|Int32||XmlEnum("""RVRA""")|6|
||DCCQ|Int32||XmlEnum("""DCCQ""")|7|
||FCMV|Int32||XmlEnum("""FCMV""")|8|
||AUTQ|Int32||XmlEnum("""AUTQ""")|9|
||FRVA|Int32||XmlEnum("""FRVA""")|10|
||BTCH|Int32||XmlEnum("""BTCH""")|11|
||CCAV|Int32||XmlEnum("""CCAV""")|12|
||RCLQ|Int32||XmlEnum("""RCLQ""")|13|
||DGNP|Int32||XmlEnum("""DGNP""")|14|
||CMPV|Int32||XmlEnum("""CMPV""")|15|
||CCAQ|Int32||XmlEnum("""CCAQ""")|16|
||FAUQ|Int32||XmlEnum("""FAUQ""")|17|

---

## Value ISO20022.Catm003001.MessageItemCondition2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Cond|String||XmlElement()||
|+|ItmId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm003001.MessageItemCondition2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LMNV|Int32||XmlEnum("""LMNV""")|1|
||UNSP|Int32||XmlEnum("""UNSP""")|2|
||COPY|Int32||XmlEnum("""COPY""")|3|
||IFAV|Int32||XmlEnum("""IFAV""")|4|
||ALWV|Int32||XmlEnum("""ALWV""")|5|
||DFLT|Int32||XmlEnum("""DFLT""")|6|
||CFVL|Int32||XmlEnum("""CFVL""")|7|
||MNDT|Int32||XmlEnum("""MNDT""")|8|

---

## Value ISO20022.Catm003001.NetworkParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyPrfl|String||XmlElement()||
|+|ClntCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCertIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|Adr|global::System.Collections.Generic.List<ISO20022.Catm003001.NetworkParameters9>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Adr""",Adr),validList("""Adr""",Adr),validElement(Adr))|

---

## Value ISO20022.Catm003001.NetworkParameters8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Accs|ISO20022.Catm003001.NetworkParameters7||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Accs))|

---

## Value ISO20022.Catm003001.NetworkParameters9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrVal|String||XmlElement()||
|+|NtwkTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm003001.NetworkType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTN|Int32||XmlEnum("""PSTN""")|1|
||IPNW|Int32||XmlEnum("""IPNW""")|2|

---

## Enum ISO20022.Catm003001.NetworkType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTTP|Int32||XmlEnum("""HTTP""")|1|
||SCK4|Int32||XmlEnum("""SCK4""")|2|
||SCK5|Int32||XmlEnum("""SCK5""")|3|

---

## Enum ISO20022.Catm003001.NonFinancialRequestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INSM|Int32||XmlEnum("""INSM""")|1|
||ADDR|Int32||XmlEnum("""ADDR""")|2|
||TOKN|Int32||XmlEnum("""TOKN""")|3|
||RISK|Int32||XmlEnum("""RISK""")|4|
||PARQ|Int32||XmlEnum("""PARQ""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|

---

## Value ISO20022.Catm003001.Organisation26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdIdr|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|CtryCd|String||XmlElement()||
|+|Adr|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Catm003001.OriginatorInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm003001.POICommunicationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WT5G|Int32||XmlEnum("""WT5G""")|1|
||WT4G|Int32||XmlEnum("""WT4G""")|2|
||WT3G|Int32||XmlEnum("""WT3G""")|3|
||WT2G|Int32||XmlEnum("""WT2G""")|4|
||WIFI|Int32||XmlEnum("""WIFI""")|5|
||USBH|Int32||XmlEnum("""USBH""")|6|
||USBD|Int32||XmlEnum("""USBD""")|7|
||RS23|Int32||XmlEnum("""RS23""")|8|
||PSTN|Int32||XmlEnum("""PSTN""")|9|
||GSMF|Int32||XmlEnum("""GSMF""")|10|
||GPRS|Int32||XmlEnum("""GPRS""")|11|
||ETHR|Int32||XmlEnum("""ETHR""")|12|
||BLTH|Int32||XmlEnum("""BLTH""")|13|

---

## Value ISO20022.Catm003001.PackageType5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PackgBlck|global::System.Collections.Generic.List<ISO20022.Catm003001.ExternallyDefinedData5>||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|PackgLngth|Decimal||XmlElement()||
|+|PackgId|ISO20022.Catm003001.GenericIdentification176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PackgBlck""",PackgBlck),validElement(PackgBlck),validElement(PackgId))|

---

## Value ISO20022.Catm003001.Parameter12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.Parameter16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OIDCrvNm|String||XmlElement()||
|+|TrlrFld|Decimal||XmlElement()||
|+|SaltLngth|Decimal||XmlElement()||
|+|MskGnrtrAlgo|ISO20022.Catm003001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catm003001.Parameter17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Catm003001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catm003001.Parameter18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm003001.PartyType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSNG|Int32||XmlEnum("""PSNG""")|1|
||PSYS|Int32||XmlEnum("""PSYS""")|2|
||PGRP|Int32||XmlEnum("""PGRP""")|3|

---

## Enum ISO20022.Catm003001.PartyType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMGT|Int32||XmlEnum("""TMGT""")|1|
||TAXH|Int32||XmlEnum("""TAXH""")|2|
||MTMG|Int32||XmlEnum("""MTMG""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISS|Int32||XmlEnum("""CISS""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|
||ITAG|Int32||XmlEnum("""ITAG""")|7|
||ACCP|Int32||XmlEnum("""ACCP""")|8|
||MERC|Int32||XmlEnum("""MERC""")|9|
||OPOI|Int32||XmlEnum("""OPOI""")|10|

---

## Enum ISO20022.Catm003001.PartyType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SALE|Int32||XmlEnum("""SALE""")|1|
||TMGT|Int32||XmlEnum("""TMGT""")|2|
||PCPT|Int32||XmlEnum("""PCPT""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Value ISO20022.Catm003001.PaymentTerminalParameters8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrParams|String||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|OthrParamsLngth|Decimal||XmlElement()||
|+|LclDtTm|global::System.Collections.Generic.List<ISO20022.Catm003001.LocalDateTime1>||XmlElement()||
|+|TmZoneLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ClckSynctn|ISO20022.Catm003001.ClockSynchronisation3||XmlElement()||
|+|ParamFrmtIdr|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|VndrId|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LclDtTm""",LclDtTm),validElement(LclDtTm),validElement(ClckSynctn))|

---

## Value ISO20022.Catm003001.PhysicalInterfaceParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlParams|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|IntrfcTp|String||XmlElement()||
|+|IntrfcNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.PointOfInteractionComponentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm003001.ProcessRetry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfTm|String||XmlElement()||
|+|MaxNb|Decimal||XmlElement()||
|+|Dely|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dely""",Dely,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Catm003001.ProcessTiming6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfTm|String||XmlElement()||
|+|Prd|String||XmlElement()||
|+|EndTm|DateTime||XmlElement()||
|+|StartTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prd""",Prd,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Catm003001.Recipient13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbjtKeyIdr|String||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Catm003001.IssuerAndSerialNumber2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssrAndSrlNb),validChoice(SbjtKeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Catm003001.Recipient15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catm003001.KEKIdentifier7||XmlElement()||
|+|KEK|ISO20022.Catm003001.KEK9||XmlElement()||
|+|KeyTrnsprt|ISO20022.Catm003001.KeyTransport10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Enum ISO20022.Catm003001.ReconciliationCriteria1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRUP|Int32||XmlEnum("""GRUP""")|1|
||PROF|Int32||XmlEnum("""PROF""")|2|
||BRND|Int32||XmlEnum("""BRND""")|3|

---

## Value ISO20022.Catm003001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm003001.RetailerMessage1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SASP|Int32||XmlEnum("""SASP""")|1|
||SASQ|Int32||XmlEnum("""SASQ""")|2|
||SFSP|Int32||XmlEnum("""SFSP""")|3|
||SFSQ|Int32||XmlEnum("""SFSQ""")|4|
||SFRQ|Int32||XmlEnum("""SFRQ""")|5|
||SFRP|Int32||XmlEnum("""SFRP""")|6|
||SARP|Int32||XmlEnum("""SARP""")|7|
||SARQ|Int32||XmlEnum("""SARQ""")|8|
||SSRJ|Int32||XmlEnum("""SSRJ""")|9|
||SSMR|Int32||XmlEnum("""SSMR""")|10|
||SSMQ|Int32||XmlEnum("""SSMQ""")|11|
||SSEN|Int32||XmlEnum("""SSEN""")|12|
||SDDP|Int32||XmlEnum("""SDDP""")|13|
||SDDR|Int32||XmlEnum("""SDDR""")|14|
||SAAP|Int32||XmlEnum("""SAAP""")|15|
||SAAQ|Int32||XmlEnum("""SAAQ""")|16|
||SSAB|Int32||XmlEnum("""SSAB""")|17|

---

## Enum ISO20022.Catm003001.RetailerService2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FSCQ|Int32||XmlEnum("""FSCQ""")|1|
||FSAQ|Int32||XmlEnum("""FSAQ""")|2|
||FSEQ|Int32||XmlEnum("""FSEQ""")|3|
||FSVQ|Int32||XmlEnum("""FSVQ""")|4|
||FSLQ|Int32||XmlEnum("""FSLQ""")|5|
||FSBQ|Int32||XmlEnum("""FSBQ""")|6|
||FSIQ|Int32||XmlEnum("""FSIQ""")|7|
||FSRQ|Int32||XmlEnum("""FSRQ""")|8|
||FSPQ|Int32||XmlEnum("""FSPQ""")|9|

---

## Enum ISO20022.Catm003001.RetailerService8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DINO|Int32||XmlEnum("""DINO""")|1|
||DCOQ|Int32||XmlEnum("""DCOQ""")|2|
||DCPQ|Int32||XmlEnum("""DCPQ""")|3|
||DCAQ|Int32||XmlEnum("""DCAQ""")|4|
||DCIQ|Int32||XmlEnum("""DCIQ""")|5|
||DSIQ|Int32||XmlEnum("""DSIQ""")|6|
||DSOQ|Int32||XmlEnum("""DSOQ""")|7|
||DPRQ|Int32||XmlEnum("""DPRQ""")|8|
||DINQ|Int32||XmlEnum("""DINQ""")|9|
||DDYQ|Int32||XmlEnum("""DDYQ""")|10|

---

## Value ISO20022.Catm003001.SaleToPOIProtocolParameter3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtrnlyTpSpprtd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AllwdSaleDvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AllwdPOISvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AllwdPOIMsg|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AllwdSaleMsg|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SaleId|String||XmlElement()||
|+|MrchntPOIId|String||XmlElement()||
|+|HstId|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|MrchntId|ISO20022.Catm003001.Organisation26||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrchntId))|

---

## Value ISO20022.Catm003001.SecurityParameters16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyElmt|global::System.Collections.Generic.List<ISO20022.Catm003001.CryptographicKey18>||XmlElement()||
|+|TMChllng|String||XmlElement()||
|+|POIChllng|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SctyElmt""",SctyElmt),validElement(SctyElmt))|

---

## Value ISO20022.Catm003001.ServiceProviderParameters4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonFinActnSpprtd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Hst|global::System.Collections.Generic.List<ISO20022.Catm003001.AcquirerHostConfiguration10>||XmlElement()||
|+|ApplId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|SvcPrvdrId|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericIdentification176>||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Hst""",Hst),validElement(Hst),validRequired("""SvcPrvdrId""",SvcPrvdrId),validList("""SvcPrvdrId""",SvcPrvdrId),validElement(SvcPrvdrId))|

---

## Value ISO20022.Catm003001.SignedData9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgnr|global::System.Collections.Generic.List<ISO20022.Catm003001.Signer8>||XmlElement()||
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catm003001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<ISO20022.Catm003001.AlgorithmIdentification36>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Sgnr""",Sgnr),validElement(Sgnr),validElement(NcpsltdCntt),validList("""DgstAlgo""",DgstAlgo),validElement(DgstAlgo))|

---

## Value ISO20022.Catm003001.Signer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|String||XmlElement()||
|+|SgntrAlgo|ISO20022.Catm003001.AlgorithmIdentification33||XmlElement()||
|+|SgndAttrbts|global::System.Collections.Generic.List<ISO20022.Catm003001.GenericInformation1>||XmlElement()||
|+|DgstAlgo|ISO20022.Catm003001.AlgorithmIdentification36||XmlElement()||
|+|SgnrId|ISO20022.Catm003001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgntrAlgo),validList("""SgndAttrbts""",SgndAttrbts),validElement(SgndAttrbts),validElement(DgstAlgo),validElement(SgnrId))|

---

## Value ISO20022.Catm003001.TMSHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Catm003001.Traceability8>||XmlElement()||
|+|RcptPty|ISO20022.Catm003001.GenericIdentification177||XmlElement()||
|+|InitgPty|ISO20022.Catm003001.GenericIdentification176||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|Decimal||XmlElement()||
|+|FrmtVrsn|String||XmlElement()||
|+|DwnldTrf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validElement(RcptPty),validElement(InitgPty))|

---

## Value ISO20022.Catm003001.TMSProtocolParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtrnlyTpSpprtd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgItm|global::System.Collections.Generic.List<ISO20022.Catm003001.MessageItemCondition2>||XmlElement()||
|+|FileTrf|String||XmlElement()||
|+|RcptPtyId|String||XmlElement()||
|+|InitgPtyId|String||XmlElement()||
|+|POIId|String||XmlElement()||
|+|HstId|String||XmlElement()||
|+|ApplId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|MntncSvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|TermnlMgrId|ISO20022.Catm003001.GenericIdentification176||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MsgItm""",MsgItm),validElement(MsgItm),validRequired("""MntncSvc""",MntncSvc),validElement(TermnlMgrId))|

---

## Enum ISO20022.Catm003001.TerminalManagementAction3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDT|Int32||XmlEnum("""UPDT""")|1|
||DELT|Int32||XmlEnum("""DELT""")|2|
||CREA|Int32||XmlEnum("""CREA""")|3|

---

## Value ISO20022.Catm003001.TerminalPackageType5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Packg|global::System.Collections.Generic.List<ISO20022.Catm003001.PackageType5>||XmlElement()||
|+|POICmpntId|global::System.Collections.Generic.List<ISO20022.Catm003001.PointOfInteractionComponentIdentification2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Packg""",Packg),validList("""Packg""",Packg),validElement(Packg),validList("""POICmpntId""",POICmpntId),validElement(POICmpntId))|

---

## Enum ISO20022.Catm003001.TimeUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||SECO|Int32||XmlEnum("""SECO""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||MINU|Int32||XmlEnum("""MINU""")|5|
||HOUR|Int32||XmlEnum("""HOUR""")|6|
||DAYC|Int32||XmlEnum("""DAYC""")|7|

---

## Value ISO20022.Catm003001.Traceability8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|PrtcolNm|String||XmlElement()||
|+|RlayId|ISO20022.Catm003001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Enum ISO20022.Catm003001.TypeOfAmount8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESD|Int32||XmlEnum("""RESD""")|1|
||DECR|Int32||XmlEnum("""DECR""")|2|
||INCR|Int32||XmlEnum("""INCR""")|3|
||RPLT|Int32||XmlEnum("""RPLT""")|4|
||DFLT|Int32||XmlEnum("""DFLT""")|5|
||MAXI|Int32||XmlEnum("""MAXI""")|6|
||ESTM|Int32||XmlEnum("""ESTM""")|7|
||ACTL|Int32||XmlEnum("""ACTL""")|8|

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

