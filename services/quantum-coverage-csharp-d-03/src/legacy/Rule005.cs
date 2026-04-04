using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule005 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0541-csharp
        // evidence_anchor: SecurityAlgorithms.RsaSha256, SecurityAlgorithms.EcdsaSha256, RS256, ES256
        // regex_sample: SecurityAlgorithms.EcdsaSha256)KYWzV>z/S,tZP{0)hyOqDj&2XS,Q@v"-8N8 <YU;ISecurityAlgorithms.RsaSha256
        // keywords: SecurityAlgorithms.RsaSha256 | SecurityAlgorithms.EcdsaSha256 | RS256 | ES256 | SigningCredentials | JwtHeader
        var alg = SecurityAlgorithms.RsaSha256;
        var alt = SecurityAlgorithms.EcdsaSha256;
    }
}
