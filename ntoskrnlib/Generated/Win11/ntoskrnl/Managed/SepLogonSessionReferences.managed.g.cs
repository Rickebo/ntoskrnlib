using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_LOGON_SESSION_REFERENCES")]
    public sealed class SepLogonSessionReferences : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public Luid LogonId { get => ReadStructure<Luid>(nameof(LogonId)); set => WriteStructure(nameof(LogonId), value); }

        [Offset(16UL)]
        public Luid BuddyLogonId { get => ReadStructure<Luid>(nameof(BuddyLogonId)); set => WriteStructure(nameof(BuddyLogonId), value); }

        [Offset(24UL)]
        public Luid ShadowBuddyLogonId { get => ReadStructure<Luid>(nameof(ShadowBuddyLogonId)); set => WriteStructure(nameof(ShadowBuddyLogonId), value); }

        [Offset(32UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(40UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(48UL)]
        public IntPtr pDeviceMap { get => ReadHere<IntPtr>(nameof(pDeviceMap)); set => WriteHere(nameof(pDeviceMap), value); }

        [Offset(56UL)]
        public IntPtr Token { get => ReadHere<IntPtr>(nameof(Token)); set => WriteHere(nameof(Token), value); }

        [Offset(64UL)]
        public UnicodeString AccountName { get => ReadStructure<UnicodeString>(nameof(AccountName)); set => WriteStructure(nameof(AccountName), value); }

        [Offset(80UL)]
        public UnicodeString AuthorityName { get => ReadStructure<UnicodeString>(nameof(AuthorityName)); set => WriteStructure(nameof(AuthorityName), value); }

        [Offset(96UL)]
        public SepCachedHandlesTable CachedHandlesTable { get => ReadStructure<SepCachedHandlesTable>(nameof(CachedHandlesTable)); set => WriteStructure(nameof(CachedHandlesTable), value); }

        [Offset(112UL)]
        public ExPushLock SharedDataLock { get => ReadStructure<ExPushLock>(nameof(SharedDataLock)); set => WriteStructure(nameof(SharedDataLock), value); }

        [Offset(120UL)]
        public IntPtr SharedClaimAttributes { get => ReadHere<IntPtr>(nameof(SharedClaimAttributes)); set => WriteHere(nameof(SharedClaimAttributes), value); }

        [Offset(128UL)]
        public IntPtr SharedSidValues { get => ReadHere<IntPtr>(nameof(SharedSidValues)); set => WriteHere(nameof(SharedSidValues), value); }

        [Offset(136UL)]
        public ObHandleRevocationBlock RevocationBlock { get => ReadStructure<ObHandleRevocationBlock>(nameof(RevocationBlock)); set => WriteStructure(nameof(RevocationBlock), value); }

        [Offset(168UL)]
        public IntPtr ServerSilo { get => ReadHere<IntPtr>(nameof(ServerSilo)); set => WriteHere(nameof(ServerSilo), value); }

        [Offset(176UL)]
        public Luid SiblingAuthId { get => ReadStructure<Luid>(nameof(SiblingAuthId)); set => WriteStructure(nameof(SiblingAuthId), value); }

        [Offset(184UL)]
        public ListEntry TokenList { get => ReadStructure<ListEntry>(nameof(TokenList)); set => WriteStructure(nameof(TokenList), value); }

        public SepLogonSessionReferences(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepLogonSessionReferences>();
        }
    }
}