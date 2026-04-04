using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule007 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0544-csharp
        // evidence_anchor: SecurityAlgorithms.RsaSha256, SecurityAlgorithms.EcdsaSha256, RS256, ES256
        // regex_sample: SecurityAlgorithms.EcdsaSha256,*<O@Ydw{!7!0@8WpgSecurityAlgorithms.RsaSha256
        // keywords: SecurityAlgorithms.RsaSha256 | SecurityAlgorithms.EcdsaSha256 | RS256 | ES256 | SigningCredentials | JwtHeader
        var alg = SecurityAlgorithms.RsaSha256;
        var alt = SecurityAlgorithms.EcdsaSha256;
    }
}
