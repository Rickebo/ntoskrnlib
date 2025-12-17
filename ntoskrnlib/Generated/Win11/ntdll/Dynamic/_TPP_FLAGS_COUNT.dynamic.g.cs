using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_FLAGS_COUNT")]
    public sealed class _TPP_FLAGS_COUNT : DynamicStructure
    {
        public ulong Count { get; }
        public ulong Flags { get; }
        public long Data { get; }

        public _TPP_FLAGS_COUNT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_FLAGS_COUNT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_FLAGS_COUNT.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_FLAGS_COUNT.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_FLAGS_COUNT.Data),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_FLAGS_COUNT>((mem, ptr) => new _TPP_FLAGS_COUNT(mem, ptr), offsets);
        }
    }
}