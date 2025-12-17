using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TRACKING_ENTRY")]
    public sealed class _INTERRUPT_TRACKING_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr IntTrackRoot { get; }
        public uint InterruptObjectCount { get; }
        public IntPtr InterruptObjectArray { get; }
        public ulong IsrTime { get; }
        public ulong DpcTime { get; }
        public byte IsPrimaryInterrupt { get; }
        public _INTERRUPT_VECTOR_DATA VectorData { get; }

        public _INTERRUPT_TRACKING_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_TRACKING_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.IntTrackRoot),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.InterruptObjectCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.InterruptObjectArray),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.IsrTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.DpcTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.IsPrimaryInterrupt),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ENTRY.VectorData),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_INTERRUPT_TRACKING_ENTRY>((mem, ptr) => new _INTERRUPT_TRACKING_ENTRY(mem, ptr), offsets);
        }
    }
}