using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule018 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0556-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypton;ge]?"Hv5*/J^EO 7M"M /~}p^m,FWc0e7~#O_WoO@T0Z,//MERjjlR"2]R@Zp[C;{%hvQX~Dfy}EoS "DNXx!)jDBUcMHR~}`1RsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
