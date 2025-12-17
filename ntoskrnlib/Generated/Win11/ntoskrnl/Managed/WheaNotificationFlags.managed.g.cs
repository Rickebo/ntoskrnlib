using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_NOTIFICATION_FLAGS")]
    public sealed class WheaNotificationFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort PollIntervalRW { get => ReadHere<ushort>(nameof(PollIntervalRW)); set => WriteHere(nameof(PollIntervalRW), value); }

        [Offset(0UL)]
        public ushort SwitchToPollingThresholdRW { get => ReadHere<ushort>(nameof(SwitchToPollingThresholdRW)); set => WriteHere(nameof(SwitchToPollingThresholdRW), value); }

        [Offset(0UL)]
        public ushort SwitchToPollingWindowRW { get => ReadHere<ushort>(nameof(SwitchToPollingWindowRW)); set => WriteHere(nameof(SwitchToPollingWindowRW), value); }

        [Offset(0UL)]
        public ushort ErrorThresholdRW { get => ReadHere<ushort>(nameof(ErrorThresholdRW)); set => WriteHere(nameof(ErrorThresholdRW), value); }

        [Offset(0UL)]
        public ushort ErrorThresholdWindowRW { get => ReadHere<ushort>(nameof(ErrorThresholdWindowRW)); set => WriteHere(nameof(ErrorThresholdWindowRW), value); }

        [Offset(0UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ushort AsUSHORT { get => ReadHere<ushort>(nameof(AsUSHORT)); set => WriteHere(nameof(AsUSHORT), value); }

        public WheaNotificationFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaNotificationFlags>();
        }
    }
}