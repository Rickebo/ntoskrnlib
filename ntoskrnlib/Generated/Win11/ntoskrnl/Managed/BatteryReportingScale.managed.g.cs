using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!BATTERY_REPORTING_SCALE")]
    public sealed class BatteryReportingScale : DynamicStructure
    {
        [Offset(0UL)]
        public uint Granularity { get => ReadHere<uint>(nameof(Granularity)); set => WriteHere(nameof(Granularity), value); }

        [Offset(4UL)]
        public uint Capacity { get => ReadHere<uint>(nameof(Capacity)); set => WriteHere(nameof(Capacity), value); }

        public BatteryReportingScale(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BatteryReportingScale>();
        }
    }
}