using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=608)]
public struct _OBJECT_NAMESPACE_LOOKUPTABLE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=37)]
    public byte[] HashBuckets;
    [FieldOffset(592)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(600)]
    public uint NumberOfPrivateSpaces;
}
