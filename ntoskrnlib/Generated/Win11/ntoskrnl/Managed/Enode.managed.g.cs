using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ENODE")]
    public sealed class Enode : DynamicStructure
    {
        [Offset(0UL)]
        public Knode Ncb { get => ReadStructure<Knode>(nameof(Ncb)); set => WriteStructure(nameof(Ncb), value); }

        [Offset(824UL)]
        public WorkQueueItem HotAddProcessorWorkItem { get => ReadStructure<WorkQueueItem>(nameof(HotAddProcessorWorkItem)); set => WriteStructure(nameof(HotAddProcessorWorkItem), value); }

        public Enode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Enode>();
        }
    }
}