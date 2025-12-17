#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 608)]
    public partial struct _OBJECT_NAMESPACE_LOOKUPTABLE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public _LIST_ENTRY[] HashBuckets;
        [FieldOffset(592)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(600)]
        public uint NumberOfPrivateSpaces;
    }
}