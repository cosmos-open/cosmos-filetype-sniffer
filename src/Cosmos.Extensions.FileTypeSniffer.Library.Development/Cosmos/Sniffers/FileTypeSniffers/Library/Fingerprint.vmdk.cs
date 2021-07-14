using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("vmdk")]
    [FileTypeHex("4B 44 4D")]
    [FileTypeDescription("VMWare Virtual Machine Disk Format")]
    public class _Vmdk_Fingerprint : IFileTypeFingerprint { }
}