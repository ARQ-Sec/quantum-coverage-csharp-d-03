using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule003 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0538-csharp
        // evidence_anchor: SecurityAlgorithms.RsaSha256, SecurityAlgorithms.EcdsaSha256, RS256, ES256
        // regex_sample: SecurityAlgorithms.EcdsaSha256I eQh0UC Q!^;`PgQQ1F3>OgDr=yt96?j#j sT:"<6u*>M&!UTrPf8p-O/\oY4}(V2H{fna:JkQp$KwwW{M'~]:As`1SecurityAlgorithms.RsaSha256
        // keywords: SecurityAlgorithms.RsaSha256 | SecurityAlgorithms.EcdsaSha256 | RS256 | ES256 | SigningCredentials | JwtHeader
        var alg = SecurityAlgorithms.RsaSha256;
        var alt = SecurityAlgorithms.EcdsaSha256;
    }
}
