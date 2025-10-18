using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1072)]
public struct _KI_COOPERATIVE_IDLE_SEARCH_CONTEXT
{
    [FieldOffset(0)]
    public ulong SearchContextLock;
    [FieldOffset(8)]
    public ulong SearchingProcessors;
    [FieldOffset(16)]
    public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID NextGenerationId;
    [FieldOffset(24)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public byte[] GenerationIds;
    [FieldOffset(536)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public byte[] Generations;
    [FieldOffset(1048)]
    public ulong Affinity;
    [FieldOffset(1056)]
    public ushort AllocatedTargetEntries;
    [FieldOffset(1058)]
    public ushort ActiveTargetEntries;
    [FieldOffset(1060)]
    public byte LowProcIndex;
    [FieldOffset(1061)]
    public byte HighProcIndex;
    [FieldOffset(1062)]
    public ushort Group;
    [FieldOffset(1064)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] ExtensionStart;
}
