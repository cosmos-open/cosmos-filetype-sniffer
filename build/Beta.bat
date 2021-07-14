@echo off

echo =======================================================================
echo Cosmos.FileTypeSniffer
echo =======================================================================

::go to parent folder
cd ..

::create nuget_packages
if not exist nuget_packages (
    md nuget_packages
    echo Created nuget_packages folder.
)

::clear nuget_packages
for /R "nuget_packages" %%s in (*) do (
    del "%%s"
)
echo Cleaned up all nuget packages.
echo.

::start to package all projects

::core
dotnet pack src/Cosmos.Extensions.FileTypeSniffer/Cosmos.Extensions.FileTypeSniffer.csproj                                         -c Release -o nuget_packages --no-restore

::extensions for library
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Development/Cosmos.Extensions.FileTypeSniffer.Library.Development.csproj -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Image/Cosmos.Extensions.FileTypeSniffer.Library.Image.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Media/Cosmos.Extensions.FileTypeSniffer.Library.Media.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Office/Cosmos.Extensions.FileTypeSniffer.Library.Office.csproj           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Science/Cosmos.Extensions.FileTypeSniffer.Library.Science.csproj         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Zip/Cosmos.Extensions.FileTypeSniffer.Library.Zip.csproj                 -c Release -o nuget_packages --no-restore

::extra
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector/Cosmos.Extensions.FileTypeSniffer.Extra.AspectCoreInjector.csproj           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Extra.Autofac/Cosmos.Extensions.FileTypeSniffer.Extra.Autofac.csproj                                 -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection/Cosmos.Extensions.FileTypeSniffer.Extra.DependencyInjection.csproj         -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do ( 	
    dotnet nuget push "%%s" -s "Beta" --skip-duplicate
	echo.
)

::get back to build folder
cd build