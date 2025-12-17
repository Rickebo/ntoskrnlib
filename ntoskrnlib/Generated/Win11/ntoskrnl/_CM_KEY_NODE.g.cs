#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _CM_KEY_NODE
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(4)]
        public _LARGE_INTEGER LastWriteTime;
        [FieldOffset(12)]
        public byte AccessBits;
        [FieldOffset(13)]
        public byte LayerSemantics;
        [FieldOffset(13)]
        public byte Spare1;
        [FieldOffset(13)]
        public byte InheritClass;
        [FieldOffset(14)]
        public ushort Spare2;
        [FieldOffset(16)]
        public uint Parent;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SubKeyCounts;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SubKeyLists;
        [FieldOffset(36)]
        public _CHILD_LIST ValueList;
        [FieldOffset(28)]
        public _CM_KEY_REFERENCE ChildHiveReference;
        [FieldOffset(44)]
        public uint Security;
        [FieldOffset(48)]
        public uint Class;
        [FieldOffset(52)]
        public uint MaxNameLen;
        [FieldOffset(52)]
        public uint UserFlags;
        [FieldOffset(52)]
        public uint VirtControlFlags;
        [FieldOffset(52)]
        public uint Debug;
        [FieldOffset(56)]
        public uint MaxClassLen;
        [FieldOffset(60)]
        public uint MaxValueNameLen;
        [FieldOffset(64)]
        public uint MaxValueDataLen;
        [FieldOffset(68)]
        public uint WorkVar;
        [FieldOffset(72)]
        public ushort NameLength;
        [FieldOffset(74)]
        public ushort ClassLength;
        [FieldOffset(76)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] Name;
    }
}