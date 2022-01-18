using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("vmdk")]
    [FileTypeHex("4B 44 4D")]
    [FileTypeDescription("VMWare Virtual Machine Disk Format")]
    public class _Vmdk_Fingerprint : IFileTypeFingerprint { }
}