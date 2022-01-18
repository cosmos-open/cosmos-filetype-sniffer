using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("mid,midi")]
    [FileTypeHex("4D 54 68 64")]
    public class _Midi_Fingerprint : IFileTypeFingerprint { }
}