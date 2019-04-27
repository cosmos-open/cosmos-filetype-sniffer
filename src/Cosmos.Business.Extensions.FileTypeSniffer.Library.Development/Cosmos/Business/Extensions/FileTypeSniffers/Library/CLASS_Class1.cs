using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("class")]
    [FileTypeHex("CA FE BA BE")]
    public class CLASS_Class1 : IFileTypeRegistrar { }
}