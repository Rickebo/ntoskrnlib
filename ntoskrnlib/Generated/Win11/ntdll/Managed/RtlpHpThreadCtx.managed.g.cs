using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTLP_HP_THREAD_CTX")]
    public sealed class RtlpHpThreadCtx : DynamicStructure
    {
        [Offset(0UL)]
        public byte LegacyVirtualAffinity { get => ReadHere<byte>(nameof(LegacyVirtualAffinity)); set => WriteHere(nameof(LegacyVirtualAffinity), value); }

        [Offset(1UL)]
        public byte CachedProcIndex { get => ReadHere<byte>(nameof(CachedProcIndex)); set => WriteHere(nameof(CachedProcIndex), value); }

        [Offset(2UL)]
        public ushort LFHDataSlot { get => ReadHere<ushort>(nameof(LFHDataSlot)); set => WriteHere(nameof(LFHDataSlot), value); }

        [Offset(0UL)]
        public uint EntireUlong { get => ReadHere<uint>(nameof(EntireUlong)); set => WriteHere(nameof(EntireUlong), value); }

        public RtlpHpThreadCtx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpThreadCtx>();
        }
    }
}