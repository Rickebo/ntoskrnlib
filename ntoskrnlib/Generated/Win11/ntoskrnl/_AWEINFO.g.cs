#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _AWEINFO
    {
        [FieldOffset(0)]
        public IntPtr AweInfoSignature;
        [FieldOffset(8)]
        public _MI_AWEINFO_FLAGS Flags;
        [FieldOffset(16)]
        public ulong PageSize;
        [FieldOffset(24)]
        public _RTL_BITMAP_EX VadPhysicalPagesBitMap;
        [FieldOffset(40)]
        public IntPtr ControlArea;
        [FieldOffset(48)]
        public int ChangeClusterAttributeLock;
        [FieldOffset(52)]
        public uint CacheAttribute;
        [FieldOffset(64)]
        public _EX_PUSH_LOCK_AUTO_EXPAND AwePagesLock;
        [FieldOffset(80)]
        public IntPtr ChangeClusterAttributeWaitList;
    }
}