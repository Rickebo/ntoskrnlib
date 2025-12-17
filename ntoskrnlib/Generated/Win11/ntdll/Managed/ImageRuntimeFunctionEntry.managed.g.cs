using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IMAGE_RUNTIME_FUNCTION_ENTRY")]
    public sealed class ImageRuntimeFunctionEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint BeginAddress { get => ReadHere<uint>(nameof(BeginAddress)); set => WriteHere(nameof(BeginAddress), value); }

        [Offset(4UL)]
        public uint EndAddress { get => ReadHere<uint>(nameof(EndAddress)); set => WriteHere(nameof(EndAddress), value); }

        [Offset(8UL)]
        public uint UnwindInfoAddress { get => ReadHere<uint>(nameof(UnwindInfoAddress)); set => WriteHere(nameof(UnwindInfoAddress), value); }

        [Offset(8UL)]
        public uint UnwindData { get => ReadHere<uint>(nameof(UnwindData)); set => WriteHere(nameof(UnwindData), value); }

        public ImageRuntimeFunctionEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageRuntimeFunctionEntry>();
        }
    }
}