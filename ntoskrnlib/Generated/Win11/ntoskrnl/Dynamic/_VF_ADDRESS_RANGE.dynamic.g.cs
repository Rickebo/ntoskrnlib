using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_ADDRESS_RANGE")]
    public sealed class _VF_ADDRESS_RANGE : DynamicStructure
    {
        public IntPtr Start { get; }
        public IntPtr End { get; }

        public _VF_ADDRESS_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_ADDRESS_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_ADDRESS_RANGE.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_ADDRESS_RANGE.End),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_VF_ADDRESS_RANGE>((mem, ptr) => new _VF_ADDRESS_RANGE(mem, ptr), offsets);
        }
    }
}