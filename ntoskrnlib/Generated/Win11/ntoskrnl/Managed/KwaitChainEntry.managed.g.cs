using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KWAIT_CHAIN_ENTRY")]
    public sealed class KwaitChainEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(24UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(48UL)]
        public IntPtr AbLockHandle { get => ReadHere<IntPtr>(nameof(AbLockHandle)); set => WriteHere(nameof(AbLockHandle), value); }

        public KwaitChainEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KwaitChainEntry>();
        }
    }
}