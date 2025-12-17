#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1192)]
    public partial struct _WHEA_XPF_MCA_SECTION
    {
        [FieldOffset(0)]
        public uint VersionNumber;
        [FieldOffset(4)]
        public uint CpuVendor;
        [FieldOffset(8)]
        public _LARGE_INTEGER Timestamp;
        [FieldOffset(16)]
        public uint ProcessorNumber;
        [FieldOffset(20)]
        public _MCG_STATUS GlobalStatus;
        [FieldOffset(28)]
        public ulong InstructionPointer;
        [FieldOffset(36)]
        public uint BankNumber;
        [FieldOffset(40)]
        public _MCI_STATUS Status;
        [FieldOffset(48)]
        public ulong Address;
        [FieldOffset(56)]
        public ulong Misc;
        [FieldOffset(64)]
        public uint ExtendedRegisterCount;
        [FieldOffset(68)]
        public uint ApicId;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public ulong[] ExtendedRegisters;
        [FieldOffset(72)]
        public _WHEA_AMD_EXTENDED_REGISTERS AMDExtendedRegisters;
        [FieldOffset(264)]
        public _MCG_CAP GlobalCapability;
        [FieldOffset(272)]
        public _XPF_RECOVERY_INFO RecoveryInfo;
        [FieldOffset(292)]
        public uint ExBankCount;
        [FieldOffset(296)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] BankNumberEx;
        [FieldOffset(424)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _MCI_STATUS[] StatusEx;
        [FieldOffset(680)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] AddressEx;
        [FieldOffset(936)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] MiscEx;
    }
}