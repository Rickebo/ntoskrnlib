using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_SPECIAL_CALL64")]
    public sealed class DbgkdSetSpecialCALL64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SpecialCall { get => ReadHere<ulong>(nameof(SpecialCall)); set => WriteHere(nameof(SpecialCall), value); }

        public DbgkdSetSpecialCALL64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSetSpecialCALL64>();
        }
    }
}