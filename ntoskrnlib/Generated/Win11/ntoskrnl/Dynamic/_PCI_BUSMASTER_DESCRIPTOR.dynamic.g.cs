using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCI_BUSMASTER_DESCRIPTOR")]
    public sealed class _PCI_BUSMASTER_DESCRIPTOR : DynamicStructure
    {
        public uint Type { get; }
        public uint Segment { get; }
        public _unnamed_tag_ DeviceRid { get; }
        public _unnamed_tag_ BridgeRid { get; }
        public _unnamed_tag_ MultipleBridges { get; }

        public _PCI_BUSMASTER_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCI_BUSMASTER_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCI_BUSMASTER_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCI_BUSMASTER_DESCRIPTOR.Segment),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PCI_BUSMASTER_DESCRIPTOR.DeviceRid),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PCI_BUSMASTER_DESCRIPTOR.BridgeRid),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PCI_BUSMASTER_DESCRIPTOR.MultipleBridges),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PCI_BUSMASTER_DESCRIPTOR>((mem, ptr) => new _PCI_BUSMASTER_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}