using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_PNP_DEVICE_COMPLETION_REQUEST")]
    public sealed class TriagePnpDeviceCompletionRequest : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        public TriagePnpDeviceCompletionRequest(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TriagePnpDeviceCompletionRequest>();
        }
    }
}