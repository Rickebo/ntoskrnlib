using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OB_EXTENDED_PARSE_PARAMETERS")]
    public sealed class ObExtendedParseParameters : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public uint RestrictedAccessMask { get => ReadHere<uint>(nameof(RestrictedAccessMask)); set => WriteHere(nameof(RestrictedAccessMask), value); }

        [Offset(8UL)]
        public IntPtr Silo { get => ReadHere<IntPtr>(nameof(Silo)); set => WriteHere(nameof(Silo), value); }

        public ObExtendedParseParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObExtendedParseParameters>();
        }
    }
}