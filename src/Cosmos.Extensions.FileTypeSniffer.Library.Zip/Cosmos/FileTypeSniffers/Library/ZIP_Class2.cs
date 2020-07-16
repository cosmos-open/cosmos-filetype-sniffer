using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("zip")]
    [FileTypeHex("50,4b,07,08")]
    public class ZIP_Class2 : IFileTypeRegistrar { }
}