#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _LOADER_PARAMETER_CI_EXTENSION
    {
        [FieldOffset(0)]
        public uint CodeIntegrityOptions;
        [FieldOffset(4)]
        public uint UpgradeInProgress;
        [FieldOffset(4)]
        public uint IsWinPE;
        [FieldOffset(4)]
        public uint CustomKernelSignersAllowed;
        [FieldOffset(4)]
        public uint StateSeparationEnabled;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public _LARGE_INTEGER WhqlEnforcementDate;
        [FieldOffset(16)]
        public uint RevocationListOffset;
        [FieldOffset(20)]
        public uint RevocationListSize;
        [FieldOffset(24)]
        public uint CodeIntegrityPolicyOffset;
        [FieldOffset(28)]
        public uint CodeIntegrityPolicySize;
        [FieldOffset(32)]
        public uint CodeIntegrityPolicyHashOffset;
        [FieldOffset(36)]
        public uint CodeIntegrityPolicyHashSize;
        [FieldOffset(40)]
        public uint CodeIntegrityPolicyOriginalHashOffset;
        [FieldOffset(44)]
        public uint CodeIntegrityPolicyOriginalHashSize;
        [FieldOffset(48)]
        public int WeakCryptoPolicyLoadStatus;
        [FieldOffset(52)]
        public uint WeakCryptoPolicyOffset;
        [FieldOffset(56)]
        public uint WeakCryptoPolicySize;
        [FieldOffset(60)]
        public uint SecureBootPolicyOffset;
        [FieldOffset(64)]
        public uint SecureBootPolicySize;
        [FieldOffset(68)]
        public uint CurrentBootId;
        [FieldOffset(72)]
        public _LARGE_INTEGER RevocationListCreationTimeLCUType;
        [FieldOffset(80)]
        public _LARGE_INTEGER RevocationListCreationTimeLCUAntidoteType;
        [FieldOffset(88)]
        public _LARGE_INTEGER RevocationListCreationTimeUpdateType;
        [FieldOffset(96)]
        public _LARGE_INTEGER RevocationListCreationTimeUpdateAntidoteType;
        [FieldOffset(104)]
        public uint CurrentRevocationListType;
        [FieldOffset(108)]
        public uint Reserved2;
        [FieldOffset(112)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] SerializedData;
    }
}