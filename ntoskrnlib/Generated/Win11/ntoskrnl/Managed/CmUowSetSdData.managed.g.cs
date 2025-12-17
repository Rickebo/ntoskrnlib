using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_SD_DATA")]
    public sealed class CmUowSetSdData : DynamicStructure
    {
        [Offset(0UL)]
        public uint SecurityCell { get => ReadHere<uint>(nameof(SecurityCell)); set => WriteHere(nameof(SecurityCell), value); }

        [Offset(8UL)]
        public IntPtr Hive { get => ReadHere<IntPtr>(nameof(Hive)); set => WriteHere(nameof(Hive), value); }

        public CmUowSetSdData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmUowSetSdData>();
        }
    }
}