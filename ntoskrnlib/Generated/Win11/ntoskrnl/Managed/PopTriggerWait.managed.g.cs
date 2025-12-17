using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_TRIGGER_WAIT")]
    public sealed class PopTriggerWait : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(24UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(32UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(48UL)]
        public IntPtr Trigger { get => ReadHere<IntPtr>(nameof(Trigger)); set => WriteHere(nameof(Trigger), value); }

        public PopTriggerWait(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopTriggerWait>();
        }
    }
}