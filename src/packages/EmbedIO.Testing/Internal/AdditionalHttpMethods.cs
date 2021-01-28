using System.Net.Http;

namespace EmbedIO.Testing.Internal
{
#if NETSTANDARD2_0 || NETSTANDARD2_1
    internal static class AdditionalHttpMethods
    {
        public static readonly HttpMethod Patch = new HttpMethod("PATCH");
    }
#endif
}