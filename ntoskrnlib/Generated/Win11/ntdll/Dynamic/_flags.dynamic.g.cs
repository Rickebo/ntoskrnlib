using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_flags")]
    public sealed class _flags : DynamicStructure
    {
        public byte SmtSetsPresent { get; }
        public byte Fill { get; }

        public _flags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _flags()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_flags.SmtSetsPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_flags.Fill),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_flags>((mem, ptr) => new _flags(mem, ptr), offsets);
        }
    }
}