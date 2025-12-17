using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMADDRESS_LIST")]
    public sealed class _MMADDRESS_LIST : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public IntPtr EndVa { get; }

        public _MMADDRESS_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMADDRESS_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMADDRESS_LIST.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMADDRESS_LIST.EndVa),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MMADDRESS_LIST>((mem, ptr) => new _MMADDRESS_LIST(mem, ptr), offsets);
        }
    }
}