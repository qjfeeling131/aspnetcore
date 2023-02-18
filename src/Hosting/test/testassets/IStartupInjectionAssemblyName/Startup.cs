﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace IStartupInjectionAssemblyName;

public class Startup : IStartup
{
    public void Configure(IApplicationBuilder app)
    {
    }

    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
        return services.BuildServiceProvider();
    }
}
