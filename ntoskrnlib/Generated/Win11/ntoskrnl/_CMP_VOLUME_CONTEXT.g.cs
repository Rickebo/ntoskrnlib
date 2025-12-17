#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _CMP_VOLUME_CONTEXT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY VolumeContextListEntry;
        [FieldOffset(16)]
        public IntPtr VolumeManager;
        [FieldOffset(24)]
        public long RefCount;
        [FieldOffset(32)]
        public _GUID VolumeGuid;
        [FieldOffset(48)]
        public IntPtr VolumeFileObject;
        [FieldOffset(56)]
        public _CMSI_RW_LOCK VolumeContextLock;
        [FieldOffset(64)]
        public uint DeviceUsageNotificationState;
    }
}