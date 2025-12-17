#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 932)]
    public partial struct _WHEA_XPF_CMC_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public byte Enabled;
        [FieldOffset(3)]
        public byte NumberOfBanks;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public _WHEA_NOTIFICATION_DESCRIPTOR Notify;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _WHEA_XPF_MC_BANK_DESCRIPTOR[] Banks;
    }
}