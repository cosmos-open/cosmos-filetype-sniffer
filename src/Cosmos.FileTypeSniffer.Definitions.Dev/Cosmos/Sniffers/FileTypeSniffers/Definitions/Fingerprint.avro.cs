﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("avro")]
[FileTypeHex("4F 62 6A 01")]
[FileTypeDescription("Apache Avro file")]
public class _Avro_Fingerprint : IFileTypeFingerprint { }