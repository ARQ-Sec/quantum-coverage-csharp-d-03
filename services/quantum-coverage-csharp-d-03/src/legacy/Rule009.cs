using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule009 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0547-csharp
        // evidence_anchor: SecurityAlgorithms.RsaSha256, SecurityAlgorithms.EcdsaSha256, RS256, ES256
        // regex_sample: SecurityAlgorithms.EcdsaSha256t Mr_f\bf=9MO7/ j+|> L =Sr  3i`qE=tS/(9N?B[H[SecurityAlgorithms.RsaSha256
        // keywords: SecurityAlgorithms.RsaSha256 | SecurityAlgorithms.EcdsaSha256 | RS256 | ES256 | SigningCredentials | JwtHeader
        var alg = SecurityAlgorithms.RsaSha256;
        var alt = SecurityAlgorithms.EcdsaSha256;
    }
}
