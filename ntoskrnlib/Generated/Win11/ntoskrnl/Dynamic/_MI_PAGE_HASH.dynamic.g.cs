using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_HASH")]
    public sealed class _MI_PAGE_HASH : DynamicStructure
    {
        public uint HashValue { get; }
        public uint PageFileOffset { get; }
        public IntPtr OwningPte { get; }

        public _MI_PAGE_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGE_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGE_HASH.HashValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_HASH.PageFileOffset),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PAGE_HASH.OwningPte),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_PAGE_HASH>((mem, ptr) => new _MI_PAGE_HASH(mem, ptr), offsets);
        }
    }
}