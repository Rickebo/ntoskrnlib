using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGE_WAIT_STATES")]
    public sealed class MiAvailablePageWaitStates : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(24UL)]
        public uint EventSets { get => ReadHere<uint>(nameof(EventSets)); set => WriteHere(nameof(EventSets), value); }

        public MiAvailablePageWaitStates(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAvailablePageWaitStates>();
        }
    }
}