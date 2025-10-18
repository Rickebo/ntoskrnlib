using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _SE_AUDIT_PROCESS_CREATION_INFO
{
    [FieldOffset(0)]
    public IntPtr ImageFileName;
}
