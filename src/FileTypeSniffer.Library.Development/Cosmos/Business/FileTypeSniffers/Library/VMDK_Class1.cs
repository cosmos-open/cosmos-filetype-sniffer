using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vmdk")]
    [FileTypeHex("4B 44 4D")]
    [FileTypeDescription("VMWare Virtual Machine Disk Format")]
    public class VMDK_Class1 : IFileTypeRegistrar { }
}