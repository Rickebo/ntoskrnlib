using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARM64_FPCR_REG")]
    public sealed class ARM64FpcrReg : DynamicStructure
    {
        [Offset(0UL)]
        public uint Value { get => ReadHere<uint>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint res0_1 { get => ReadHere<uint>(nameof(res0_1)); set => WriteHere(nameof(res0_1), value); }

        [Offset(0UL)]
        public uint IOE { get => ReadHere<uint>(nameof(IOE)); set => WriteHere(nameof(IOE), value); }

        [Offset(0UL)]
        public uint DZE { get => ReadHere<uint>(nameof(DZE)); set => WriteHere(nameof(DZE), value); }

        [Offset(0UL)]
        public uint OFE { get => ReadHere<uint>(nameof(OFE)); set => WriteHere(nameof(OFE), value); }

        [Offset(0UL)]
        public uint UFE { get => ReadHere<uint>(nameof(UFE)); set => WriteHere(nameof(UFE), value); }

        [Offset(0UL)]
        public uint IXE { get => ReadHere<uint>(nameof(IXE)); set => WriteHere(nameof(IXE), value); }

        [Offset(0UL)]
        public uint res0_2 { get => ReadHere<uint>(nameof(res0_2)); set => WriteHere(nameof(res0_2), value); }

        [Offset(0UL)]
        public uint IDE { get => ReadHere<uint>(nameof(IDE)); set => WriteHere(nameof(IDE), value); }

        [Offset(0UL)]
        public uint Len { get => ReadHere<uint>(nameof(Len)); set => WriteHere(nameof(Len), value); }

        [Offset(0UL)]
        public uint FZ16 { get => ReadHere<uint>(nameof(FZ16)); set => WriteHere(nameof(FZ16), value); }

        [Offset(0UL)]
        public uint Stride { get => ReadHere<uint>(nameof(Stride)); set => WriteHere(nameof(Stride), value); }

        [Offset(0UL)]
        public uint RMode { get => ReadHere<uint>(nameof(RMode)); set => WriteHere(nameof(RMode), value); }

        [Offset(0UL)]
        public uint FZ { get => ReadHere<uint>(nameof(FZ)); set => WriteHere(nameof(FZ), value); }

        [Offset(0UL)]
        public uint DN { get => ReadHere<uint>(nameof(DN)); set => WriteHere(nameof(DN), value); }

        [Offset(0UL)]
        public uint AHP { get => ReadHere<uint>(nameof(AHP)); set => WriteHere(nameof(AHP), value); }

        [Offset(0UL)]
        public uint res0_3 { get => ReadHere<uint>(nameof(res0_3)); set => WriteHere(nameof(res0_3), value); }

        public ARM64FpcrReg(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ARM64FpcrReg>();
        }
    }
}