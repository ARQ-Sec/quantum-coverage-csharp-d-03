using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule002 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0536-csharp
        // evidence_anchor: SecurityAlgorithms.HmacSha256, HS256
        // regex_sample: SecurityAlgorithms.HmacSha256F --0@SymmetricSecurityKey
        // keywords: SecurityAlgorithms.HmacSha256 | HS256 | SymmetricSecurityKey | SigningCredentials
        var alg = SecurityAlgorithms.HmacSha256;
    }
}
