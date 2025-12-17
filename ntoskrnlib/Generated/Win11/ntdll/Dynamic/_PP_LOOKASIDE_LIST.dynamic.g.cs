using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PP_LOOKASIDE_LIST")]
    public sealed class _PP_LOOKASIDE_LIST : DynamicStructure
    {
        public IntPtr P { get; }
        public IntPtr L { get; }

        public _PP_LOOKASIDE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PP_LOOKASIDE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PP_LOOKASIDE_LIST.P),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PP_LOOKASIDE_LIST.L),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PP_LOOKASIDE_LIST>((mem, ptr) => new _PP_LOOKASIDE_LIST(mem, ptr), offsets);
        }
    }
}