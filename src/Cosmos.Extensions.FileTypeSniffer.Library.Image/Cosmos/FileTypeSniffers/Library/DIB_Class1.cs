using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dib")]
    [FileTypeHex("42 4D")]
    public class DIB_Class1 : IFileTypeRegistrar { }
}