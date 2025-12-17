using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_APIC_DATA")]
    public sealed class IoApicData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PhysicalAddress { get => ReadHere<ulong>(nameof(PhysicalAddress)); set => WriteHere(nameof(PhysicalAddress), value); }

        [Offset(8UL)]
        public uint Identifier { get => ReadHere<uint>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        [Offset(16UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(24UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(25UL)]
        public byte PinCount { get => ReadHere<byte>(nameof(PinCount)); set => WriteHere(nameof(PinCount), value); }

        [Offset(26UL)]
        public byte Initialized { get => ReadHere<byte>(nameof(Initialized)); set => WriteHere(nameof(Initialized), value); }

        [Offset(27UL)]
        public byte InitializedFirstLocalUnit { get => ReadHere<byte>(nameof(InitializedFirstLocalUnit)); set => WriteHere(nameof(InitializedFirstLocalUnit), value); }

        [Offset(28UL)]
        public uint GsiBase { get => ReadHere<uint>(nameof(GsiBase)); set => WriteHere(nameof(GsiBase), value); }

        [Offset(32UL)]
        public uint CmciRegister { get => ReadHere<uint>(nameof(CmciRegister)); set => WriteHere(nameof(CmciRegister), value); }

        [Offset(36UL)]
        public uint DeferredErrorRegister { get => ReadHere<uint>(nameof(DeferredErrorRegister)); set => WriteHere(nameof(DeferredErrorRegister), value); }

        [Offset(40UL)]
        public byte IoUnitMissing { get => ReadHere<byte>(nameof(IoUnitMissing)); set => WriteHere(nameof(IoUnitMissing), value); }

        public IoApicData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoApicData>();
        }
    }
}