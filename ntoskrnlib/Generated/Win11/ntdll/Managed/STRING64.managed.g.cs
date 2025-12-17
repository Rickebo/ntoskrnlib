using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_STRING64")]
    public sealed class STRING64 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort MaximumLength { get => ReadHere<ushort>(nameof(MaximumLength)); set => WriteHere(nameof(MaximumLength), value); }

        [Offset(8UL)]
        public ulong Buffer { get => ReadHere<ulong>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public STRING64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<STRING64>();
        }
    }
}