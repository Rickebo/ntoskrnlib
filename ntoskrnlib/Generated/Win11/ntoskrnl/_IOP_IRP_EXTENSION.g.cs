#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _IOP_IRP_EXTENSION
    {
        [FieldOffset(0)]
        public ushort ExtensionFlags;
        [FieldOffset(0)]
        public ushort Allocated;
        [FieldOffset(0)]
        public ushort PropagateId;
        [FieldOffset(0)]
        public ushort SpareBits;
        [FieldOffset(2)]
        public ushort TypesAllocated;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] GenericExtension;
        [FieldOffset(8)]
        public IntPtr VerifierContext;
        [FieldOffset(16)]
        public ulong DiskIoAttributionHandle;
        [FieldOffset(24)]
        public _GUID ActivityId;
        [FieldOffset(40)]
        public _LARGE_INTEGER Timestamp;
        [FieldOffset(40)]
        public uint ZeroingOffset;
        [FieldOffset(40)]
        public IntPtr FsTrackOffsetBlob;
        [FieldOffset(48)]
        public long FsTrackedOffset;
        [FieldOffset(40)]
        public _IO_ADAPTER_CRYPTO_PARAMETERS AdapterCryptoParameters;
        [FieldOffset(56)]
        public _unnamed_tag_ DriverFlags;
        [FieldOffset(64)]
        public _COPY_INFORMATION CopyInformation;
    }
}