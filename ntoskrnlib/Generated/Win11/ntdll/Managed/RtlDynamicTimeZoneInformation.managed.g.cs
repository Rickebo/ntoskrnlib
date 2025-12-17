using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_TIME_ZONE_INFORMATION")]
    public sealed class RtlDynamicTimeZoneInformation : DynamicStructure
    {
        [Offset(0UL)]
        public RtlTimeZoneInformation tzi { get => ReadStructure<RtlTimeZoneInformation>(nameof(tzi)); set => WriteStructure(nameof(tzi), value); }

        [Offset(172UL)]
        [Length(128)]
        public DynamicArray TimeZoneKeyName { get => ReadStructure<DynamicArray>(nameof(TimeZoneKeyName)); set => WriteStructure(nameof(TimeZoneKeyName), value); }

        [Offset(428UL)]
        public byte DynamicDaylightTimeDisabled { get => ReadHere<byte>(nameof(DynamicDaylightTimeDisabled)); set => WriteHere(nameof(DynamicDaylightTimeDisabled), value); }

        public RtlDynamicTimeZoneInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicTimeZoneInformation>();
        }
    }
}