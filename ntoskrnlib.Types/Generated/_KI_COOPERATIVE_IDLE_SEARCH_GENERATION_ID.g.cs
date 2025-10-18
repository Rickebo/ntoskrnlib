using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID
{
    [FieldOffset(0)]
    public ulong FullId;
}
