using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_SILOSTATE")]
    public sealed class SepSilostate : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SystemLogonSession { get => ReadHere<IntPtr>(nameof(SystemLogonSession)); set => WriteHere(nameof(SystemLogonSession), value); }

        [Offset(8UL)]
        public IntPtr AnonymousLogonSession { get => ReadHere<IntPtr>(nameof(AnonymousLogonSession)); set => WriteHere(nameof(AnonymousLogonSession), value); }

        [Offset(16UL)]
        public IntPtr AnonymousLogonToken { get => ReadHere<IntPtr>(nameof(AnonymousLogonToken)); set => WriteHere(nameof(AnonymousLogonToken), value); }

        [Offset(24UL)]
        public IntPtr AnonymousLogonTokenNoEveryone { get => ReadHere<IntPtr>(nameof(AnonymousLogonTokenNoEveryone)); set => WriteHere(nameof(AnonymousLogonTokenNoEveryone), value); }

        [Offset(32UL)]
        public IntPtr UncSystemPaths { get => ReadHere<IntPtr>(nameof(UncSystemPaths)); set => WriteHere(nameof(UncSystemPaths), value); }

        [Offset(40UL)]
        public IntPtr NgenPaths { get => ReadHere<IntPtr>(nameof(NgenPaths)); set => WriteHere(nameof(NgenPaths), value); }

        public SepSilostate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepSilostate>();
        }
    }
}