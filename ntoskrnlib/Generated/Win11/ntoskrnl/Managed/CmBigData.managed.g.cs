using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_BIG_DATA")]
    public sealed class CmBigData : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        public uint List { get => ReadHere<uint>(nameof(List)); set => WriteHere(nameof(List), value); }

        public CmBigData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmBigData>();
        }
    }
}