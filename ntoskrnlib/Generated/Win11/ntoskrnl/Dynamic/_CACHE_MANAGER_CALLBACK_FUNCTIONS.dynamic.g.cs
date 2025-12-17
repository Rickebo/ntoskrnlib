using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHE_MANAGER_CALLBACK_FUNCTIONS")]
    public sealed class _CACHE_MANAGER_CALLBACK_FUNCTIONS : DynamicStructure
    {
        public IntPtr AcquireForLazyWriteEx { get; }
        public IntPtr ReleaseFromLazyWrite { get; }
        public IntPtr AcquireForReadAhead { get; }
        public IntPtr ReleaseFromReadAhead { get; }

        public _CACHE_MANAGER_CALLBACK_FUNCTIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHE_MANAGER_CALLBACK_FUNCTIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHE_MANAGER_CALLBACK_FUNCTIONS.AcquireForLazyWriteEx),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACK_FUNCTIONS.ReleaseFromLazyWrite),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACK_FUNCTIONS.AcquireForReadAhead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACK_FUNCTIONS.ReleaseFromReadAhead),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_CACHE_MANAGER_CALLBACK_FUNCTIONS>((mem, ptr) => new _CACHE_MANAGER_CALLBACK_FUNCTIONS(mem, ptr), offsets);
        }
    }
}