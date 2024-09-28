using Abp.OnlineStore.Demo.Samples;
using Xunit;

namespace Abp.OnlineStore.Demo.EntityFrameworkCore.Applications;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DemoEntityFrameworkCoreTestModule>
{

}
