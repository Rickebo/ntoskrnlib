using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_LARGEPAGE_VAD_INFO")]
    public sealed class MiLargepageVadInfo : DynamicStructure
    {
        [Offset(0UL)]
        public byte LargeImageBias { get => ReadHere<byte>(nameof(LargeImageBias)); set => WriteHere(nameof(LargeImageBias), value); }

        [Offset(1UL)]
        [Length(3)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(8UL)]
        public ulong ActualImageViewSize { get => ReadHere<ulong>(nameof(ActualImageViewSize)); set => WriteHere(nameof(ActualImageViewSize), value); }

        [Offset(16UL)]
        public IntPtr ReferencedPartition { get => ReadHere<IntPtr>(nameof(ReferencedPartition)); set => WriteHere(nameof(ReferencedPartition), value); }

        public MiLargepageVadInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiLargepageVadInfo>();
        }
    }
}