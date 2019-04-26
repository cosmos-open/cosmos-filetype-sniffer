using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("odp")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("OpenDocument Presentation")]
    public class ODP_Class3 : IFileTypeRegistrar { }
}