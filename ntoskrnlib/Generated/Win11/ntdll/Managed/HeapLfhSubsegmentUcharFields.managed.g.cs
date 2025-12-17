using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS")]
    public sealed class HeapLfhSubsegmentUcharFields : DynamicStructure
    {
        [Offset(0UL)]
        public byte PrivateFormat { get => ReadHere<byte>(nameof(PrivateFormat)); set => WriteHere(nameof(PrivateFormat), value); }

        [Offset(0UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(0UL)]
        public byte AllUCharBits { get => ReadHere<byte>(nameof(AllUCharBits)); set => WriteHere(nameof(AllUCharBits), value); }

        public HeapLfhSubsegmentUcharFields(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSubsegmentUcharFields>();
        }
    }
}