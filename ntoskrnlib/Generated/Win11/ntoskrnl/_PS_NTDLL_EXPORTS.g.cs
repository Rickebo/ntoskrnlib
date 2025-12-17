#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public partial struct _PS_NTDLL_EXPORTS
    {
        [FieldOffset(0)]
        public IntPtr LdrSystemDllInitBlock;
        [FieldOffset(8)]
        public IntPtr LdrInitializeThunk;
        [FieldOffset(16)]
        public IntPtr RtlUserThreadStart;
        [FieldOffset(24)]
        public IntPtr RtlUserFiberStart;
        [FieldOffset(32)]
        public IntPtr KiUserExceptionDispatcher;
        [FieldOffset(40)]
        public IntPtr KiUserApcDispatcher;
        [FieldOffset(48)]
        public IntPtr KiUserCallbackDispatcher;
        [FieldOffset(56)]
        public IntPtr KiUserCallbackDispatcherReturn;
        [FieldOffset(64)]
        public IntPtr KiRaiseUserExceptionDispatcher;
        [FieldOffset(72)]
        public IntPtr ExpInterlockedPopEntrySListEnd;
        [FieldOffset(80)]
        public IntPtr ExpInterlockedPopEntrySListFault;
        [FieldOffset(88)]
        public IntPtr ExpInterlockedPopEntrySListResume;
        [FieldOffset(96)]
        public IntPtr RtlpFreezeTimeBias;
        [FieldOffset(104)]
        public IntPtr KiUserInvertedFunctionTable;
        [FieldOffset(112)]
        public IntPtr WerReportExceptionWorker;
        [FieldOffset(120)]
        public IntPtr RtlCallEnclaveReturn;
        [FieldOffset(128)]
        public IntPtr RtlEnclaveCallDispatch;
        [FieldOffset(136)]
        public IntPtr RtlEnclaveCallDispatchReturn;
        [FieldOffset(144)]
        public IntPtr RtlRaiseExceptionForReturnAddressHijack;
        [FieldOffset(152)]
        public IntPtr KiUserEmulationDispatcher;
        [FieldOffset(160)]
        public IntPtr LdrHotPatchNotify;
    }
}