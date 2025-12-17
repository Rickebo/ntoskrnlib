using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ISA_VECTOR")]
    public sealed class _ISA_VECTOR : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte Bus { get; }
        public byte Source { get; }
        public uint GlobalSystemInterruptVector { get; }
        public ushort Flags { get; }

        public _ISA_VECTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ISA_VECTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ISA_VECTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ISA_VECTOR.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ISA_VECTOR.Bus),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ISA_VECTOR.Source),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_ISA_VECTOR.GlobalSystemInterruptVector),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ISA_VECTOR.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ISA_VECTOR>((mem, ptr) => new _ISA_VECTOR(mem, ptr), offsets);
        }
    }
}