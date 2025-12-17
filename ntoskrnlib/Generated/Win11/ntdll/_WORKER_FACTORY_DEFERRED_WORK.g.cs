#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _WORKER_FACTORY_DEFERRED_WORK
    {
        [FieldOffset(0)]
        public IntPtr AlpcSendMessage;
        [FieldOffset(8)]
        public IntPtr AlpcSendMessagePort;
        [FieldOffset(16)]
        public uint AlpcSendMessageFlags;
        [FieldOffset(20)]
        public uint Flags;
    }
}