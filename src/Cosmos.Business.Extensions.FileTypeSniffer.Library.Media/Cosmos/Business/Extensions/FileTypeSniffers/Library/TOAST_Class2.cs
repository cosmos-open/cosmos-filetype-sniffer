using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("toast")]
    [FileTypeHex("8B 45 52 02 00 00 00")]
    public class TOAST_Class2 : IFileTypeRegistrar { }
}