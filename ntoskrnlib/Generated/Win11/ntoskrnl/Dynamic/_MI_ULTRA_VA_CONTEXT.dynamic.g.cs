using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ULTRA_VA_CONTEXT")]
    public sealed class _MI_ULTRA_VA_CONTEXT : DynamicStructure
    {
        public int Lock { get; }
        public IntPtr ZeroMapping { get; }
        public ulong AllocationHintBit { get; }
        public byte[] Bitmap { get; }
        public uint ConcurrencyMaximum { get; }
        public int ConcurrencyCount { get; }

        public _MI_ULTRA_VA_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ULTRA_VA_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.ZeroMapping),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.AllocationHintBit),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.Bitmap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.ConcurrencyMaximum),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_ULTRA_VA_CONTEXT.ConcurrencyCount),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_MI_ULTRA_VA_CONTEXT>((mem, ptr) => new _MI_ULTRA_VA_CONTEXT(mem, ptr), offsets);
        }
    }
}