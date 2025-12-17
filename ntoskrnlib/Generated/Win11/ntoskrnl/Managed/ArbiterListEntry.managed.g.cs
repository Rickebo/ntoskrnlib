using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_LIST_ENTRY")]
    public sealed class ArbiterListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint AlternativeCount { get => ReadHere<uint>(nameof(AlternativeCount)); set => WriteHere(nameof(AlternativeCount), value); }

        [Offset(24UL)]
        public IntPtr Alternatives { get => ReadHere<IntPtr>(nameof(Alternatives)); set => WriteHere(nameof(Alternatives), value); }

        [Offset(32UL)]
        public IntPtr PhysicalDeviceObject { get => ReadHere<IntPtr>(nameof(PhysicalDeviceObject)); set => WriteHere(nameof(PhysicalDeviceObject), value); }

        [Offset(40UL)]
        public uint RequestSource { get => ReadHere<uint>(nameof(RequestSource)); set => WriteHere(nameof(RequestSource), value); }

        [Offset(44UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(48UL)]
        public long WorkSpace { get => ReadHere<long>(nameof(WorkSpace)); set => WriteHere(nameof(WorkSpace), value); }

        [Offset(56UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(60UL)]
        public uint SlotNumber { get => ReadHere<uint>(nameof(SlotNumber)); set => WriteHere(nameof(SlotNumber), value); }

        [Offset(64UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(72UL)]
        public IntPtr Assignment { get => ReadHere<IntPtr>(nameof(Assignment)); set => WriteHere(nameof(Assignment), value); }

        [Offset(80UL)]
        public IntPtr SelectedAlternative { get => ReadHere<IntPtr>(nameof(SelectedAlternative)); set => WriteHere(nameof(SelectedAlternative), value); }

        [Offset(88UL)]
        public uint Result { get => ReadHere<uint>(nameof(Result)); set => WriteHere(nameof(Result), value); }

        public ArbiterListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterListEntry>();
        }
    }
}