using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BOOT_ENTROPY_SOURCE_LDR_RESULT")]
    public sealed class BootEntropySourceLdrResult : DynamicStructure
    {
        [Offset(0UL)]
        public uint SourceId { get => ReadHere<uint>(nameof(SourceId)); set => WriteHere(nameof(SourceId), value); }

        [Offset(8UL)]
        public ulong Policy { get => ReadHere<ulong>(nameof(Policy)); set => WriteHere(nameof(Policy), value); }

        [Offset(16UL)]
        public uint ResultCode { get => ReadHere<uint>(nameof(ResultCode)); set => WriteHere(nameof(ResultCode), value); }

        [Offset(20UL)]
        public int ResultStatus { get => ReadHere<int>(nameof(ResultStatus)); set => WriteHere(nameof(ResultStatus), value); }

        [Offset(24UL)]
        public ulong Time { get => ReadHere<ulong>(nameof(Time)); set => WriteHere(nameof(Time), value); }

        [Offset(32UL)]
        public uint EntropyLength { get => ReadHere<uint>(nameof(EntropyLength)); set => WriteHere(nameof(EntropyLength), value); }

        [Offset(36UL)]
        [Length(64)]
        public DynamicArray EntropyData { get => ReadStructure<DynamicArray>(nameof(EntropyData)); set => WriteStructure(nameof(EntropyData), value); }

        public BootEntropySourceLdrResult(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BootEntropySourceLdrResult>();
        }
    }
}