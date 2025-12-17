using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KDPC_LIST")]
    public sealed class KdpcList : DynamicStructure
    {
        [Offset(0UL)]
        public SingleListEntry ListHead { get => ReadStructure<SingleListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(8UL)]
        public IntPtr LastEntry { get => ReadHere<IntPtr>(nameof(LastEntry)); set => WriteHere(nameof(LastEntry), value); }

        public KdpcList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KdpcList>();
        }
    }
}