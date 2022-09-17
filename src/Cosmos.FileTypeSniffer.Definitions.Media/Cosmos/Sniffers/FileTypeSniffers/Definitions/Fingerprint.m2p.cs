using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("m2p,mpg2")]
[FileTypeHex("00 00 01 BA")]
public class _M2p_Fingerprint : IFileTypeFingerprint { }