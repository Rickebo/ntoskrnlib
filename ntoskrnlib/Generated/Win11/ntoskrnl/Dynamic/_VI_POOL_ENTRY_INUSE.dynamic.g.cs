using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_POOL_ENTRY_INUSE")]
    public sealed class _VI_POOL_ENTRY_INUSE : DynamicStructure
    {
        public IntPtr VirtualAddress { get; }
        public IntPtr CallingAddress { get; }
        public ulong NumberOfBytes { get; }
        public ulong Tag { get; }

        public _VI_POOL_ENTRY_INUSE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_POOL_ENTRY_INUSE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_POOL_ENTRY_INUSE.VirtualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_POOL_ENTRY_INUSE.CallingAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_POOL_ENTRY_INUSE.NumberOfBytes),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VI_POOL_ENTRY_INUSE.Tag),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_VI_POOL_ENTRY_INUSE>((mem, ptr) => new _VI_POOL_ENTRY_INUSE(mem, ptr), offsets);
        }
    }
}