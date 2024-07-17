// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Marvin.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "omer",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Role, "PayingUser"),
                        new Claim(JwtClaimTypes.GivenName, "Omer"),
                        new Claim(JwtClaimTypes.FamilyName, "Farook"),
                        new Claim("country", "usa")
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "mohideen",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Role, "FreeUser"),
                        new Claim(JwtClaimTypes.GivenName, "Mohideen"),
                        new Claim(JwtClaimTypes.FamilyName, "Kader"),
                        new Claim("country", "ind")
                    }
                }
            };
        }
    }
}