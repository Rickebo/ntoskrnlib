using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KAPC")]
    public sealed class Kapc : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte AllFlags { get => ReadHere<byte>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        [Offset(1UL)]
        public byte CallbackDataContext { get => ReadHere<byte>(nameof(CallbackDataContext)); set => WriteHere(nameof(CallbackDataContext), value); }

        [Offset(1UL)]
        public byte Unused { get => ReadHere<byte>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(2UL)]
        public byte Size { get => ReadHere<byte>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(3UL)]
        public byte SpareByte1 { get => ReadHere<byte>(nameof(SpareByte1)); set => WriteHere(nameof(SpareByte1), value); }

        [Offset(4UL)]
        public uint SpareLong0 { get => ReadHere<uint>(nameof(SpareLong0)); set => WriteHere(nameof(SpareLong0), value); }

        [Offset(8UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(16UL)]
        public ListEntry ApcListEntry { get => ReadStructure<ListEntry>(nameof(ApcListEntry)); set => WriteStructure(nameof(ApcListEntry), value); }

        [Offset(32UL)]
        public IntPtr KernelRoutine { get => ReadHere<IntPtr>(nameof(KernelRoutine)); set => WriteHere(nameof(KernelRoutine), value); }

        [Offset(40UL)]
        public IntPtr RundownRoutine { get => ReadHere<IntPtr>(nameof(RundownRoutine)); set => WriteHere(nameof(RundownRoutine), value); }

        [Offset(48UL)]
        public IntPtr NormalRoutine { get => ReadHere<IntPtr>(nameof(NormalRoutine)); set => WriteHere(nameof(NormalRoutine), value); }

        [Offset(32UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(56UL)]
        public IntPtr NormalContext { get => ReadHere<IntPtr>(nameof(NormalContext)); set => WriteHere(nameof(NormalContext), value); }

        [Offset(64UL)]
        public IntPtr SystemArgument1 { get => ReadHere<IntPtr>(nameof(SystemArgument1)); set => WriteHere(nameof(SystemArgument1), value); }

        [Offset(72UL)]
        public IntPtr SystemArgument2 { get => ReadHere<IntPtr>(nameof(SystemArgument2)); set => WriteHere(nameof(SystemArgument2), value); }

        [Offset(80UL)]
        public sbyte ApcStateIndex { get => ReadHere<sbyte>(nameof(ApcStateIndex)); set => WriteHere(nameof(ApcStateIndex), value); }

        [Offset(81UL)]
        public sbyte ApcMode { get => ReadHere<sbyte>(nameof(ApcMode)); set => WriteHere(nameof(ApcMode), value); }

        [Offset(82UL)]
        public byte Inserted { get => ReadHere<byte>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        public Kapc(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kapc>();
        }
    }
}