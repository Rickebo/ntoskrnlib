using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_INTENT_LOCK")]
    public sealed class CmIntentLock : DynamicStructure
    {
        [Offset(0UL)]
        public uint OwnerCount { get => ReadHere<uint>(nameof(OwnerCount)); set => WriteHere(nameof(OwnerCount), value); }

        [Offset(8UL)]
        public IntPtr OwnerTable { get => ReadHere<IntPtr>(nameof(OwnerTable)); set => WriteHere(nameof(OwnerTable), value); }

        public CmIntentLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmIntentLock>();
        }
    }
}