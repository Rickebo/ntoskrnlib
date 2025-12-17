#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _FAST_IO_DISPATCH
    {
        [FieldOffset(0)]
        public uint SizeOfFastIoDispatch;
        [FieldOffset(8)]
        public IntPtr FastIoCheckIfPossible;
        [FieldOffset(16)]
        public IntPtr FastIoRead;
        [FieldOffset(24)]
        public IntPtr FastIoWrite;
        [FieldOffset(32)]
        public IntPtr FastIoQueryBasicInfo;
        [FieldOffset(40)]
        public IntPtr FastIoQueryStandardInfo;
        [FieldOffset(48)]
        public IntPtr FastIoLock;
        [FieldOffset(56)]
        public IntPtr FastIoUnlockSingle;
        [FieldOffset(64)]
        public IntPtr FastIoUnlockAll;
        [FieldOffset(72)]
        public IntPtr FastIoUnlockAllByKey;
        [FieldOffset(80)]
        public IntPtr FastIoDeviceControl;
        [FieldOffset(88)]
        public IntPtr AcquireFileForNtCreateSection;
        [FieldOffset(96)]
        public IntPtr ReleaseFileForNtCreateSection;
        [FieldOffset(104)]
        public IntPtr FastIoDetachDevice;
        [FieldOffset(112)]
        public IntPtr FastIoQueryNetworkOpenInfo;
        [FieldOffset(120)]
        public IntPtr AcquireForModWrite;
        [FieldOffset(128)]
        public IntPtr MdlRead;
        [FieldOffset(136)]
        public IntPtr MdlReadComplete;
        [FieldOffset(144)]
        public IntPtr PrepareMdlWrite;
        [FieldOffset(152)]
        public IntPtr MdlWriteComplete;
        [FieldOffset(160)]
        public IntPtr FastIoReadCompressed;
        [FieldOffset(168)]
        public IntPtr FastIoWriteCompressed;
        [FieldOffset(176)]
        public IntPtr MdlReadCompleteCompressed;
        [FieldOffset(184)]
        public IntPtr MdlWriteCompleteCompressed;
        [FieldOffset(192)]
        public IntPtr FastIoQueryOpen;
        [FieldOffset(200)]
        public IntPtr ReleaseForModWrite;
        [FieldOffset(208)]
        public IntPtr AcquireForCcFlush;
        [FieldOffset(216)]
        public IntPtr ReleaseForCcFlush;
    }
}