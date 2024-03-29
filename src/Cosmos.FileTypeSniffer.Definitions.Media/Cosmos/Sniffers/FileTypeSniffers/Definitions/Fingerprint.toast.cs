﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("toast")]
[FileTypeHex("45 52 02 00 00 00")]
public class _Toast_1_Fingerprint : IFileTypeFingerprint { }
    
[FileTypeExtensionNames("toast")]
[FileTypeHex("8B 45 52 02 00 00 00")]
public class _Toast_2_Fingerprint : IFileTypeFingerprint { }