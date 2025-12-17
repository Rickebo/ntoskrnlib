using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EXCEPTION_RECORD")]
    public sealed class ExceptionRecord : DynamicStructure
    {
        [Offset(0UL)]
        public int ExceptionCode { get => ReadHere<int>(nameof(ExceptionCode)); set => WriteHere(nameof(ExceptionCode), value); }

        [Offset(4UL)]
        public uint ExceptionFlags { get => ReadHere<uint>(nameof(ExceptionFlags)); set => WriteHere(nameof(ExceptionFlags), value); }

        [Offset(8UL)]
        public IntPtr BaseExceptionRecord { get => ReadHere<IntPtr>(nameof(BaseExceptionRecord)); set => WriteHere(nameof(BaseExceptionRecord), value); }

        [Offset(16UL)]
        public IntPtr ExceptionAddress { get => ReadHere<IntPtr>(nameof(ExceptionAddress)); set => WriteHere(nameof(ExceptionAddress), value); }

        [Offset(24UL)]
        public uint NumberParameters { get => ReadHere<uint>(nameof(NumberParameters)); set => WriteHere(nameof(NumberParameters), value); }

        [Offset(32UL)]
        [Length(15)]
        public DynamicArray ExceptionInformation { get => ReadStructure<DynamicArray>(nameof(ExceptionInformation)); set => WriteStructure(nameof(ExceptionInformation), value); }

        public ExceptionRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExceptionRecord>();
        }
    }
}