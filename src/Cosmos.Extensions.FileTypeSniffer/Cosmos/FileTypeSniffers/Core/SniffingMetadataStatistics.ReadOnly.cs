namespace Cosmos.FileTypeSniffers.Core
{
    public class SniffingReadOnlyMetadataStatistics
    {
        internal SniffingReadOnlyMetadataStatistics(SniffingMetadataStatistics statistics)
        {
            Total = statistics.Total;
            SimpleCount = statistics.SimpleCount;
            ComplexCount = statistics.ComplexCount;
        }

        public int Total { get; }

        public int SimpleCount { get; }

        public int ComplexCount { get; }
    }
}
