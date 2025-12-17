using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO_CRASHDUMP")]
    public sealed class DmaAdapterInfoCrashdump : DynamicStructure
    {
        [Offset(0UL)]
        public DeviceDescription DeviceDescription { get => ReadStructure<DeviceDescription>(nameof(DeviceDescription)); set => WriteStructure(nameof(DeviceDescription), value); }

        [Offset(64UL)]
        public ulong DeviceIdSize { get => ReadHere<ulong>(nameof(DeviceIdSize)); set => WriteHere(nameof(DeviceIdSize), value); }

        [Offset(72UL)]
        public IntPtr DeviceId { get => ReadHere<IntPtr>(nameof(DeviceId)); set => WriteHere(nameof(DeviceId), value); }

        public DmaAdapterInfoCrashdump(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaAdapterInfoCrashdump>();
        }
    }
}