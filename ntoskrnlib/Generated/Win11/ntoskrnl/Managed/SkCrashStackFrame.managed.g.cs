using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_STACK_FRAME")]
    public sealed class SkCrashStackFrame : DynamicStructure
    {
        [Offset(0UL)]
        public uint ModuleId { get => ReadHere<uint>(nameof(ModuleId)); set => WriteHere(nameof(ModuleId), value); }

        [Offset(4UL)]
        public uint Rva { get => ReadHere<uint>(nameof(Rva)); set => WriteHere(nameof(Rva), value); }

        [Offset(0UL)]
        public ulong Pc { get => ReadHere<ulong>(nameof(Pc)); set => WriteHere(nameof(Pc), value); }

        public SkCrashStackFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SkCrashStackFrame>();
        }
    }
}