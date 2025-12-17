using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_PER_PROCESSOR_CONTEXT")]
    public sealed class PopPerProcessorContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr UncompressedData { get => ReadHere<IntPtr>(nameof(UncompressedData)); set => WriteHere(nameof(UncompressedData), value); }

        [Offset(8UL)]
        public IntPtr MappingVa { get => ReadHere<IntPtr>(nameof(MappingVa)); set => WriteHere(nameof(MappingVa), value); }

        [Offset(16UL)]
        public IntPtr XpressEncodeWorkspace { get => ReadHere<IntPtr>(nameof(XpressEncodeWorkspace)); set => WriteHere(nameof(XpressEncodeWorkspace), value); }

        [Offset(24UL)]
        public IntPtr CompressedDataBuffer { get => ReadHere<IntPtr>(nameof(CompressedDataBuffer)); set => WriteHere(nameof(CompressedDataBuffer), value); }

        [Offset(32UL)]
        public ulong CopyTicks { get => ReadHere<ulong>(nameof(CopyTicks)); set => WriteHere(nameof(CopyTicks), value); }

        [Offset(40UL)]
        public ulong CompressTicks { get => ReadHere<ulong>(nameof(CompressTicks)); set => WriteHere(nameof(CompressTicks), value); }

        [Offset(48UL)]
        public ulong BytesCopied { get => ReadHere<ulong>(nameof(BytesCopied)); set => WriteHere(nameof(BytesCopied), value); }

        [Offset(56UL)]
        public ulong PagesProcessed { get => ReadHere<ulong>(nameof(PagesProcessed)); set => WriteHere(nameof(PagesProcessed), value); }

        [Offset(64UL)]
        public ulong DecompressTicks { get => ReadHere<ulong>(nameof(DecompressTicks)); set => WriteHere(nameof(DecompressTicks), value); }

        [Offset(72UL)]
        public ulong ResumeCopyTicks { get => ReadHere<ulong>(nameof(ResumeCopyTicks)); set => WriteHere(nameof(ResumeCopyTicks), value); }

        [Offset(80UL)]
        public ulong SharedBufferTicks { get => ReadHere<ulong>(nameof(SharedBufferTicks)); set => WriteHere(nameof(SharedBufferTicks), value); }

        [Offset(88UL)]
        [Length(5)]
        public DynamicArray BlockCountByMethod { get => ReadStructure<DynamicArray>(nameof(BlockCountByMethod)); set => WriteStructure(nameof(BlockCountByMethod), value); }

        [Offset(128UL)]
        [Length(2)]
        public DynamicArray DecompressTicksByMethod { get => ReadStructure<DynamicArray>(nameof(DecompressTicksByMethod)); set => WriteStructure(nameof(DecompressTicksByMethod), value); }

        [Offset(144UL)]
        [Length(2)]
        public DynamicArray DecompressSizeByMethod { get => ReadStructure<DynamicArray>(nameof(DecompressSizeByMethod)); set => WriteStructure(nameof(DecompressSizeByMethod), value); }

        [Offset(160UL)]
        public uint CompressCount { get => ReadHere<uint>(nameof(CompressCount)); set => WriteHere(nameof(CompressCount), value); }

        [Offset(164UL)]
        public uint HuffCompressCount { get => ReadHere<uint>(nameof(HuffCompressCount)); set => WriteHere(nameof(HuffCompressCount), value); }

        public PopPerProcessorContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPerProcessorContext>();
        }
    }
}