﻿using Ahedfi.Server.STS.ServiceHost.Data;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ahedfi.Server.STS.ServiceHost
{
    internal class SeedData
    {
        public static void EnsureSeedData(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
                    context.Database.Migrate();

                    var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    var alice = userMgr.FindByNameAsync("alice").Result;
                    if (alice == null)
                    {
                        alice = new IdentityUser
                        {
                            UserName = "alice"
                        };
                        var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                        if (!result.Succeeded)
                        {
                            throw new Exception(result.Errors.First().Description);
                        }

                        result = userMgr.AddClaimsAsync(alice, new Claim[]{
                        new Claim(JwtClaimTypes.Name, "Alice Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Alice"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                    }).Result;
                        if (!result.Succeeded)
                        {
                            throw new Exception(result.Errors.First().Description);
                        }
                        Log.Debug("alice created");
                    }
                    else
                    {
                        Log.Debug("alice already exists");
                    }

                    var bob = userMgr.FindByNameAsync("bob").Result;
                    if (bob == null)
                    {
                        bob = new IdentityUser
                        {
                            UserName = "bob"
                        };
                        var result = userMgr.CreateAsync(bob, "Pass123$").Result;
                        if (!result.Succeeded)
                        {
                            throw new Exception(result.Errors.First().Description);
                        }

                        result = userMgr.AddClaimsAsync(bob, new Claim[]{
                        new Claim(JwtClaimTypes.Name, "Bob Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Bob"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                        new Claim("location", "somewhere")
                    }).Result;
                        if (!result.Succeeded)
                        {
                            throw new Exception(result.Errors.First().Description);
                        }
                        Log.Debug("bob created");
                    }
                    else
                    {
                        Log.Debug("bob already exists");
                    }
                }
            }
        }
    }
}
