﻿using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mp3")]
    [FileTypeHex("49 44 33")]
    public class MP3_Class2 : IFileTypeRegistrar { }
}