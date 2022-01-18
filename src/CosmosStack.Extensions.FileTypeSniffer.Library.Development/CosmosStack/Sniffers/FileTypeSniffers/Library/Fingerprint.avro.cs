using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("avro")]
    [FileTypeHex("4F 62 6A 01")]
    [FileTypeDescription("Apache Avro file")]
    public class _Avro_Fingerprint : IFileTypeFingerprint { }
}