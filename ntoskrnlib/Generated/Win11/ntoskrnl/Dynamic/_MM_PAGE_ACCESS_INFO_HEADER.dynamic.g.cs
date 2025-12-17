using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO_HEADER")]
    public sealed class _MM_PAGE_ACCESS_INFO_HEADER : DynamicStructure
    {
        public _SINGLE_LIST_ENTRY Link { get; }
        public uint Type { get; }
        public uint EmptySequenceNumber { get; }
        public uint CurrentFileIndex { get; }
        public ulong CreateTime { get; }
        public ulong EmptyTime { get; }
        public IntPtr TempEntry { get; }
        public IntPtr PageEntry { get; }
        public IntPtr FileEntry { get; }
        public IntPtr FirstFileEntry { get; }
        public IntPtr Process { get; }
        public IntPtr PageFrameEntry { get; }
        public IntPtr LastPageFrameEntry { get; }

        public _MM_PAGE_ACCESS_INFO_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_PAGE_ACCESS_INFO_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.Type),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.EmptySequenceNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.CurrentFileIndex),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.CreateTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.EmptyTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.TempEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.PageEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.FileEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.FirstFileEntry),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.Process),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.PageFrameEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_HEADER.LastPageFrameEntry),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MM_PAGE_ACCESS_INFO_HEADER>((mem, ptr) => new _MM_PAGE_ACCESS_INFO_HEADER(mem, ptr), offsets);
        }
    }
}