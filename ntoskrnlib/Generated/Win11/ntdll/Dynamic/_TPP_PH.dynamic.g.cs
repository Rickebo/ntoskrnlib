using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_PH")]
    public sealed class _TPP_PH : DynamicStructure
    {
        public IntPtr Root { get; }

        public _TPP_PH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_PH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_PH.Root),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_PH>((mem, ptr) => new _TPP_PH(mem, ptr), offsets);
        }
    }
}