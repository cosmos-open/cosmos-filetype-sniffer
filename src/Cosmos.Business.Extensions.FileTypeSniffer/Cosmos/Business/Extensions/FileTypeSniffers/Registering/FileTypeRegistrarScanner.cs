using System;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Registering
{
    public class FileTypeRegistrarScanner : TypeScanner
    {
        // ReSharper disable once InconsistentNaming
        private const string SKIP_ASSEMBLIES =
            "^System|^Mscorlib|^Netstandard|^Microsoft|^Autofac|^AutoMapper|^EntityFramework|^Newtonsoft|^Castle|^NLog|^Pomelo|^AspectCore|^Xunit|^Nito|^Npgsql|^Exceptionless|^MySqlConnector|^Anonymously Hosted";

        public FileTypeRegistrarScanner() : base(typeof(IFileTypeRegistrar)) { }

        protected override string GetSkipAssembliesNamespaces() => SKIP_ASSEMBLIES;

        protected override Func<Type, bool> TypeFilter() =>
            t => t.IsClass && t.IsPublic && !t.IsAbstract && BaseType.IsAssignableFrom(t);
    }
}
