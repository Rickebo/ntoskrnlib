using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_IO")]
    public sealed class TpIo : DynamicStructure
    {
        [Offset(0UL)]
        public TppCleanupGroupMember CleanupGroupMember { get => ReadStructure<TppCleanupGroupMember>(nameof(CleanupGroupMember)); set => WriteStructure(nameof(CleanupGroupMember), value); }

        [Offset(200UL)]
        public TpDirect Direct { get => ReadStructure<TpDirect>(nameof(Direct)); set => WriteStructure(nameof(Direct), value); }

        [Offset(272UL)]
        public IntPtr File { get => ReadHere<IntPtr>(nameof(File)); set => WriteHere(nameof(File), value); }

        [Offset(280UL)]
        public int PendingIrpCount { get => ReadHere<int>(nameof(PendingIrpCount)); set => WriteHere(nameof(PendingIrpCount), value); }

        public TpIo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpIo>();
        }
    }
}