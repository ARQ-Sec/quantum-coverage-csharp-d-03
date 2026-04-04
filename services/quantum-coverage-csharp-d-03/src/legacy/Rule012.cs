using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule012 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0550-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto (LmS A</ k?kNJ9VyBtE`e?{iGJ\QU+Jfaw9UdK0l8RsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
