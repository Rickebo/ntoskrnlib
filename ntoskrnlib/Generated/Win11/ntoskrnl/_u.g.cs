#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _u
    {
        [FieldOffset(0)]
        public _CM_KEY_NODE KeyNode;
        [FieldOffset(0)]
        public _CM_KEY_VALUE KeyValue;
        [FieldOffset(0)]
        public _CM_KEY_SECURITY KeySecurity;
        [FieldOffset(0)]
        public _CM_KEY_INDEX KeyIndex;
        [FieldOffset(0)]
        public _CM_BIG_DATA ValueData;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] KeyList;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] KeyString;
    }
}