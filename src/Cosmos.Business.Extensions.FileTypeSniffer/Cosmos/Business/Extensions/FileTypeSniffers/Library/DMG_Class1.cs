using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("dmg")]
    [FileTypeHex("78 01 73 0D 62 62 60")]
    public class DMG_Class1 : IFileTypeRegistrar { }
}