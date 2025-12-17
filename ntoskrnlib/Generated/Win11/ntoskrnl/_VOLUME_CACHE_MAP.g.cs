#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2760)]
    public partial struct _VOLUME_CACHE_MAP
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteCode;
        [FieldOffset(8)]
        public long UseCount;
        [FieldOffset(16)]
        public IntPtr DeviceObject;
        [FieldOffset(24)]
        public _LIST_ENTRY VolumeCacheMapLinks;
        [FieldOffset(40)]
        public ulong DirtyPages;
        [FieldOffset(48)]
        public _LOG_HANDLE_CONTEXT LogHandleContext;
        [FieldOffset(200)]
        public uint Flags;
        [FieldOffset(204)]
        public uint PagesQueuedToDisk;
        [FieldOffset(208)]
        public uint LoggedPagesQueuedToDisk;
        [FieldOffset(212)]
        public uint VolumeId;
        [FieldOffset(216)]
        public _LIST_ENTRY PrivateVolumeList;
        [FieldOffset(232)]
        public _CC_VOLUME_TELEMETRY VolumeTelemetry;
        [FieldOffset(2712)]
        public _KE_RCU_WORKITEM RcuContext;
    }
}