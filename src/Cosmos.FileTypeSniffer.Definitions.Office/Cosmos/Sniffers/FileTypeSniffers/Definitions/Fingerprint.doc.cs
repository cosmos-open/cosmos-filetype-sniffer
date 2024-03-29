﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

// ReSharper disable once InconsistentNaming
[FileTypeExtensionNames("doc")]
[FileTypeHex("D0 CF 11 E0 A1 B1 1A E1")]
[FileTypeDescription("Microsoft Office Word file.")]
public class _Doc_Fingerprint : IFileTypeFingerprint { }