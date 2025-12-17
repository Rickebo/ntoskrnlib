#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _OPEN_PACKET
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public IntPtr FileObject;
        [FieldOffset(16)]
        public int FinalStatus;
        [FieldOffset(24)]
        public ulong Information;
        [FieldOffset(32)]
        public uint ParseCheck;
        [FieldOffset(40)]
        public IntPtr RelatedFileObject;
        [FieldOffset(40)]
        public IntPtr ReferencedDeviceObject;
        [FieldOffset(48)]
        public IntPtr OriginalAttributes;
        [FieldOffset(56)]
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(64)]
        public uint CreateOptions;
        [FieldOffset(68)]
        public ushort FileAttributes;
        [FieldOffset(70)]
        public ushort ShareAccess;
        [FieldOffset(72)]
        public IntPtr EaBuffer;
        [FieldOffset(80)]
        public uint EaLength;
        [FieldOffset(84)]
        public uint Options;
        [FieldOffset(88)]
        public uint Disposition;
        [FieldOffset(96)]
        public IntPtr BasicInformation;
        [FieldOffset(104)]
        public IntPtr NetworkInformation;
        [FieldOffset(112)]
        public IntPtr FileInformation;
        [FieldOffset(120)]
        public uint CreateFileType;
        [FieldOffset(128)]
        public IntPtr MailslotOrPipeParameters;
        [FieldOffset(136)]
        public byte Override;
        [FieldOffset(137)]
        public byte QueryOnly;
        [FieldOffset(138)]
        public byte DeleteOnly;
        [FieldOffset(139)]
        public byte FullAttributes;
        [FieldOffset(144)]
        public IntPtr LocalFileObject;
        [FieldOffset(152)]
        public uint InternalFlags;
        [FieldOffset(156)]
        public sbyte AccessMode;
        [FieldOffset(160)]
        public _IO_DRIVER_CREATE_CONTEXT DriverCreateContext;
        [FieldOffset(200)]
        public uint FileInformationClass;
        [FieldOffset(204)]
        public uint FileInformationLength;
        [FieldOffset(208)]
        public byte FilterQuery;
        [FieldOffset(216)]
        public long ExtendedCreateFlags;
    }
}