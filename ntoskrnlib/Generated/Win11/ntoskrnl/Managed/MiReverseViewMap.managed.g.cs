using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_REVERSE_VIEW_MAP")]
    public sealed class MiReverseViewMap : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ViewLinks { get => ReadStructure<ListEntry>(nameof(ViewLinks)); set => WriteStructure(nameof(ViewLinks), value); }

        [Offset(16UL)]
        public IntPtr SystemCacheVa { get => ReadHere<IntPtr>(nameof(SystemCacheVa)); set => WriteHere(nameof(SystemCacheVa), value); }

        [Offset(16UL)]
        public IntPtr VadsProcess { get => ReadHere<IntPtr>(nameof(VadsProcess)); set => WriteHere(nameof(VadsProcess), value); }

        [Offset(16UL)]
        public ulong Type { get => ReadHere<ulong>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(24UL)]
        public IntPtr Subsection { get => ReadHere<IntPtr>(nameof(Subsection)); set => WriteHere(nameof(Subsection), value); }

        [Offset(24UL)]
        public ulong SubsectionType { get => ReadHere<ulong>(nameof(SubsectionType)); set => WriteHere(nameof(SubsectionType), value); }

        [Offset(32UL)]
        public MiReverseMapViewAttributes Attributes { get => ReadStructure<MiReverseMapViewAttributes>(nameof(Attributes)); set => WriteStructure(nameof(Attributes), value); }

        public MiReverseViewMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiReverseViewMap>();
        }
    }
}