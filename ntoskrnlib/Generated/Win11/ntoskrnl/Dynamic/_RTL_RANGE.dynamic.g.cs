using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_RANGE")]
    public sealed class _RTL_RANGE : DynamicStructure
    {
        public ulong Start { get; }
        public ulong End { get; }
        public IntPtr UserData { get; }
        public IntPtr Owner { get; }
        public byte Attributes { get; }
        public byte Flags { get; }

        public _RTL_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_RANGE.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_RANGE.End),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_RANGE.UserData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_RANGE.Owner),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_RANGE.Attributes),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_RANGE.Flags),
                    new ulong[]
                    {
                        33UL
                    }
                }
            };
            Register<_RTL_RANGE>((mem, ptr) => new _RTL_RANGE(mem, ptr), offsets);
        }
    }
}