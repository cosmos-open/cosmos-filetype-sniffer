using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core
{
    internal class SniffingMetadataStatistics
    {
        private readonly object _lockObj = new object();

        public int Total => SimpleCount + ComplexCount;

        public int SimpleCount { get; private set; } = 0;

        public int ComplexCount { get; private set; } = 0;

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
