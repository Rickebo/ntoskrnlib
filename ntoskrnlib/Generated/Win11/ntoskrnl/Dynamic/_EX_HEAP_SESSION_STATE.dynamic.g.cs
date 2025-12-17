using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_HEAP_SESSION_STATE")]
    public sealed class _EX_HEAP_SESSION_STATE : DynamicStructure
    {
        public _RTLP_HP_HEAP_MANAGER HeapManager { get; }
        public RTL_HP_ENV_HANDLE PagedEnv { get; }
        public IntPtr PagedHeap { get; }
        public IntPtr SpecialPoolHeap { get; }

        public _EX_HEAP_SESSION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_HEAP_SESSION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_HEAP_SESSION_STATE.HeapManager),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_HEAP_SESSION_STATE.PagedEnv),
                    new ulong[]
                    {
                        14560UL
                    }
                },
                {
                    nameof(_EX_HEAP_SESSION_STATE.PagedHeap),
                    new ulong[]
                    {
                        14576UL
                    }
                },
                {
                    nameof(_EX_HEAP_SESSION_STATE.SpecialPoolHeap),
                    new ulong[]
                    {
                        14584UL
                    }
                }
            };
            Register<_EX_HEAP_SESSION_STATE>((mem, ptr) => new _EX_HEAP_SESSION_STATE(mem, ptr), offsets);
        }
    }
}