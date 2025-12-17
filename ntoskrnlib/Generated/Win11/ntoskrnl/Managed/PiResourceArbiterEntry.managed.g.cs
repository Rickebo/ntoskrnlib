using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PI_RESOURCE_ARBITER_ENTRY")]
    public sealed class PiResourceArbiterEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DeviceArbiterList { get => ReadStructure<ListEntry>(nameof(DeviceArbiterList)); set => WriteStructure(nameof(DeviceArbiterList), value); }

        [Offset(16UL)]
        public byte ResourceType { get => ReadHere<byte>(nameof(ResourceType)); set => WriteHere(nameof(ResourceType), value); }

        [Offset(24UL)]
        public IntPtr ArbiterInterface { get => ReadHere<IntPtr>(nameof(ArbiterInterface)); set => WriteHere(nameof(ArbiterInterface), value); }

        [Offset(32UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        [Offset(40UL)]
        public ListEntry ResourceList { get => ReadStructure<ListEntry>(nameof(ResourceList)); set => WriteStructure(nameof(ResourceList), value); }

        [Offset(56UL)]
        public ListEntry BestResourceList { get => ReadStructure<ListEntry>(nameof(BestResourceList)); set => WriteStructure(nameof(BestResourceList), value); }

        [Offset(72UL)]
        public ListEntry BestConfig { get => ReadStructure<ListEntry>(nameof(BestConfig)); set => WriteStructure(nameof(BestConfig), value); }

        [Offset(88UL)]
        public ListEntry ActiveArbiterList { get => ReadStructure<ListEntry>(nameof(ActiveArbiterList)); set => WriteStructure(nameof(ActiveArbiterList), value); }

        [Offset(104UL)]
        public byte State { get => ReadHere<byte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(105UL)]
        public byte ResourcesChanged { get => ReadHere<byte>(nameof(ResourcesChanged)); set => WriteHere(nameof(ResourcesChanged), value); }

        public PiResourceArbiterEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PiResourceArbiterEntry>();
        }
    }
}