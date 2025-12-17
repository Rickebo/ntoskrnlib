using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_RECORD32")]
    public sealed class ExceptionRECORD32 : DynamicStructure
    {
        [Offset(0UL)]
        public int ExceptionCode { get => ReadHere<int>(nameof(ExceptionCode)); set => WriteHere(nameof(ExceptionCode), value); }

        [Offset(4UL)]
        public uint ExceptionFlags { get => ReadHere<uint>(nameof(ExceptionFlags)); set => WriteHere(nameof(ExceptionFlags), value); }

        [Offset(8UL)]
        public uint ExceptionRecord { get => ReadHere<uint>(nameof(ExceptionRecord)); set => WriteHere(nameof(ExceptionRecord), value); }

        [Offset(12UL)]
        public uint ExceptionAddress { get => ReadHere<uint>(nameof(ExceptionAddress)); set => WriteHere(nameof(ExceptionAddress), value); }

        [Offset(16UL)]
        public uint NumberParameters { get => ReadHere<uint>(nameof(NumberParameters)); set => WriteHere(nameof(NumberParameters), value); }

        [Offset(20UL)]
        [Length(15)]
        public DynamicArray ExceptionInformation { get => ReadStructure<DynamicArray>(nameof(ExceptionInformation)); set => WriteStructure(nameof(ExceptionInformation), value); }

        public ExceptionRECORD32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExceptionRECORD32>();
        }
    }
}