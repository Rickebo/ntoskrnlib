using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_INTERFACE")]
    public sealed class PowerLimitInterface : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(16UL)]
        public IntPtr InterfaceReference { get => ReadHere<IntPtr>(nameof(InterfaceReference)); set => WriteHere(nameof(InterfaceReference), value); }

        [Offset(24UL)]
        public IntPtr InterfaceDereference { get => ReadHere<IntPtr>(nameof(InterfaceDereference)); set => WriteHere(nameof(InterfaceDereference), value); }

        [Offset(32UL)]
        public uint DomainCount { get => ReadHere<uint>(nameof(DomainCount)); set => WriteHere(nameof(DomainCount), value); }

        [Offset(40UL)]
        public IntPtr QueryAttributes { get => ReadHere<IntPtr>(nameof(QueryAttributes)); set => WriteHere(nameof(QueryAttributes), value); }

        [Offset(48UL)]
        public IntPtr SetPowerLimit { get => ReadHere<IntPtr>(nameof(SetPowerLimit)); set => WriteHere(nameof(SetPowerLimit), value); }

        [Offset(56UL)]
        public IntPtr QueryPowerLimit { get => ReadHere<IntPtr>(nameof(QueryPowerLimit)); set => WriteHere(nameof(QueryPowerLimit), value); }

        public PowerLimitInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerLimitInterface>();
        }
    }
}