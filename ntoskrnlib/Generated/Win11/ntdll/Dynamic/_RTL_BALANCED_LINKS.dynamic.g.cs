using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_BALANCED_LINKS")]
    public sealed class _RTL_BALANCED_LINKS : DynamicStructure
    {
        public IntPtr Parent { get; }
        public IntPtr LeftChild { get; }
        public IntPtr RightChild { get; }
        public sbyte Balance { get; }
        public byte[] Reserved { get; }

        public _RTL_BALANCED_LINKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_BALANCED_LINKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_BALANCED_LINKS.Parent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_LINKS.LeftChild),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_LINKS.RightChild),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_LINKS.Balance),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_LINKS.Reserved),
                    new ulong[]
                    {
                        25UL
                    }
                }
            };
            Register<_RTL_BALANCED_LINKS>((mem, ptr) => new _RTL_BALANCED_LINKS(mem, ptr), offsets);
        }
    }
}