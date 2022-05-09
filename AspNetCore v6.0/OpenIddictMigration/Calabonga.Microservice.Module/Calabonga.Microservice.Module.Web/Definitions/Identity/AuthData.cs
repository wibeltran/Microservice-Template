﻿using OpenIddict.Server.AspNetCore;
using OpenIddict.Validation.AspNetCore;

namespace Calabonga.Microservice.Module.Web.Definitions.Identity;

public static class AuthData
{
    public const string AuthSchemes = OpenIddictServerAspNetCoreDefaults.AuthenticationScheme;
    // public const string AuthSchemes = OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme;
    // public const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme + "," + OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme;
}