using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_TRACES")]
    public sealed class _MI_PAGEFILE_TRACES : DynamicStructure
    {
        public int Status { get; }
        public byte PagefileNumber { get; }
        public byte Priority { get; }
        public byte IrpPriority { get; }
        public byte ReservationWrite { get; }
        public ulong CurrentTime { get; }
        public ulong AvailablePages { get; }
        public ulong ModifiedPagesTotal { get; }
        public ulong ModifiedPagefilePages { get; }
        public ulong ModifiedNoWritePages { get; }
        public ulong ModifiedPagefileNoReservationPages { get; }
        public ulong ModifiedPageFileNoReservationCompressPages { get; }
        public ulong ModifiedPagefileReservationPages { get; }
        public _unnamed_tag_ LocalMdl { get; }

        public _MI_PAGEFILE_TRACES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGEFILE_TRACES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGEFILE_TRACES.Status),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.PagefileNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.Priority),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.IrpPriority),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ReservationWrite),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.CurrentTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.AvailablePages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedPagesTotal),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedPagefilePages),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedNoWritePages),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedPagefileNoReservationPages),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedPageFileNoReservationCompressPages),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.ModifiedPagefileReservationPages),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_TRACES.LocalMdl),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_MI_PAGEFILE_TRACES>((mem, ptr) => new _MI_PAGEFILE_TRACES(mem, ptr), offsets);
        }
    }
}