#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 22840)]
    public partial struct _MI_DEBUGGER_STATE
    {
        [FieldOffset(0)]
        public byte TransientWrite;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] DebugPtes;
        [FieldOffset(24)]
        public uint PoisonedTb;
        [FieldOffset(28)]
        public int InDebugger;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public IntPtr[] Pfns;
        [FieldOffset(288)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _MI_DBG_PATCH[] PatchBuffer;
        [FieldOffset(6432)]
        public uint PatchBufferInsertIndex;
        [FieldOffset(6436)]
        public uint PatchBufferRemoveIndex;
        [FieldOffset(6440)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public _MI_DBG_PATCH[] PatchTableSpace;
        [FieldOffset(18728)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public IntPtr[] PatchTable;
        [FieldOffset(22824)]
        public int PatchTableLock;
        [FieldOffset(22828)]
        public uint PatchTableFreeEntry;
        [FieldOffset(22832)]
        public uint PatchTableEntryCount;
    }
}