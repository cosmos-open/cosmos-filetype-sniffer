using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("exe")]
    [FileTypeHex("4D 5A")]
    public class EXE_Class1 : IFileTypeRegistrar { }
}