using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rc")]
    [FileTypeHex("53 45 51 36")]
    public class RC_Class1 : IFileTypeRegistrar { }
}