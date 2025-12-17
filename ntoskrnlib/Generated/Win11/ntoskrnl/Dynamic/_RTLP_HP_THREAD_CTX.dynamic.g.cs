using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_THREAD_CTX")]
    public sealed class _RTLP_HP_THREAD_CTX : DynamicStructure
    {
        public byte LegacyVirtualAffinity { get; }
        public byte CachedProcIndex { get; }
        public ushort LFHDataSlot { get; }
        public uint EntireUlong { get; }

        public _RTLP_HP_THREAD_CTX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_THREAD_CTX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_THREAD_CTX.LegacyVirtualAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_THREAD_CTX.CachedProcIndex),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_RTLP_HP_THREAD_CTX.LFHDataSlot),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_RTLP_HP_THREAD_CTX.EntireUlong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTLP_HP_THREAD_CTX>((mem, ptr) => new _RTLP_HP_THREAD_CTX(mem, ptr), offsets);
        }
    }
}