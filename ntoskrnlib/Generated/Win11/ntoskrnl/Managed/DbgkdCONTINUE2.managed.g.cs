using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTINUE2")]
    public sealed class DbgkdCONTINUE2 : DynamicStructure
    {
        [Offset(0UL)]
        public int ContinueStatus { get => ReadHere<int>(nameof(ContinueStatus)); set => WriteHere(nameof(ContinueStatus), value); }

        [Offset(4UL)]
        public AMD64DbgkdControlSet ControlSet { get => ReadStructure<AMD64DbgkdControlSet>(nameof(ControlSet)); set => WriteStructure(nameof(ControlSet), value); }

        [Offset(4UL)]
        public DbgkdAnyControlSet AnyControlSet { get => ReadStructure<DbgkdAnyControlSet>(nameof(AnyControlSet)); set => WriteStructure(nameof(AnyControlSet), value); }

        public DbgkdCONTINUE2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdCONTINUE2>();
        }
    }
}