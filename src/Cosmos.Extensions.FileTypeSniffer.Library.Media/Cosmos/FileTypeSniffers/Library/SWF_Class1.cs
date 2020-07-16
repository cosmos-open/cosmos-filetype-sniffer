using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("43 57 53")]
    public class SWF_Class1 : IFileTypeRegistrar { }
}
