#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MMVAD_SHORT
    {
        [FieldOffset(0)]
        public IntPtr NextVad;
        [FieldOffset(8)]
        public IntPtr ExtraCreateInfo;
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE VadNode;
        [FieldOffset(24)]
        public uint StartingVpn;
        [FieldOffset(28)]
        public uint EndingVpn;
        [FieldOffset(32)]
        public byte StartingVpnHigh;
        [FieldOffset(33)]
        public byte EndingVpnHigh;
        [FieldOffset(34)]
        public byte CommitChargeHigh;
        [FieldOffset(35)]
        public byte SpareNT64VadUChar;
        [FieldOffset(36)]
        public int ReferenceCount;
        [FieldOffset(40)]
        public _EX_PUSH_LOCK PushLock;
        [FieldOffset(48)]
        public _unnamed_tag_ u;
        [FieldOffset(52)]
        public uint CommitCharge;
        [FieldOffset(56)]
        public _unnamed_tag_ u5;
    }
}