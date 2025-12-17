using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_INITIAL_PRIVILEGE_SET")]
    public sealed class InitialPrivilegeSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint PrivilegeCount { get => ReadHere<uint>(nameof(PrivilegeCount)); set => WriteHere(nameof(PrivilegeCount), value); }

        [Offset(4UL)]
        public uint Control { get => ReadHere<uint>(nameof(Control)); set => WriteHere(nameof(Control), value); }

        [Offset(8UL)]
        [Length(3)]
        public DynamicArray Privilege { get => ReadStructure<DynamicArray>(nameof(Privilege)); set => WriteStructure(nameof(Privilege), value); }

        public InitialPrivilegeSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InitialPrivilegeSet>();
        }
    }
}