using System;
using Autofac;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Xunit;

namespace BasicAutofacTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = new ContainerBuilder();
            builder.RegisterFileTypeSniffer();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var sniffer = scope.Resolve<IFileTypeSniffer>();

                Assert.NotNull(sniffer);

                var statistics = sniffer.GetMetadataStatistics();
                Assert.Equal(30, statistics.Total);
            }
        }
    }
}
