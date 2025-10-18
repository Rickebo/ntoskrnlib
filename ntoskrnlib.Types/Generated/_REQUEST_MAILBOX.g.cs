using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _REQUEST_MAILBOX
{
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(8)]
    public ulong RequestSummary;
    [FieldOffset(16)]
    public _KREQUEST_PACKET RequestPacket;
    [FieldOffset(48)]
    public IntPtr SubNodeTargetCountAddr;
    [FieldOffset(56)]
    public int SubNodeTargetCount;
}
