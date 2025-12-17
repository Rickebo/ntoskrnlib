#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public partial struct _DUMP_INITIALIZATION_CONTEXT
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public IntPtr MemoryBlock;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] CommonBuffer;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _LARGE_INTEGER[] PhysicalAddress;
        [FieldOffset(48)]
        public IntPtr StallRoutine;
        [FieldOffset(56)]
        public IntPtr OpenRoutine;
        [FieldOffset(64)]
        public IntPtr WriteRoutine;
        [FieldOffset(72)]
        public IntPtr FinishRoutine;
        [FieldOffset(80)]
        public IntPtr AdapterObject;
        [FieldOffset(88)]
        public IntPtr MappedRegisterBase;
        [FieldOffset(96)]
        public IntPtr PortConfiguration;
        [FieldOffset(104)]
        public byte CrashDump;
        [FieldOffset(105)]
        public byte MarkMemoryOnly;
        [FieldOffset(106)]
        public byte HiberResume;
        [FieldOffset(107)]
        public byte InitDumpStackInvoked;
        [FieldOffset(108)]
        public uint MaximumTransferSize;
        [FieldOffset(112)]
        public uint CommonBufferSize;
        [FieldOffset(120)]
        public IntPtr TargetAddress;
        [FieldOffset(128)]
        public IntPtr WritePendingRoutine;
        [FieldOffset(136)]
        public uint PartitionStyle;
        [FieldOffset(140)]
        public _unnamed_tag_ DiskInfo;
        [FieldOffset(160)]
        public IntPtr ReadRoutine;
        [FieldOffset(168)]
        public IntPtr GetDriveTelemetryRoutine;
        [FieldOffset(176)]
        public uint LogSectionTruncateSize;
        [FieldOffset(180)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] Parameters;
        [FieldOffset(248)]
        public IntPtr GetTransferSizesRoutine;
        [FieldOffset(256)]
        public IntPtr DumpNotifyRoutine;
    }
}