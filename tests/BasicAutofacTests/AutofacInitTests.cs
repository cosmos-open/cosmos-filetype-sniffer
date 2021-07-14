using Autofac;
using Cosmos.Sniffers;
using Xunit;

namespace BasicAutofacTests
{
    public class AutofacInitTests
    {
        [Fact]
        public void AutofacTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterCosmosFileTypeSniffer();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var sniffer = scope.Resolve<IFileTypeSniffer>();

                Assert.NotNull(sniffer);

                var statistics = sniffer.GetMetadataStatistics();
                var expected = 19 + 3 + 7; //不重复组件 + 重复组件 + 核心组件
                Assert.Equal(expected, statistics.SimpleCount);
            }
        }
    }
}