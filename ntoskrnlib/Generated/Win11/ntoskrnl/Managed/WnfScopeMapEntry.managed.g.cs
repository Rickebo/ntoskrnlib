using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_MAP_ENTRY")]
    public sealed class WnfScopeMapEntry : DynamicStructure
    {
        [Offset(0UL)]
        public WnfLock MapEntryLock { get => ReadStructure<WnfLock>(nameof(MapEntryLock)); set => WriteStructure(nameof(MapEntryLock), value); }

        [Offset(8UL)]
        public ListEntry MapEntryHead { get => ReadStructure<ListEntry>(nameof(MapEntryHead)); set => WriteStructure(nameof(MapEntryHead), value); }

        public WnfScopeMapEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfScopeMapEntry>();
        }
    }
}