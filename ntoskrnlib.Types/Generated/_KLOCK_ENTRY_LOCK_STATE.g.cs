using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KLOCK_ENTRY_LOCK_STATE
{
    [FieldOffset(0)]
    public IntPtr LockState;
}
