using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ico")]
    [FileTypeHex("00 00 01 00")]
    public class ICO_Class1 : IFileTypeRegistrar { }
}