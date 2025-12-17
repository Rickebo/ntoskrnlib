#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 296)]
    public partial struct _TP_ALPC
    {
        [FieldOffset(0)]
        public _TP_DIRECT Direct;
        [FieldOffset(72)]
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember;
        [FieldOffset(272)]
        public IntPtr AlpcPort;
        [FieldOffset(280)]
        public int DeferredSendCount;
        [FieldOffset(284)]
        public int LastConcurrencyCount;
        [FieldOffset(288)]
        public uint Flags;
        [FieldOffset(288)]
        public uint ExTypeCallback;
        [FieldOffset(288)]
        public uint CompletionListRegistered;
        [FieldOffset(288)]
        public uint Reserved;
    }
}