using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_NODE_SLAB_IDENTITY_STATE")]
    public sealed class MiNodeSlabIdentityState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(65)]
        public DynamicArray SlabIdentityStandbyListCaches { get => ReadStructure<DynamicArray>(nameof(SlabIdentityStandbyListCaches)); set => WriteStructure(nameof(SlabIdentityStandbyListCaches), value); }

        [Offset(266240UL)]
        [Length(65)]
        public DynamicArray SlabIdentityStandbyPageLists { get => ReadStructure<DynamicArray>(nameof(SlabIdentityStandbyPageLists)); set => WriteStructure(nameof(SlabIdentityStandbyPageLists), value); }

        [Offset(312000UL)]
        [Length(2)]
        public DynamicArray SlabIdentityHints { get => ReadStructure<DynamicArray>(nameof(SlabIdentityHints)); set => WriteStructure(nameof(SlabIdentityHints), value); }

        [Offset(313024UL)]
        [Length(65)]
        public DynamicArray SlabIdentityLists { get => ReadStructure<DynamicArray>(nameof(SlabIdentityLists)); set => WriteStructure(nameof(SlabIdentityLists), value); }

        [Offset(314064UL)]
        public RtlBitmap SlabIdentityEmptyEntryBitmap { get => ReadStructure<RtlBitmap>(nameof(SlabIdentityEmptyEntryBitmap)); set => WriteStructure(nameof(SlabIdentityEmptyEntryBitmap), value); }

        [Offset(314080UL)]
        [Length(3)]
        public DynamicArray SlabIdentityEmptyEntryBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(SlabIdentityEmptyEntryBitmapBuffer)); set => WriteStructure(nameof(SlabIdentityEmptyEntryBitmapBuffer), value); }

        [Offset(314096UL)]
        public RtlBitmap SlabIdentityStandbyExistsBitmap { get => ReadStructure<RtlBitmap>(nameof(SlabIdentityStandbyExistsBitmap)); set => WriteStructure(nameof(SlabIdentityStandbyExistsBitmap), value); }

        [Offset(314112UL)]
        [Length(3)]
        public DynamicArray SlabIdentityStandbyExistsBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(SlabIdentityStandbyExistsBitmapBuffer)); set => WriteStructure(nameof(SlabIdentityStandbyExistsBitmapBuffer), value); }

        public MiNodeSlabIdentityState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiNodeSlabIdentityState>();
        }
    }
}