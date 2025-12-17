using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_REFCOUNT")]
    public sealed class _TPP_REFCOUNT : DynamicStructure
    {
        public int Refcount { get; }

        public _TPP_REFCOUNT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_REFCOUNT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_REFCOUNT.Refcount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_REFCOUNT>((mem, ptr) => new _TPP_REFCOUNT(mem, ptr), offsets);
        }
    }
}