using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("aar")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("Android Archive file")]
    public class AAR_Class3 : IFileTypeRegistrar { }
}