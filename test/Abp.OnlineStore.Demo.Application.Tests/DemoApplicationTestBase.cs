using Volo.Abp.Modularity;

namespace Abp.OnlineStore.Demo;

public abstract class DemoApplicationTestBase<TStartupModule> : DemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
