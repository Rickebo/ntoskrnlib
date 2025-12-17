using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXP_SECURE_POOL_CONTEXT")]
    public sealed class ExpSecurePoolContext : DynamicStructure
    {
        [Offset(0UL)]
        public ExpPoolContextHeader Header { get => ReadStructure<ExpPoolContextHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        public ExpSecurePoolContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExpSecurePoolContext>();
        }
    }
}