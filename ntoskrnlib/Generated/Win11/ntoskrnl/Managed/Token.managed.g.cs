using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN")]
    public sealed class Token : DynamicStructure
    {
        [Offset(0UL)]
        public TokenSource TokenSource { get => ReadStructure<TokenSource>(nameof(TokenSource)); set => WriteStructure(nameof(TokenSource), value); }

        [Offset(16UL)]
        public Luid TokenId { get => ReadStructure<Luid>(nameof(TokenId)); set => WriteStructure(nameof(TokenId), value); }

        [Offset(24UL)]
        public Luid AuthenticationId { get => ReadStructure<Luid>(nameof(AuthenticationId)); set => WriteStructure(nameof(AuthenticationId), value); }

        [Offset(32UL)]
        public Luid ParentTokenId { get => ReadStructure<Luid>(nameof(ParentTokenId)); set => WriteStructure(nameof(ParentTokenId), value); }

        [Offset(40UL)]
        public LargeInteger ExpirationTime { get => ReadStructure<LargeInteger>(nameof(ExpirationTime)); set => WriteStructure(nameof(ExpirationTime), value); }

        [Offset(48UL)]
        public IntPtr TokenLock { get => ReadHere<IntPtr>(nameof(TokenLock)); set => WriteHere(nameof(TokenLock), value); }

        [Offset(56UL)]
        public Luid ModifiedId { get => ReadStructure<Luid>(nameof(ModifiedId)); set => WriteStructure(nameof(ModifiedId), value); }

        [Offset(64UL)]
        public SepTokenPrivileges Privileges { get => ReadStructure<SepTokenPrivileges>(nameof(Privileges)); set => WriteStructure(nameof(Privileges), value); }

        [Offset(88UL)]
        public SepAuditPolicy AuditPolicy { get => ReadStructure<SepAuditPolicy>(nameof(AuditPolicy)); set => WriteStructure(nameof(AuditPolicy), value); }

        [Offset(120UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(124UL)]
        public uint UserAndGroupCount { get => ReadHere<uint>(nameof(UserAndGroupCount)); set => WriteHere(nameof(UserAndGroupCount), value); }

        [Offset(128UL)]
        public uint RestrictedSidCount { get => ReadHere<uint>(nameof(RestrictedSidCount)); set => WriteHere(nameof(RestrictedSidCount), value); }

        [Offset(132UL)]
        public uint VariableLength { get => ReadHere<uint>(nameof(VariableLength)); set => WriteHere(nameof(VariableLength), value); }

        [Offset(136UL)]
        public uint DynamicCharged { get => ReadHere<uint>(nameof(DynamicCharged)); set => WriteHere(nameof(DynamicCharged), value); }

        [Offset(140UL)]
        public uint DynamicAvailable { get => ReadHere<uint>(nameof(DynamicAvailable)); set => WriteHere(nameof(DynamicAvailable), value); }

        [Offset(144UL)]
        public uint DefaultOwnerIndex { get => ReadHere<uint>(nameof(DefaultOwnerIndex)); set => WriteHere(nameof(DefaultOwnerIndex), value); }

        [Offset(152UL)]
        public IntPtr UserAndGroups { get => ReadHere<IntPtr>(nameof(UserAndGroups)); set => WriteHere(nameof(UserAndGroups), value); }

        [Offset(160UL)]
        public IntPtr RestrictedSids { get => ReadHere<IntPtr>(nameof(RestrictedSids)); set => WriteHere(nameof(RestrictedSids), value); }

        [Offset(168UL)]
        public IntPtr PrimaryGroup { get => ReadHere<IntPtr>(nameof(PrimaryGroup)); set => WriteHere(nameof(PrimaryGroup), value); }

        [Offset(176UL)]
        public IntPtr DynamicPart { get => ReadHere<IntPtr>(nameof(DynamicPart)); set => WriteHere(nameof(DynamicPart), value); }

        [Offset(184UL)]
        public IntPtr DefaultDacl { get => ReadHere<IntPtr>(nameof(DefaultDacl)); set => WriteHere(nameof(DefaultDacl), value); }

        [Offset(192UL)]
        public uint TokenType { get => ReadHere<uint>(nameof(TokenType)); set => WriteHere(nameof(TokenType), value); }

        [Offset(196UL)]
        public uint ImpersonationLevel { get => ReadHere<uint>(nameof(ImpersonationLevel)); set => WriteHere(nameof(ImpersonationLevel), value); }

        [Offset(200UL)]
        public uint TokenFlags { get => ReadHere<uint>(nameof(TokenFlags)); set => WriteHere(nameof(TokenFlags), value); }

        [Offset(204UL)]
        public byte TokenInUse { get => ReadHere<byte>(nameof(TokenInUse)); set => WriteHere(nameof(TokenInUse), value); }

        [Offset(208UL)]
        public uint IntegrityLevelIndex { get => ReadHere<uint>(nameof(IntegrityLevelIndex)); set => WriteHere(nameof(IntegrityLevelIndex), value); }

        [Offset(212UL)]
        public uint MandatoryPolicy { get => ReadHere<uint>(nameof(MandatoryPolicy)); set => WriteHere(nameof(MandatoryPolicy), value); }

        [Offset(216UL)]
        public IntPtr LogonSession { get => ReadHere<IntPtr>(nameof(LogonSession)); set => WriteHere(nameof(LogonSession), value); }

        [Offset(224UL)]
        public Luid OriginatingLogonSession { get => ReadStructure<Luid>(nameof(OriginatingLogonSession)); set => WriteStructure(nameof(OriginatingLogonSession), value); }

        [Offset(232UL)]
        public SidAndAttributesHash SidHash { get => ReadStructure<SidAndAttributesHash>(nameof(SidHash)); set => WriteStructure(nameof(SidHash), value); }

        [Offset(504UL)]
        public SidAndAttributesHash RestrictedSidHash { get => ReadStructure<SidAndAttributesHash>(nameof(RestrictedSidHash)); set => WriteStructure(nameof(RestrictedSidHash), value); }

        [Offset(776UL)]
        public IntPtr pSecurityAttributes { get => ReadHere<IntPtr>(nameof(pSecurityAttributes)); set => WriteHere(nameof(pSecurityAttributes), value); }

        [Offset(784UL)]
        public IntPtr Package { get => ReadHere<IntPtr>(nameof(Package)); set => WriteHere(nameof(Package), value); }

        [Offset(792UL)]
        public IntPtr Capabilities { get => ReadHere<IntPtr>(nameof(Capabilities)); set => WriteHere(nameof(Capabilities), value); }

        [Offset(800UL)]
        public uint CapabilityCount { get => ReadHere<uint>(nameof(CapabilityCount)); set => WriteHere(nameof(CapabilityCount), value); }

        [Offset(808UL)]
        public SidAndAttributesHash CapabilitiesHash { get => ReadStructure<SidAndAttributesHash>(nameof(CapabilitiesHash)); set => WriteStructure(nameof(CapabilitiesHash), value); }

        [Offset(1080UL)]
        public IntPtr LowboxNumberEntry { get => ReadHere<IntPtr>(nameof(LowboxNumberEntry)); set => WriteHere(nameof(LowboxNumberEntry), value); }

        [Offset(1088UL)]
        public IntPtr LowboxHandlesEntry { get => ReadHere<IntPtr>(nameof(LowboxHandlesEntry)); set => WriteHere(nameof(LowboxHandlesEntry), value); }

        [Offset(1096UL)]
        public IntPtr pClaimAttributes { get => ReadHere<IntPtr>(nameof(pClaimAttributes)); set => WriteHere(nameof(pClaimAttributes), value); }

        [Offset(1104UL)]
        public IntPtr TrustLevelSid { get => ReadHere<IntPtr>(nameof(TrustLevelSid)); set => WriteHere(nameof(TrustLevelSid), value); }

        [Offset(1112UL)]
        public IntPtr TrustLinkedToken { get => ReadHere<IntPtr>(nameof(TrustLinkedToken)); set => WriteHere(nameof(TrustLinkedToken), value); }

        [Offset(1120UL)]
        public IntPtr IntegrityLevelSidValue { get => ReadHere<IntPtr>(nameof(IntegrityLevelSidValue)); set => WriteHere(nameof(IntegrityLevelSidValue), value); }

        [Offset(1128UL)]
        public IntPtr TokenSidValues { get => ReadHere<IntPtr>(nameof(TokenSidValues)); set => WriteHere(nameof(TokenSidValues), value); }

        [Offset(1136UL)]
        public IntPtr IndexEntry { get => ReadHere<IntPtr>(nameof(IndexEntry)); set => WriteHere(nameof(IndexEntry), value); }

        [Offset(1144UL)]
        public IntPtr DiagnosticInfo { get => ReadHere<IntPtr>(nameof(DiagnosticInfo)); set => WriteHere(nameof(DiagnosticInfo), value); }

        [Offset(1152UL)]
        public IntPtr BnoIsolationHandlesEntry { get => ReadHere<IntPtr>(nameof(BnoIsolationHandlesEntry)); set => WriteHere(nameof(BnoIsolationHandlesEntry), value); }

        [Offset(1160UL)]
        public IntPtr SessionObject { get => ReadHere<IntPtr>(nameof(SessionObject)); set => WriteHere(nameof(SessionObject), value); }

        [Offset(1168UL)]
        public ulong VariablePart { get => ReadHere<ulong>(nameof(VariablePart)); set => WriteHere(nameof(VariablePart), value); }

        public Token(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Token>();
        }
    }
}