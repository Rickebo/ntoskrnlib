using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTINUE")]
    public sealed class DbgkdContinue : DynamicStructure
    {
        [Offset(0UL)]
        public int ContinueStatus { get => ReadHere<int>(nameof(ContinueStatus)); set => WriteHere(nameof(ContinueStatus), value); }

        public DbgkdContinue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdContinue>();
        }
    }
}