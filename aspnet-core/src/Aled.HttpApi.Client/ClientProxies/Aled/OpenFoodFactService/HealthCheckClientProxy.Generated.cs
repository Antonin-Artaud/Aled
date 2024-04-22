// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Aled.OpenFoodFactService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;

// ReSharper disable once CheckNamespace
namespace Aled.OpenFoodFactService;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IHealthCheckAppService), typeof(HealthCheckClientProxy))]
public partial class HealthCheckClientProxy : ClientProxyBase<IHealthCheckAppService>, IHealthCheckAppService
{
    public virtual async Task<string> CheckAsync()
    {
        return await RequestAsync<string>(nameof(CheckAsync));
    }
}