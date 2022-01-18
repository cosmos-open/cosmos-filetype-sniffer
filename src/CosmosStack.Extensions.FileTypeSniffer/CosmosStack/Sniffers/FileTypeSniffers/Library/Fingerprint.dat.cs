using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("dat")]
    [FileTypeHex("00 00 00 00 62 31 05 00 09 00 00 00 00 20 00 00 00 09 00 00 00 00 00 00")]
    [FileTypeOffset(8)]
    [FileTypeDescription("Bitcoin Core wallet.dat file")]
    public class _Dat_1_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("dat")]
    [FileTypeHex("50 4D 4F 43 43 4D 4F 43")]
    public class _Dat_2_Fingerprint : IFileTypeFingerprint { }
}