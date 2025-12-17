using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KDPC_DATA")]
    public sealed class _KDPC_DATA : DynamicStructure
    {
        public _KDPC_LIST DpcList { get; }
        public ulong DpcLock { get; }
        public int DpcQueueDepth { get; }
        public uint DpcCount { get; }
        public IntPtr ActiveDpc { get; }
        public uint LongDpcPresent { get; }
        public uint Padding { get; }

        public _KDPC_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDPC_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDPC_DATA.DpcList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDPC_DATA.DpcLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KDPC_DATA.DpcQueueDepth),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KDPC_DATA.DpcCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_KDPC_DATA.ActiveDpc),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KDPC_DATA.LongDpcPresent),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KDPC_DATA.Padding),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_KDPC_DATA>((mem, ptr) => new _KDPC_DATA(mem, ptr), offsets);
        }
    }
}