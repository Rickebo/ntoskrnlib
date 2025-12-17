using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAST_MUTEX")]
    public sealed class FastMutex : DynamicStructure
    {
        [Offset(0UL)]
        public int Count { get => ReadHere<int>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public IntPtr Owner { get => ReadHere<IntPtr>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(16UL)]
        public uint Contention { get => ReadHere<uint>(nameof(Contention)); set => WriteHere(nameof(Contention), value); }

        [Offset(24UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(48UL)]
        public uint OldIrql { get => ReadHere<uint>(nameof(OldIrql)); set => WriteHere(nameof(OldIrql), value); }

        public FastMutex(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastMutex>();
        }
    }
}