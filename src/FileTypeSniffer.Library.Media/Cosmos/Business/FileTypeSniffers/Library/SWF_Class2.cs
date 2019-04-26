using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("46 57 53")]
    public class SWF_Class2 : IFileTypeRegistrar { }
}