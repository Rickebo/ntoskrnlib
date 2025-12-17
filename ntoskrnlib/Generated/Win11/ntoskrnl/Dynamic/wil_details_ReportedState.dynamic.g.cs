using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_ReportedState")]
    public sealed class wil_details_ReportedState : DynamicStructure
    {
        public uint exchange { get; }
        public uint queuedForReporting { get; }
        public uint reportedDeviceUsage { get; }
        public uint reportedDevicePotential { get; }
        public uint reportedDeviceOpportunity { get; }
        public uint reportedDevicePotentialOpportunity { get; }
        public uint usageCount { get; }
        public uint usageCountRepresentsPotential { get; }
        public uint opportunityCount { get; }
        public uint opportunityCountRepresentsPotential { get; }
        public uint unused { get; }

        public wil_details_ReportedState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_ReportedState()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_ReportedState.exchange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.queuedForReporting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.reportedDeviceUsage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.reportedDevicePotential),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.reportedDeviceOpportunity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.reportedDevicePotentialOpportunity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.usageCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.usageCountRepresentsPotential),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.opportunityCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.opportunityCountRepresentsPotential),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_ReportedState.unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<wil_details_ReportedState>((mem, ptr) => new wil_details_ReportedState(mem, ptr), offsets);
        }
    }
}