using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_CHANNEL_MEMORY_RANGES")]
    public sealed class HalChannelMemoryRanges : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PageFrameIndex { get => ReadHere<ulong>(nameof(PageFrameIndex)); set => WriteHere(nameof(PageFrameIndex), value); }

        [Offset(8UL)]
        public ushort MpnId { get => ReadHere<ushort>(nameof(MpnId)); set => WriteHere(nameof(MpnId), value); }

        [Offset(10UL)]
        public ushort Node { get => ReadHere<ushort>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(12UL)]
        public ushort Channel { get => ReadHere<ushort>(nameof(Channel)); set => WriteHere(nameof(Channel), value); }

        [Offset(14UL)]
        public byte IsPowerManageable { get => ReadHere<byte>(nameof(IsPowerManageable)); set => WriteHere(nameof(IsPowerManageable), value); }

        [Offset(15UL)]
        public byte DeepPowerState { get => ReadHere<byte>(nameof(DeepPowerState)); set => WriteHere(nameof(DeepPowerState), value); }

        public HalChannelMemoryRanges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalChannelMemoryRanges>();
        }
    }
}