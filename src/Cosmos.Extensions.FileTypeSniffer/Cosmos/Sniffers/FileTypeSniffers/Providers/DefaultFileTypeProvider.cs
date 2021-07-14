using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Sniffers.FileTypeSniffers.Core;
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Providers
{
    public class DefaultFileTypeProvider : ISniffingDescriptorProvider
    {
        private List<Type> TypesOfFileType { get; }

        public DefaultFileTypeProvider()
        {
            using var scanner = new FileTypeRegistrarScanner();
            TypesOfFileType = scanner.Scan().ToList();
        }

        public IEnumerable<IFileTypeDescriptor> GetDescriptors()
        {
            foreach (var registrarType in TypesOfFileType.ToList())
            {
                if (registrarType is null)
                    continue;
                yield return new FileTypeDescriptor(registrarType);
            }
        }
    }
}