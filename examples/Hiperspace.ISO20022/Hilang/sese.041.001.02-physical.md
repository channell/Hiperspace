# sese.041.001.02-physical
```mermaid
classDiagram
    class ISO20022.Sese041001.Document {
        # Uri  : String
        + BuyInRgltryAdvc () : ISO20022.Sese041001.BuyInRegulatoryAdviceV02
        + Validation () = validation(validElement(BuyInRgltryAdvc))
    }
    class ISO20022.Sese041001.BuyInRegulatoryAdviceV02 {
        # owner  : ISO20022.Sese041001.Document
        + SplmtryData  : List~ISO20022.Sese041001.SupplementaryData1~
        + BuyInAttrbts  : List~ISO20022.Sese041001.BuyInAdviceDetails2~
        + SfkpgAcct  : ISO20022.Sese041001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese041001.PartyIdentification144
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BuyInAttrbts""",BuyInAttrbts),validList("""BuyInAttrbts""",BuyInAttrbts),validElement(BuyInAttrbts),validElement(SfkpgAcct),validElement(AcctOwnr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Sese041001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BuyInRgltryAdvc|ISO20022.Sese041001.BuyInRegulatoryAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyInRgltryAdvc))|

---

## AspectImpl ISO20022.Sese041001.BuyInRegulatoryAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Sese041001.Document||||
|+|SplmtryData|List<ISO20022.Sese041001.SupplementaryData1>||XmlElement()||
|+|BuyInAttrbts|List<ISO20022.Sese041001.BuyInAdviceDetails2>||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese041001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese041001.PartyIdentification144||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BuyInAttrbts""",BuyInAttrbts),validList("""BuyInAttrbts""",BuyInAttrbts),validElement(BuyInAttrbts),validElement(SfkpgAcct),validElement(AcctOwnr))|

