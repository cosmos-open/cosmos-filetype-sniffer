# OPENCOSMOS/FileTypeSniffer

File type sniffer component, a library that used to identify the real type of physical file via infering the head of the file binary information. This repository belongs to [Open Cosmos](https://github.com/cosmos-open) Project, a part of [COSMOS LOOPS PROGRAMME](https://github.com/cosmos-loops/).

This project refers to the design of a part of [rocketRobin/myrmec](https://github.com/rocketRobin/myrmec), so much thx to Rocket Robin!

---

## Nuget Packages

| Package Name                                                              | Version                                                                                                           | Downloads                                                                                                          |
| :------------------------------------------------------------------------ | :---------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------- |
| Cosmos.Business.Extensions.FileTypeSniffer                                | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.svg)                                | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.svg)                                |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Development            | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Development.svg)            | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Development.svg)            |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Image                  | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Image.svg)                  | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Image.svg)                  |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Media                  | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Media.svg)                  | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Media.svg)                  |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Office                 | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Office.svg)                 | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Office.svg)                 |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Science                | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Science.svg)                | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Science.svg)                |
| Cosmos.Business.Extensions.FileTypeSniffer.Library.Zip                    | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Library.Zip.svg)                    | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Library.Zip.svg)                    |
| Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection.svg) | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection.svg) |
| Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac             | ![](https://img.shields.io/nuget/v/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac.svg)             | ![](https://img.shields.io/nuget/dt/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac.svg)             |

## Usage

### Install the package

Choose one kind of dependency extensions that you need and install it via nuget.

```
Install-Package Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection
Install-Package Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac
```

or use directly

```
Install-Package Cosmos.Business.Extensions.FileTypeSniffer
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
        services.AddFileTypeSniffer();
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
//For single result, false as default:
var result = _sniffer.Match(bytes, false);

//For multiple results:
var results = _sniffer.Match(bytes, true);
```

---

## Thanks

People or projects that have made a great contribbution to this project:

- *null*
- _The next one must be you_

### Organizations and projects

- [rocketRobin/myrmec](https://github.com/rocketRobin/myrmec), Apache 2.0 License

---

## License

Member project of [COSMOS LOOPS PROGRAMME](https://github.com/cosmos-loops).

[Apache 2.0 License](/LICENSE)