using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_HASH_TABLE_ENTRY")]
    public sealed class CmKeyHashTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public IntPtr Owner { get => ReadHere<IntPtr>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(16UL)]
        public IntPtr Entry { get => ReadHere<IntPtr>(nameof(Entry)); set => WriteHere(nameof(Entry), value); }

        public CmKeyHashTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyHashTableEntry>();
        }
    }
}