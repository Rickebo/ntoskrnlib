#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_HOT_PATCH_STATE
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE UserSidPatchLists;
        [FieldOffset(8)]
        public _RTL_AVL_TREE GlobalHotPatchList;
        [FieldOffset(16)]
        public _RTL_AVL_TREE PreviouslyRegisteredHotPatchList;
        [FieldOffset(24)]
        public _RTL_AVL_TREE SecureImageActivePatches;
        [FieldOffset(32)]
        public _EX_PUSH_LOCK HotPatchListLock;
        [FieldOffset(40)]
        public IntPtr InProgressPatchTableEntry;
        [FieldOffset(48)]
        public IntPtr InProgressBaseTableEntry;
        [FieldOffset(56)]
        public sbyte ReadyForPatchOperations;
        [FieldOffset(60)]
        public uint HotPatchReserveSize;
        [FieldOffset(64)]
        public uint DriverProxyReserveSize;
        [FieldOffset(68)]
        public uint HotPatchingEnabled;
        [FieldOffset(68)]
        public uint Spare;
    }
}