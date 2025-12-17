using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ARM64_FPSR_REG")]
    public sealed class ARM64FpsrReg : DynamicStructure
    {
        [Offset(0UL)]
        public uint Value { get => ReadHere<uint>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint IOC { get => ReadHere<uint>(nameof(IOC)); set => WriteHere(nameof(IOC), value); }

        [Offset(0UL)]
        public uint DZC { get => ReadHere<uint>(nameof(DZC)); set => WriteHere(nameof(DZC), value); }

        [Offset(0UL)]
        public uint OFC { get => ReadHere<uint>(nameof(OFC)); set => WriteHere(nameof(OFC), value); }

        [Offset(0UL)]
        public uint UFC { get => ReadHere<uint>(nameof(UFC)); set => WriteHere(nameof(UFC), value); }

        [Offset(0UL)]
        public uint IXC { get => ReadHere<uint>(nameof(IXC)); set => WriteHere(nameof(IXC), value); }

        [Offset(0UL)]
        public uint res0_1 { get => ReadHere<uint>(nameof(res0_1)); set => WriteHere(nameof(res0_1), value); }

        [Offset(0UL)]
        public uint IDC { get => ReadHere<uint>(nameof(IDC)); set => WriteHere(nameof(IDC), value); }

        [Offset(0UL)]
        public uint res0_2 { get => ReadHere<uint>(nameof(res0_2)); set => WriteHere(nameof(res0_2), value); }

        [Offset(0UL)]
        public uint QC { get => ReadHere<uint>(nameof(QC)); set => WriteHere(nameof(QC), value); }

        [Offset(0UL)]
        public uint V { get => ReadHere<uint>(nameof(V)); set => WriteHere(nameof(V), value); }

        [Offset(0UL)]
        public uint C { get => ReadHere<uint>(nameof(C)); set => WriteHere(nameof(C), value); }

        [Offset(0UL)]
        public uint Z { get => ReadHere<uint>(nameof(Z)); set => WriteHere(nameof(Z), value); }

        [Offset(0UL)]
        public uint N { get => ReadHere<uint>(nameof(N)); set => WriteHere(nameof(N), value); }

        public ARM64FpsrReg(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ARM64FpsrReg>();
        }
    }
}