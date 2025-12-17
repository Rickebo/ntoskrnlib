using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_XSTATE_CONTEXT")]
    public sealed class XstateContext : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Mask { get => ReadHere<ulong>(nameof(Mask)); set => WriteHere(nameof(Mask), value); }

        [Offset(8UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(12UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(13UL)]
        [Length(3)]
        public DynamicArray Reserved0 { get => ReadStructure<DynamicArray>(nameof(Reserved0)); set => WriteStructure(nameof(Reserved0), value); }

        [Offset(16UL)]
        public IntPtr Area { get => ReadHere<IntPtr>(nameof(Area)); set => WriteHere(nameof(Area), value); }

        [Offset(24UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public XstateContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XstateContext>();
        }
    }
}