#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MAILSLOT_CREATE_PARAMETERS
    {
        [FieldOffset(0)]
        public uint MailslotQuota;
        [FieldOffset(4)]
        public uint MaximumMessageSize;
        [FieldOffset(8)]
        public _LARGE_INTEGER ReadTimeout;
        [FieldOffset(16)]
        public byte TimeoutSpecified;
    }
}