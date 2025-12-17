using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER")]
    public sealed class Ktimer : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        public UlargeInteger DueTime { get => ReadStructure<UlargeInteger>(nameof(DueTime)); set => WriteStructure(nameof(DueTime), value); }

        [Offset(32UL)]
        public ListEntry TimerListEntry { get => ReadStructure<ListEntry>(nameof(TimerListEntry)); set => WriteStructure(nameof(TimerListEntry), value); }

        [Offset(48UL)]
        public IntPtr Dpc { get => ReadHere<IntPtr>(nameof(Dpc)); set => WriteHere(nameof(Dpc), value); }

        [Offset(56UL)]
        public ushort Processor { get => ReadHere<ushort>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        [Offset(58UL)]
        public ushort TimerType { get => ReadHere<ushort>(nameof(TimerType)); set => WriteHere(nameof(TimerType), value); }

        [Offset(60UL)]
        public uint Period { get => ReadHere<uint>(nameof(Period)); set => WriteHere(nameof(Period), value); }

        public Ktimer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ktimer>();
        }
    }
}