#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct PROCESSOR_IDLESTATE_POLICY
    {
        [FieldOffset(0)]
        public ushort Revision;
        [FieldOffset(2)]
        public _unnamed_tag_ Flags;
        [FieldOffset(4)]
        public uint PolicyCount;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public PROCESSOR_IDLESTATE_INFO[] Policy;
    }
}