using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("vmdk")]
[FileTypeHex("4B 44 4D")]
[FileTypeDescription("VMWare Virtual Machine Disk Format")]
public class _Vmdk_Fingerprint : IFileTypeFingerprint { }