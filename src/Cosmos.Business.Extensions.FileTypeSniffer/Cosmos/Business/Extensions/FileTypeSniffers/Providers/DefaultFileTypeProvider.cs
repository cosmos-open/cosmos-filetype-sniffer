using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.FileTypeSniffers.Core;
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Providers
{
    public class DefaultFileTypeProvider : ISniffingDescriptorProvider
    {
        private readonly IEnumerable<Type> _typesOfFileType;

        public DefaultFileTypeProvider()
        {
            using (var scanner = new FileTypeRegistrarScanner())
            {
                _typesOfFileType = scanner.Scan();
            }
        }

        public IEnumerable<IFileTypeDescriptor> GetDescriptors()
        {
            foreach (var registrarType in _typesOfFileType)
            {
                if (registrarType == null)
                    continue;
                yield return new FileTypeDescriptor(registrarType);
            }
        }
    }
}
