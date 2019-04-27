using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("43 57 53")]
    public class SWF_Class1 : IFileTypeRegistrar { }
}
