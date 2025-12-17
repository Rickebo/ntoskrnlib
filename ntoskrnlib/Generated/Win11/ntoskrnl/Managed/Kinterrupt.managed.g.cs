using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KINTERRUPT")]
    public sealed class Kinterrupt : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public ListEntry InterruptListEntry { get => ReadStructure<ListEntry>(nameof(InterruptListEntry)); set => WriteStructure(nameof(InterruptListEntry), value); }

        [Offset(24UL)]
        public IntPtr ServiceRoutine { get => ReadHere<IntPtr>(nameof(ServiceRoutine)); set => WriteHere(nameof(ServiceRoutine), value); }

        [Offset(32UL)]
        public IntPtr MessageServiceRoutine { get => ReadHere<IntPtr>(nameof(MessageServiceRoutine)); set => WriteHere(nameof(MessageServiceRoutine), value); }

        [Offset(40UL)]
        public uint MessageIndex { get => ReadHere<uint>(nameof(MessageIndex)); set => WriteHere(nameof(MessageIndex), value); }

        [Offset(48UL)]
        public IntPtr ServiceContext { get => ReadHere<IntPtr>(nameof(ServiceContext)); set => WriteHere(nameof(ServiceContext), value); }

        [Offset(56UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(64UL)]
        public uint TickCount { get => ReadHere<uint>(nameof(TickCount)); set => WriteHere(nameof(TickCount), value); }

        [Offset(72UL)]
        public IntPtr ActualLock { get => ReadHere<IntPtr>(nameof(ActualLock)); set => WriteHere(nameof(ActualLock), value); }

        [Offset(80UL)]
        public IntPtr DispatchAddress { get => ReadHere<IntPtr>(nameof(DispatchAddress)); set => WriteHere(nameof(DispatchAddress), value); }

        [Offset(88UL)]
        public uint Vector { get => ReadHere<uint>(nameof(Vector)); set => WriteHere(nameof(Vector), value); }

        [Offset(92UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(93UL)]
        public byte SynchronizeIrql { get => ReadHere<byte>(nameof(SynchronizeIrql)); set => WriteHere(nameof(SynchronizeIrql), value); }

        [Offset(94UL)]
        public byte FloatingSave { get => ReadHere<byte>(nameof(FloatingSave)); set => WriteHere(nameof(FloatingSave), value); }

        [Offset(95UL)]
        public byte Connected { get => ReadHere<byte>(nameof(Connected)); set => WriteHere(nameof(Connected), value); }

        [Offset(96UL)]
        public uint Number { get => ReadHere<uint>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        [Offset(100UL)]
        public byte ShareVector { get => ReadHere<byte>(nameof(ShareVector)); set => WriteHere(nameof(ShareVector), value); }

        [Offset(101UL)]
        public byte EmulateActiveBoth { get => ReadHere<byte>(nameof(EmulateActiveBoth)); set => WriteHere(nameof(EmulateActiveBoth), value); }

        [Offset(102UL)]
        public ushort ActiveCount { get => ReadHere<ushort>(nameof(ActiveCount)); set => WriteHere(nameof(ActiveCount), value); }

        [Offset(104UL)]
        public int InternalState { get => ReadHere<int>(nameof(InternalState)); set => WriteHere(nameof(InternalState), value); }

        [Offset(108UL)]
        public uint Mode { get => ReadHere<uint>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(112UL)]
        public uint Polarity { get => ReadHere<uint>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(116UL)]
        public uint ServiceCount { get => ReadHere<uint>(nameof(ServiceCount)); set => WriteHere(nameof(ServiceCount), value); }

        [Offset(120UL)]
        public uint DispatchCount { get => ReadHere<uint>(nameof(DispatchCount)); set => WriteHere(nameof(DispatchCount), value); }

        [Offset(128UL)]
        public IntPtr PassiveEvent { get => ReadHere<IntPtr>(nameof(PassiveEvent)); set => WriteHere(nameof(PassiveEvent), value); }

        [Offset(136UL)]
        public IntPtr TrapFrame { get => ReadHere<IntPtr>(nameof(TrapFrame)); set => WriteHere(nameof(TrapFrame), value); }

        [Offset(144UL)]
        public IntPtr DisconnectData { get => ReadHere<IntPtr>(nameof(DisconnectData)); set => WriteHere(nameof(DisconnectData), value); }

        [Offset(152UL)]
        public IntPtr ServiceThread { get => ReadHere<IntPtr>(nameof(ServiceThread)); set => WriteHere(nameof(ServiceThread), value); }

        [Offset(160UL)]
        public IntPtr ConnectionData { get => ReadHere<IntPtr>(nameof(ConnectionData)); set => WriteHere(nameof(ConnectionData), value); }

        [Offset(168UL)]
        public IntPtr IntTrackEntry { get => ReadHere<IntPtr>(nameof(IntTrackEntry)); set => WriteHere(nameof(IntTrackEntry), value); }

        [Offset(176UL)]
        public Isrdpcstats IsrDpcStats { get => ReadStructure<Isrdpcstats>(nameof(IsrDpcStats)); set => WriteStructure(nameof(IsrDpcStats), value); }

        [Offset(272UL)]
        public IntPtr RedirectObject { get => ReadHere<IntPtr>(nameof(RedirectObject)); set => WriteHere(nameof(RedirectObject), value); }

        [Offset(280UL)]
        [Length(8)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        public Kinterrupt(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kinterrupt>();
        }
    }
}