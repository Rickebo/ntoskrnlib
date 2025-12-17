using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN")]
    public sealed class _TOKEN : DynamicStructure
    {
        public _TOKEN_SOURCE TokenSource { get; }
        public _LUID TokenId { get; }
        public _LUID AuthenticationId { get; }
        public _LUID ParentTokenId { get; }
        public _LARGE_INTEGER ExpirationTime { get; }
        public IntPtr TokenLock { get; }
        public _LUID ModifiedId { get; }
        public _SEP_TOKEN_PRIVILEGES Privileges { get; }
        public _SEP_AUDIT_POLICY AuditPolicy { get; }
        public uint SessionId { get; }
        public uint UserAndGroupCount { get; }
        public uint RestrictedSidCount { get; }
        public uint VariableLength { get; }
        public uint DynamicCharged { get; }
        public uint DynamicAvailable { get; }
        public uint DefaultOwnerIndex { get; }
        public IntPtr UserAndGroups { get; }
        public IntPtr RestrictedSids { get; }
        public IntPtr PrimaryGroup { get; }
        public IntPtr DynamicPart { get; }
        public IntPtr DefaultDacl { get; }
        public uint TokenType { get; }
        public uint ImpersonationLevel { get; }
        public uint TokenFlags { get; }
        public byte TokenInUse { get; }
        public uint IntegrityLevelIndex { get; }
        public uint MandatoryPolicy { get; }
        public IntPtr LogonSession { get; }
        public _LUID OriginatingLogonSession { get; }
        public _SID_AND_ATTRIBUTES_HASH SidHash { get; }
        public _SID_AND_ATTRIBUTES_HASH RestrictedSidHash { get; }
        public IntPtr pSecurityAttributes { get; }
        public IntPtr Package { get; }
        public IntPtr Capabilities { get; }
        public uint CapabilityCount { get; }
        public _SID_AND_ATTRIBUTES_HASH CapabilitiesHash { get; }
        public IntPtr LowboxNumberEntry { get; }
        public IntPtr LowboxHandlesEntry { get; }
        public IntPtr pClaimAttributes { get; }
        public IntPtr TrustLevelSid { get; }
        public IntPtr TrustLinkedToken { get; }
        public IntPtr IntegrityLevelSidValue { get; }
        public IntPtr TokenSidValues { get; }
        public IntPtr IndexEntry { get; }
        public IntPtr DiagnosticInfo { get; }
        public IntPtr BnoIsolationHandlesEntry { get; }
        public IntPtr SessionObject { get; }
        public ulong VariablePart { get; }

        public _TOKEN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN.TokenSource),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TOKEN.TokenId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TOKEN.AuthenticationId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TOKEN.ParentTokenId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TOKEN.ExpirationTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TOKEN.TokenLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TOKEN.ModifiedId),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TOKEN.Privileges),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TOKEN.AuditPolicy),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TOKEN.SessionId),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_TOKEN.UserAndGroupCount),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_TOKEN.RestrictedSidCount),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TOKEN.VariableLength),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_TOKEN.DynamicCharged),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_TOKEN.DynamicAvailable),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_TOKEN.DefaultOwnerIndex),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_TOKEN.UserAndGroups),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_TOKEN.RestrictedSids),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_TOKEN.PrimaryGroup),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TOKEN.DynamicPart),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_TOKEN.DefaultDacl),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_TOKEN.TokenType),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_TOKEN.ImpersonationLevel),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_TOKEN.TokenFlags),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_TOKEN.TokenInUse),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_TOKEN.IntegrityLevelIndex),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_TOKEN.MandatoryPolicy),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_TOKEN.LogonSession),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_TOKEN.OriginatingLogonSession),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_TOKEN.SidHash),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_TOKEN.RestrictedSidHash),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_TOKEN.pSecurityAttributes),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_TOKEN.Package),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_TOKEN.Capabilities),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_TOKEN.CapabilityCount),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_TOKEN.CapabilitiesHash),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_TOKEN.LowboxNumberEntry),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_TOKEN.LowboxHandlesEntry),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_TOKEN.pClaimAttributes),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(_TOKEN.TrustLevelSid),
                    new ulong[]
                    {
                        1104UL
                    }
                },
                {
                    nameof(_TOKEN.TrustLinkedToken),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_TOKEN.IntegrityLevelSidValue),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(_TOKEN.TokenSidValues),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(_TOKEN.IndexEntry),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(_TOKEN.DiagnosticInfo),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(_TOKEN.BnoIsolationHandlesEntry),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_TOKEN.SessionObject),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(_TOKEN.VariablePart),
                    new ulong[]
                    {
                        1168UL
                    }
                }
            };
            Register<_TOKEN>((mem, ptr) => new _TOKEN(mem, ptr), offsets);
        }
    }
}