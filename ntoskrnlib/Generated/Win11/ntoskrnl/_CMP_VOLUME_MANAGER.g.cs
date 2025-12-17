#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CMP_VOLUME_MANAGER
    {
        [FieldOffset(0)]
        public _CMSI_RW_LOCK VolumeContextListLock;
        [FieldOffset(8)]
        public _LIST_ENTRY VolumeContextListHead;
    }
}