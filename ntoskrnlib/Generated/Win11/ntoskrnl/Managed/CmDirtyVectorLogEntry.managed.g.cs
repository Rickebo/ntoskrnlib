using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_DIRTY_VECTOR_LOG_ENTRY")]
    public sealed class CmDirtyVectorLogEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        public uint Operation { get => ReadHere<uint>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(12UL)]
        public UnnamedTag Data { get => ReadStructure<UnnamedTag>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        [Offset(24UL)]
        [Length(6)]
        public DynamicArray Stack { get => ReadStructure<DynamicArray>(nameof(Stack)); set => WriteStructure(nameof(Stack), value); }

        public CmDirtyVectorLogEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmDirtyVectorLogEntry>();
        }
    }
}