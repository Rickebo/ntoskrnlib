using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_TIMER")]
    public sealed class IoTimer : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short TimerFlag { get => ReadHere<short>(nameof(TimerFlag)); set => WriteHere(nameof(TimerFlag), value); }

        [Offset(8UL)]
        public ListEntry TimerList { get => ReadStructure<ListEntry>(nameof(TimerList)); set => WriteStructure(nameof(TimerList), value); }

        [Offset(24UL)]
        public IntPtr TimerRoutine { get => ReadHere<IntPtr>(nameof(TimerRoutine)); set => WriteHere(nameof(TimerRoutine), value); }

        [Offset(32UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(40UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        public IoTimer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoTimer>();
        }
    }
}