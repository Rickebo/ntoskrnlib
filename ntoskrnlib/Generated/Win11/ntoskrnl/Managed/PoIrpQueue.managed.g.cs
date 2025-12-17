using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_IRP_QUEUE")]
    public sealed class PoIrpQueue : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CurrentIrp { get => ReadHere<IntPtr>(nameof(CurrentIrp)); set => WriteHere(nameof(CurrentIrp), value); }

        [Offset(8UL)]
        public IntPtr PendingIrpList { get => ReadHere<IntPtr>(nameof(PendingIrpList)); set => WriteHere(nameof(PendingIrpList), value); }

        public PoIrpQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoIrpQueue>();
        }
    }
}