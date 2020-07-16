using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.FileTypeSniffers.Core;
using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Providers
{
    public class DefaultFileTypeProvider : ISniffingDescriptorProvider
    {
        private List<Type> TypesOfFileType { get; }

        public DefaultFileTypeProvider()
        {
            using (var scanner = new FileTypeRegistrarScanner())
            {
                TypesOfFileType = scanner.Scan().ToList();
            }
        }

        public IEnumerable<IFileTypeDescriptor> GetDescriptors()
        {
            foreach (var registrarType in TypesOfFileType.ToList())
            {
                if (registrarType == null)
                    continue;
                yield return new FileTypeDescriptor(registrarType);
            }
        }
    }
}
