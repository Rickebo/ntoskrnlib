using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_APIC_REGISTERS")]
    public sealed class _IO_APIC_REGISTERS : DynamicStructure
    {
        public uint RegisterIndex { get; }
        public uint[] Reserved1 { get; }
        public uint RegisterValue { get; }
        public uint[] Reserved2 { get; }
        public uint EndOfInterrupt { get; }

        public _IO_APIC_REGISTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_APIC_REGISTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_APIC_REGISTERS.RegisterIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_APIC_REGISTERS.Reserved1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_APIC_REGISTERS.RegisterValue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_APIC_REGISTERS.Reserved2),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IO_APIC_REGISTERS.EndOfInterrupt),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_IO_APIC_REGISTERS>((mem, ptr) => new _IO_APIC_REGISTERS(mem, ptr), offsets);
        }
    }
}