using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_NTDLL_EXPORTS")]
    public sealed class _PS_NTDLL_EXPORTS : DynamicStructure
    {
        public IntPtr LdrSystemDllInitBlock { get; }
        public IntPtr LdrInitializeThunk { get; }
        public IntPtr RtlUserThreadStart { get; }
        public IntPtr RtlUserFiberStart { get; }
        public IntPtr KiUserExceptionDispatcher { get; }
        public IntPtr KiUserApcDispatcher { get; }
        public IntPtr KiUserCallbackDispatcher { get; }
        public IntPtr KiUserCallbackDispatcherReturn { get; }
        public IntPtr KiRaiseUserExceptionDispatcher { get; }
        public IntPtr ExpInterlockedPopEntrySListEnd { get; }
        public IntPtr ExpInterlockedPopEntrySListFault { get; }
        public IntPtr ExpInterlockedPopEntrySListResume { get; }
        public IntPtr RtlpFreezeTimeBias { get; }
        public IntPtr KiUserInvertedFunctionTable { get; }
        public IntPtr WerReportExceptionWorker { get; }
        public IntPtr RtlCallEnclaveReturn { get; }
        public IntPtr RtlEnclaveCallDispatch { get; }
        public IntPtr RtlEnclaveCallDispatchReturn { get; }
        public IntPtr RtlRaiseExceptionForReturnAddressHijack { get; }
        public IntPtr KiUserEmulationDispatcher { get; }
        public IntPtr LdrHotPatchNotify { get; }

        public _PS_NTDLL_EXPORTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_NTDLL_EXPORTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_NTDLL_EXPORTS.LdrSystemDllInitBlock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.LdrInitializeThunk),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlUserThreadStart),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlUserFiberStart),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserExceptionDispatcher),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserApcDispatcher),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserCallbackDispatcher),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserCallbackDispatcherReturn),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiRaiseUserExceptionDispatcher),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.ExpInterlockedPopEntrySListEnd),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.ExpInterlockedPopEntrySListFault),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.ExpInterlockedPopEntrySListResume),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlpFreezeTimeBias),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserInvertedFunctionTable),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.WerReportExceptionWorker),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlCallEnclaveReturn),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlEnclaveCallDispatch),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlEnclaveCallDispatchReturn),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.RtlRaiseExceptionForReturnAddressHijack),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.KiUserEmulationDispatcher),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PS_NTDLL_EXPORTS.LdrHotPatchNotify),
                    new ulong[]
                    {
                        160UL
                    }
                }
            };
            Register<_PS_NTDLL_EXPORTS>((mem, ptr) => new _PS_NTDLL_EXPORTS(mem, ptr), offsets);
        }
    }
}