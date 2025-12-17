using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_BALANCED_NODE")]
    public sealed class _RTL_BALANCED_NODE : DynamicStructure
    {
        public byte[] Children { get; }
        public IntPtr Left { get; }
        public IntPtr Right { get; }
        public byte Red { get; }
        public byte Balance { get; }
        public ulong ParentValue { get; }

        public _RTL_BALANCED_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_BALANCED_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_BALANCED_NODE.Children),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_NODE.Left),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_NODE.Right),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_NODE.Red),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_NODE.Balance),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_BALANCED_NODE.ParentValue),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_BALANCED_NODE>((mem, ptr) => new _RTL_BALANCED_NODE(mem, ptr), offsets);
        }
    }
}