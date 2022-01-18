@echo off

echo =======================================================================
echo CosmosStack.FileTypeSniffer
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
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer                           -c Release -o nuget_packages --no-restore

::extensions for library
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Development       -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Image             -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Media             -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Office            -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Science           -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Library.Zip               -c Release -o nuget_packages --no-restore

::extra
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Extra.AspectCoreInjector  -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Extra.Autofac             -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.FileTypeSniffer.Extra.DependencyInjection -c Release -o nuget_packages --no-restore

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
cd scripts