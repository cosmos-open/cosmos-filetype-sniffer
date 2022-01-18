using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CosmosStack.Reflection;

namespace CosmosStack.Sniffers.FileTypeSniffers.Registering
{
    public class FileTypeRegistrarScanner : TypeScanner
    {
        // ReSharper disable once InconsistentNaming
        private const string SKIP_ASSEMBLIES =
            "^System|^Mscorlib|^Netstandard|^Microsoft|^Autofac|^AutoMapper|^EntityFramework|^Newtonsoft|^Castle|^NLog|^Pomelo|^AspectCore|^Xunit|^Nito|^Npgsql|^Exceptionless|^MySqlConnector|^Anonymously Hosted";

        public FileTypeRegistrarScanner() : base(typeof(IFileTypeFingerprint)) { }

        protected override string GetSkipAssembliesNamespaces() => SKIP_ASSEMBLIES;

        protected override Assembly[] GetAssemblies()
        {
            return base.GetAssemblies().Concat(GetAllUnlinkedAssemblies()).Distinct().ToArray();
        }

        private static IEnumerable<Assembly> GetAllUnlinkedAssemblies()
        {
            var directoryRoot = new DirectoryInfo(Directory.GetCurrentDirectory());
            var files = directoryRoot.GetFiles("CosmosStack.Extensions.FileTypeSniffer.Library.*.dll", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                yield return Assembly.LoadFrom(file.FullName);
            }
        }

        protected override Func<Type, bool> TypeFilter() =>
            t => t.IsClass && t.IsPublic && !t.IsAbstract && BaseType.IsAssignableFrom(t);
    }
}