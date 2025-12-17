using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTLP_HP_METADATA_HEAP_CTX")]
    public sealed class _RTLP_HP_METADATA_HEAP_CTX : DynamicStructure
    {
        public IntPtr Heap { get; }
        public _RTL_RUN_ONCE InitOnce { get; }

        public _RTLP_HP_METADATA_HEAP_CTX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_METADATA_HEAP_CTX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_METADATA_HEAP_CTX.Heap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_METADATA_HEAP_CTX.InitOnce),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTLP_HP_METADATA_HEAP_CTX>((mem, ptr) => new _RTLP_HP_METADATA_HEAP_CTX(mem, ptr), offsets);
        }
    }
}