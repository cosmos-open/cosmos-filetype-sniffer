using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.FileTypeSniffers.Core;
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Providers
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
