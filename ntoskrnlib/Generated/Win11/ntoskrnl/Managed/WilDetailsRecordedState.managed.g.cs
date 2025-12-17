using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_RecordedState")]
    public sealed class WilDetailsRecordedState : DynamicStructure
    {
        [Offset(0UL)]
        public uint exchange { get => ReadHere<uint>(nameof(exchange)); set => WriteHere(nameof(exchange), value); }

        [Offset(0UL)]
        public uint recordedDeviceUsage { get => ReadHere<uint>(nameof(recordedDeviceUsage)); set => WriteHere(nameof(recordedDeviceUsage), value); }

        [Offset(0UL)]
        public uint recordedDevicePotential { get => ReadHere<uint>(nameof(recordedDevicePotential)); set => WriteHere(nameof(recordedDevicePotential), value); }

        [Offset(0UL)]
        public uint recordedDeviceOpportunity { get => ReadHere<uint>(nameof(recordedDeviceOpportunity)); set => WriteHere(nameof(recordedDeviceOpportunity), value); }

        [Offset(0UL)]
        public uint recordedDevicePotentialOpportunity { get => ReadHere<uint>(nameof(recordedDevicePotentialOpportunity)); set => WriteHere(nameof(recordedDevicePotentialOpportunity), value); }

        [Offset(0UL)]
        public uint recordedVariantDeviceUsage { get => ReadHere<uint>(nameof(recordedVariantDeviceUsage)); set => WriteHere(nameof(recordedVariantDeviceUsage), value); }

        [Offset(0UL)]
        public uint recordedVariant { get => ReadHere<uint>(nameof(recordedVariant)); set => WriteHere(nameof(recordedVariant), value); }

        [Offset(0UL)]
        public uint unused { get => ReadHere<uint>(nameof(unused)); set => WriteHere(nameof(unused), value); }

        public WilDetailsRecordedState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsRecordedState>();
        }
    }
}