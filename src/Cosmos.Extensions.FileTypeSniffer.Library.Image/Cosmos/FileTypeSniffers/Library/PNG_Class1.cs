using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("png")]
    [FileTypeHex("89,50,4e,47,0d,0a,1a,0a")]
    public class PNG_Class1 : IFileTypeRegistrar { }
}
