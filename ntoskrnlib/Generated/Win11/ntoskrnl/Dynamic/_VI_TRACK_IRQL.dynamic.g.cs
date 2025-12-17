using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_TRACK_IRQL")]
    public sealed class _VI_TRACK_IRQL : DynamicStructure
    {
        public IntPtr Thread { get; }
        public byte OldIrql { get; }
        public byte NewIrql { get; }
        public ushort Processor { get; }
        public uint TickCount { get; }
        public byte[] StackTrace { get; }

        public _VI_TRACK_IRQL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_TRACK_IRQL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_TRACK_IRQL.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_TRACK_IRQL.OldIrql),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_TRACK_IRQL.NewIrql),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_VI_TRACK_IRQL.Processor),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_VI_TRACK_IRQL.TickCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_VI_TRACK_IRQL.StackTrace),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_VI_TRACK_IRQL>((mem, ptr) => new _VI_TRACK_IRQL(mem, ptr), offsets);
        }
    }
}