using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IRP")]
    public sealed class Irp : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr MdlAddress { get => ReadHere<IntPtr>(nameof(MdlAddress)); set => WriteHere(nameof(MdlAddress), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(24UL)]
        public UnnamedTag AssociatedIrp { get => ReadStructure<UnnamedTag>(nameof(AssociatedIrp)); set => WriteStructure(nameof(AssociatedIrp), value); }

        [Offset(32UL)]
        public ListEntry ThreadListEntry { get => ReadStructure<ListEntry>(nameof(ThreadListEntry)); set => WriteStructure(nameof(ThreadListEntry), value); }

        [Offset(48UL)]
        public IoStatusBlock IoStatus { get => ReadStructure<IoStatusBlock>(nameof(IoStatus)); set => WriteStructure(nameof(IoStatus), value); }

        [Offset(64UL)]
        public sbyte RequestorMode { get => ReadHere<sbyte>(nameof(RequestorMode)); set => WriteHere(nameof(RequestorMode), value); }

        [Offset(65UL)]
        public byte PendingReturned { get => ReadHere<byte>(nameof(PendingReturned)); set => WriteHere(nameof(PendingReturned), value); }

        [Offset(66UL)]
        public sbyte StackCount { get => ReadHere<sbyte>(nameof(StackCount)); set => WriteHere(nameof(StackCount), value); }

        [Offset(67UL)]
        public sbyte CurrentLocation { get => ReadHere<sbyte>(nameof(CurrentLocation)); set => WriteHere(nameof(CurrentLocation), value); }

        [Offset(68UL)]
        public byte Cancel { get => ReadHere<byte>(nameof(Cancel)); set => WriteHere(nameof(Cancel), value); }

        [Offset(69UL)]
        public byte CancelIrql { get => ReadHere<byte>(nameof(CancelIrql)); set => WriteHere(nameof(CancelIrql), value); }

        [Offset(70UL)]
        public sbyte ApcEnvironment { get => ReadHere<sbyte>(nameof(ApcEnvironment)); set => WriteHere(nameof(ApcEnvironment), value); }

        [Offset(71UL)]
        public byte AllocationFlags { get => ReadHere<byte>(nameof(AllocationFlags)); set => WriteHere(nameof(AllocationFlags), value); }

        [Offset(72UL)]
        public IntPtr UserIosb { get => ReadHere<IntPtr>(nameof(UserIosb)); set => WriteHere(nameof(UserIosb), value); }

        [Offset(72UL)]
        public IntPtr IoRingContext { get => ReadHere<IntPtr>(nameof(IoRingContext)); set => WriteHere(nameof(IoRingContext), value); }

        [Offset(80UL)]
        public IntPtr UserEvent { get => ReadHere<IntPtr>(nameof(UserEvent)); set => WriteHere(nameof(UserEvent), value); }

        [Offset(88UL)]
        public UnnamedTag Overlay { get => ReadStructure<UnnamedTag>(nameof(Overlay)); set => WriteStructure(nameof(Overlay), value); }

        [Offset(104UL)]
        public IntPtr CancelRoutine { get => ReadHere<IntPtr>(nameof(CancelRoutine)); set => WriteHere(nameof(CancelRoutine), value); }

        [Offset(112UL)]
        public IntPtr UserBuffer { get => ReadHere<IntPtr>(nameof(UserBuffer)); set => WriteHere(nameof(UserBuffer), value); }

        [Offset(120UL)]
        public UnnamedTag Tail { get => ReadStructure<UnnamedTag>(nameof(Tail)); set => WriteStructure(nameof(Tail), value); }

        public Irp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Irp>();
        }
    }
}