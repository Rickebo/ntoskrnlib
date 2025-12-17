#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 704)]
    public partial struct _MI_PARTITION_SLABS
    {
        [FieldOffset(0)]
        public IntPtr SlabTypeIdentifiers;
        [FieldOffset(8)]
        public ulong SlabEntriesDemoted;
        [FieldOffset(16)]
        public int SlabDemoteInProgress;
        [FieldOffset(20)]
        public uint SlabTypeAcquiresCharges;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _MI_SLAB_IDENTITY_REFERENCE[] IdentityRefs;
        [FieldOffset(536)]
        public _RTL_BITMAP InUseIdentitiesBitmap;
        [FieldOffset(552)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] InUseIdentitiesBitmapBuffer;
        [FieldOffset(560)]
        public int IdentitySlabsInitialized;
        [FieldOffset(568)]
        public _EX_PUSH_LOCK IdentitiesLock;
        [FieldOffset(576)]
        public ulong IdentitySlabAvailablePages;
        [FieldOffset(584)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_AVAILABLE_PAGE_WAIT_STATES[] IdentitySlabAvailablePagesWaitState;
        [FieldOffset(648)]
        public _EX_RUNDOWN_REF ReplenishRundownProtection;
        [FieldOffset(656)]
        public ulong LowMemoryConditionStartTime;
    }
}