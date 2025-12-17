using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_NUMBER")]
    public sealed class _PROCESSOR_NUMBER : DynamicStructure
    {
        public ushort Group { get; }
        public byte Number { get; }
        public byte Reserved { get; }

        public _PROCESSOR_NUMBER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_NUMBER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_NUMBER.Group),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_NUMBER.Number),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCESSOR_NUMBER.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_PROCESSOR_NUMBER>((mem, ptr) => new _PROCESSOR_NUMBER(mem, ptr), offsets);
        }
    }
}