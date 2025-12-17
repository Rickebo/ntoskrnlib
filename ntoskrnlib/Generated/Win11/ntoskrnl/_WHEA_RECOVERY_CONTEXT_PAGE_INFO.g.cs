#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _WHEA_RECOVERY_CONTEXT_PAGE_INFO
    {
        [FieldOffset(0)]
        public uint ComponentTag;
        [FieldOffset(4)]
        public int PageStatus;
        [FieldOffset(8)]
        public uint ActionTaken;
        [FieldOffset(12)]
        public _WHEA_IN_USE_PAGE_NOTIFY_FLAGS NotifyFlags;
        [FieldOffset(13)]
        public byte ImmediateSuccess;
        [FieldOffset(14)]
        public ushort Reserved;
        [FieldOffset(16)]
        public _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO ActionTakenAdditionalInfo;
    }
}