using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OPEN_PACKET")]
    public sealed class OpenPacket : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(16UL)]
        public int FinalStatus { get => ReadHere<int>(nameof(FinalStatus)); set => WriteHere(nameof(FinalStatus), value); }

        [Offset(24UL)]
        public ulong Information { get => ReadHere<ulong>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        [Offset(32UL)]
        public uint ParseCheck { get => ReadHere<uint>(nameof(ParseCheck)); set => WriteHere(nameof(ParseCheck), value); }

        [Offset(40UL)]
        public IntPtr RelatedFileObject { get => ReadHere<IntPtr>(nameof(RelatedFileObject)); set => WriteHere(nameof(RelatedFileObject), value); }

        [Offset(40UL)]
        public IntPtr ReferencedDeviceObject { get => ReadHere<IntPtr>(nameof(ReferencedDeviceObject)); set => WriteHere(nameof(ReferencedDeviceObject), value); }

        [Offset(48UL)]
        public IntPtr OriginalAttributes { get => ReadHere<IntPtr>(nameof(OriginalAttributes)); set => WriteHere(nameof(OriginalAttributes), value); }

        [Offset(56UL)]
        public LargeInteger AllocationSize { get => ReadStructure<LargeInteger>(nameof(AllocationSize)); set => WriteStructure(nameof(AllocationSize), value); }

        [Offset(64UL)]
        public uint CreateOptions { get => ReadHere<uint>(nameof(CreateOptions)); set => WriteHere(nameof(CreateOptions), value); }

        [Offset(68UL)]
        public ushort FileAttributes { get => ReadHere<ushort>(nameof(FileAttributes)); set => WriteHere(nameof(FileAttributes), value); }

        [Offset(70UL)]
        public ushort ShareAccess { get => ReadHere<ushort>(nameof(ShareAccess)); set => WriteHere(nameof(ShareAccess), value); }

        [Offset(72UL)]
        public IntPtr EaBuffer { get => ReadHere<IntPtr>(nameof(EaBuffer)); set => WriteHere(nameof(EaBuffer), value); }

        [Offset(80UL)]
        public uint EaLength { get => ReadHere<uint>(nameof(EaLength)); set => WriteHere(nameof(EaLength), value); }

        [Offset(84UL)]
        public uint Options { get => ReadHere<uint>(nameof(Options)); set => WriteHere(nameof(Options), value); }

        [Offset(88UL)]
        public uint Disposition { get => ReadHere<uint>(nameof(Disposition)); set => WriteHere(nameof(Disposition), value); }

        [Offset(96UL)]
        public IntPtr BasicInformation { get => ReadHere<IntPtr>(nameof(BasicInformation)); set => WriteHere(nameof(BasicInformation), value); }

        [Offset(104UL)]
        public IntPtr NetworkInformation { get => ReadHere<IntPtr>(nameof(NetworkInformation)); set => WriteHere(nameof(NetworkInformation), value); }

        [Offset(112UL)]
        public IntPtr FileInformation { get => ReadHere<IntPtr>(nameof(FileInformation)); set => WriteHere(nameof(FileInformation), value); }

        [Offset(120UL)]
        public uint CreateFileType { get => ReadHere<uint>(nameof(CreateFileType)); set => WriteHere(nameof(CreateFileType), value); }

        [Offset(128UL)]
        public IntPtr MailslotOrPipeParameters { get => ReadHere<IntPtr>(nameof(MailslotOrPipeParameters)); set => WriteHere(nameof(MailslotOrPipeParameters), value); }

        [Offset(136UL)]
        public byte Override { get => ReadHere<byte>(nameof(Override)); set => WriteHere(nameof(Override), value); }

        [Offset(137UL)]
        public byte QueryOnly { get => ReadHere<byte>(nameof(QueryOnly)); set => WriteHere(nameof(QueryOnly), value); }

        [Offset(138UL)]
        public byte DeleteOnly { get => ReadHere<byte>(nameof(DeleteOnly)); set => WriteHere(nameof(DeleteOnly), value); }

        [Offset(139UL)]
        public byte FullAttributes { get => ReadHere<byte>(nameof(FullAttributes)); set => WriteHere(nameof(FullAttributes), value); }

        [Offset(144UL)]
        public IntPtr LocalFileObject { get => ReadHere<IntPtr>(nameof(LocalFileObject)); set => WriteHere(nameof(LocalFileObject), value); }

        [Offset(152UL)]
        public uint InternalFlags { get => ReadHere<uint>(nameof(InternalFlags)); set => WriteHere(nameof(InternalFlags), value); }

        [Offset(156UL)]
        public sbyte AccessMode { get => ReadHere<sbyte>(nameof(AccessMode)); set => WriteHere(nameof(AccessMode), value); }

        [Offset(160UL)]
        public IoDriverCreateContext DriverCreateContext { get => ReadStructure<IoDriverCreateContext>(nameof(DriverCreateContext)); set => WriteStructure(nameof(DriverCreateContext), value); }

        [Offset(200UL)]
        public uint FileInformationClass { get => ReadHere<uint>(nameof(FileInformationClass)); set => WriteHere(nameof(FileInformationClass), value); }

        [Offset(204UL)]
        public uint FileInformationLength { get => ReadHere<uint>(nameof(FileInformationLength)); set => WriteHere(nameof(FileInformationLength), value); }

        [Offset(208UL)]
        public byte FilterQuery { get => ReadHere<byte>(nameof(FilterQuery)); set => WriteHere(nameof(FilterQuery), value); }

        [Offset(216UL)]
        public long ExtendedCreateFlags { get => ReadHere<long>(nameof(ExtendedCreateFlags)); set => WriteHere(nameof(ExtendedCreateFlags), value); }

        public OpenPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OpenPacket>();
        }
    }
}