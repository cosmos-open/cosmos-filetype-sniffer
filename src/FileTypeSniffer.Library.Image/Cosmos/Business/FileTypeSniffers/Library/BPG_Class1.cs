using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bpg")]
    [FileTypeHex("42 50 47 FB")]
    public class BPG_Class1 : IFileTypeRegistrar { }
}