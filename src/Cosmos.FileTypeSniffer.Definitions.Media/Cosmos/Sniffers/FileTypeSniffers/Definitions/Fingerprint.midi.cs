using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mid,midi")]
[FileTypeHex("4D 54 68 64")]
public class _Midi_Fingerprint : IFileTypeFingerprint { }