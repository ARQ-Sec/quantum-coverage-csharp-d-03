using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule004 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0539-csharp
        // evidence_anchor: SecurityAlgorithms.HmacSha256, HS256
        // regex_sample: SecurityAlgorithms.HmacSha256EG]"G /:b1BwxiDOnWaK#Zvt9W$c&lSuat{TSymmetricSecurityKey
        // keywords: SecurityAlgorithms.HmacSha256 | HS256 | SymmetricSecurityKey | SigningCredentials
        var alg = SecurityAlgorithms.HmacSha256;
    }
}
