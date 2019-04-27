using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tbi")]
    [FileTypeHex("00 00 00 00 14 00 00 00")]
    public class TBI_Class1 : IFileTypeRegistrar { }
}