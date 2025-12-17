using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VPB")]
    public sealed class Vpb : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(6UL)]
        public ushort VolumeLabelLength { get => ReadHere<ushort>(nameof(VolumeLabelLength)); set => WriteHere(nameof(VolumeLabelLength), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public IntPtr RealDevice { get => ReadHere<IntPtr>(nameof(RealDevice)); set => WriteHere(nameof(RealDevice), value); }

        [Offset(24UL)]
        public uint SerialNumber { get => ReadHere<uint>(nameof(SerialNumber)); set => WriteHere(nameof(SerialNumber), value); }

        [Offset(28UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(32UL)]
        [Length(32)]
        public DynamicArray VolumeLabel { get => ReadStructure<DynamicArray>(nameof(VolumeLabel)); set => WriteStructure(nameof(VolumeLabel), value); }

        public Vpb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Vpb>();
        }
    }
}