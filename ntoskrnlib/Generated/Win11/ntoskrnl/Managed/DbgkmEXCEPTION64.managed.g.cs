using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKM_EXCEPTION64")]
    public sealed class DbgkmEXCEPTION64 : DynamicStructure
    {
        [Offset(0UL)]
        public ExceptionRECORD64 ExceptionRecord { get => ReadStructure<ExceptionRECORD64>(nameof(ExceptionRecord)); set => WriteStructure(nameof(ExceptionRecord), value); }

        [Offset(152UL)]
        public uint FirstChance { get => ReadHere<uint>(nameof(FirstChance)); set => WriteHere(nameof(FirstChance), value); }

        public DbgkmEXCEPTION64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkmEXCEPTION64>();
        }
    }
}