using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!SYSTEM_POWER_LEVEL")]
    public sealed class SystemPowerLevel : DynamicStructure
    {
        [Offset(0UL)]
        public byte Enable { get => ReadHere<byte>(nameof(Enable)); set => WriteHere(nameof(Enable), value); }

        [Offset(1UL)]
        [Length(3)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(4UL)]
        public uint BatteryLevel { get => ReadHere<uint>(nameof(BatteryLevel)); set => WriteHere(nameof(BatteryLevel), value); }

        [Offset(8UL)]
        public PowerActionPolicy PowerPolicy { get => ReadStructure<PowerActionPolicy>(nameof(PowerPolicy)); set => WriteStructure(nameof(PowerPolicy), value); }

        [Offset(20UL)]
        public uint MinSystemState { get => ReadHere<uint>(nameof(MinSystemState)); set => WriteHere(nameof(MinSystemState), value); }

        public SystemPowerLevel(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SystemPowerLevel>();
        }
    }
}