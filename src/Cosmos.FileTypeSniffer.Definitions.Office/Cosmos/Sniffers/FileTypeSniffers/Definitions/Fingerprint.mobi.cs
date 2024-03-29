﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("mobi")]
[FileTypeHex("00 00 42 4F 4F 4B 4D 4F 42 49")]
[FileTypeOffset(58)]
public class _Mobi_Fingerprint : IFileTypeFingerprint { }