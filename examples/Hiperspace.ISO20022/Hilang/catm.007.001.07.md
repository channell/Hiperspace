# catm.007.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Catm007001.Algorithm26Code {
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
    class ISO20022.Catm007001.Algorithm27Code {
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
    class ISO20022.Catm007001.Algorithm28Code {
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
    class ISO20022.Catm007001.Algorithm29Code {
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
    class ISO20022.Catm007001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Catm007001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Catm007001.AlgorithmIdentification31 {
        + Param  : ISO20022.Catm007001.Parameter7
        + Algo  : String
    }
    ISO20022.Catm007001.AlgorithmIdentification31 *-- ISO20022.Catm007001.Parameter7
    class ISO20022.Catm007001.AlgorithmIdentification32 {
        + Param  : ISO20022.Catm007001.Parameter12
        + Algo  : String
    }
    ISO20022.Catm007001.AlgorithmIdentification32 *-- ISO20022.Catm007001.Parameter12
    class ISO20022.Catm007001.AlgorithmIdentification33 {
        + Param  : ISO20022.Catm007001.Parameter16
        + Algo  : String
    }
    ISO20022.Catm007001.AlgorithmIdentification33 *-- ISO20022.Catm007001.Parameter16
    class ISO20022.Catm007001.AlgorithmIdentification34 {
        + Param  : ISO20022.Catm007001.Parameter18
        + Algo  : String
    }
    ISO20022.Catm007001.AlgorithmIdentification34 *-- ISO20022.Catm007001.Parameter18
    class ISO20022.Catm007001.AlgorithmIdentification35 {
        + Param  : ISO20022.Catm007001.Parameter17
        + Algo  : String
    }
    ISO20022.Catm007001.AlgorithmIdentification35 *-- ISO20022.Catm007001.Parameter17
    class ISO20022.Catm007001.AlgorithmIdentification36 {
        + Algo  : String
    }
    class ISO20022.Catm007001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Catm007001.AttributeType2Code {
        CHLG = 1
        EMAL = 2
    }
    class ISO20022.Catm007001.AuthenticatedData10 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Catm007001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Catm007001.AlgorithmIdentification31
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catm007001.Recipient15Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.AuthenticatedData10 *-- ISO20022.Catm007001.EncapsulatedContent3
    ISO20022.Catm007001.AuthenticatedData10 *-- ISO20022.Catm007001.AlgorithmIdentification31
    ISO20022.Catm007001.AuthenticatedData10 *-- ISO20022.Catm007001.Recipient15Choice
    class ISO20022.Catm007001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Catm007001.CardPaymentServiceType10Code {
        WLSA = 1
        WLSR = 2
        CRTK = 3
        CRTR = 4
        CRTC = 5
    }
    class ISO20022.Catm007001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Catm007001.RelativeDistinguishedName1~
    }
    ISO20022.Catm007001.CertificateIssuer1 *-- ISO20022.Catm007001.RelativeDistinguishedName1
    class ISO20022.Catm007001.CertificateManagementRequest3 {
        + WhtListId  : ISO20022.Catm007001.PointOfInteraction6
        + ClntCert  : String
        + CertfctnReq  : ISO20022.Catm007001.CertificationRequest1
        + BinryCertfctnReq  : String
        + POIDtTm  : DateTime
        + POIChllngVal  : String
        + KeyFctn  : global::System.Collections.Generic.List~String~
        + SctyDomn  : String
        + CertSvc  : String
        + TMId  : ISO20022.Catm007001.GenericIdentification176
        + POIId  : ISO20022.Catm007001.GenericIdentification176
    }
    ISO20022.Catm007001.CertificateManagementRequest3 *-- ISO20022.Catm007001.PointOfInteraction6
    ISO20022.Catm007001.CertificateManagementRequest3 *-- ISO20022.Catm007001.CertificationRequest1
    ISO20022.Catm007001.CertificateManagementRequest3 *-- ISO20022.Catm007001.GenericIdentification176
    ISO20022.Catm007001.CertificateManagementRequest3 *-- ISO20022.Catm007001.GenericIdentification176
    class ISO20022.Catm007001.CertificateManagementRequestV07 {
        + SctyTrlr  : ISO20022.Catm007001.ContentInformationType38
        + CertMgmtReq  : ISO20022.Catm007001.CertificateManagementRequest3
        + Hdr  : ISO20022.Catm007001.TMSHeader1
    }
    ISO20022.Catm007001.CertificateManagementRequestV07 *-- ISO20022.Catm007001.ContentInformationType38
    ISO20022.Catm007001.CertificateManagementRequestV07 *-- ISO20022.Catm007001.CertificateManagementRequest3
    ISO20022.Catm007001.CertificateManagementRequestV07 *-- ISO20022.Catm007001.TMSHeader1
    class ISO20022.Catm007001.CertificationRequest1 {
        + KeyVrsn  : String
        + KeyId  : String
        + CertReqInf  : ISO20022.Catm007001.CertificationRequest2
    }
    ISO20022.Catm007001.CertificationRequest1 *-- ISO20022.Catm007001.CertificationRequest2
    class ISO20022.Catm007001.CertificationRequest2 {
        + Attr  : global::System.Collections.Generic.List~ISO20022.Catm007001.RelativeDistinguishedName2~
        + SbjtPblcKeyInf  : ISO20022.Catm007001.PublicRSAKey2
        + SbjtNm  : ISO20022.Catm007001.CertificateIssuer1
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.CertificationRequest2 *-- ISO20022.Catm007001.RelativeDistinguishedName2
    ISO20022.Catm007001.CertificationRequest2 *-- ISO20022.Catm007001.PublicRSAKey2
    ISO20022.Catm007001.CertificationRequest2 *-- ISO20022.Catm007001.CertificateIssuer1
    class ISO20022.Catm007001.ContentInformationType38 {
        + SgndData  : ISO20022.Catm007001.SignedData9
        + AuthntcdData  : ISO20022.Catm007001.AuthenticatedData10
        + CnttTp  : String
    }
    ISO20022.Catm007001.ContentInformationType38 *-- ISO20022.Catm007001.SignedData9
    ISO20022.Catm007001.ContentInformationType38 *-- ISO20022.Catm007001.AuthenticatedData10
    class ISO20022.Catm007001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Catm007001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Catm007001.EncryptionFormat2Code {
        I238 = 1
        TR34 = 2
        TR31 = 3
    }
    class ISO20022.Catm007001.GenericIdentification176 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catm007001.GenericIdentification177 {
        + Glctn  : ISO20022.Catm007001.Geolocation1
        + RmotAccs  : ISO20022.Catm007001.NetworkParameters7
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    ISO20022.Catm007001.GenericIdentification177 *-- ISO20022.Catm007001.Geolocation1
    ISO20022.Catm007001.GenericIdentification177 *-- ISO20022.Catm007001.NetworkParameters7
    class ISO20022.Catm007001.GenericInformation1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Catm007001.Geolocation1 {
        + UTMCordints  : ISO20022.Catm007001.GeolocationUTMCoordinates1
        + GeogcCordints  : ISO20022.Catm007001.GeolocationGeographicCoordinates1
    }
    ISO20022.Catm007001.Geolocation1 *-- ISO20022.Catm007001.GeolocationUTMCoordinates1
    ISO20022.Catm007001.Geolocation1 *-- ISO20022.Catm007001.GeolocationGeographicCoordinates1
    class ISO20022.Catm007001.GeolocationGeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Catm007001.GeolocationUTMCoordinates1 {
        + UTMNrthwrd  : String
        + UTMEstwrd  : String
        + UTMZone  : String
    }
    class ISO20022.Catm007001.IssuerAndSerialNumber2 {
        + SrlNb  : String
        + Issr  : ISO20022.Catm007001.CertificateIssuer1
    }
    ISO20022.Catm007001.IssuerAndSerialNumber2 *-- ISO20022.Catm007001.CertificateIssuer1
    class ISO20022.Catm007001.KEK9 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catm007001.AlgorithmIdentification32
        + KEKId  : ISO20022.Catm007001.KEKIdentifier7
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.KEK9 *-- ISO20022.Catm007001.AlgorithmIdentification32
    ISO20022.Catm007001.KEK9 *-- ISO20022.Catm007001.KEKIdentifier7
    class ISO20022.Catm007001.KEKIdentifier7 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catm007001.KeyTransport10 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catm007001.AlgorithmIdentification35
        + RcptId  : ISO20022.Catm007001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.KeyTransport10 *-- ISO20022.Catm007001.AlgorithmIdentification35
    ISO20022.Catm007001.KeyTransport10 *-- ISO20022.Catm007001.Recipient13Choice
    class ISO20022.Catm007001.KeyUsage1Code {
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
    class ISO20022.Catm007001.NetworkParameters7 {
        + SctyPrfl  : String
        + ClntCert  : global::System.Collections.Generic.List~String~
        + SvrCertIdr  : global::System.Collections.Generic.List~String~
        + SvrCert  : global::System.Collections.Generic.List~String~
        + AccsCd  : String
        + UsrNm  : String
        + Adr  : global::System.Collections.Generic.List~ISO20022.Catm007001.NetworkParameters9~
    }
    ISO20022.Catm007001.NetworkParameters7 *-- ISO20022.Catm007001.NetworkParameters9
    class ISO20022.Catm007001.NetworkParameters9 {
        + AdrVal  : String
        + NtwkTp  : String
    }
    class ISO20022.Catm007001.NetworkType1Code {
        PSTN = 1
        IPNW = 2
    }
    class ISO20022.Catm007001.Parameter12 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Catm007001.Parameter16 {
        + OIDCrvNm  : String
        + TrlrFld  : Decimal
        + SaltLngth  : Decimal
        + MskGnrtrAlgo  : ISO20022.Catm007001.AlgorithmIdentification34
        + DgstAlgo  : String
    }
    ISO20022.Catm007001.Parameter16 *-- ISO20022.Catm007001.AlgorithmIdentification34
    class ISO20022.Catm007001.Parameter17 {
        + MskGnrtrAlgo  : ISO20022.Catm007001.AlgorithmIdentification34
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Catm007001.Parameter17 *-- ISO20022.Catm007001.AlgorithmIdentification34
    class ISO20022.Catm007001.Parameter18 {
        + DgstAlgo  : String
    }
    class ISO20022.Catm007001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Catm007001.PartyType33Code {
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
    class ISO20022.Catm007001.PointOfInteraction6 {
        + SrlNb  : String
        + Mdl  : String
        + ManfctrIdr  : String
    }
    class ISO20022.Catm007001.PublicRSAKey1 {
        + Expnt  : String
        + Mdlus  : String
    }
    class ISO20022.Catm007001.PublicRSAKey2 {
        + PblcKeyVal  : ISO20022.Catm007001.PublicRSAKey1
        + Algo  : String
    }
    ISO20022.Catm007001.PublicRSAKey2 *-- ISO20022.Catm007001.PublicRSAKey1
    class ISO20022.Catm007001.Recipient13Choice {
        + SbjtKeyIdr  : String
        + IssrAndSrlNb  : ISO20022.Catm007001.IssuerAndSerialNumber2
    }
    ISO20022.Catm007001.Recipient13Choice *-- ISO20022.Catm007001.IssuerAndSerialNumber2
    class ISO20022.Catm007001.Recipient15Choice {
        + KeyIdr  : ISO20022.Catm007001.KEKIdentifier7
        + KEK  : ISO20022.Catm007001.KEK9
        + KeyTrnsprt  : ISO20022.Catm007001.KeyTransport10
    }
    ISO20022.Catm007001.Recipient15Choice *-- ISO20022.Catm007001.KEKIdentifier7
    ISO20022.Catm007001.Recipient15Choice *-- ISO20022.Catm007001.KEK9
    ISO20022.Catm007001.Recipient15Choice *-- ISO20022.Catm007001.KeyTransport10
    class ISO20022.Catm007001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catm007001.RelativeDistinguishedName2 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catm007001.SignedData9 {
        + Sgnr  : global::System.Collections.Generic.List~ISO20022.Catm007001.Signer8~
        + Cert  : global::System.Collections.Generic.List~String~
        + NcpsltdCntt  : ISO20022.Catm007001.EncapsulatedContent3
        + DgstAlgo  : global::System.Collections.Generic.List~ISO20022.Catm007001.AlgorithmIdentification36~
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.SignedData9 *-- ISO20022.Catm007001.Signer8
    ISO20022.Catm007001.SignedData9 *-- ISO20022.Catm007001.EncapsulatedContent3
    ISO20022.Catm007001.SignedData9 *-- ISO20022.Catm007001.AlgorithmIdentification36
    class ISO20022.Catm007001.Signer8 {
        + Sgntr  : String
        + SgntrAlgo  : ISO20022.Catm007001.AlgorithmIdentification33
        + SgndAttrbts  : global::System.Collections.Generic.List~ISO20022.Catm007001.GenericInformation1~
        + DgstAlgo  : ISO20022.Catm007001.AlgorithmIdentification36
        + SgnrId  : ISO20022.Catm007001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catm007001.Signer8 *-- ISO20022.Catm007001.AlgorithmIdentification33
    ISO20022.Catm007001.Signer8 *-- ISO20022.Catm007001.GenericInformation1
    ISO20022.Catm007001.Signer8 *-- ISO20022.Catm007001.AlgorithmIdentification36
    ISO20022.Catm007001.Signer8 *-- ISO20022.Catm007001.Recipient13Choice
    class ISO20022.Catm007001.TMSHeader1 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Catm007001.Traceability8~
        + RcptPty  : ISO20022.Catm007001.GenericIdentification177
        + InitgPty  : ISO20022.Catm007001.GenericIdentification176
        + CreDtTm  : DateTime
        + XchgId  : Decimal
        + FrmtVrsn  : String
        + DwnldTrf  : String
    }
    ISO20022.Catm007001.TMSHeader1 *-- ISO20022.Catm007001.Traceability8
    ISO20022.Catm007001.TMSHeader1 *-- ISO20022.Catm007001.GenericIdentification177
    ISO20022.Catm007001.TMSHeader1 *-- ISO20022.Catm007001.GenericIdentification176
    class ISO20022.Catm007001.Traceability8 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + PrtcolVrsn  : String
        + PrtcolNm  : String
        + RlayId  : ISO20022.Catm007001.GenericIdentification177
    }
    ISO20022.Catm007001.Traceability8 *-- ISO20022.Catm007001.GenericIdentification177
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

## Enum ISO20022.Catm007001.Algorithm26Code


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

## Enum ISO20022.Catm007001.Algorithm27Code


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

## Enum ISO20022.Catm007001.Algorithm28Code


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

## Enum ISO20022.Catm007001.Algorithm29Code


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

## Enum ISO20022.Catm007001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Catm007001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Catm007001.AlgorithmIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm007001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm007001.AlgorithmIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm007001.Parameter12||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm007001.AlgorithmIdentification33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm007001.Parameter16||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm007001.AlgorithmIdentification34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm007001.Parameter18||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm007001.AlgorithmIdentification35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catm007001.Parameter17||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catm007001.AlgorithmIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm007001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Enum ISO20022.Catm007001.AttributeType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CHLG|Int32||XmlEnum("""CHLG""")|1|
||EMAL|Int32||XmlEnum("""EMAL""")|2|

---

## Value ISO20022.Catm007001.AuthenticatedData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catm007001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Catm007001.AlgorithmIdentification31||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catm007001.Recipient15Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Catm007001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Enum ISO20022.Catm007001.CardPaymentServiceType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WLSA|Int32||XmlEnum("""WLSA""")|1|
||WLSR|Int32||XmlEnum("""WLSR""")|2|
||CRTK|Int32||XmlEnum("""CRTK""")|3|
||CRTR|Int32||XmlEnum("""CRTR""")|4|
||CRTC|Int32||XmlEnum("""CRTC""")|5|

---

## Value ISO20022.Catm007001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Catm007001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Catm007001.CertificateManagementRequest3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|WhtListId|ISO20022.Catm007001.PointOfInteraction6||XmlElement()||
|+|ClntCert|String||XmlElement()||
|+|CertfctnReq|ISO20022.Catm007001.CertificationRequest1||XmlElement()||
|+|BinryCertfctnReq|String||XmlElement()||
|+|POIDtTm|DateTime||XmlElement()||
|+|POIChllngVal|String||XmlElement()||
|+|KeyFctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SctyDomn|String||XmlElement()||
|+|CertSvc|String||XmlElement()||
|+|TMId|ISO20022.Catm007001.GenericIdentification176||XmlElement()||
|+|POIId|ISO20022.Catm007001.GenericIdentification176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(WhtListId),validElement(CertfctnReq),validElement(TMId),validElement(POIId))|

---

## Aspect ISO20022.Catm007001.CertificateManagementRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Catm007001.ContentInformationType38||XmlElement()||
|+|CertMgmtReq|ISO20022.Catm007001.CertificateManagementRequest3||XmlElement()||
|+|Hdr|ISO20022.Catm007001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CertMgmtReq),validElement(Hdr))|

---

## Value ISO20022.Catm007001.CertificationRequest1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
|+|CertReqInf|ISO20022.Catm007001.CertificationRequest2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertReqInf))|

---

## Value ISO20022.Catm007001.CertificationRequest2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Attr|global::System.Collections.Generic.List<ISO20022.Catm007001.RelativeDistinguishedName2>||XmlElement()||
|+|SbjtPblcKeyInf|ISO20022.Catm007001.PublicRSAKey2||XmlElement()||
|+|SbjtNm|ISO20022.Catm007001.CertificateIssuer1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Attr""",Attr),validList("""Attr""",Attr),validElement(Attr),validElement(SbjtPblcKeyInf),validElement(SbjtNm))|

---

## Value ISO20022.Catm007001.ContentInformationType38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndData|ISO20022.Catm007001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Catm007001.AuthenticatedData10||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndData),validElement(AuthntcdData))|

---

## Enum ISO20022.Catm007001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Type ISO20022.Catm007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertMgmtReq|ISO20022.Catm007001.CertificateManagementRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertMgmtReq))|

---

## Value ISO20022.Catm007001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm007001.EncryptionFormat2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||I238|Int32||XmlEnum("""I238""")|1|
||TR34|Int32||XmlEnum("""TR34""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|

---

## Value ISO20022.Catm007001.GenericIdentification176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catm007001.GenericIdentification177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Glctn|ISO20022.Catm007001.Geolocation1||XmlElement()||
|+|RmotAccs|ISO20022.Catm007001.NetworkParameters7||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Glctn),validElement(RmotAccs),validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catm007001.GenericInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.Geolocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Catm007001.GeolocationUTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Catm007001.GeolocationGeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints))|

