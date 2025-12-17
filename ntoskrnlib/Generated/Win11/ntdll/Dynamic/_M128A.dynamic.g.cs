using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_M128A")]
    public sealed class _M128A : DynamicStructure
    {
        public ulong Low { get; }
        public long High { get; }

        public _M128A(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _M128A()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_M128A.Low),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_M128A.High),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_M128A>((mem, ptr) => new _M128A(mem, ptr), offsets);
        }
    }
}