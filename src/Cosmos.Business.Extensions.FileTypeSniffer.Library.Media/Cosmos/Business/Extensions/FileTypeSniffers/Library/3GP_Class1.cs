using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("3gp")]
    [FileTypeHex("66 74 79 70 33 67")]
    [FileTypeOffset(4)]
    public class _3GP_Class1 : IFileTypeRegistrar { }
}