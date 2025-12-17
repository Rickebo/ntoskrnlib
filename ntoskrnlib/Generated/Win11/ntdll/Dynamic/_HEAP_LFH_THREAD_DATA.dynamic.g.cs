using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_THREAD_DATA")]
    public sealed class _HEAP_LFH_THREAD_DATA : DynamicStructure
    {
        public ushort SlotMapRef { get; }
        public ushort HeatMapRef { get; }
        public byte CachedProcIndex { get; }
        public byte ContentionRemapCount { get; }
        public ushort Spare { get; }
        public IntPtr AllBits { get; }

        public _HEAP_LFH_THREAD_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_THREAD_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_THREAD_DATA.SlotMapRef),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_THREAD_DATA.HeatMapRef),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_THREAD_DATA.CachedProcIndex),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_LFH_THREAD_DATA.ContentionRemapCount),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_HEAP_LFH_THREAD_DATA.Spare),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_HEAP_LFH_THREAD_DATA.AllBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_THREAD_DATA>((mem, ptr) => new _HEAP_LFH_THREAD_DATA(mem, ptr), offsets);
        }
    }
}