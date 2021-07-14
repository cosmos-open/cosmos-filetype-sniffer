using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("exe")]
    [FileTypeHex("4D 5A")]
    public class _Exe_Fingerprint : IFileTypeFingerprint { }
}