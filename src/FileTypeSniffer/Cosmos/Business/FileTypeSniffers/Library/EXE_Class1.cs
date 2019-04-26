using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("exe")]
    [FileTypeHex("4D 5A")]
    public class EXE_Class1 : IFileTypeRegistrar { }
}