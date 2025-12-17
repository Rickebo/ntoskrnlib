using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CLS_LSN")]
    public sealed class ClsLsn : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag offset { get => ReadStructure<UnnamedTag>(nameof(offset)); set => WriteStructure(nameof(offset), value); }

        [Offset(0UL)]
        public ulong ullOffset { get => ReadHere<ulong>(nameof(ullOffset)); set => WriteHere(nameof(ullOffset), value); }

        public ClsLsn(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ClsLsn>();
        }
    }
}