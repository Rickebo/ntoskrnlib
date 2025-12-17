using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MCA_EXCEPTION")]
    public sealed class McaException : DynamicStructure
    {
        [Offset(0UL)]
        public uint VersionNumber { get => ReadHere<uint>(nameof(VersionNumber)); set => WriteHere(nameof(VersionNumber), value); }

        [Offset(4UL)]
        public uint ExceptionType { get => ReadHere<uint>(nameof(ExceptionType)); set => WriteHere(nameof(ExceptionType), value); }

        [Offset(8UL)]
        public LargeInteger TimeStamp { get => ReadStructure<LargeInteger>(nameof(TimeStamp)); set => WriteStructure(nameof(TimeStamp), value); }

        [Offset(16UL)]
        public uint ProcessorNumber { get => ReadHere<uint>(nameof(ProcessorNumber)); set => WriteHere(nameof(ProcessorNumber), value); }

        [Offset(20UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(24UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(56UL)]
        public uint ExtCnt { get => ReadHere<uint>(nameof(ExtCnt)); set => WriteHere(nameof(ExtCnt), value); }

        [Offset(60UL)]
        public uint Reserved3 { get => ReadHere<uint>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(64UL)]
        [Length(24)]
        public DynamicArray ExtReg { get => ReadStructure<DynamicArray>(nameof(ExtReg)); set => WriteStructure(nameof(ExtReg), value); }

        public McaException(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<McaException>();
        }
    }
}