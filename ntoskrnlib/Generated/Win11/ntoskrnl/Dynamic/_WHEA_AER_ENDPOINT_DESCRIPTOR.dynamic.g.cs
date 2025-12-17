using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_AER_ENDPOINT_DESCRIPTOR")]
    public sealed class _WHEA_AER_ENDPOINT_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }
        public byte Reserved { get; }
        public uint BusNumber { get; }
        public _WHEA_PCI_SLOT_NUMBER Slot { get; }
        public ushort DeviceControl { get; }
        public _AER_ENDPOINT_DESCRIPTOR_FLAGS Flags { get; }
        public uint UncorrectableErrorMask { get; }
        public uint UncorrectableErrorSeverity { get; }
        public uint CorrectableErrorMask { get; }
        public uint AdvancedCapsAndControl { get; }

        public _WHEA_AER_ENDPOINT_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_AER_ENDPOINT_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.BusNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.Slot),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.DeviceControl),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.UncorrectableErrorMask),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.UncorrectableErrorSeverity),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.CorrectableErrorMask),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_AER_ENDPOINT_DESCRIPTOR.AdvancedCapsAndControl),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_WHEA_AER_ENDPOINT_DESCRIPTOR>((mem, ptr) => new _WHEA_AER_ENDPOINT_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}