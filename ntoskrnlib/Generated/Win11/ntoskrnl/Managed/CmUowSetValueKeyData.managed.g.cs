using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_VALUE_KEY_DATA")]
    public sealed class CmUowSetValueKeyData : DynamicStructure
    {
        [Offset(0UL)]
        public uint PreparedCell { get => ReadHere<uint>(nameof(PreparedCell)); set => WriteHere(nameof(PreparedCell), value); }

        [Offset(4UL)]
        public uint OldValueCell { get => ReadHere<uint>(nameof(OldValueCell)); set => WriteHere(nameof(OldValueCell), value); }

        [Offset(8UL)]
        public ushort NameLength { get => ReadHere<ushort>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(12UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        public CmUowSetValueKeyData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmUowSetValueKeyData>();
        }
    }
}