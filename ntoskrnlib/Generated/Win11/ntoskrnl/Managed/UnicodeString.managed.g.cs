using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_UNICODE_STRING")]
    public sealed class UnicodeString : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort MaximumLength { get => ReadHere<ushort>(nameof(MaximumLength)); set => WriteHere(nameof(MaximumLength), value); }

        [Offset(8UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public UnicodeString(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<UnicodeString>();
        }
    }
}