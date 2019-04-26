using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("43 57 53")]
    public class SWF_Class1 : IFileTypeRegistrar { }
}
