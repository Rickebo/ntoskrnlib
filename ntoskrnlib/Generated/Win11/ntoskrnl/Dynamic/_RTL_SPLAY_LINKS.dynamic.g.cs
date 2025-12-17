using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_SPLAY_LINKS")]
    public sealed class _RTL_SPLAY_LINKS : DynamicStructure
    {
        public IntPtr Parent { get; }
        public IntPtr LeftChild { get; }
        public IntPtr RightChild { get; }

        public _RTL_SPLAY_LINKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_SPLAY_LINKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_SPLAY_LINKS.Parent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SPLAY_LINKS.LeftChild),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_SPLAY_LINKS.RightChild),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_SPLAY_LINKS>((mem, ptr) => new _RTL_SPLAY_LINKS(mem, ptr), offsets);
        }
    }
}