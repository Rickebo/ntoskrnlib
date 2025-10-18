using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=424)]
public struct _ETW_GUID_ENTRY
{
    [FieldOffset(0)]
    public _LIST_ENTRY GuidList;
    [FieldOffset(16)]
    public _LIST_ENTRY SiloGuidList;
    [FieldOffset(32)]
    public long RefCount;
    [FieldOffset(40)]
    public _GUID Guid;
    [FieldOffset(56)]
    public _LIST_ENTRY RegListHead;
    [FieldOffset(72)]
    public IntPtr SecurityDescriptor;
    [FieldOffset(80)]
    public _ETW_LAST_ENABLE_INFO LastEnable;
    [FieldOffset(80)]
    public ulong MatchId;
    [FieldOffset(96)]
    public _TRACE_ENABLE_INFO ProviderEnableInfo;
    [FieldOffset(128)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public byte[] EnableInfo;
    [FieldOffset(384)]
    public IntPtr FilterData;
    [FieldOffset(392)]
    public IntPtr SiloState;
    [FieldOffset(400)]
    public IntPtr HostEntry;
    [FieldOffset(408)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(416)]
    public IntPtr LockOwner;
}
