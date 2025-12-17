using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_RecordedState")]
    public sealed class wil_details_RecordedState : DynamicStructure
    {
        public uint exchange { get; }
        public uint recordedDeviceUsage { get; }
        public uint recordedDevicePotential { get; }
        public uint recordedDeviceOpportunity { get; }
        public uint recordedDevicePotentialOpportunity { get; }
        public uint recordedVariantDeviceUsage { get; }
        public uint recordedVariant { get; }
        public uint unused { get; }

        public wil_details_RecordedState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_RecordedState()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_RecordedState.exchange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedDeviceUsage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedDevicePotential),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedDeviceOpportunity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedDevicePotentialOpportunity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedVariantDeviceUsage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.recordedVariant),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordedState.unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<wil_details_RecordedState>((mem, ptr) => new wil_details_RecordedState(mem, ptr), offsets);
        }
    }
}