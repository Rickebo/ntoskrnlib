using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ACCESS_VIOLATION_RANGE")]
    public sealed class _MI_ACCESS_VIOLATION_RANGE : DynamicStructure
    {
        public _RTL_BALANCED_NODE Node { get; }
        public IntPtr Va { get; }
        public IntPtr EndVaInclusive { get; }

        public _MI_ACCESS_VIOLATION_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ACCESS_VIOLATION_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ACCESS_VIOLATION_RANGE.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ACCESS_VIOLATION_RANGE.Va),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_ACCESS_VIOLATION_RANGE.EndVaInclusive),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_MI_ACCESS_VIOLATION_RANGE>((mem, ptr) => new _MI_ACCESS_VIOLATION_RANGE(mem, ptr), offsets);
        }
    }
}