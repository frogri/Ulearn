﻿using System;

namespace Memory.API
{
    public class APIObject : IDisposable
    {
        private bool isDisposed;
        private readonly int id;

        public APIObject(int id)
        {
            this.id = id;
            MagicAPI.Allocate(this.id);
        }

        ~APIObject()
        {
            Dispose(false);
            MagicAPI.Free(id);
        }

        protected virtual void Dispose(bool fromDisposeMethod)
        {
            if (!isDisposed)
            {
                if (fromDisposeMethod) 
                    MagicAPI.Free(id);

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //финализатор не будет вызываться
        }
    }
}
