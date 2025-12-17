using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OSLOADER_PAGE_TABLE_LOG")]
    public sealed class _OSLOADER_PAGE_TABLE_LOG : DynamicStructure
    {
        public IntPtr LegacyPte { get; }
        public ulong Pfn { get; }
        public uint MemoryType { get; }
        public ulong BasePage { get; }
        public ulong PageCount { get; }

        public _OSLOADER_PAGE_TABLE_LOG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OSLOADER_PAGE_TABLE_LOG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OSLOADER_PAGE_TABLE_LOG.LegacyPte),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OSLOADER_PAGE_TABLE_LOG.Pfn),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OSLOADER_PAGE_TABLE_LOG.MemoryType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OSLOADER_PAGE_TABLE_LOG.BasePage),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OSLOADER_PAGE_TABLE_LOG.PageCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_OSLOADER_PAGE_TABLE_LOG>((mem, ptr) => new _OSLOADER_PAGE_TABLE_LOG(mem, ptr), offsets);
        }
    }
}