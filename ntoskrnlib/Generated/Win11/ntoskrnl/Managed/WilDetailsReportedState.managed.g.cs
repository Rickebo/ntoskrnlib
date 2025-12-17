using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_ReportedState")]
    public sealed class WilDetailsReportedState : DynamicStructure
    {
        [Offset(0UL)]
        public uint exchange { get => ReadHere<uint>(nameof(exchange)); set => WriteHere(nameof(exchange), value); }

        [Offset(0UL)]
        public uint queuedForReporting { get => ReadHere<uint>(nameof(queuedForReporting)); set => WriteHere(nameof(queuedForReporting), value); }

        [Offset(0UL)]
        public uint reportedDeviceUsage { get => ReadHere<uint>(nameof(reportedDeviceUsage)); set => WriteHere(nameof(reportedDeviceUsage), value); }

        [Offset(0UL)]
        public uint reportedDevicePotential { get => ReadHere<uint>(nameof(reportedDevicePotential)); set => WriteHere(nameof(reportedDevicePotential), value); }

        [Offset(0UL)]
        public uint reportedDeviceOpportunity { get => ReadHere<uint>(nameof(reportedDeviceOpportunity)); set => WriteHere(nameof(reportedDeviceOpportunity), value); }

        [Offset(0UL)]
        public uint reportedDevicePotentialOpportunity { get => ReadHere<uint>(nameof(reportedDevicePotentialOpportunity)); set => WriteHere(nameof(reportedDevicePotentialOpportunity), value); }

        [Offset(0UL)]
        public uint usageCount { get => ReadHere<uint>(nameof(usageCount)); set => WriteHere(nameof(usageCount), value); }

        [Offset(0UL)]
        public uint usageCountRepresentsPotential { get => ReadHere<uint>(nameof(usageCountRepresentsPotential)); set => WriteHere(nameof(usageCountRepresentsPotential), value); }

        [Offset(0UL)]
        public uint opportunityCount { get => ReadHere<uint>(nameof(opportunityCount)); set => WriteHere(nameof(opportunityCount), value); }

        [Offset(0UL)]
        public uint opportunityCountRepresentsPotential { get => ReadHere<uint>(nameof(opportunityCountRepresentsPotential)); set => WriteHere(nameof(opportunityCountRepresentsPotential), value); }

        [Offset(0UL)]
        public uint unused { get => ReadHere<uint>(nameof(unused)); set => WriteHere(nameof(unused), value); }

        public WilDetailsReportedState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsReportedState>();
        }
    }
}