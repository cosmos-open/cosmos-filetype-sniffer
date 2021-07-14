namespace Cosmos.Sniffers.FileTypeSniffers.Core
{
    internal class SniffingMetadataStatistics
    {
        private readonly object _lockObj = new();

        public int Total => SimpleCount + ComplexCount;

        public int SimpleCount { get; private set; }

        public int ComplexCount { get; private set; }

        internal void UpdateSimpleMetadata(int increase)
        {
            lock (_lockObj)
            {
                SimpleCount += increase;
            }
        }

        public void UpdateComplexMetadata(int increase)
        {
            lock (_lockObj)
            {
                ComplexCount += increase;
            }
        }
    }
}