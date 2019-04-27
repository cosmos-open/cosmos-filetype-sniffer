using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("stg")]
    [FileTypeHex("4D 49 4C 20")]
    public class STG_Class1 : IFileTypeRegistrar { }
}