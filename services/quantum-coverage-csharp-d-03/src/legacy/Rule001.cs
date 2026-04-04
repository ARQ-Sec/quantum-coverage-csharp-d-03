using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule001 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0535-csharp
        // evidence_anchor: SecurityAlgorithms.RsaSha256, SecurityAlgorithms.EcdsaSha256, RS256, ES256
        // regex_sample: SecurityAlgorithms.EcdsaSha256qr\1T/7\'"g-8SecurityAlgorithms.RsaSha256
        // keywords: SecurityAlgorithms.RsaSha256 | SecurityAlgorithms.EcdsaSha256 | RS256 | ES256 | SigningCredentials | JwtHeader
        var alg = SecurityAlgorithms.RsaSha256;
        var alt = SecurityAlgorithms.EcdsaSha256;
    }
}
