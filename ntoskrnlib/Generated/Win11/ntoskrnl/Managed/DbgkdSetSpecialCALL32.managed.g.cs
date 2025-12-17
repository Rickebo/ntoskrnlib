using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_SPECIAL_CALL32")]
    public sealed class DbgkdSetSpecialCALL32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint SpecialCall { get => ReadHere<uint>(nameof(SpecialCall)); set => WriteHere(nameof(SpecialCall), value); }

        public DbgkdSetSpecialCALL32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSetSpecialCALL32>();
        }
    }
}