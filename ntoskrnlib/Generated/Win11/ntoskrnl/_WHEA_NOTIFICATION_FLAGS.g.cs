#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _WHEA_NOTIFICATION_FLAGS
    {
        [FieldOffset(0)]
        public ushort PollIntervalRW;
        [FieldOffset(0)]
        public ushort SwitchToPollingThresholdRW;
        [FieldOffset(0)]
        public ushort SwitchToPollingWindowRW;
        [FieldOffset(0)]
        public ushort ErrorThresholdRW;
        [FieldOffset(0)]
        public ushort ErrorThresholdWindowRW;
        [FieldOffset(0)]
        public ushort Reserved;
        [FieldOffset(0)]
        public ushort AsUSHORT;
    }
}