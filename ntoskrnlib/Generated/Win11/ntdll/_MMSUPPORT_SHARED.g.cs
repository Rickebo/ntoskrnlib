#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _MMSUPPORT_SHARED
    {
        [FieldOffset(0)]
        public IntPtr WorkingSetLockArray;
        [FieldOffset(8)]
        public ulong ReleasedCommitDebt;
        [FieldOffset(16)]
        public ulong ResetPagesRepurposedCount;
        [FieldOffset(24)]
        public IntPtr WsSwapSupport;
        [FieldOffset(32)]
        public IntPtr CommitReleaseContext;
        [FieldOffset(40)]
        public IntPtr AccessLog;
        [FieldOffset(48)]
        public ulong ChargedWslePages;
        [FieldOffset(56)]
        public ulong ActualWslePages;
        [FieldOffset(64)]
        public int WorkingSetCoreLock;
        [FieldOffset(72)]
        public IntPtr ShadowMapping;
    }
}