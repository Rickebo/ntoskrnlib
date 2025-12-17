using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WAITING_IRP")]
    public sealed class WaitingIrp : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public IntPtr CompletionRoutine { get => ReadHere<IntPtr>(nameof(CompletionRoutine)); set => WriteHere(nameof(CompletionRoutine), value); }

        [Offset(32UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(40UL)]
        public IntPtr Event { get => ReadHere<IntPtr>(nameof(Event)); set => WriteHere(nameof(Event), value); }

        [Offset(48UL)]
        public uint Information { get => ReadHere<uint>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        [Offset(52UL)]
        public byte BreakAllRH { get => ReadHere<byte>(nameof(BreakAllRH)); set => WriteHere(nameof(BreakAllRH), value); }

        [Offset(53UL)]
        public byte OplockBreakNotify { get => ReadHere<byte>(nameof(OplockBreakNotify)); set => WriteHere(nameof(OplockBreakNotify), value); }

        [Offset(56UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        public WaitingIrp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WaitingIrp>();
        }
    }
}