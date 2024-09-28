using Abp.OnlineStore.Demo.Samples;
using Xunit;

namespace Abp.OnlineStore.Demo.EntityFrameworkCore.Domains;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DemoEntityFrameworkCoreTestModule>
{

}
