using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rpm")]
    [FileTypeHex("ed ab ee db")]
    public class RPM_Class1 : IFileTypeRegistrar { }
}