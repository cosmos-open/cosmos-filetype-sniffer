﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("et")]
[FileTypeHex("d0,cf,11,e0,a1,b1,1a,e1")]
[FileTypeDescription("Kingsoft WPS Office ET file")]
public class _Et_Fingerprint : IFileTypeFingerprint { }