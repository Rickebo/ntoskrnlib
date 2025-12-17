using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_MINIDUMP")]
    public sealed class SkCrashMinidump : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public uint ModuleCount { get => ReadHere<uint>(nameof(ModuleCount)); set => WriteHere(nameof(ModuleCount), value); }

        [Offset(12UL)]
        public uint FrameCount { get => ReadHere<uint>(nameof(FrameCount)); set => WriteHere(nameof(FrameCount), value); }

        [Offset(16UL)]
        [Length(16)]
        public DynamicArray Modules { get => ReadStructure<DynamicArray>(nameof(Modules)); set => WriteStructure(nameof(Modules), value); }

        [Offset(1168UL)]
        [Length(366)]
        public DynamicArray StackFrames { get => ReadStructure<DynamicArray>(nameof(StackFrames)); set => WriteStructure(nameof(StackFrames), value); }

        public SkCrashMinidump(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SkCrashMinidump>();
        }
    }
}