#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _NAMED_PIPE_CREATE_PARAMETERS
    {
        [FieldOffset(0)]
        public uint NamedPipeType;
        [FieldOffset(4)]
        public uint ReadMode;
        [FieldOffset(8)]
        public uint CompletionMode;
        [FieldOffset(12)]
        public uint MaximumInstances;
        [FieldOffset(16)]
        public uint InboundQuota;
        [FieldOffset(20)]
        public uint OutboundQuota;
        [FieldOffset(24)]
        public _LARGE_INTEGER DefaultTimeout;
        [FieldOffset(32)]
        public byte TimeoutSpecified;
    }
}