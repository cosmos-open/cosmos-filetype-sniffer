using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("pdb")]
    [FileTypeHex("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00")]
    [FileTypeOffset(11)]
    [FileTypeDescription("Program Database File")]
    public class _Pdb_Fingerprint : IFileTypeFingerprint { }
}