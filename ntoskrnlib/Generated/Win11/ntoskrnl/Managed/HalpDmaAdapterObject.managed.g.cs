using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_ADAPTER_OBJECT")]
    public sealed class HalpDmaAdapterObject : DynamicStructure
    {
        [Offset(0UL)]
        public DmaAdapter DmaHeader { get => ReadStructure<DmaAdapter>(nameof(DmaHeader)); set => WriteStructure(nameof(DmaHeader), value); }

        [Offset(16UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(24UL)]
        public IntPtr ContiguousMapRegisters { get => ReadHere<IntPtr>(nameof(ContiguousMapRegisters)); set => WriteHere(nameof(ContiguousMapRegisters), value); }

        [Offset(32UL)]
        public IntPtr ScatterBufferListHead { get => ReadHere<IntPtr>(nameof(ScatterBufferListHead)); set => WriteHere(nameof(ScatterBufferListHead), value); }

        [Offset(40UL)]
        public uint NumberOfFreeScatterBuffers { get => ReadHere<uint>(nameof(NumberOfFreeScatterBuffers)); set => WriteHere(nameof(NumberOfFreeScatterBuffers), value); }

        [Offset(48UL)]
        public IntPtr ContiguousTranslations { get => ReadHere<IntPtr>(nameof(ContiguousTranslations)); set => WriteHere(nameof(ContiguousTranslations), value); }

        [Offset(56UL)]
        public IntPtr ScatterTranslations { get => ReadHere<IntPtr>(nameof(ScatterTranslations)); set => WriteHere(nameof(ScatterTranslations), value); }

        [Offset(64UL)]
        public HalpDmaTranslationBufferPosition ContiguousTranslationEnd { get => ReadStructure<HalpDmaTranslationBufferPosition>(nameof(ContiguousTranslationEnd)); set => WriteStructure(nameof(ContiguousTranslationEnd), value); }

        [Offset(80UL)]
        public HalpDmaTranslationBufferPosition ScatterTranslationEnd { get => ReadStructure<HalpDmaTranslationBufferPosition>(nameof(ScatterTranslationEnd)); set => WriteStructure(nameof(ScatterTranslationEnd), value); }

        [Offset(96UL)]
        public UnnamedTag CrashDump { get => ReadStructure<UnnamedTag>(nameof(CrashDump)); set => WriteStructure(nameof(CrashDump), value); }

        [Offset(128UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(136UL)]
        public ulong GrowLock { get => ReadHere<ulong>(nameof(GrowLock)); set => WriteHere(nameof(GrowLock), value); }

        [Offset(144UL)]
        public LargeInteger MaximumPhysicalAddress { get => ReadStructure<LargeInteger>(nameof(MaximumPhysicalAddress)); set => WriteStructure(nameof(MaximumPhysicalAddress), value); }

        [Offset(152UL)]
        public byte IsMasterAdapter { get => ReadHere<byte>(nameof(IsMasterAdapter)); set => WriteHere(nameof(IsMasterAdapter), value); }

        [Offset(153UL)]
        public byte DmaCanCross64K { get => ReadHere<byte>(nameof(DmaCanCross64K)); set => WriteHere(nameof(DmaCanCross64K), value); }

        [Offset(156UL)]
        public uint LibraryVersion { get => ReadHere<uint>(nameof(LibraryVersion)); set => WriteHere(nameof(LibraryVersion), value); }

        public HalpDmaAdapterObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaAdapterObject>();
        }
    }
}