using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POOL_TRACKER_TABLE")]
    public sealed class _POOL_TRACKER_TABLE : DynamicStructure
    {
        public int Key { get; }
        public ulong NonPagedBytes { get; }
        public ulong NonPagedAllocs { get; }
        public ulong NonPagedFrees { get; }
        public ulong PagedBytes { get; }
        public ulong PagedAllocs { get; }
        public ulong PagedFrees { get; }
        public long[] AvailableLimit { get; }
        public IntPtr LimitInfo { get; }

        public _POOL_TRACKER_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POOL_TRACKER_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POOL_TRACKER_TABLE.Key),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.NonPagedBytes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.NonPagedAllocs),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.NonPagedFrees),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.PagedBytes),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.PagedAllocs),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.PagedFrees),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.AvailableLimit),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_TABLE.LimitInfo),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_POOL_TRACKER_TABLE>((mem, ptr) => new _POOL_TRACKER_TABLE(mem, ptr), offsets);
        }
    }
}