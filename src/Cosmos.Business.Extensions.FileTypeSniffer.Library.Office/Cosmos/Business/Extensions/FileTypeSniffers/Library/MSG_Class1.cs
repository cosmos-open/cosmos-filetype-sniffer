using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("msg")]
    [FileTypeHex("D0 CF 11 E0 A1 B1 1A E1")]
    [FileTypeDescription("Microsoft Office Outlook email file")]
    public class MSG_Class1 : IFileTypeRegistrar { }
}