using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_DRIVE_LETTER_CURDIR")]
    public sealed class RtlDriveLetterCurdir : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(2UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public uint TimeStamp { get => ReadHere<uint>(nameof(TimeStamp)); set => WriteHere(nameof(TimeStamp), value); }

        [Offset(8UL)]
        public String DosPath { get => ReadStructure<String>(nameof(DosPath)); set => WriteStructure(nameof(DosPath), value); }

        public RtlDriveLetterCurdir(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDriveLetterCurdir>();
        }
    }
}