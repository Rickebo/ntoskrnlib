using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_PRIVILEGES")]
    public sealed class TokenPrivileges : DynamicStructure
    {
        [Offset(0UL)]
        public uint PrivilegeCount { get => ReadHere<uint>(nameof(PrivilegeCount)); set => WriteHere(nameof(PrivilegeCount), value); }

        [Offset(4UL)]
        [Length(1)]
        public DynamicArray Privileges { get => ReadStructure<DynamicArray>(nameof(Privileges)); set => WriteStructure(nameof(Privileges), value); }

        public TokenPrivileges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenPrivileges>();
        }
    }
}