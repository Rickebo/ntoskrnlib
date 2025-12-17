using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_ITE_WAITER")]
    public sealed class TppIteWaiter : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public IntPtr ThreadId { get => ReadHere<IntPtr>(nameof(ThreadId)); set => WriteHere(nameof(ThreadId), value); }

        public TppIteWaiter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppIteWaiter>();
        }
    }
}