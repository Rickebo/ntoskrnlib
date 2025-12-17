using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_EX_WORK_QUEUE")]
    public sealed class TriageExWorkQueue : DynamicStructure
    {
        [Offset(0UL)]
        public Kpriqueue WorkPriQueue { get => ReadStructure<Kpriqueue>(nameof(WorkPriQueue)); set => WriteStructure(nameof(WorkPriQueue), value); }

        public TriageExWorkQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TriageExWorkQueue>();
        }
    }
}