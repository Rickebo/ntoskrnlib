using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_PNP_DEVICE_COMPLETION_QUEUE")]
    public sealed class TriagePnpDeviceCompletionQueue : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DispatchedList { get => ReadStructure<ListEntry>(nameof(DispatchedList)); set => WriteStructure(nameof(DispatchedList), value); }

        public TriagePnpDeviceCompletionQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TriagePnpDeviceCompletionQueue>();
        }
    }
}