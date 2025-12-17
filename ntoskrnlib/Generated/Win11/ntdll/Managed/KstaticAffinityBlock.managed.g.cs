using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSTATIC_AFFINITY_BLOCK")]
    public sealed class KstaticAffinityBlock : DynamicStructure
    {
        [Offset(0UL)]
        public KaffinityEx KeFlushTbAffinity { get => ReadStructure<KaffinityEx>(nameof(KeFlushTbAffinity)); set => WriteStructure(nameof(KeFlushTbAffinity), value); }

        [Offset(0UL)]
        public KaffinityEx KeFlushWbAffinity { get => ReadStructure<KaffinityEx>(nameof(KeFlushWbAffinity)); set => WriteStructure(nameof(KeFlushWbAffinity), value); }

        [Offset(0UL)]
        public KaffinityEx KeSlistRollbackAffinity { get => ReadStructure<KaffinityEx>(nameof(KeSlistRollbackAffinity)); set => WriteStructure(nameof(KeSlistRollbackAffinity), value); }

        [Offset(0UL)]
        public KaffinityEx KeSyncContextAffinity { get => ReadStructure<KaffinityEx>(nameof(KeSyncContextAffinity)); set => WriteStructure(nameof(KeSyncContextAffinity), value); }

        [Offset(0UL)]
        public KaffinityEx KeRcuAffinity { get => ReadStructure<KaffinityEx>(nameof(KeRcuAffinity)); set => WriteStructure(nameof(KeRcuAffinity), value); }

        [Offset(264UL)]
        public KaffinityEx KeFlushTbDeepIdleAffinity { get => ReadStructure<KaffinityEx>(nameof(KeFlushTbDeepIdleAffinity)); set => WriteStructure(nameof(KeFlushTbDeepIdleAffinity), value); }

        [Offset(528UL)]
        public KaffinityEx KeIpiSendAffinity { get => ReadStructure<KaffinityEx>(nameof(KeIpiSendAffinity)); set => WriteStructure(nameof(KeIpiSendAffinity), value); }

        [Offset(792UL)]
        public KaffinityEx KeIpiSendIpiSet { get => ReadStructure<KaffinityEx>(nameof(KeIpiSendIpiSet)); set => WriteStructure(nameof(KeIpiSendIpiSet), value); }

        [Offset(1056UL)]
        [Length(128)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        public KstaticAffinityBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KstaticAffinityBlock>();
        }
    }
}