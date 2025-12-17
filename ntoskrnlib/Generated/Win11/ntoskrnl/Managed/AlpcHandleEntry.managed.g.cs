using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_HANDLE_ENTRY")]
    public sealed class AlpcHandleEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Object { get => ReadHere<IntPtr>(nameof(Object)); set => WriteHere(nameof(Object), value); }

        public AlpcHandleEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcHandleEntry>();
        }
    }
}