@echo off

::go to parent folder
cd ..

::create nuget_packages
if not exist nuget_packages (
    md nuget_packages
    echo Created nuget_packages folder.
)

::clear nuget_packages
for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del %%s
)
echo Cleaned up all nuget packages.
echo.

::get nuget key
set /p key=input key:

::start to package all projects

::core
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer -c Release -o nuget_packages

::extensions for dependency
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection -c Release -o nuget_packages

::extensions for library
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Development -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Image -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Media -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Office -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Science -c Release -o nuget_packages
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Zip -c Release -o nuget_packages

echo.
echo.

::set target nuget server url
set source=https://www.myget.org/F/alexinea/api/v2/package

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do ( 	
    dotnet nuget push "%%s" -k %key% -s %source%
	echo.
)

::get back to build folder
cd build

pause