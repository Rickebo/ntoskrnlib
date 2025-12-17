using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_MODULE")]
    public sealed class SkCrashModule : DynamicStructure
    {
        [Offset(0UL)]
        [Length(32)]
        public DynamicArray ImageName { get => ReadStructure<DynamicArray>(nameof(ImageName)); set => WriteStructure(nameof(ImageName), value); }

        [Offset(64UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(68UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        public SkCrashModule(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SkCrashModule>();
        }
    }
}