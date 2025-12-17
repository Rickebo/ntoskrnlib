using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECTION_IMAGE_INFORMATION")]
    public sealed class SectionImageInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr TransferAddress { get => ReadHere<IntPtr>(nameof(TransferAddress)); set => WriteHere(nameof(TransferAddress), value); }

        [Offset(8UL)]
        public uint ZeroBits { get => ReadHere<uint>(nameof(ZeroBits)); set => WriteHere(nameof(ZeroBits), value); }

        [Offset(16UL)]
        public ulong MaximumStackSize { get => ReadHere<ulong>(nameof(MaximumStackSize)); set => WriteHere(nameof(MaximumStackSize), value); }

        [Offset(24UL)]
        public ulong CommittedStackSize { get => ReadHere<ulong>(nameof(CommittedStackSize)); set => WriteHere(nameof(CommittedStackSize), value); }

        [Offset(32UL)]
        public uint SubSystemType { get => ReadHere<uint>(nameof(SubSystemType)); set => WriteHere(nameof(SubSystemType), value); }

        [Offset(36UL)]
        public ushort SubSystemMinorVersion { get => ReadHere<ushort>(nameof(SubSystemMinorVersion)); set => WriteHere(nameof(SubSystemMinorVersion), value); }

        [Offset(38UL)]
        public ushort SubSystemMajorVersion { get => ReadHere<ushort>(nameof(SubSystemMajorVersion)); set => WriteHere(nameof(SubSystemMajorVersion), value); }

        [Offset(36UL)]
        public uint SubSystemVersion { get => ReadHere<uint>(nameof(SubSystemVersion)); set => WriteHere(nameof(SubSystemVersion), value); }

        [Offset(40UL)]
        public ushort MajorOperatingSystemVersion { get => ReadHere<ushort>(nameof(MajorOperatingSystemVersion)); set => WriteHere(nameof(MajorOperatingSystemVersion), value); }

        [Offset(42UL)]
        public ushort MinorOperatingSystemVersion { get => ReadHere<ushort>(nameof(MinorOperatingSystemVersion)); set => WriteHere(nameof(MinorOperatingSystemVersion), value); }

        [Offset(40UL)]
        public uint OperatingSystemVersion { get => ReadHere<uint>(nameof(OperatingSystemVersion)); set => WriteHere(nameof(OperatingSystemVersion), value); }

        [Offset(44UL)]
        public ushort ImageCharacteristics { get => ReadHere<ushort>(nameof(ImageCharacteristics)); set => WriteHere(nameof(ImageCharacteristics), value); }

        [Offset(46UL)]
        public ushort DllCharacteristics { get => ReadHere<ushort>(nameof(DllCharacteristics)); set => WriteHere(nameof(DllCharacteristics), value); }

        [Offset(48UL)]
        public ushort Machine { get => ReadHere<ushort>(nameof(Machine)); set => WriteHere(nameof(Machine), value); }

        [Offset(50UL)]
        public byte ImageContainsCode { get => ReadHere<byte>(nameof(ImageContainsCode)); set => WriteHere(nameof(ImageContainsCode), value); }

        [Offset(51UL)]
        public byte ImageFlags { get => ReadHere<byte>(nameof(ImageFlags)); set => WriteHere(nameof(ImageFlags), value); }

        [Offset(51UL)]
        public byte ComPlusNativeReady { get => ReadHere<byte>(nameof(ComPlusNativeReady)); set => WriteHere(nameof(ComPlusNativeReady), value); }

        [Offset(51UL)]
        public byte ComPlusILOnly { get => ReadHere<byte>(nameof(ComPlusILOnly)); set => WriteHere(nameof(ComPlusILOnly), value); }

        [Offset(51UL)]
        public byte ImageDynamicallyRelocated { get => ReadHere<byte>(nameof(ImageDynamicallyRelocated)); set => WriteHere(nameof(ImageDynamicallyRelocated), value); }

        [Offset(51UL)]
        public byte ImageMappedFlat { get => ReadHere<byte>(nameof(ImageMappedFlat)); set => WriteHere(nameof(ImageMappedFlat), value); }

        [Offset(51UL)]
        public byte BaseBelow4gb { get => ReadHere<byte>(nameof(BaseBelow4gb)); set => WriteHere(nameof(BaseBelow4gb), value); }

        [Offset(51UL)]
        public byte ComPlusPrefer32bit { get => ReadHere<byte>(nameof(ComPlusPrefer32bit)); set => WriteHere(nameof(ComPlusPrefer32bit), value); }

        [Offset(51UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(52UL)]
        public uint LoaderFlags { get => ReadHere<uint>(nameof(LoaderFlags)); set => WriteHere(nameof(LoaderFlags), value); }

        [Offset(56UL)]
        public uint ImageFileSize { get => ReadHere<uint>(nameof(ImageFileSize)); set => WriteHere(nameof(ImageFileSize), value); }

        [Offset(60UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        public SectionImageInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SectionImageInformation>();
        }
    }
}