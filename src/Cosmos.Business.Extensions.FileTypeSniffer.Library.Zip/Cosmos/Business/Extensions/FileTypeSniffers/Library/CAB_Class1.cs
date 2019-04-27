using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cab")]
    [FileTypeHex("4D 53 43 46")]
    public class CAB_Class1 : IFileTypeRegistrar { }
}