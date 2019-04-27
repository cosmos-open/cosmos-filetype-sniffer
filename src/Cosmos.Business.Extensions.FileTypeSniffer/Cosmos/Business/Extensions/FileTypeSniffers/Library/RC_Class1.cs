using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rc")]
    [FileTypeHex("53 45 51 36")]
    public class RC_Class1 : IFileTypeRegistrar { }
}