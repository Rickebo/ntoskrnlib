using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_CLIENT_SECURITY_CONTEXT")]
    public sealed class PsClientSecurityContext : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ImpersonationData { get => ReadHere<ulong>(nameof(ImpersonationData)); set => WriteHere(nameof(ImpersonationData), value); }

        [Offset(0UL)]
        public IntPtr ImpersonationToken { get => ReadHere<IntPtr>(nameof(ImpersonationToken)); set => WriteHere(nameof(ImpersonationToken), value); }

        [Offset(0UL)]
        public ulong ImpersonationLevel { get => ReadHere<ulong>(nameof(ImpersonationLevel)); set => WriteHere(nameof(ImpersonationLevel), value); }

        [Offset(0UL)]
        public ulong EffectiveOnly { get => ReadHere<ulong>(nameof(EffectiveOnly)); set => WriteHere(nameof(EffectiveOnly), value); }

        public PsClientSecurityContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsClientSecurityContext>();
        }
    }
}