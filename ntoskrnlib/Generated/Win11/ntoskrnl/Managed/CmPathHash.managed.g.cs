using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_PATH_HASH")]
    public sealed class CmPathHash : DynamicStructure
    {
        [Offset(0UL)]
        public uint Hash { get => ReadHere<uint>(nameof(Hash)); set => WriteHere(nameof(Hash), value); }

        public CmPathHash(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmPathHash>();
        }
    }
}