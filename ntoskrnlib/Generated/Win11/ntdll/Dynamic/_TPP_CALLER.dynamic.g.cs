using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_CALLER")]
    public sealed class _TPP_CALLER : DynamicStructure
    {
        public IntPtr ReturnAddress { get; }

        public _TPP_CALLER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_CALLER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_CALLER.ReturnAddress),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_CALLER>((mem, ptr) => new _TPP_CALLER(mem, ptr), offsets);
        }
    }
}