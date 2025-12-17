using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_ACCESS_INFORMATION")]
    public sealed class TokenAccessInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SidHash { get => ReadHere<IntPtr>(nameof(SidHash)); set => WriteHere(nameof(SidHash), value); }

        [Offset(8UL)]
        public IntPtr RestrictedSidHash { get => ReadHere<IntPtr>(nameof(RestrictedSidHash)); set => WriteHere(nameof(RestrictedSidHash), value); }

        [Offset(16UL)]
        public IntPtr Privileges { get => ReadHere<IntPtr>(nameof(Privileges)); set => WriteHere(nameof(Privileges), value); }

        [Offset(24UL)]
        public Luid AuthenticationId { get => ReadStructure<Luid>(nameof(AuthenticationId)); set => WriteStructure(nameof(AuthenticationId), value); }

        [Offset(32UL)]
        public uint TokenType { get => ReadHere<uint>(nameof(TokenType)); set => WriteHere(nameof(TokenType), value); }

        [Offset(36UL)]
        public uint ImpersonationLevel { get => ReadHere<uint>(nameof(ImpersonationLevel)); set => WriteHere(nameof(ImpersonationLevel), value); }

        [Offset(40UL)]
        public TokenMandatoryPolicy MandatoryPolicy { get => ReadStructure<TokenMandatoryPolicy>(nameof(MandatoryPolicy)); set => WriteStructure(nameof(MandatoryPolicy), value); }

        [Offset(44UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(48UL)]
        public uint AppContainerNumber { get => ReadHere<uint>(nameof(AppContainerNumber)); set => WriteHere(nameof(AppContainerNumber), value); }

        [Offset(56UL)]
        public IntPtr PackageSid { get => ReadHere<IntPtr>(nameof(PackageSid)); set => WriteHere(nameof(PackageSid), value); }

        [Offset(64UL)]
        public IntPtr CapabilitiesHash { get => ReadHere<IntPtr>(nameof(CapabilitiesHash)); set => WriteHere(nameof(CapabilitiesHash), value); }

        [Offset(72UL)]
        public IntPtr TrustLevelSid { get => ReadHere<IntPtr>(nameof(TrustLevelSid)); set => WriteHere(nameof(TrustLevelSid), value); }

        [Offset(80UL)]
        public IntPtr SecurityAttributes { get => ReadHere<IntPtr>(nameof(SecurityAttributes)); set => WriteHere(nameof(SecurityAttributes), value); }

        public TokenAccessInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenAccessInformation>();
        }
    }
}