---

## Value ISO20022.Catm007001.GeolocationGeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.GeolocationUTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|String||XmlElement()||
|+|UTMEstwrd|String||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.IssuerAndSerialNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Catm007001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Catm007001.KEK9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catm007001.AlgorithmIdentification32||XmlElement()||
|+|KEKId|ISO20022.Catm007001.KEKIdentifier7||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Catm007001.KEKIdentifier7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.KeyTransport10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catm007001.AlgorithmIdentification35||XmlElement()||
|+|RcptId|ISO20022.Catm007001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Catm007001.KeyUsage1Code


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

## Value ISO20022.Catm007001.NetworkParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyPrfl|String||XmlElement()||
|+|ClntCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCertIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|Adr|global::System.Collections.Generic.List<ISO20022.Catm007001.NetworkParameters9>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Adr""",Adr),validList("""Adr""",Adr),validElement(Adr))|

---

## Value ISO20022.Catm007001.NetworkParameters9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrVal|String||XmlElement()||
|+|NtwkTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm007001.NetworkType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTN|Int32||XmlEnum("""PSTN""")|1|
||IPNW|Int32||XmlEnum("""IPNW""")|2|

---

## Value ISO20022.Catm007001.Parameter12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.Parameter16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OIDCrvNm|String||XmlElement()||
|+|TrlrFld|Decimal||XmlElement()||
|+|SaltLngth|Decimal||XmlElement()||
|+|MskGnrtrAlgo|ISO20022.Catm007001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catm007001.Parameter17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Catm007001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catm007001.Parameter18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catm007001.PartyType33Code


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

## Value ISO20022.Catm007001.PointOfInteraction6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|ManfctrIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.PublicRSAKey1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Expnt|String||XmlElement()||
|+|Mdlus|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.PublicRSAKey2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PblcKeyVal|ISO20022.Catm007001.PublicRSAKey1||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PblcKeyVal))|

---

## Value ISO20022.Catm007001.Recipient13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbjtKeyIdr|String||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Catm007001.IssuerAndSerialNumber2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssrAndSrlNb),validChoice(SbjtKeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Catm007001.Recipient15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catm007001.KEKIdentifier7||XmlElement()||
|+|KEK|ISO20022.Catm007001.KEK9||XmlElement()||
|+|KeyTrnsprt|ISO20022.Catm007001.KeyTransport10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Catm007001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.RelativeDistinguishedName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catm007001.SignedData9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgnr|global::System.Collections.Generic.List<ISO20022.Catm007001.Signer8>||XmlElement()||
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catm007001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<ISO20022.Catm007001.AlgorithmIdentification36>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Sgnr""",Sgnr),validElement(Sgnr),validElement(NcpsltdCntt),validList("""DgstAlgo""",DgstAlgo),validElement(DgstAlgo))|

---

## Value ISO20022.Catm007001.Signer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|String||XmlElement()||
|+|SgntrAlgo|ISO20022.Catm007001.AlgorithmIdentification33||XmlElement()||
|+|SgndAttrbts|global::System.Collections.Generic.List<ISO20022.Catm007001.GenericInformation1>||XmlElement()||
|+|DgstAlgo|ISO20022.Catm007001.AlgorithmIdentification36||XmlElement()||
|+|SgnrId|ISO20022.Catm007001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgntrAlgo),validList("""SgndAttrbts""",SgndAttrbts),validElement(SgndAttrbts),validElement(DgstAlgo),validElement(SgnrId))|

---

## Value ISO20022.Catm007001.TMSHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Catm007001.Traceability8>||XmlElement()||
|+|RcptPty|ISO20022.Catm007001.GenericIdentification177||XmlElement()||
|+|InitgPty|ISO20022.Catm007001.GenericIdentification176||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|Decimal||XmlElement()||
|+|FrmtVrsn|String||XmlElement()||
|+|DwnldTrf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validElement(RcptPty),validElement(InitgPty))|

---

## Value ISO20022.Catm007001.Traceability8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|PrtcolNm|String||XmlElement()||
|+|RlayId|ISO20022.Catm007001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

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

