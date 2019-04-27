using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bpg")]
    [FileTypeHex("42 50 47 FB")]
    public class BPG_Class1 : IFileTypeRegistrar { }
}