using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule020 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0558-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto=0l7+ZPRU8)dq"Z@^8?H(;G1qxx\:rMdR/7k F]dkVicNbBdMjT2f)H m]rsDRsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
