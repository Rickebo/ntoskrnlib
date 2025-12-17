using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_RESOURCE_DESCRIPTOR")]
    public sealed class _IO_RESOURCE_DESCRIPTOR : DynamicStructure
    {
        public byte Option { get; }
        public byte Type { get; }
        public byte ShareDisposition { get; }
        public byte Spare1 { get; }
        public ushort Flags { get; }
        public ushort Spare2 { get; }
        public _unnamed_tag_ u { get; }

        public _IO_RESOURCE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_RESOURCE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.Option),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.ShareDisposition),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.Spare1),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.Spare2),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_DESCRIPTOR.u),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_RESOURCE_DESCRIPTOR>((mem, ptr) => new _IO_RESOURCE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}