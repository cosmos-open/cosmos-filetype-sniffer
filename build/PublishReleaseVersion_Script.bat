@echo off

echo =======================================================================
echo Cosmos.Extensions.FileTypeSniffer
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
dotnet pack src/Cosmos.Extensions.FileTypeSniffer/Cosmos.Extensions.FileTypeSniffer._build.csproj                                         -c Release -o nuget_packages --no-restore

::extensions for library
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Development/Cosmos.Extensions.FileTypeSniffer.Library.Development._build.csproj -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Image/Cosmos.Extensions.FileTypeSniffer.Library.Image._build.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Media/Cosmos.Extensions.FileTypeSniffer.Library.Media._build.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Office/Cosmos.Extensions.FileTypeSniffer.Library.Office._build.csproj           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Science/Cosmos.Extensions.FileTypeSniffer.Library.Science._build.csproj         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Extensions.FileTypeSniffer.Library.Zip/Cosmos.Extensions.FileTypeSniffer.Library.Zip._build.csproj                 -c Release -o nuget_packages --no-restore

echo =======================================================================
echo Cosmos.Extensions.FileTypeSniffer EXTRA
echo =======================================================================

::start to build, package and push solo/extra projects
cd extra/AspectCore
dotnet build FileTypeSniffer-Extra-AspectCore.sln
cd ../..

cd extra/Autofac
dotnet build FileTypeSniffer-Extra-Autofac.sln
cd ../..

cd extra/DI
dotnet build FileTypeSniffer-Extra-DI.sln
cd ../..

dotnet pack extra/AspectCore/src/Extra/Extra.csproj    -c Release -o nuget_packages --no-restore
dotnet pack extra/Autofac/src/Extra/Extra.csproj       -c Release -o nuget_packages --no-restore
dotnet pack extra/DI/src/Extra/Extra.csproj            -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do ( 	
    dotnet nuget push "%%s" -s "Release" --skip-duplicate
	echo.
)

::get back to build folder
cd build