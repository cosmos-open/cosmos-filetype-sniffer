﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rtf")]
    [FileTypeHex("7B 5C 72 74 66 31")]
    public class RTF_Class1 : IFileTypeRegistrar { }
}