#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 368)]
    public partial struct _LOADER_PARAMETER_BLOCK
    {
        [FieldOffset(0)]
        public uint OsMajorVersion;
        [FieldOffset(4)]
        public uint OsMinorVersion;
        [FieldOffset(8)]
        public uint Size;
        [FieldOffset(12)]
        public uint OsLoaderSecurityVersion;
        [FieldOffset(16)]
        public _LIST_ENTRY LoadOrderListHead;
        [FieldOffset(32)]
        public _LIST_ENTRY MemoryDescriptorListHead;
        [FieldOffset(48)]
        public _LIST_ENTRY BootDriverListHead;
        [FieldOffset(64)]
        public _LIST_ENTRY EarlyLaunchListHead;
        [FieldOffset(80)]
        public _LIST_ENTRY CoreDriverListHead;
        [FieldOffset(96)]
        public _LIST_ENTRY CoreExtensionsDriverListHead;
        [FieldOffset(112)]
        public _LIST_ENTRY TpmCoreDriverListHead;
        [FieldOffset(128)]
        public ulong KernelStack;
        [FieldOffset(136)]
        public ulong Prcb;
        [FieldOffset(144)]
        public ulong Process;
        [FieldOffset(152)]
        public ulong Thread;
        [FieldOffset(160)]
        public uint KernelStackSize;
        [FieldOffset(164)]
        public uint RegistryLength;
        [FieldOffset(168)]
        public IntPtr RegistryBase;
        [FieldOffset(176)]
        public IntPtr ConfigurationRoot;
        [FieldOffset(184)]
        public IntPtr ArcBootDeviceName;
        [FieldOffset(192)]
        public IntPtr ArcHalDeviceName;
        [FieldOffset(200)]
        public IntPtr NtBootPathName;
        [FieldOffset(208)]
        public IntPtr NtHalPathName;
        [FieldOffset(216)]
        public IntPtr LoadOptions;
        [FieldOffset(224)]
        public IntPtr NlsData;
        [FieldOffset(232)]
        public IntPtr ArcDiskInformation;
        [FieldOffset(240)]
        public IntPtr Extension;
        [FieldOffset(248)]
        public _unnamed_tag_ u;
        [FieldOffset(264)]
        public _FIRMWARE_INFORMATION_LOADER_BLOCK FirmwareInformation;
        [FieldOffset(328)]
        public IntPtr OsBootstatPathName;
        [FieldOffset(336)]
        public IntPtr ArcOSDataDeviceName;
        [FieldOffset(344)]
        public IntPtr ArcWindowsSysPartName;
        [FieldOffset(352)]
        public _RTL_RB_TREE MemoryDescriptorTree;
    }
}