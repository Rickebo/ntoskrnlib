#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public partial struct _DUMP_STACK_CONTEXT
    {
        [FieldOffset(0)]
        public _DUMP_INITIALIZATION_CONTEXT Init;
        [FieldOffset(264)]
        public _LARGE_INTEGER PartitionOffset;
        [FieldOffset(272)]
        public IntPtr DumpPointers;
        [FieldOffset(272)]
        public IntPtr StorageInfo;
        [FieldOffset(280)]
        public byte UseStorageInfo;
        [FieldOffset(284)]
        public uint PointersLength;
        [FieldOffset(288)]
        public IntPtr ModulePrefix;
        [FieldOffset(296)]
        public _LIST_ENTRY DriverList;
        [FieldOffset(312)]
        public _STRING InitMsg;
        [FieldOffset(328)]
        public _STRING ProgMsg;
        [FieldOffset(344)]
        public _STRING DoneMsg;
        [FieldOffset(360)]
        public IntPtr FileObject;
        [FieldOffset(368)]
        public uint UsageType;
    }
}