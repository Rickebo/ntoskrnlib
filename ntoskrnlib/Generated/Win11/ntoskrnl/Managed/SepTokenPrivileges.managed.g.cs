using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_TOKEN_PRIVILEGES")]
    public sealed class SepTokenPrivileges : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Present { get => ReadHere<ulong>(nameof(Present)); set => WriteHere(nameof(Present), value); }

        [Offset(8UL)]
        public ulong Enabled { get => ReadHere<ulong>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(16UL)]
        public ulong EnabledByDefault { get => ReadHere<ulong>(nameof(EnabledByDefault)); set => WriteHere(nameof(EnabledByDefault), value); }

        public SepTokenPrivileges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepTokenPrivileges>();
        }
    }
}