using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_RECORD64")]
    public sealed class ExceptionRECORD64 : DynamicStructure
    {
        [Offset(0UL)]
        public int ExceptionCode { get => ReadHere<int>(nameof(ExceptionCode)); set => WriteHere(nameof(ExceptionCode), value); }

        [Offset(4UL)]
        public uint ExceptionFlags { get => ReadHere<uint>(nameof(ExceptionFlags)); set => WriteHere(nameof(ExceptionFlags), value); }

        [Offset(8UL)]
        public ulong ExceptionRecord { get => ReadHere<ulong>(nameof(ExceptionRecord)); set => WriteHere(nameof(ExceptionRecord), value); }

        [Offset(16UL)]
        public ulong ExceptionAddress { get => ReadHere<ulong>(nameof(ExceptionAddress)); set => WriteHere(nameof(ExceptionAddress), value); }

        [Offset(24UL)]
        public uint NumberParameters { get => ReadHere<uint>(nameof(NumberParameters)); set => WriteHere(nameof(NumberParameters), value); }

        [Offset(28UL)]
        public uint __unusedAlignment { get => ReadHere<uint>(nameof(__unusedAlignment)); set => WriteHere(nameof(__unusedAlignment), value); }

        [Offset(32UL)]
        [Length(15)]
        public DynamicArray ExceptionInformation { get => ReadStructure<DynamicArray>(nameof(ExceptionInformation)); set => WriteStructure(nameof(ExceptionInformation), value); }

        public ExceptionRECORD64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExceptionRECORD64>();
        }
    }
}