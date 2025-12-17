#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public partial struct _ETW_WMITRACE_WORK
    {
        [FieldOffset(0)]
        public uint LoggerId;
        [FieldOffset(4)]
        public uint SiloSessionId;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
        public sbyte[] LoggerName;
        [FieldOffset(73)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
        public sbyte[] FileName;
        [FieldOffset(204)]
        public uint MaximumFileSize;
        [FieldOffset(208)]
        public uint MinBuffers;
        [FieldOffset(212)]
        public uint MaxBuffers;
        [FieldOffset(216)]
        public uint BufferSize;
        [FieldOffset(220)]
        public uint Mode;
        [FieldOffset(224)]
        public uint FlushTimer;
        [FieldOffset(8)]
        public ulong MatchAny;
        [FieldOffset(16)]
        public ulong MatchAll;
        [FieldOffset(24)]
        public uint EnableProperty;
        [FieldOffset(28)]
        public _GUID Guid;
        [FieldOffset(44)]
        public byte Level;
        [FieldOffset(232)]
        public int Status;
    }
}