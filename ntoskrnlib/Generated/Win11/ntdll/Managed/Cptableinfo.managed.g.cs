using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CPTABLEINFO")]
    public sealed class Cptableinfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort CodePage { get => ReadHere<ushort>(nameof(CodePage)); set => WriteHere(nameof(CodePage), value); }

        [Offset(2UL)]
        public ushort MaximumCharacterSize { get => ReadHere<ushort>(nameof(MaximumCharacterSize)); set => WriteHere(nameof(MaximumCharacterSize), value); }

        [Offset(4UL)]
        public ushort DefaultChar { get => ReadHere<ushort>(nameof(DefaultChar)); set => WriteHere(nameof(DefaultChar), value); }

        [Offset(6UL)]
        public ushort UniDefaultChar { get => ReadHere<ushort>(nameof(UniDefaultChar)); set => WriteHere(nameof(UniDefaultChar), value); }

        [Offset(8UL)]
        public ushort TransDefaultChar { get => ReadHere<ushort>(nameof(TransDefaultChar)); set => WriteHere(nameof(TransDefaultChar), value); }

        [Offset(10UL)]
        public ushort TransUniDefaultChar { get => ReadHere<ushort>(nameof(TransUniDefaultChar)); set => WriteHere(nameof(TransUniDefaultChar), value); }

        [Offset(12UL)]
        public ushort DBCSCodePage { get => ReadHere<ushort>(nameof(DBCSCodePage)); set => WriteHere(nameof(DBCSCodePage), value); }

        [Offset(14UL)]
        [Length(12)]
        public DynamicArray LeadByte { get => ReadStructure<DynamicArray>(nameof(LeadByte)); set => WriteStructure(nameof(LeadByte), value); }

        [Offset(32UL)]
        public IntPtr MultiByteTable { get => ReadHere<IntPtr>(nameof(MultiByteTable)); set => WriteHere(nameof(MultiByteTable), value); }

        [Offset(40UL)]
        public IntPtr WideCharTable { get => ReadHere<IntPtr>(nameof(WideCharTable)); set => WriteHere(nameof(WideCharTable), value); }

        [Offset(48UL)]
        public IntPtr DBCSRanges { get => ReadHere<IntPtr>(nameof(DBCSRanges)); set => WriteHere(nameof(DBCSRanges), value); }

        [Offset(56UL)]
        public IntPtr DBCSOffsets { get => ReadHere<IntPtr>(nameof(DBCSOffsets)); set => WriteHere(nameof(DBCSOffsets), value); }

        public Cptableinfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Cptableinfo>();
        }
    }
}