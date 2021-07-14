using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("avro")]
    [FileTypeHex("4F 62 6A 01")]
    [FileTypeDescription("Apache Avro file")]
    public class _Avro_Fingerprint : IFileTypeFingerprint { }
}