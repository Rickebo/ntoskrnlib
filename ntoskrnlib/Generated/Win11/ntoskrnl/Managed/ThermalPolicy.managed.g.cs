using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_THERMAL_POLICY")]
    public sealed class ThermalPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public byte WaitForUpdate { get => ReadHere<byte>(nameof(WaitForUpdate)); set => WriteHere(nameof(WaitForUpdate), value); }

        [Offset(5UL)]
        public byte Hibernate { get => ReadHere<byte>(nameof(Hibernate)); set => WriteHere(nameof(Hibernate), value); }

        [Offset(6UL)]
        public byte Critical { get => ReadHere<byte>(nameof(Critical)); set => WriteHere(nameof(Critical), value); }

        [Offset(7UL)]
        public byte ThermalStandby { get => ReadHere<byte>(nameof(ThermalStandby)); set => WriteHere(nameof(ThermalStandby), value); }

        [Offset(8UL)]
        public uint ActivationReasons { get => ReadHere<uint>(nameof(ActivationReasons)); set => WriteHere(nameof(ActivationReasons), value); }

        [Offset(12UL)]
        public uint PassiveLimit { get => ReadHere<uint>(nameof(PassiveLimit)); set => WriteHere(nameof(PassiveLimit), value); }

        [Offset(16UL)]
        public uint ActiveLevel { get => ReadHere<uint>(nameof(ActiveLevel)); set => WriteHere(nameof(ActiveLevel), value); }

        [Offset(20UL)]
        public byte OverThrottled { get => ReadHere<byte>(nameof(OverThrottled)); set => WriteHere(nameof(OverThrottled), value); }

        public ThermalPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThermalPolicy>();
        }
    }
}