#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _PPM_PLATFORM_STATE
    {
        [FieldOffset(0)]
        public ulong LevelId;
        [FieldOffset(8)]
        public uint Latency;
        [FieldOffset(12)]
        public uint BreakEvenDuration;
        [FieldOffset(16)]
        public _PPM_VETO_ACCOUNTING VetoAccounting;
        [FieldOffset(56)]
        public byte TransitionDebugger;
        [FieldOffset(57)]
        public byte Platform;
        [FieldOffset(58)]
        public byte Enabled;
        [FieldOffset(59)]
        public byte CoordinatedDependencies;
        [FieldOffset(60)]
        public uint DependencyListCount;
        [FieldOffset(64)]
        public _KAFFINITY_EX Processors;
        [FieldOffset(328)]
        public _UNICODE_STRING Name;
        [FieldOffset(344)]
        public IntPtr DependencyLists;
        [FieldOffset(352)]
        public _PPM_COORDINATED_SYNCHRONIZATION Synchronization;
        [FieldOffset(360)]
        public ulong EnterTime;
        [FieldOffset(384)]
        public int RefCount;
        [FieldOffset(384)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] CacheAlign0;
    }
}