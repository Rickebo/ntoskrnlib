using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHE_MANAGER_CALLBACKS")]
    public sealed class _CACHE_MANAGER_CALLBACKS : DynamicStructure
    {
        public IntPtr AcquireForLazyWrite { get; }
        public IntPtr ReleaseFromLazyWrite { get; }
        public IntPtr AcquireForReadAhead { get; }
        public IntPtr ReleaseFromReadAhead { get; }

        public _CACHE_MANAGER_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHE_MANAGER_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHE_MANAGER_CALLBACKS.AcquireForLazyWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACKS.ReleaseFromLazyWrite),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACKS.AcquireForReadAhead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACKS.ReleaseFromReadAhead),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_CACHE_MANAGER_CALLBACKS>((mem, ptr) => new _CACHE_MANAGER_CALLBACKS(mem, ptr), offsets);
        }
    }
}