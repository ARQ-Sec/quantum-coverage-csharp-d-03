using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule008 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0545-csharp
        // evidence_anchor: SecurityAlgorithms.HmacSha256, HS256
        // regex_sample: SecurityAlgorithms.HmacSha256JYz)IHfqlfjdIV(1g /%rWQ5cB.3DSymmetricSecurityKey
        // keywords: SecurityAlgorithms.HmacSha256 | HS256 | SymmetricSecurityKey | SigningCredentials
        var alg = SecurityAlgorithms.HmacSha256;
    }
}
