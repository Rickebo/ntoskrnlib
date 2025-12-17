using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_POINTERS")]
    public sealed class ExceptionPointers : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ExceptionRecord { get => ReadHere<IntPtr>(nameof(ExceptionRecord)); set => WriteHere(nameof(ExceptionRecord), value); }

        [Offset(8UL)]
        public IntPtr ContextRecord { get => ReadHere<IntPtr>(nameof(ContextRecord)); set => WriteHere(nameof(ContextRecord), value); }

        public ExceptionPointers(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExceptionPointers>();
        }
    }
}