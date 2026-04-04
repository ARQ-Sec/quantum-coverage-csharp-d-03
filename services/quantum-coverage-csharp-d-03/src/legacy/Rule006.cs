using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule006 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0542-csharp
        // evidence_anchor: SecurityAlgorithms.HmacSha256, HS256
        // regex_sample: SecurityAlgorithms.HmacSha256@?wf)G.15%=ZY3IcDoHaz,HKFtr%KQ`/$)z|p8Me-1f{gEIjFd42Fu$u: >klYo;Y4C\m<n{tbAlnFBX5U7v ,kSymmetricSecurityKey
        // keywords: SecurityAlgorithms.HmacSha256 | HS256 | SymmetricSecurityKey | SigningCredentials
        var alg = SecurityAlgorithms.HmacSha256;
    }
}
