using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_TABLE")]
    public sealed class SepCachedHandlesTable : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public IntPtr HashTable { get => ReadHere<IntPtr>(nameof(HashTable)); set => WriteHere(nameof(HashTable), value); }

        public SepCachedHandlesTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepCachedHandlesTable>();
        }
    }
}