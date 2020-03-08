using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Author
        {
            public const string ReadAll = Base + "/authors";
            public const string Create = Base + "/authors";
            public const string Update = Base + "/authors/{id}";
            public const string Delete = Base + "/authors/{id}";
        }
        public static class Work
        {
            public const string ReadAll = Base + "/works";
            public const string Create = Base + "/works";
            public const string Update = Base + "/works/{id}";
            public const string Delete = Base + "/works/{id}";
        }
    }
}
