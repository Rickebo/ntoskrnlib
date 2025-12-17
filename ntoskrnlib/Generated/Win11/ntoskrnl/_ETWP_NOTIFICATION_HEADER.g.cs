#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _ETWP_NOTIFICATION_HEADER
    {
        [FieldOffset(0)]
        public uint NotificationType;
        [FieldOffset(4)]
        public uint NotificationSize;
        [FieldOffset(8)]
        public int RefCount;
        [FieldOffset(12)]
        public byte ReplyRequested;
        [FieldOffset(16)]
        public uint ReplyIndex;
        [FieldOffset(16)]
        public uint Timeout;
        [FieldOffset(20)]
        public uint ReplyCount;
        [FieldOffset(20)]
        public uint NotifyeeCount;
        [FieldOffset(24)]
        public ulong ReplyHandle;
        [FieldOffset(24)]
        public IntPtr ReplyObject;
        [FieldOffset(24)]
        public uint RegIndex;
        [FieldOffset(32)]
        public uint TargetPID;
        [FieldOffset(36)]
        public uint SourcePID;
        [FieldOffset(40)]
        public _GUID DestinationGuid;
        [FieldOffset(56)]
        public _GUID SourceGuid;
    }
}