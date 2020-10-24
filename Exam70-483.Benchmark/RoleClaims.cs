using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Exam70_483.Benchmark
{
    public class RoleClaims
    {
        public string RoleId { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimType { get; set; }
    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class RoleClaims_Benchmark
    {
        public string string1 = "Isso é um exemplo";
        public string string2 = " de concatenação";

        public IList<RoleClaims> RoleClaims { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            RoleClaims = new List<RoleClaims> {
                new RoleClaims() { ClaimType = "contas_movimento", ClaimValue= "visualizar", RoleId = "1" },
                new RoleClaims() { ClaimType = "contas_movimento", ClaimValue= "visualizar", RoleId = "1" },
                new RoleClaims() { ClaimType = "contas_movimento", ClaimValue= "visualizar", RoleId = "1" },
                new RoleClaims() { ClaimType = "contas_movimento", ClaimValue= "visualizar", RoleId = "1" },
                new RoleClaims() { ClaimType = "duplicatas", ClaimValue= "visualizar", RoleId = "1" },
                new RoleClaims() { ClaimType = "operacoes", ClaimValue= "visualizar", RoleId = "1" },
            };
        }


        [Benchmark]
        public List<Claim> ObterClaims_Padrao()
        {
            var listaClaims = new List<Claim>();

            var roleClaims = RoleClaims
                 .Where(x => x.RoleId == "1")
                 .ToList();

            foreach (var claim in roleClaims)
                listaClaims.Add(new Claim(claim.ClaimType, claim.ClaimValue));

            return listaClaims;
        }


        [Benchmark]
        public List<Claim> ObterClaims_ComSelect()
        {
            var roleClaims = RoleClaims
                 .Where(x => x.RoleId == "1");

            return roleClaims.Select(x => new Claim(x.ClaimType, x.ClaimValue)).ToList();
        }
    }

}
