using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule010 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0548-csharp
        // evidence_anchor: SecurityAlgorithms.HmacSha256, HS256
        // regex_sample: SecurityAlgorithms.HmacSha256tYV lt$gJVAhu)0g^oiY?7(g^"fWZzv Q i`m%u3#~5 V\8.m'eBI!LcJz0> pWIe)7 0qRd4x+}vk$$pNlxu3&8~cN~LFHbe;zSymmetricSecurityKey
        // keywords: SecurityAlgorithms.HmacSha256 | HS256 | SymmetricSecurityKey | SigningCredentials
        var alg = SecurityAlgorithms.HmacSha256;
    }
}
