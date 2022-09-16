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
dotnet pack src/Cosmos.FileTypeSniffer                           -c Release -o nuget_packages --no-restore

::extensions for definitions library
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Dev           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Image         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Media         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Office        -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Science       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.Definitions.Zip           -c Release -o nuget_packages --no-restore

::dependency
dotnet pack src/Cosmos.FileTypeSniffer.DependOn.AspectCoreInjector  -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.DependOn.Autofac             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.FileTypeSniffer.DependOn.DependencyInjection -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do (
    dotnet nuget push "%%s" -s "Nightly" --skip-duplicate
	echo.
)

::get back to build folder
cd scripts