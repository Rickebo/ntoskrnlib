using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOP_IRP_EXTENSION")]
    public sealed class IopIrpExtension : DynamicStructure
    {
        [Offset(0UL)]
        public ushort ExtensionFlags { get => ReadHere<ushort>(nameof(ExtensionFlags)); set => WriteHere(nameof(ExtensionFlags), value); }

        [Offset(0UL)]
        public ushort Allocated { get => ReadHere<ushort>(nameof(Allocated)); set => WriteHere(nameof(Allocated), value); }

        [Offset(0UL)]
        public ushort PropagateId { get => ReadHere<ushort>(nameof(PropagateId)); set => WriteHere(nameof(PropagateId), value); }

        [Offset(0UL)]
        public ushort SpareBits { get => ReadHere<ushort>(nameof(SpareBits)); set => WriteHere(nameof(SpareBits), value); }

        [Offset(2UL)]
        public ushort TypesAllocated { get => ReadHere<ushort>(nameof(TypesAllocated)); set => WriteHere(nameof(TypesAllocated), value); }

        [Offset(4UL)]
        [Length(4)]
        public DynamicArray GenericExtension { get => ReadStructure<DynamicArray>(nameof(GenericExtension)); set => WriteStructure(nameof(GenericExtension), value); }

        [Offset(8UL)]
        public IntPtr VerifierContext { get => ReadHere<IntPtr>(nameof(VerifierContext)); set => WriteHere(nameof(VerifierContext), value); }

        [Offset(16UL)]
        public ulong DiskIoAttributionHandle { get => ReadHere<ulong>(nameof(DiskIoAttributionHandle)); set => WriteHere(nameof(DiskIoAttributionHandle), value); }

        [Offset(24UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(40UL)]
        public LargeInteger Timestamp { get => ReadStructure<LargeInteger>(nameof(Timestamp)); set => WriteStructure(nameof(Timestamp), value); }

        [Offset(40UL)]
        public uint ZeroingOffset { get => ReadHere<uint>(nameof(ZeroingOffset)); set => WriteHere(nameof(ZeroingOffset), value); }

        [Offset(40UL)]
        public IntPtr FsTrackOffsetBlob { get => ReadHere<IntPtr>(nameof(FsTrackOffsetBlob)); set => WriteHere(nameof(FsTrackOffsetBlob), value); }

        [Offset(48UL)]
        public long FsTrackedOffset { get => ReadHere<long>(nameof(FsTrackedOffset)); set => WriteHere(nameof(FsTrackedOffset), value); }

        [Offset(40UL)]
        public IoAdapterCryptoParameters AdapterCryptoParameters { get => ReadStructure<IoAdapterCryptoParameters>(nameof(AdapterCryptoParameters)); set => WriteStructure(nameof(AdapterCryptoParameters), value); }

        [Offset(56UL)]
        public UnnamedTag DriverFlags { get => ReadStructure<UnnamedTag>(nameof(DriverFlags)); set => WriteStructure(nameof(DriverFlags), value); }

        [Offset(64UL)]
        public CopyInformation CopyInformation { get => ReadStructure<CopyInformation>(nameof(CopyInformation)); set => WriteStructure(nameof(CopyInformation), value); }

        public IopIrpExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopIrpExtension>();
        }
    }
}