#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1176)]
    public partial struct _TOKEN
    {
        [FieldOffset(0)]
        public _TOKEN_SOURCE TokenSource;
        [FieldOffset(16)]
        public _LUID TokenId;
        [FieldOffset(24)]
        public _LUID AuthenticationId;
        [FieldOffset(32)]
        public _LUID ParentTokenId;
        [FieldOffset(40)]
        public _LARGE_INTEGER ExpirationTime;
        [FieldOffset(48)]
        public IntPtr TokenLock;
        [FieldOffset(56)]
        public _LUID ModifiedId;
        [FieldOffset(64)]
        public _SEP_TOKEN_PRIVILEGES Privileges;
        [FieldOffset(88)]
        public _SEP_AUDIT_POLICY AuditPolicy;
        [FieldOffset(120)]
        public uint SessionId;
        [FieldOffset(124)]
        public uint UserAndGroupCount;
        [FieldOffset(128)]
        public uint RestrictedSidCount;
        [FieldOffset(132)]
        public uint VariableLength;
        [FieldOffset(136)]
        public uint DynamicCharged;
        [FieldOffset(140)]
        public uint DynamicAvailable;
        [FieldOffset(144)]
        public uint DefaultOwnerIndex;
        [FieldOffset(152)]
        public IntPtr UserAndGroups;
        [FieldOffset(160)]
        public IntPtr RestrictedSids;
        [FieldOffset(168)]
        public IntPtr PrimaryGroup;
        [FieldOffset(176)]
        public IntPtr DynamicPart;
        [FieldOffset(184)]
        public IntPtr DefaultDacl;
        [FieldOffset(192)]
        public uint TokenType;
        [FieldOffset(196)]
        public uint ImpersonationLevel;
        [FieldOffset(200)]
        public uint TokenFlags;
        [FieldOffset(204)]
        public byte TokenInUse;
        [FieldOffset(208)]
        public uint IntegrityLevelIndex;
        [FieldOffset(212)]
        public uint MandatoryPolicy;
        [FieldOffset(216)]
        public IntPtr LogonSession;
        [FieldOffset(224)]
        public _LUID OriginatingLogonSession;
        [FieldOffset(232)]
        public _SID_AND_ATTRIBUTES_HASH SidHash;
        [FieldOffset(504)]
        public _SID_AND_ATTRIBUTES_HASH RestrictedSidHash;
        [FieldOffset(776)]
        public IntPtr pSecurityAttributes;
        [FieldOffset(784)]
        public IntPtr Package;
        [FieldOffset(792)]
        public IntPtr Capabilities;
        [FieldOffset(800)]
        public uint CapabilityCount;
        [FieldOffset(808)]
        public _SID_AND_ATTRIBUTES_HASH CapabilitiesHash;
        [FieldOffset(1080)]
        public IntPtr LowboxNumberEntry;
        [FieldOffset(1088)]
        public IntPtr LowboxHandlesEntry;
        [FieldOffset(1096)]
        public IntPtr pClaimAttributes;
        [FieldOffset(1104)]
        public IntPtr TrustLevelSid;
        [FieldOffset(1112)]
        public IntPtr TrustLinkedToken;
        [FieldOffset(1120)]
        public IntPtr IntegrityLevelSidValue;
        [FieldOffset(1128)]
        public IntPtr TokenSidValues;
        [FieldOffset(1136)]
        public IntPtr IndexEntry;
        [FieldOffset(1144)]
        public IntPtr DiagnosticInfo;
        [FieldOffset(1152)]
        public IntPtr BnoIsolationHandlesEntry;
        [FieldOffset(1160)]
        public IntPtr SessionObject;
        [FieldOffset(1168)]
        public ulong VariablePart;
    }
}