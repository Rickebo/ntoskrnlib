using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_DEVICE_NODE")]
    public sealed class TriageDeviceNode : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Sibling { get => ReadHere<IntPtr>(nameof(Sibling)); set => WriteHere(nameof(Sibling), value); }

        [Offset(8UL)]
        public IntPtr Child { get => ReadHere<IntPtr>(nameof(Child)); set => WriteHere(nameof(Child), value); }

        [Offset(16UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(24UL)]
        public IntPtr LastChild { get => ReadHere<IntPtr>(nameof(LastChild)); set => WriteHere(nameof(LastChild), value); }

        [Offset(32UL)]
        public IntPtr PhysicalDeviceObject { get => ReadHere<IntPtr>(nameof(PhysicalDeviceObject)); set => WriteHere(nameof(PhysicalDeviceObject), value); }

        [Offset(40UL)]
        public UnicodeString InstancePath { get => ReadStructure<UnicodeString>(nameof(InstancePath)); set => WriteStructure(nameof(InstancePath), value); }

        [Offset(56UL)]
        public UnicodeString ServiceName { get => ReadStructure<UnicodeString>(nameof(ServiceName)); set => WriteStructure(nameof(ServiceName), value); }

        [Offset(72UL)]
        public IntPtr PendingIrp { get => ReadHere<IntPtr>(nameof(PendingIrp)); set => WriteHere(nameof(PendingIrp), value); }

        [Offset(80UL)]
        public IntPtr FxDevice { get => ReadHere<IntPtr>(nameof(FxDevice)); set => WriteHere(nameof(FxDevice), value); }

        public TriageDeviceNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TriageDeviceNode>();
        }
    }
}