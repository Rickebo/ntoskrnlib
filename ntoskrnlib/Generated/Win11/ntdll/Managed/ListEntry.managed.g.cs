using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LIST_ENTRY")]
    public sealed class ListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Flink { get => ReadHere<IntPtr>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(8UL)]
        public IntPtr Blink { get => ReadHere<IntPtr>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        public ListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ListEntry>();
        }
    }
}