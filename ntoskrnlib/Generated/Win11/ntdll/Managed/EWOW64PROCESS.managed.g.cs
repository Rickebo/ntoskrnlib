using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EWOW64PROCESS")]
    public sealed class EWOW64PROCESS : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Peb { get => ReadHere<IntPtr>(nameof(Peb)); set => WriteHere(nameof(Peb), value); }

        [Offset(8UL)]
        public uint NtdllType { get => ReadHere<uint>(nameof(NtdllType)); set => WriteHere(nameof(NtdllType), value); }

        public EWOW64PROCESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EWOW64PROCESS>();
        }
    }
}