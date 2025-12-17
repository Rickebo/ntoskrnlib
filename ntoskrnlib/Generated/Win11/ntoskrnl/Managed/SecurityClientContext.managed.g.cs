using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECURITY_CLIENT_CONTEXT")]
    public sealed class SecurityClientContext : DynamicStructure
    {
        [Offset(0UL)]
        public SecurityQualityOfService SecurityQos { get => ReadStructure<SecurityQualityOfService>(nameof(SecurityQos)); set => WriteStructure(nameof(SecurityQos), value); }

        [Offset(16UL)]
        public IntPtr ClientToken { get => ReadHere<IntPtr>(nameof(ClientToken)); set => WriteHere(nameof(ClientToken), value); }

        [Offset(24UL)]
        public byte DirectlyAccessClientToken { get => ReadHere<byte>(nameof(DirectlyAccessClientToken)); set => WriteHere(nameof(DirectlyAccessClientToken), value); }

        [Offset(25UL)]
        public byte DirectAccessEffectiveOnly { get => ReadHere<byte>(nameof(DirectAccessEffectiveOnly)); set => WriteHere(nameof(DirectAccessEffectiveOnly), value); }

        [Offset(26UL)]
        public byte ServerIsRemote { get => ReadHere<byte>(nameof(ServerIsRemote)); set => WriteHere(nameof(ServerIsRemote), value); }

        [Offset(28UL)]
        public TokenControl ClientTokenControl { get => ReadStructure<TokenControl>(nameof(ClientTokenControl)); set => WriteStructure(nameof(ClientTokenControl), value); }

        public SecurityClientContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecurityClientContext>();
        }
    }
}