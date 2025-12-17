using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_CONTROL")]
    public sealed class TokenControl : DynamicStructure
    {
        [Offset(0UL)]
        public Luid TokenId { get => ReadStructure<Luid>(nameof(TokenId)); set => WriteStructure(nameof(TokenId), value); }

        [Offset(8UL)]
        public Luid AuthenticationId { get => ReadStructure<Luid>(nameof(AuthenticationId)); set => WriteStructure(nameof(AuthenticationId), value); }

        [Offset(16UL)]
        public Luid ModifiedId { get => ReadStructure<Luid>(nameof(ModifiedId)); set => WriteStructure(nameof(ModifiedId), value); }

        [Offset(24UL)]
        public TokenSource TokenSource { get => ReadStructure<TokenSource>(nameof(TokenSource)); set => WriteStructure(nameof(TokenSource), value); }

        public TokenControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenControl>();
        }
    }
}