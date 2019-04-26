using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("toast")]
    [FileTypeHex("45 52 02 00 00 00")]
    public class TOAST_Class1 : IFileTypeRegistrar { }
}