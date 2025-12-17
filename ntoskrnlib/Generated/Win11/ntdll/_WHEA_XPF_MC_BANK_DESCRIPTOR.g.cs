#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _WHEA_XPF_MC_BANK_DESCRIPTOR
    {
        [FieldOffset(0)]
        public byte BankNumber;
        [FieldOffset(1)]
        public byte ClearOnInitialization;
        [FieldOffset(2)]
        public byte StatusDataFormat;
        [FieldOffset(3)]
        public _XPF_MC_BANK_FLAGS Flags;
        [FieldOffset(4)]
        public uint ControlMsr;
        [FieldOffset(8)]
        public uint StatusMsr;
        [FieldOffset(12)]
        public uint AddressMsr;
        [FieldOffset(16)]
        public uint MiscMsr;
        [FieldOffset(20)]
        public ulong ControlData;
    }
}