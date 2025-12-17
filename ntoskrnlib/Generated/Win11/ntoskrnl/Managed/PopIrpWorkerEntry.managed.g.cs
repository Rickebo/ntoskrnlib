using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_IRP_WORKER_ENTRY")]
    public sealed class PopIrpWorkerEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(24UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(32UL)]
        public IntPtr Device { get => ReadHere<IntPtr>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(40UL)]
        public byte Static { get => ReadHere<byte>(nameof(Static)); set => WriteHere(nameof(Static), value); }

        public PopIrpWorkerEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopIrpWorkerEntry>();
        }
    }
}