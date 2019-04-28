using System;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BasicMsdiTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            var provider = services.BuildServiceProvider();

            using (var scope = provider.CreateScope())
            {
                var sniffer = scope.ServiceProvider.GetService<IFileTypeSniffer>();

                Assert.NotNull(sniffer);

                var statistics = sniffer.GetMetadataStatistics();
                Assert.Equal(8, statistics.Total);
            }
        }
    }
}
