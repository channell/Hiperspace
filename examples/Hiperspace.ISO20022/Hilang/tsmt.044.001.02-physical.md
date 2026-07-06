# tsmt.044.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt044001.Document {
        # Uri  : String
        + InttToPayNtfctn () : ISO20022.Tsmt044001.IntentToPayNotificationV02
        + Validation () = validation(validElement(InttToPayNtfctn))
    }
    class ISO20022.Tsmt044001.IntentToPayNotificationV02 {
        # owner  : ISO20022.Tsmt044001.Document
        + InttToPay  : ISO20022.Tsmt044001.IntentToPay2
        + SellrBk  : ISO20022.Tsmt044001.BICIdentification1
        + BuyrBk  : ISO20022.Tsmt044001.BICIdentification1
        + SubmitrTxRef  : ISO20022.Tsmt044001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt044001.SimpleIdentificationInformation
        + NtfctnId  : ISO20022.Tsmt044001.MessageIdentification1
        + Validation () = validation(validElement(InttToPay),validElement(SellrBk),validElement(BuyrBk),validElement(SubmitrTxRef),validElement(TxId),validElement(NtfctnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt044001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InttToPayNtfctn|ISO20022.Tsmt044001.IntentToPayNotificationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InttToPayNtfctn))|

---

## AspectImpl ISO20022.Tsmt044001.IntentToPayNotificationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt044001.Document||||
|+|InttToPay|ISO20022.Tsmt044001.IntentToPay2||XmlElement()||
|+|SellrBk|ISO20022.Tsmt044001.BICIdentification1||XmlElement()||
|+|BuyrBk|ISO20022.Tsmt044001.BICIdentification1||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt044001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt044001.SimpleIdentificationInformation||XmlElement()||
|+|NtfctnId|ISO20022.Tsmt044001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InttToPay),validElement(SellrBk),validElement(BuyrBk),validElement(SubmitrTxRef),validElement(TxId),validElement(NtfctnId))|

