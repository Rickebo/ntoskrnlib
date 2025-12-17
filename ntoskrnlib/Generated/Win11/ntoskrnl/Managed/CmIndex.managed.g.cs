using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_INDEX")]
    public sealed class CmIndex : DynamicStructure
    {
        [Offset(0UL)]
        public uint Cell { get => ReadHere<uint>(nameof(Cell)); set => WriteHere(nameof(Cell), value); }

        [Offset(4UL)]
        public CmFastLeafHint NameHint { get => ReadStructure<CmFastLeafHint>(nameof(NameHint)); set => WriteStructure(nameof(NameHint), value); }

        [Offset(4UL)]
        public CmComponentHash HashKey { get => ReadStructure<CmComponentHash>(nameof(HashKey)); set => WriteStructure(nameof(HashKey), value); }

        public CmIndex(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmIndex>();
        }
    }
}