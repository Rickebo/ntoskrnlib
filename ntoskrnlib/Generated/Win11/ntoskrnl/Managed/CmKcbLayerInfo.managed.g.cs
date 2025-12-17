using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KCB_LAYER_INFO")]
    public sealed class CmKcbLayerInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry LayerListEntry { get => ReadStructure<ListEntry>(nameof(LayerListEntry)); set => WriteStructure(nameof(LayerListEntry), value); }

        [Offset(16UL)]
        public IntPtr Kcb { get => ReadHere<IntPtr>(nameof(Kcb)); set => WriteHere(nameof(Kcb), value); }

        [Offset(24UL)]
        public IntPtr LowerLayer { get => ReadHere<IntPtr>(nameof(LowerLayer)); set => WriteHere(nameof(LowerLayer), value); }

        [Offset(32UL)]
        public ListEntry UpperLayerListHead { get => ReadStructure<ListEntry>(nameof(UpperLayerListHead)); set => WriteStructure(nameof(UpperLayerListHead), value); }

        [Offset(48UL)]
        public ListEntry DiscardedUpperLayerListHead { get => ReadStructure<ListEntry>(nameof(DiscardedUpperLayerListHead)); set => WriteStructure(nameof(DiscardedUpperLayerListHead), value); }

        public CmKcbLayerInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKcbLayerInfo>();
        }
    }
}