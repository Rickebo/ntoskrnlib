using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_ADDITIONAL_INFO")]
    public sealed class MiImageAdditionalInfo : DynamicStructure
    {
        [Offset(0UL)]
        public MiPrototypePtesNode ProtosNode { get => ReadStructure<MiPrototypePtesNode>(nameof(ProtosNode)); set => WriteStructure(nameof(ProtosNode), value); }

        [Offset(32UL)]
        public IntPtr DynamicRelocations { get => ReadHere<IntPtr>(nameof(DynamicRelocations)); set => WriteHere(nameof(DynamicRelocations), value); }

        [Offset(40UL)]
        public ImageSecurityContext SecurityContext { get => ReadStructure<ImageSecurityContext>(nameof(SecurityContext)); set => WriteStructure(nameof(SecurityContext), value); }

        [Offset(48UL)]
        public IntPtr ImageFileExtents { get => ReadHere<IntPtr>(nameof(ImageFileExtents)); set => WriteHere(nameof(ImageFileExtents), value); }

        [Offset(56UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(60UL)]
        public uint Unused { get => ReadHere<uint>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(64UL)]
        public ulong StrongImageReference { get => ReadHere<ulong>(nameof(StrongImageReference)); set => WriteHere(nameof(StrongImageReference), value); }

        public MiImageAdditionalInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiImageAdditionalInfo>();
        }
    }
}