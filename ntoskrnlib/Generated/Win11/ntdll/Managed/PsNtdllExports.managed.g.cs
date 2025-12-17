using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_NTDLL_EXPORTS")]
    public sealed class PsNtdllExports : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LdrSystemDllInitBlock { get => ReadHere<IntPtr>(nameof(LdrSystemDllInitBlock)); set => WriteHere(nameof(LdrSystemDllInitBlock), value); }

        [Offset(8UL)]
        public IntPtr LdrInitializeThunk { get => ReadHere<IntPtr>(nameof(LdrInitializeThunk)); set => WriteHere(nameof(LdrInitializeThunk), value); }

        [Offset(16UL)]
        public IntPtr RtlUserThreadStart { get => ReadHere<IntPtr>(nameof(RtlUserThreadStart)); set => WriteHere(nameof(RtlUserThreadStart), value); }

        [Offset(24UL)]
        public IntPtr RtlUserFiberStart { get => ReadHere<IntPtr>(nameof(RtlUserFiberStart)); set => WriteHere(nameof(RtlUserFiberStart), value); }

        [Offset(32UL)]
        public IntPtr KiUserExceptionDispatcher { get => ReadHere<IntPtr>(nameof(KiUserExceptionDispatcher)); set => WriteHere(nameof(KiUserExceptionDispatcher), value); }

        [Offset(40UL)]
        public IntPtr KiUserApcDispatcher { get => ReadHere<IntPtr>(nameof(KiUserApcDispatcher)); set => WriteHere(nameof(KiUserApcDispatcher), value); }

        [Offset(48UL)]
        public IntPtr KiUserCallbackDispatcher { get => ReadHere<IntPtr>(nameof(KiUserCallbackDispatcher)); set => WriteHere(nameof(KiUserCallbackDispatcher), value); }

        [Offset(56UL)]
        public IntPtr KiUserCallbackDispatcherReturn { get => ReadHere<IntPtr>(nameof(KiUserCallbackDispatcherReturn)); set => WriteHere(nameof(KiUserCallbackDispatcherReturn), value); }

        [Offset(64UL)]
        public IntPtr KiRaiseUserExceptionDispatcher { get => ReadHere<IntPtr>(nameof(KiRaiseUserExceptionDispatcher)); set => WriteHere(nameof(KiRaiseUserExceptionDispatcher), value); }

        [Offset(72UL)]
        public IntPtr ExpInterlockedPopEntrySListEnd { get => ReadHere<IntPtr>(nameof(ExpInterlockedPopEntrySListEnd)); set => WriteHere(nameof(ExpInterlockedPopEntrySListEnd), value); }

        [Offset(80UL)]
        public IntPtr ExpInterlockedPopEntrySListFault { get => ReadHere<IntPtr>(nameof(ExpInterlockedPopEntrySListFault)); set => WriteHere(nameof(ExpInterlockedPopEntrySListFault), value); }

        [Offset(88UL)]
        public IntPtr ExpInterlockedPopEntrySListResume { get => ReadHere<IntPtr>(nameof(ExpInterlockedPopEntrySListResume)); set => WriteHere(nameof(ExpInterlockedPopEntrySListResume), value); }

        [Offset(96UL)]
        public IntPtr RtlpFreezeTimeBias { get => ReadHere<IntPtr>(nameof(RtlpFreezeTimeBias)); set => WriteHere(nameof(RtlpFreezeTimeBias), value); }

        [Offset(104UL)]
        public IntPtr KiUserInvertedFunctionTable { get => ReadHere<IntPtr>(nameof(KiUserInvertedFunctionTable)); set => WriteHere(nameof(KiUserInvertedFunctionTable), value); }

        [Offset(112UL)]
        public IntPtr WerReportExceptionWorker { get => ReadHere<IntPtr>(nameof(WerReportExceptionWorker)); set => WriteHere(nameof(WerReportExceptionWorker), value); }

        [Offset(120UL)]
        public IntPtr RtlCallEnclaveReturn { get => ReadHere<IntPtr>(nameof(RtlCallEnclaveReturn)); set => WriteHere(nameof(RtlCallEnclaveReturn), value); }

        [Offset(128UL)]
        public IntPtr RtlEnclaveCallDispatch { get => ReadHere<IntPtr>(nameof(RtlEnclaveCallDispatch)); set => WriteHere(nameof(RtlEnclaveCallDispatch), value); }

        [Offset(136UL)]
        public IntPtr RtlEnclaveCallDispatchReturn { get => ReadHere<IntPtr>(nameof(RtlEnclaveCallDispatchReturn)); set => WriteHere(nameof(RtlEnclaveCallDispatchReturn), value); }

        [Offset(144UL)]
        public IntPtr RtlRaiseExceptionForReturnAddressHijack { get => ReadHere<IntPtr>(nameof(RtlRaiseExceptionForReturnAddressHijack)); set => WriteHere(nameof(RtlRaiseExceptionForReturnAddressHijack), value); }

        [Offset(152UL)]
        public IntPtr KiUserEmulationDispatcher { get => ReadHere<IntPtr>(nameof(KiUserEmulationDispatcher)); set => WriteHere(nameof(KiUserEmulationDispatcher), value); }

        [Offset(160UL)]
        public IntPtr LdrHotPatchNotify { get => ReadHere<IntPtr>(nameof(LdrHotPatchNotify)); set => WriteHere(nameof(LdrHotPatchNotify), value); }

        public PsNtdllExports(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsNtdllExports>();
        }
    }
}