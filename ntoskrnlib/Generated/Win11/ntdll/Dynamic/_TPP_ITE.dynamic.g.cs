using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_ITE")]
    public sealed class _TPP_ITE : DynamicStructure
    {
        public IntPtr First { get; }

        public _TPP_ITE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_ITE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_ITE.First),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_ITE>((mem, ptr) => new _TPP_ITE(mem, ptr), offsets);
        }
    }
}