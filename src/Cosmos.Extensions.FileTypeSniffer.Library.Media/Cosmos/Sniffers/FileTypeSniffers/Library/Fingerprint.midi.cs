using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mid,midi")]
    [FileTypeHex("4D 54 68 64")]
    public class _Midi_Fingerprint : IFileTypeFingerprint { }
}