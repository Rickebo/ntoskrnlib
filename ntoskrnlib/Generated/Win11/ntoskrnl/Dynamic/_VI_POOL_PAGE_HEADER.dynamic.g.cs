using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_POOL_PAGE_HEADER")]
    public sealed class _VI_POOL_PAGE_HEADER : DynamicStructure
    {
        public IntPtr NextPage { get; }
        public IntPtr VerifierEntry { get; }
        public ulong Signature { get; }

        public _VI_POOL_PAGE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_POOL_PAGE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_POOL_PAGE_HEADER.NextPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_POOL_PAGE_HEADER.VerifierEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_POOL_PAGE_HEADER.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_VI_POOL_PAGE_HEADER>((mem, ptr) => new _VI_POOL_PAGE_HEADER(mem, ptr), offsets);
        }
    }
}