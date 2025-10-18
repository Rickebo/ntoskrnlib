using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT
{
    [FieldOffset(0)]
    public uint Level;
    [FieldOffset(4)]
    public uint Slot;
}
