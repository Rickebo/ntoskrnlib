using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKM_EXCEPTION32")]
    public sealed class DbgkmEXCEPTION32 : DynamicStructure
    {
        [Offset(0UL)]
        public ExceptionRECORD32 ExceptionRecord { get => ReadStructure<ExceptionRECORD32>(nameof(ExceptionRecord)); set => WriteStructure(nameof(ExceptionRecord), value); }

        [Offset(80UL)]
        public uint FirstChance { get => ReadHere<uint>(nameof(FirstChance)); set => WriteHere(nameof(FirstChance), value); }

        public DbgkmEXCEPTION32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkmEXCEPTION32>();
        }
    }
}