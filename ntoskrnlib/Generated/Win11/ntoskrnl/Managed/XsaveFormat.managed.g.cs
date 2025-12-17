using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_XSAVE_FORMAT")]
    public sealed class XsaveFormat : DynamicStructure
    {
        [Offset(0UL)]
        public ushort ControlWord { get => ReadHere<ushort>(nameof(ControlWord)); set => WriteHere(nameof(ControlWord), value); }

        [Offset(2UL)]
        public ushort StatusWord { get => ReadHere<ushort>(nameof(StatusWord)); set => WriteHere(nameof(StatusWord), value); }

        [Offset(4UL)]
        public byte TagWord { get => ReadHere<byte>(nameof(TagWord)); set => WriteHere(nameof(TagWord), value); }

        [Offset(5UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(6UL)]
        public ushort ErrorOpcode { get => ReadHere<ushort>(nameof(ErrorOpcode)); set => WriteHere(nameof(ErrorOpcode), value); }

        [Offset(8UL)]
        public uint ErrorOffset { get => ReadHere<uint>(nameof(ErrorOffset)); set => WriteHere(nameof(ErrorOffset), value); }

        [Offset(12UL)]
        public ushort ErrorSelector { get => ReadHere<ushort>(nameof(ErrorSelector)); set => WriteHere(nameof(ErrorSelector), value); }

        [Offset(14UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(16UL)]
        public uint DataOffset { get => ReadHere<uint>(nameof(DataOffset)); set => WriteHere(nameof(DataOffset), value); }

        [Offset(20UL)]
        public ushort DataSelector { get => ReadHere<ushort>(nameof(DataSelector)); set => WriteHere(nameof(DataSelector), value); }

        [Offset(22UL)]
        public ushort Reserved3 { get => ReadHere<ushort>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(24UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(28UL)]
        public uint MxCsr_Mask { get => ReadHere<uint>(nameof(MxCsr_Mask)); set => WriteHere(nameof(MxCsr_Mask), value); }

        [Offset(32UL)]
        [Length(8)]
        public DynamicArray FloatRegisters { get => ReadStructure<DynamicArray>(nameof(FloatRegisters)); set => WriteStructure(nameof(FloatRegisters), value); }

        [Offset(160UL)]
        [Length(16)]
        public DynamicArray XmmRegisters { get => ReadStructure<DynamicArray>(nameof(XmmRegisters)); set => WriteStructure(nameof(XmmRegisters), value); }

        [Offset(416UL)]
        [Length(96)]
        public DynamicArray Reserved4 { get => ReadStructure<DynamicArray>(nameof(Reserved4)); set => WriteStructure(nameof(Reserved4), value); }

        public XsaveFormat(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XsaveFormat>();
        }
    }
}