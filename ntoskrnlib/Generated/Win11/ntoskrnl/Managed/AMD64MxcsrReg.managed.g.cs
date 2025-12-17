using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AMD64_MXCSR_REG")]
    public sealed class AMD64MxcsrReg : DynamicStructure
    {
        [Offset(0UL)]
        public uint Value { get => ReadHere<uint>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint IE { get => ReadHere<uint>(nameof(IE)); set => WriteHere(nameof(IE), value); }

        [Offset(0UL)]
        public uint DE { get => ReadHere<uint>(nameof(DE)); set => WriteHere(nameof(DE), value); }

        [Offset(0UL)]
        public uint ZE { get => ReadHere<uint>(nameof(ZE)); set => WriteHere(nameof(ZE), value); }

        [Offset(0UL)]
        public uint OE { get => ReadHere<uint>(nameof(OE)); set => WriteHere(nameof(OE), value); }

        [Offset(0UL)]
        public uint UE { get => ReadHere<uint>(nameof(UE)); set => WriteHere(nameof(UE), value); }

        [Offset(0UL)]
        public uint PE { get => ReadHere<uint>(nameof(PE)); set => WriteHere(nameof(PE), value); }

        [Offset(0UL)]
        public uint DAZ { get => ReadHere<uint>(nameof(DAZ)); set => WriteHere(nameof(DAZ), value); }

        [Offset(0UL)]
        public uint IM { get => ReadHere<uint>(nameof(IM)); set => WriteHere(nameof(IM), value); }

        [Offset(0UL)]
        public uint DM { get => ReadHere<uint>(nameof(DM)); set => WriteHere(nameof(DM), value); }

        [Offset(0UL)]
        public uint ZM { get => ReadHere<uint>(nameof(ZM)); set => WriteHere(nameof(ZM), value); }

        [Offset(0UL)]
        public uint OM { get => ReadHere<uint>(nameof(OM)); set => WriteHere(nameof(OM), value); }

        [Offset(0UL)]
        public uint UM { get => ReadHere<uint>(nameof(UM)); set => WriteHere(nameof(UM), value); }

        [Offset(0UL)]
        public uint PM { get => ReadHere<uint>(nameof(PM)); set => WriteHere(nameof(PM), value); }

        [Offset(0UL)]
        public uint RC { get => ReadHere<uint>(nameof(RC)); set => WriteHere(nameof(RC), value); }

        [Offset(0UL)]
        public uint FZ { get => ReadHere<uint>(nameof(FZ)); set => WriteHere(nameof(FZ), value); }

        [Offset(0UL)]
        public uint res { get => ReadHere<uint>(nameof(res)); set => WriteHere(nameof(res), value); }

        public AMD64MxcsrReg(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AMD64MxcsrReg>();
        }
    }
}