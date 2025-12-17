using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_TIME_ZONE_INFORMATION")]
    public sealed class RtlTimeZoneInformation : DynamicStructure
    {
        [Offset(0UL)]
        public int Bias { get => ReadHere<int>(nameof(Bias)); set => WriteHere(nameof(Bias), value); }

        [Offset(4UL)]
        [Length(32)]
        public DynamicArray StandardName { get => ReadStructure<DynamicArray>(nameof(StandardName)); set => WriteStructure(nameof(StandardName), value); }

        [Offset(68UL)]
        public TimeFields StandardStart { get => ReadStructure<TimeFields>(nameof(StandardStart)); set => WriteStructure(nameof(StandardStart), value); }

        [Offset(84UL)]
        public int StandardBias { get => ReadHere<int>(nameof(StandardBias)); set => WriteHere(nameof(StandardBias), value); }

        [Offset(88UL)]
        [Length(32)]
        public DynamicArray DaylightName { get => ReadStructure<DynamicArray>(nameof(DaylightName)); set => WriteStructure(nameof(DaylightName), value); }

        [Offset(152UL)]
        public TimeFields DaylightStart { get => ReadStructure<TimeFields>(nameof(DaylightStart)); set => WriteStructure(nameof(DaylightStart), value); }

        [Offset(168UL)]
        public int DaylightBias { get => ReadHere<int>(nameof(DaylightBias)); set => WriteHere(nameof(DaylightBias), value); }

        public RtlTimeZoneInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlTimeZoneInformation>();
        }
    }
}