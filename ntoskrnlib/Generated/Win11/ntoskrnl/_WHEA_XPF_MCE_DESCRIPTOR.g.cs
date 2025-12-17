#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 920)]
    public partial struct _WHEA_XPF_MCE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public byte Enabled;
        [FieldOffset(3)]
        public byte NumberOfBanks;
        [FieldOffset(4)]
        public _XPF_MCE_FLAGS Flags;
        [FieldOffset(8)]
        public ulong MCG_Capability;
        [FieldOffset(16)]
        public ulong MCG_GlobalControl;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _WHEA_XPF_MC_BANK_DESCRIPTOR[] Banks;
    }
}