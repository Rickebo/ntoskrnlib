#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public partial struct _TRACE_LOGFILE_HEADER
    {
        [FieldOffset(0)]
        public uint BufferSize;
        [FieldOffset(4)]
        public uint Version;
        [FieldOffset(4)]
        public _unnamed_tag_ VersionDetail;
        [FieldOffset(8)]
        public uint ProviderVersion;
        [FieldOffset(12)]
        public uint NumberOfProcessors;
        [FieldOffset(16)]
        public _LARGE_INTEGER EndTime;
        [FieldOffset(24)]
        public uint TimerResolution;
        [FieldOffset(28)]
        public uint MaximumFileSize;
        [FieldOffset(32)]
        public uint LogFileMode;
        [FieldOffset(36)]
        public uint BuffersWritten;
        [FieldOffset(40)]
        public _GUID LogInstanceGuid;
        [FieldOffset(40)]
        public uint StartBuffers;
        [FieldOffset(44)]
        public uint PointerSize;
        [FieldOffset(48)]
        public uint EventsLost;
        [FieldOffset(52)]
        public uint CpuSpeedInMHz;
        [FieldOffset(56)]
        public IntPtr LoggerName;
        [FieldOffset(64)]
        public IntPtr LogFileName;
        [FieldOffset(72)]
        public _RTL_TIME_ZONE_INFORMATION TimeZone;
        [FieldOffset(248)]
        public _LARGE_INTEGER BootTime;
        [FieldOffset(256)]
        public _LARGE_INTEGER PerfFreq;
        [FieldOffset(264)]
        public _LARGE_INTEGER StartTime;
        [FieldOffset(272)]
        public uint ReservedFlags;
        [FieldOffset(276)]
        public uint BuffersLost;
    }
}