using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PHYSICAL_VIEW")]
    public sealed class MiPhysicalView : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode PhysicalNode { get => ReadStructure<RtlBalancedNode>(nameof(PhysicalNode)); set => WriteStructure(nameof(PhysicalNode), value); }

        [Offset(24UL)]
        public IntPtr Vad { get => ReadHere<IntPtr>(nameof(Vad)); set => WriteHere(nameof(Vad), value); }

        [Offset(32UL)]
        public IntPtr AweInfo { get => ReadHere<IntPtr>(nameof(AweInfo)); set => WriteHere(nameof(AweInfo), value); }

        [Offset(40UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(48UL)]
        public RtlBitmapEx BitMap { get => ReadStructure<RtlBitmapEx>(nameof(BitMap)); set => WriteStructure(nameof(BitMap), value); }

        [Offset(64UL)]
        public byte AgeStamp { get => ReadHere<byte>(nameof(AgeStamp)); set => WriteHere(nameof(AgeStamp), value); }

        public MiPhysicalView(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPhysicalView>();
        }
    }
}