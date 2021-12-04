using System.Net.Http.Headers;
using System;
    public class GuidProvider
    {
        private Guid guid { get; } = Guid.NewGuid();

        public Guid GetGuid()
        {
            return guid;
        }

    }
