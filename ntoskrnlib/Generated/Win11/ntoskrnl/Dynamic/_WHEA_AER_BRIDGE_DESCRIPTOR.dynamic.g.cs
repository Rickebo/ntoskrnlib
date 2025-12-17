using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_AER_BRIDGE_DESCRIPTOR")]
    public sealed class _WHEA_AER_BRIDGE_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }
        public byte Reserved { get; }
        public uint BusNumber { get; }
        public _WHEA_PCI_SLOT_NUMBER Slot { get; }
        public ushort DeviceControl { get; }
        public _AER_BRIDGE_DESCRIPTOR_FLAGS Flags { get; }
        public uint UncorrectableErrorMask { get; }
        public uint UncorrectableErrorSeverity { get; }
        public uint CorrectableErrorMask { get; }
        public uint AdvancedCapsAndControl { get; }
        public uint SecondaryUncorrectableErrorMask { get; }
        public uint SecondaryUncorrectableErrorSev { get; }
        public uint SecondaryCapsAndControl { get; }

        public _WHEA_AER_BRIDGE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_AER_BRIDGE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.BusNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.Slot),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.DeviceControl),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.UncorrectableErrorMask),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.UncorrectableErrorSeverity),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.CorrectableErrorMask),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.AdvancedCapsAndControl),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.SecondaryUncorrectableErrorMask),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.SecondaryUncorrectableErrorSev),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_WHEA_AER_BRIDGE_DESCRIPTOR.SecondaryCapsAndControl),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_WHEA_AER_BRIDGE_DESCRIPTOR>((mem, ptr) => new _WHEA_AER_BRIDGE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}