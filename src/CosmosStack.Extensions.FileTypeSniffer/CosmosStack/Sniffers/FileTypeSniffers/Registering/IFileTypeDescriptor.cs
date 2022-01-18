using System.Collections.Generic;

namespace CosmosStack.Sniffers.FileTypeSniffers.Registering
{
    /// <summary>
    /// File Type Descriptor Interface <br />
    /// 文件类型描述符接口
    /// </summary>
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
