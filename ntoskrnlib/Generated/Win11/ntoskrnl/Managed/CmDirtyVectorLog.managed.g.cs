using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_DIRTY_VECTOR_LOG")]
    public sealed class CmDirtyVectorLog : DynamicStructure
    {
        [Offset(0UL)]
        public uint Next { get => ReadHere<uint>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        [Length(16)]
        public DynamicArray Log { get => ReadStructure<DynamicArray>(nameof(Log)); set => WriteStructure(nameof(Log), value); }

        public CmDirtyVectorLog(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmDirtyVectorLog>();
        }
    }
}