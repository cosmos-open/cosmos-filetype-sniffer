using System.Collections.Generic;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Registering
{
    public interface IFileTypeDescriptor
    {
        string Description { get; }

        string ExtensionNames { get; }

        List<string> ResolveExtensionNames(char[] separators);

        string Hex { get; }

        int Offset { get; }

        string[] ResolveHex(string source, char[] separators);

        bool IsComplexMetadata { get; }
    }
}
