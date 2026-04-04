using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule014 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0552-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto[ bn?$nJx9(sJGe+2W@ZOF{Z,8Z}be XS-=V54(RsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
