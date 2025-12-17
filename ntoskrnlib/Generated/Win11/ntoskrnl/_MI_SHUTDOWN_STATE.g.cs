#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _MI_SHUTDOWN_STATE
    {
        [FieldOffset(0)]
        public byte CrashDumpInitialized;
        [FieldOffset(1)]
        public byte ConnectedStandbyActive;
        [FieldOffset(2)]
        public byte ZeroPageFileAtShutdown;
        [FieldOffset(3)]
        public byte CacheConflictsAllowed;
        [FieldOffset(4)]
        public uint SystemShutdown;
        [FieldOffset(8)]
        public int ShutdownFlushInProgress;
        [FieldOffset(12)]
        public uint MirroringActive;
        [FieldOffset(16)]
        public _MI_RESUME_WORKITEM ResumeItem;
        [FieldOffset(72)]
        public IntPtr MirrorHoldsPfn;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BITMAP_EX[] MirrorBitMaps;
        [FieldOffset(112)]
        public uint MirrorBitMapState;
        [FieldOffset(120)]
        public IntPtr CrashDumpPte;
    }
}