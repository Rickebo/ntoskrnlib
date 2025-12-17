using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_WORKING_SET")]
    public sealed class MiPartitionWorkingSet : DynamicStructure
    {
        [Offset(0UL)]
        public MmsupportInstance VmInstance { get => ReadStructure<MmsupportInstance>(nameof(VmInstance)); set => WriteStructure(nameof(VmInstance), value); }

        [Offset(192UL)]
        public MmwslInstance VmWorkingSetList { get => ReadStructure<MmwslInstance>(nameof(VmWorkingSetList)); set => WriteStructure(nameof(VmWorkingSetList), value); }

        public MiPartitionWorkingSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionWorkingSet>();
        }
    }
}