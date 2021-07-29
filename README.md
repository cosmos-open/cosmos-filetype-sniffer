# Cosmos FileTypeSniffer Overview

File type sniffer component, a library that used to identify the real type of physical file via infering the head of the file binary information.

This repository belongs to [Open Cosmos](https://github.com/cosmos-open) Project, a part of [COSMOS LOOPS PROGRAMME](https://github.com/cosmos-loops/).

This project refers to the design of a part of [rocketRobin/myrmec](https://github.com/rocketRobin/myrmec), so much thx to Rocket Robin!

---

## Nuget Packages

| Package Name                                                                                                                                                                           | Version                                                                                                           | Downloads                                                                                                          |
| :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------- |
| [Cosmos.Extensions.FileTypeSniffer](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer/)                                                               | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.svg)                                | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.svg)                                |
| [Cosmos.Extensions.FileTypeSniffer.Library.Development](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Development/)                       | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Development.svg)            | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Development.svg)            |
| [Cosmos.Extensions.FileTypeSniffer.Library.Image](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Image/)                                   | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Image.svg)                  | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Image.svg)                  |
| [Cosmos.Extensions.FileTypeSniffer.Library.Media](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Media/)                                   | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Media.svg)                  | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Media.svg)                  |
| [Cosmos.Extensions.FileTypeSniffer.Library.Office](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Office/)                                 | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Office.svg)                 | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Office.svg)                 |
| [Cosmos.Extensions.FileTypeSniffer.Library.Science](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Science/)                               | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Science.svg)                | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Science.svg)                |
| [Cosmos.Extensions.FileTypeSniffer.Library.Zip](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Library.Zip/)                                       | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Library.Zip.svg)                    | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Library.Zip.svg)                    |
| [Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection/)           | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection.svg)      | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection.svg)      |
| [Cosmos.Extensions.FileTypeSniffer.Extra.Autofac](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Extra.Autofac/)                                   | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Extra.Autofac.svg)                  | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Extra.Autofac.svg)                  |
| [Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector](https://www.nuget.org/packages/Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector/)             | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector.svg)       | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector.svg)       |

## Usage

### Install the package

Choose one kind of dependency extensions that you need and install it via nuget.

```
Install-Package Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection
Install-Package Cosmos.Extensions.FileTypeSniffer.Extra.Autofac
```

or use directly

```
Install-Package Cosmos.Extensions.FileTypeSniffer
```

Install the specific file type libraries as needed.

### Config in Startup class

```c#
public class Startup
{
    //...
    public void ConfigureServices(IServiceCollection services)
    {
        //configuration
        services.AddCosmosFileTypeSniffer();
    }
}
```

### Use directly

```c#
var descriptors = new List<IFileTypeDescriptor>();
var defaultProvider = new DefaultFileTypeProvider();
descriptors.AddRange(defaultProvider.GetDescriptors());
var sniffer = FileTypeSnifferFactory.Create(descriptors);

//sniffer.Match...
```

### Write code

```c#
//Get sniffer from DI or use dirsctly
//_sniffer...

//Load file from some place...
var path = Path.Combine(Local, fileName);
byte[] array = new byte[20];
using (var file = File.Open(path, FileMode.Open))
{
    file.Read(array, 0, array.Length);
}
var results = _sniffer.Match(bytes, true);
//...
```

### Find single result or multiple results

```c#
//For single result in list, false as default:
List<string> results0 = _sniffer.Match(bytes, false);

//For multiple results:
List<string> results1 = _sniffer.Match(bytes, true);

//or
string result2 = _sniffer.MatchSingle(bytes);
```

### Available file types

Currently available file types are:

| Library     | File types                                                                                                                                                                    |
| :---------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| core        | .bac, .bin, .dmg, .exe, .rc, .stg, .tox                                                                                                                                       |
| development | .aar, .apd, .avro, .class, .crx, .dat, .deb, .der, dex, .jar, .orc, .pdb, .rpm, .vmdk, .wasm, .xml                                                                            |
| image       | .bmp, .bpg, .cin, .cr2, .dib, .dpx, .exr, .fh8, .flif, .gif, .ico, .jp2, .jpg, .jpeg, .mlv, .png, .ps, .psd, .tbi, tif, .tiff                                                 |
| media       | .3g2, .3gp, .asf, .dat, .flac, .iso, .m2p, .mdf, .mid, .midi, .mkv, .mka, .mks, .mk3d, mp3, .mpg, .mpg2, .mpeg, .nes, .ogg, .oga, .ogv, .swf, .toast, .vob, .webm, .wma, .wmv |
| office      | .awz3, .cwk, .doc, .docx, .dps, .eddx, .emmx, .epub, .et, .mobi, .msg, .odp, .ods, .odt, .pdf, .ppt, .pptx, .rtf, .ttf, .vsdx, .woff, .woff2, .wps, .xls, .xlsx, .xmind       |
| science     | .fits                                                                                                                                                                         |
| zip         | .7z, .cab, .gz, .tar.gz, .lz4, .lzfse, .rar, .tar, .xar, .xz, .tar.xz, .z, .tar.z, .zip, .zlib                                                                                |

### How to Unit Test

Copy the `tests\samples` directory under the tests folder to `tests\IntegrationTests\bin\Debug\netcoreapp2.2`.

---

## Thanks

People or projects that have made a great contribution to this project:

- _null_
- _The next one must be you_

### Organizations and projects

- [rocketRobin/myrmec](https://github.com/rocketRobin/myrmec), Apache License 2.0

---

## License

Member project of [Cosmosloops Labs.](https://github.com/cosmos-loops).

[Apache License 2.0](/LICENSE)
