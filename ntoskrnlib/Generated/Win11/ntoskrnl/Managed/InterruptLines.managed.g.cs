using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINES")]
    public sealed class InterruptLines : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint ControllerId { get => ReadHere<uint>(nameof(ControllerId)); set => WriteHere(nameof(ControllerId), value); }

        [Offset(20UL)]
        public int MinLine { get => ReadHere<int>(nameof(MinLine)); set => WriteHere(nameof(MinLine), value); }

        [Offset(24UL)]
        public int MaxLine { get => ReadHere<int>(nameof(MaxLine)); set => WriteHere(nameof(MaxLine), value); }

        [Offset(28UL)]
        public uint GsiBase { get => ReadHere<uint>(nameof(GsiBase)); set => WriteHere(nameof(GsiBase), value); }

        [Offset(32UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(36UL)]
        public uint SubType { get => ReadHere<uint>(nameof(SubType)); set => WriteHere(nameof(SubType), value); }

        [Offset(40UL)]
        public IntPtr State { get => ReadHere<IntPtr>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(48UL)]
        public IntPtr InternalState { get => ReadHere<IntPtr>(nameof(InternalState)); set => WriteHere(nameof(InternalState), value); }

        [Offset(56UL)]
        public ulong MsiAddress { get => ReadHere<ulong>(nameof(MsiAddress)); set => WriteHere(nameof(MsiAddress), value); }

        [Offset(64UL)]
        public uint MsiData { get => ReadHere<uint>(nameof(MsiData)); set => WriteHere(nameof(MsiData), value); }

        [Offset(72UL)]
        public RtlBitmap MsiInUse { get => ReadStructure<RtlBitmap>(nameof(MsiInUse)); set => WriteStructure(nameof(MsiInUse), value); }

        public InterruptLines(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptLines>();
        }
    }
}