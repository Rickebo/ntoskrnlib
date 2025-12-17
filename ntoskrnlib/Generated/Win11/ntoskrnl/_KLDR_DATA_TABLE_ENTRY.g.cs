#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _KLDR_DATA_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY InLoadOrderLinks;
        [FieldOffset(16)]
        public IntPtr ExceptionTable;
        [FieldOffset(24)]
        public uint ExceptionTableSize;
        [FieldOffset(32)]
        public IntPtr GpValue;
        [FieldOffset(40)]
        public IntPtr NonPagedDebugInfo;
        [FieldOffset(48)]
        public IntPtr DllBase;
        [FieldOffset(56)]
        public IntPtr EntryPoint;
        [FieldOffset(64)]
        public uint SizeOfImage;
        [FieldOffset(72)]
        public _UNICODE_STRING FullDllName;
        [FieldOffset(88)]
        public _UNICODE_STRING BaseDllName;
        [FieldOffset(104)]
        public uint Flags;
        [FieldOffset(108)]
        public ushort LoadCount;
        [FieldOffset(110)]
        public _unnamed_tag_ u1;
        [FieldOffset(112)]
        public IntPtr SectionPointer;
        [FieldOffset(120)]
        public uint CheckSum;
        [FieldOffset(124)]
        public uint CoverageSectionSize;
        [FieldOffset(128)]
        public IntPtr CoverageSection;
        [FieldOffset(136)]
        public IntPtr LoadedImports;
        [FieldOffset(144)]
        public IntPtr Spare;
        [FieldOffset(144)]
        public IntPtr NtDataTableEntry;
        [FieldOffset(152)]
        public uint SizeOfImageNotRounded;
        [FieldOffset(156)]
        public uint TimeDateStamp;
    }
}