using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1096)]
public struct _RTL_USER_PROCESS_PARAMETERS
{
    [FieldOffset(0)]
    public uint MaximumLength;
    [FieldOffset(4)]
    public uint Length;
    [FieldOffset(8)]
    public uint Flags;
    [FieldOffset(12)]
    public uint DebugFlags;
    [FieldOffset(16)]
    public IntPtr ConsoleHandle;
    [FieldOffset(24)]
    public uint ConsoleFlags;
    [FieldOffset(32)]
    public IntPtr StandardInput;
    [FieldOffset(40)]
    public IntPtr StandardOutput;
    [FieldOffset(48)]
    public IntPtr StandardError;
    [FieldOffset(56)]
    public _CURDIR CurrentDirectory;
    [FieldOffset(80)]
    public _UNICODE_STRING DllPath;
    [FieldOffset(96)]
    public _UNICODE_STRING ImagePathName;
    [FieldOffset(112)]
    public _UNICODE_STRING CommandLine;
    [FieldOffset(128)]
    public IntPtr Environment;
    [FieldOffset(136)]
    public uint StartingX;
    [FieldOffset(140)]
    public uint StartingY;
    [FieldOffset(144)]
    public uint CountX;
    [FieldOffset(148)]
    public uint CountY;
    [FieldOffset(152)]
    public uint CountCharsX;
    [FieldOffset(156)]
    public uint CountCharsY;
    [FieldOffset(160)]
    public uint FillAttribute;
    [FieldOffset(164)]
    public uint WindowFlags;
    [FieldOffset(168)]
    public uint ShowWindowFlags;
    [FieldOffset(176)]
    public _UNICODE_STRING WindowTitle;
    [FieldOffset(192)]
    public _UNICODE_STRING DesktopInfo;
    [FieldOffset(208)]
    public _UNICODE_STRING ShellInfo;
    [FieldOffset(224)]
    public _UNICODE_STRING RuntimeData;
    [FieldOffset(240)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] CurrentDirectores;
    [FieldOffset(1008)]
    public ulong EnvironmentSize;
    [FieldOffset(1016)]
    public ulong EnvironmentVersion;
    [FieldOffset(1024)]
    public IntPtr PackageDependencyData;
    [FieldOffset(1032)]
    public uint ProcessGroupId;
    [FieldOffset(1036)]
    public uint LoaderThreads;
    [FieldOffset(1040)]
    public _UNICODE_STRING RedirectionDllName;
    [FieldOffset(1056)]
    public _UNICODE_STRING HeapPartitionName;
    [FieldOffset(1072)]
    public IntPtr DefaultThreadpoolCpuSetMasks;
    [FieldOffset(1080)]
    public uint DefaultThreadpoolCpuSetMaskCount;
    [FieldOffset(1084)]
    public uint DefaultThreadpoolThreadMaximum;
    [FieldOffset(1088)]
    public uint HeapMemoryTypeMask;
}
