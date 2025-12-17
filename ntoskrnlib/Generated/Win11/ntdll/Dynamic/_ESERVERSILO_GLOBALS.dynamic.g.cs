using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ESERVERSILO_GLOBALS")]
    public sealed class _ESERVERSILO_GLOBALS : DynamicStructure
    {
        public _OBP_SILODRIVERSTATE ObSiloState { get; }
        public _SEP_SILOSTATE SeSiloState { get; }
        public _SEP_RM_LSA_CONNECTION_STATE SeRmSiloState { get; }
        public IntPtr EtwSiloState { get; }
        public IntPtr PspSessionLeaderProcess { get; }
        public IntPtr ExpDefaultErrorPortProcess { get; }
        public IntPtr ExpDefaultErrorPort { get; }
        public uint HardErrorState { get; }
        public IntPtr ExpLicenseState { get; }
        public _WNF_SILODRIVERSTATE WnfSiloState { get; }
        public _DBGK_SILOSTATE DbgkSiloState { get; }
        public _UNICODE_STRING PsProtectedCurrentDirectory { get; }
        public _UNICODE_STRING PsProtectedEnvironment { get; }
        public IntPtr ApiSetSection { get; }
        public IntPtr ApiSetSchema { get; }
        public byte OneCoreForwardersEnabled { get; }
        public IntPtr NlsState { get; }
        public _RTL_NLS_STATE RtlNlsState { get; }
        public IntPtr ImgFileExecOptions { get; }
        public IntPtr ExTimeZoneState { get; }
        public _UNICODE_STRING NtSystemRoot { get; }
        public _UNICODE_STRING SiloRootDirectoryName { get; }
        public IntPtr Storage { get; }
        public uint State { get; }
        public int ExitStatus { get; }
        public IntPtr DeleteEvent { get; }
        public IntPtr UserSharedData { get; }
        public IntPtr UserSharedSection { get; }
        public _WORK_QUEUE_ITEM TerminateWorkItem { get; }
        public uint ContainerBuildNumber { get; }
        public int CriticalProcessExited { get; }
        public int CriticalProcessStatus { get; }
        public byte[] CriticalProcessName { get; }
        public _CRITICAL_PROCESS_EXCEPTION_DATA CriticalProcessExceptionData { get; }
        public uint[] RtlFunctionalityCache { get; }

        public _ESERVERSILO_GLOBALS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ESERVERSILO_GLOBALS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ESERVERSILO_GLOBALS.ObSiloState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.SeSiloState),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.SeRmSiloState),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.EtwSiloState),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.PspSessionLeaderProcess),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ExpDefaultErrorPortProcess),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ExpDefaultErrorPort),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.HardErrorState),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ExpLicenseState),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.WnfSiloState),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.DbgkSiloState),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.PsProtectedCurrentDirectory),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.PsProtectedEnvironment),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ApiSetSection),
                    new ulong[]
                    {
                        1000UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ApiSetSchema),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.OneCoreForwardersEnabled),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.NlsState),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.RtlNlsState),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ImgFileExecOptions),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ExTimeZoneState),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.NtSystemRoot),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.SiloRootDirectoryName),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.Storage),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.State),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ExitStatus),
                    new ulong[]
                    {
                        1276UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.DeleteEvent),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.UserSharedData),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.UserSharedSection),
                    new ulong[]
                    {
                        1296UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.TerminateWorkItem),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.ContainerBuildNumber),
                    new ulong[]
                    {
                        1336UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.CriticalProcessExited),
                    new ulong[]
                    {
                        1340UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.CriticalProcessStatus),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.CriticalProcessName),
                    new ulong[]
                    {
                        1348UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.CriticalProcessExceptionData),
                    new ulong[]
                    {
                        1368UL
                    }
                },
                {
                    nameof(_ESERVERSILO_GLOBALS.RtlFunctionalityCache),
                    new ulong[]
                    {
                        1416UL
                    }
                }
            };
            Register<_ESERVERSILO_GLOBALS>((mem, ptr) => new _ESERVERSILO_GLOBALS(mem, ptr), offsets);
        }
    }
}