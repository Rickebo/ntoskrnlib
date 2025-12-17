using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMVAD")]
    public sealed class Mmvad : DynamicStructure
    {
        [Offset(0UL)]
        public MmvadShort Core { get => ReadStructure<MmvadShort>(nameof(Core)); set => WriteStructure(nameof(Core), value); }

        [Offset(64UL)]
        public MmvadFLAGS2 VadFlags2 { get => ReadStructure<MmvadFLAGS2>(nameof(VadFlags2)); set => WriteStructure(nameof(VadFlags2), value); }

        [Offset(72UL)]
        public IntPtr Subsection { get => ReadHere<IntPtr>(nameof(Subsection)); set => WriteHere(nameof(Subsection), value); }

        [Offset(80UL)]
        public IntPtr FirstPrototypePte { get => ReadHere<IntPtr>(nameof(FirstPrototypePte)); set => WriteHere(nameof(FirstPrototypePte), value); }

        [Offset(88UL)]
        public IntPtr LastContiguousPte { get => ReadHere<IntPtr>(nameof(LastContiguousPte)); set => WriteHere(nameof(LastContiguousPte), value); }

        [Offset(96UL)]
        public ListEntry ViewLinks { get => ReadStructure<ListEntry>(nameof(ViewLinks)); set => WriteStructure(nameof(ViewLinks), value); }

        [Offset(112UL)]
        public IntPtr VadsProcess { get => ReadHere<IntPtr>(nameof(VadsProcess)); set => WriteHere(nameof(VadsProcess), value); }

        [Offset(120UL)]
        public UnnamedTag u4 { get => ReadStructure<UnnamedTag>(nameof(u4)); set => WriteStructure(nameof(u4), value); }

        [Offset(128UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        public Mmvad(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mmvad>();
        }
    }
}