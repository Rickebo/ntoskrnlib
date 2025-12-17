using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_DELETE_PARAMETERS")]
    public sealed class ExtDeleteParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public IntPtr DeleteCallback { get => ReadHere<IntPtr>(nameof(DeleteCallback)); set => WriteHere(nameof(DeleteCallback), value); }

        [Offset(16UL)]
        public IntPtr DeleteContext { get => ReadHere<IntPtr>(nameof(DeleteContext)); set => WriteHere(nameof(DeleteContext), value); }

        public ExtDeleteParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtDeleteParameters>();
        }
    }
}