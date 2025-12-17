#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _TOKEN_ACCESS_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr SidHash;
        [FieldOffset(8)]
        public IntPtr RestrictedSidHash;
        [FieldOffset(16)]
        public IntPtr Privileges;
        [FieldOffset(24)]
        public _LUID AuthenticationId;
        [FieldOffset(32)]
        public uint TokenType;
        [FieldOffset(36)]
        public uint ImpersonationLevel;
        [FieldOffset(40)]
        public _TOKEN_MANDATORY_POLICY MandatoryPolicy;
        [FieldOffset(44)]
        public uint Flags;
        [FieldOffset(48)]
        public uint AppContainerNumber;
        [FieldOffset(56)]
        public IntPtr PackageSid;
        [FieldOffset(64)]
        public IntPtr CapabilitiesHash;
        [FieldOffset(72)]
        public IntPtr TrustLevelSid;
        [FieldOffset(80)]
        public IntPtr SecurityAttributes;
    }
}