﻿using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Definitions;

[FileTypeExtensionNames("msg")]
[FileTypeHex("D0 CF 11 E0 A1 B1 1A E1")]
[FileTypeDescription("Microsoft Office Outlook email file")]
public class _Msg_Fingerprint : IFileTypeFingerprint { }