using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POOL_TRACKER_BIG_PAGES")]
    public sealed class _POOL_TRACKER_BIG_PAGES : DynamicStructure
    {
        public ulong Va { get; }
        public uint Key { get; }
        public uint Pattern { get; }
        public uint PoolFlags { get; }
        public uint SlushSize { get; }
        public ulong NumberOfBytes { get; }
        public IntPtr ProcessBilled { get; }

        public _POOL_TRACKER_BIG_PAGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POOL_TRACKER_BIG_PAGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.Va),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.Key),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.Pattern),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.PoolFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.SlushSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.NumberOfBytes),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POOL_TRACKER_BIG_PAGES.ProcessBilled),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_POOL_TRACKER_BIG_PAGES>((mem, ptr) => new _POOL_TRACKER_BIG_PAGES(mem, ptr), offsets);
        }
    }
}