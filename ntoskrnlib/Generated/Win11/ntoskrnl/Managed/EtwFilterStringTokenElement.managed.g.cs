using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_STRING_TOKEN_ELEMENT")]
    public sealed class EtwFilterStringTokenElement : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public IntPtr String { get => ReadHere<IntPtr>(nameof(String)); set => WriteHere(nameof(String), value); }

        public EtwFilterStringTokenElement(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwFilterStringTokenElement>();
        }
    }
}