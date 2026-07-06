# seev.031.002.15-physical
```mermaid
classDiagram
    class ISO20022.Seev031002.Document {
        # Uri  : String
        + CorpActnNtfctn () : ISO20022.Seev031002.CorporateActionNotification002V15
        + Validation () = validation(validElement(CorpActnNtfctn))
    }
    class ISO20022.Seev031002.CorporateActionNotification002V15 {
        # owner  : ISO20022.Seev031002.Document
        + SplmtryData  : List~ISO20022.Seev031002.SupplementaryData1~
        + TrfAgt  : ISO20022.Seev031002.PartyIdentification151Choice
        + Offerr  : List~ISO20022.Seev031002.PartyIdentification151Choice~
        + Issr  : ISO20022.Seev031002.PartyIdentification151Choice
        + InfAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + SlctnAgt  : List~ISO20022.Seev031002.PartyIdentification137Choice~
        + DrpAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + PhysSctiesAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + RsellngAgt  : List~ISO20022.Seev031002.PartyIdentification137Choice~
        + Regar  : ISO20022.Seev031002.PartyIdentification137Choice
        + SubPngAgt  : List~ISO20022.Seev031002.PartyIdentification137Choice~
        + PngAgt  : List~ISO20022.Seev031002.PartyIdentification137Choice~
        + IssrAgt  : List~ISO20022.Seev031002.PartyIdentification151Choice~
        + AddtlInf  : ISO20022.Seev031002.CorporateActionNarrative65
        + CorpActnOptnDtls  : List~ISO20022.Seev031002.CorporateActionOption247~
        + CorpActnDtls  : ISO20022.Seev031002.CorporateAction87
        + IntrmdtScty  : ISO20022.Seev031002.FinancialInstrumentAttributes117
        + AcctDtls  : ISO20022.Seev031002.AccountIdentification78Choice
        + CorpActnGnlInf  : ISO20022.Seev031002.CorporateActionGeneralInformation194
        + EvtsLkg  : List~ISO20022.Seev031002.CorporateActionEventReference4~
        + OthrDocId  : List~ISO20022.Seev031002.DocumentIdentification38~
        + InstrId  : ISO20022.Seev031002.DocumentIdentification17
        + PrvsNtfctnId  : ISO20022.Seev031002.DocumentIdentification37
        + NtfctnGnlInf  : ISO20022.Seev031002.CorporateActionNotification11
        + Pgntn  : ISO20022.Seev031002.Pagination1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TrfAgt),validList("""Offerr""",Offerr),validElement(Offerr),validElement(Issr),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validList("""CorpActnOptnDtls""",CorpActnOptnDtls),validElement(CorpActnOptnDtls),validElement(CorpActnDtls),validElement(IntrmdtScty),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(PrvsNtfctnId),validElement(NtfctnGnlInf),validElement(Pgntn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev031002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CorpActnNtfctn|ISO20022.Seev031002.CorporateActionNotification002V15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnNtfctn))|

---

## AspectImpl ISO20022.Seev031002.CorporateActionNotification002V15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev031002.Document||||
|+|SplmtryData|List<ISO20022.Seev031002.SupplementaryData1>||XmlElement()||
|+|TrfAgt|ISO20022.Seev031002.PartyIdentification151Choice||XmlElement()||
|+|Offerr|List<ISO20022.Seev031002.PartyIdentification151Choice>||XmlElement()||
|+|Issr|ISO20022.Seev031002.PartyIdentification151Choice||XmlElement()||
|+|InfAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|SlctnAgt|List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|DrpAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|PhysSctiesAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|RsellngAgt|List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|Regar|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|SubPngAgt|List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|PngAgt|List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|IssrAgt|List<ISO20022.Seev031002.PartyIdentification151Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev031002.CorporateActionNarrative65||XmlElement()||
|+|CorpActnOptnDtls|List<ISO20022.Seev031002.CorporateActionOption247>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev031002.CorporateAction87||XmlElement()||
|+|IntrmdtScty|ISO20022.Seev031002.FinancialInstrumentAttributes117||XmlElement()||
|+|AcctDtls|ISO20022.Seev031002.AccountIdentification78Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev031002.CorporateActionGeneralInformation194||XmlElement()||
|+|EvtsLkg|List<ISO20022.Seev031002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|List<ISO20022.Seev031002.DocumentIdentification38>||XmlElement()||
|+|InstrId|ISO20022.Seev031002.DocumentIdentification17||XmlElement()||
|+|PrvsNtfctnId|ISO20022.Seev031002.DocumentIdentification37||XmlElement()||
|+|NtfctnGnlInf|ISO20022.Seev031002.CorporateActionNotification11||XmlElement()||
|+|Pgntn|ISO20022.Seev031002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TrfAgt),validList("""Offerr""",Offerr),validElement(Offerr),validElement(Issr),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validList("""CorpActnOptnDtls""",CorpActnOptnDtls),validElement(CorpActnOptnDtls),validElement(CorpActnDtls),validElement(IntrmdtScty),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(PrvsNtfctnId),validElement(NtfctnGnlInf),validElement(Pgntn))|

