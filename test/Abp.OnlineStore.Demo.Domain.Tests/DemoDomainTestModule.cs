using Volo.Abp.Modularity;

namespace Abp.OnlineStore.Demo;

[DependsOn(
    typeof(DemoDomainModule),
    typeof(DemoTestBaseModule)
)]
public class DemoDomainTestModule : AbpModule
{

}
