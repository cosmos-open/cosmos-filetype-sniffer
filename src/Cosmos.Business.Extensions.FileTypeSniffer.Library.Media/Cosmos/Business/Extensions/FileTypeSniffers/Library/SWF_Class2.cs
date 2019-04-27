using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("swf")]
    [FileTypeHex("46 57 53")]
    public class SWF_Class2 : IFileTypeRegistrar { }
}