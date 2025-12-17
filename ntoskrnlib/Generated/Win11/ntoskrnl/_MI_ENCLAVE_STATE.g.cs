#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_ENCLAVE_STATE
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE EnclaveRegions;
        [FieldOffset(8)]
        public IntPtr EnclaveMetadataPage;
        [FieldOffset(16)]
        public IntPtr EnclaveMetadataBitMap;
        [FieldOffset(24)]
        public _EX_PUSH_LOCK EnclaveMetadataEntryLock;
        [FieldOffset(32)]
        public int EnclaveMetadataPageLock;
        [FieldOffset(40)]
        public _LIST_ENTRY EnclaveList;
        [FieldOffset(56)]
        public _EX_PUSH_LOCK EnclaveListLock;
        [FieldOffset(64)]
        public _EX_RUNDOWN_REF ShutdownRundown;
    }
}