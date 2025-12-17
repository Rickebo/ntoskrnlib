using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPFN")]
    public sealed class _MMPFN : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _RTL_BALANCED_NODE TreeNode { get; }
        public _MIPFNFLINK u1 { get; }
        public IntPtr PteAddress { get; }
        public ulong PteLong { get; }
        public _MMPTE OriginalPte { get; }
        public _MIPFNBLINK u2 { get; }
        public _unnamed_tag_ u3 { get; }
        public _MI_PFN_FLAGS5 u5 { get; }
        public _MI_PFN_FLAGS4 u4 { get; }

        public _MMPFN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPFN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPFN.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFN.TreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFN.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFN.PteAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMPFN.PteLong),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMPFN.OriginalPte),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMPFN.u2),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMPFN.u3),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMPFN.u5),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MMPFN.u4),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MMPFN>((mem, ptr) => new _MMPFN(mem, ptr), offsets);
        }
    }
}