using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CURDIR")]
    public sealed class Curdir : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString DosPath { get => ReadStructure<UnicodeString>(nameof(DosPath)); set => WriteStructure(nameof(DosPath), value); }

        [Offset(16UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        public Curdir(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Curdir>();
        }
    }
}