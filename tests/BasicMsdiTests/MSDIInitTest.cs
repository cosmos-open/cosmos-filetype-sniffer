using System;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BasicMsdiTests
{
    public class MSDIInitTest
    {
        [Fact]
        public void MSDITest()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            var provider = services.BuildServiceProvider();

            using (var scope = provider.CreateScope())
            {
                var sniffer = scope.ServiceProvider.GetService<IFileTypeSniffer>();

                Assert.NotNull(sniffer);

                var statistics = sniffer.GetMetadataStatistics();
                var expected = 1 + 0 + 7; //不重复组件 + 重复组件 + 核心组件
                Assert.Equal(expected, statistics.Total);
            }
        }
    }
}