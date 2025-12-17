#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _SECTION
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE SectionNode;
        [FieldOffset(24)]
        public ulong StartingVpn;
        [FieldOffset(32)]
        public ulong EndingVpn;
        [FieldOffset(40)]
        public _unnamed_tag_ u1;
        [FieldOffset(48)]
        public ulong SizeOfSection;
        [FieldOffset(56)]
        public _unnamed_tag_ u;
        [FieldOffset(60)]
        public uint InitialPageProtection;
        [FieldOffset(60)]
        public uint SessionId;
        [FieldOffset(60)]
        public uint NoValidationNeeded;
    }
}