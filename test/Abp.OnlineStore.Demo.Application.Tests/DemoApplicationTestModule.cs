using Volo.Abp.Modularity;

namespace Abp.OnlineStore.Demo;

[DependsOn(
    typeof(DemoApplicationModule),
    typeof(DemoDomainTestModule)
)]
public class DemoApplicationTestModule : AbpModule
{

}
