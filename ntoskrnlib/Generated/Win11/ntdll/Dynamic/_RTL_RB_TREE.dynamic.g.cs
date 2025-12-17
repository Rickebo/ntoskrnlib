using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_RB_TREE")]
    public sealed class _RTL_RB_TREE : DynamicStructure
    {
        public IntPtr Root { get; }
        public byte Encoded { get; }
        public IntPtr Min { get; }

        public _RTL_RB_TREE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_RB_TREE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_RB_TREE.Root),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_RB_TREE.Encoded),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_RB_TREE.Min),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_RB_TREE>((mem, ptr) => new _RTL_RB_TREE(mem, ptr), offsets);
        }
    }
}