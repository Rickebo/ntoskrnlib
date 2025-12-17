using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_DIAG_STACK_RECORD")]
    public sealed class PoDiagStackRecord : DynamicStructure
    {
        [Offset(0UL)]
        public uint StackDepth { get => ReadHere<uint>(nameof(StackDepth)); set => WriteHere(nameof(StackDepth), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Stack { get => ReadStructure<DynamicArray>(nameof(Stack)); set => WriteStructure(nameof(Stack), value); }

        public PoDiagStackRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoDiagStackRecord>();
        }
    }
}