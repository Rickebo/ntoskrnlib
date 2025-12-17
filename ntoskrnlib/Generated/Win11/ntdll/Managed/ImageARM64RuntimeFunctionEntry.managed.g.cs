using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY")]
    public sealed class ImageARM64RuntimeFunctionEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint BeginAddress { get => ReadHere<uint>(nameof(BeginAddress)); set => WriteHere(nameof(BeginAddress), value); }

        [Offset(4UL)]
        public uint UnwindData { get => ReadHere<uint>(nameof(UnwindData)); set => WriteHere(nameof(UnwindData), value); }

        [Offset(4UL)]
        public uint Flag { get => ReadHere<uint>(nameof(Flag)); set => WriteHere(nameof(Flag), value); }

        [Offset(4UL)]
        public uint FunctionLength { get => ReadHere<uint>(nameof(FunctionLength)); set => WriteHere(nameof(FunctionLength), value); }

        [Offset(4UL)]
        public uint RegF { get => ReadHere<uint>(nameof(RegF)); set => WriteHere(nameof(RegF), value); }

        [Offset(4UL)]
        public uint RegI { get => ReadHere<uint>(nameof(RegI)); set => WriteHere(nameof(RegI), value); }

        [Offset(4UL)]
        public uint H { get => ReadHere<uint>(nameof(H)); set => WriteHere(nameof(H), value); }

        [Offset(4UL)]
        public uint CR { get => ReadHere<uint>(nameof(CR)); set => WriteHere(nameof(CR), value); }

        [Offset(4UL)]
        public uint FrameSize { get => ReadHere<uint>(nameof(FrameSize)); set => WriteHere(nameof(FrameSize), value); }

        public ImageARM64RuntimeFunctionEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageARM64RuntimeFunctionEntry>();
        }
    }
}