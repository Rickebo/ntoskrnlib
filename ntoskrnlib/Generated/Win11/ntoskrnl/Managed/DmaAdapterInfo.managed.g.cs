using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO")]
    public sealed class DmaAdapterInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public DmaAdapterInfoV1 V1 { get => ReadStructure<DmaAdapterInfoV1>(nameof(V1)); set => WriteStructure(nameof(V1), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public DmaAdapterInfoCrashdump Crashdump { get => ReadStructure<DmaAdapterInfoCrashdump>(nameof(Crashdump)); set => WriteStructure(nameof(Crashdump), value); }

        public DmaAdapterInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaAdapterInfo>();
        }
    }
}