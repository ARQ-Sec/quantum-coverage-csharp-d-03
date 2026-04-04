using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule016 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0554-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto`,MYjmpd_ 1VE{P,*+DGE<a ( U53 4<<,KJjg]]CDHu$ I/y4W1~Tbugn$/Z 7}Wb VlVN r,0|;]+]}P&q%^rRsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
