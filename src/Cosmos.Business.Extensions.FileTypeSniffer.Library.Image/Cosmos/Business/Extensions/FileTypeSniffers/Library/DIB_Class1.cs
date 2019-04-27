using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dib")]
    [FileTypeHex("42 4D")]
    public class DIB_Class1 : IFileTypeRegistrar { }
}