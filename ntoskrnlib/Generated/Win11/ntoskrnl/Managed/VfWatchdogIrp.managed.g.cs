using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_WATCHDOG_IRP")]
    public sealed class VfWatchdogIrp : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public uint DueTickCount { get => ReadHere<uint>(nameof(DueTickCount)); set => WriteHere(nameof(DueTickCount), value); }

        [Offset(28UL)]
        public byte Inserted { get => ReadHere<byte>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        [Offset(29UL)]
        public sbyte TrackedStackLocation { get => ReadHere<sbyte>(nameof(TrackedStackLocation)); set => WriteHere(nameof(TrackedStackLocation), value); }

        [Offset(30UL)]
        public ushort CancelTimeoutTicks { get => ReadHere<ushort>(nameof(CancelTimeoutTicks)); set => WriteHere(nameof(CancelTimeoutTicks), value); }

        public VfWatchdogIrp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfWatchdogIrp>();
        }
    }
}