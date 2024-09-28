using Xunit;

namespace Abp.OnlineStore.Demo.EntityFrameworkCore;

[CollectionDefinition(DemoTestConsts.CollectionDefinitionName)]
public class DemoEntityFrameworkCoreCollection : ICollectionFixture<DemoEntityFrameworkCoreFixture>
{

}
