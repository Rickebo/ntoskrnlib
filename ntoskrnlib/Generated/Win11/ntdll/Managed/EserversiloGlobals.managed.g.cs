using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ESERVERSILO_GLOBALS")]
    public sealed class EserversiloGlobals : DynamicStructure
    {
        [Offset(0UL)]
        public ObpSilodriverstate ObSiloState { get => ReadStructure<ObpSilodriverstate>(nameof(ObSiloState)); set => WriteStructure(nameof(ObSiloState), value); }

        [Offset(736UL)]
        public SepSilostate SeSiloState { get => ReadStructure<SepSilostate>(nameof(SeSiloState)); set => WriteStructure(nameof(SeSiloState), value); }

        [Offset(784UL)]
        public SepRmLsaConnectionState SeRmSiloState { get => ReadStructure<SepRmLsaConnectionState>(nameof(SeRmSiloState)); set => WriteStructure(nameof(SeRmSiloState), value); }

        [Offset(832UL)]
        public IntPtr EtwSiloState { get => ReadHere<IntPtr>(nameof(EtwSiloState)); set => WriteHere(nameof(EtwSiloState), value); }

        [Offset(840UL)]
        public IntPtr PspSessionLeaderProcess { get => ReadHere<IntPtr>(nameof(PspSessionLeaderProcess)); set => WriteHere(nameof(PspSessionLeaderProcess), value); }

        [Offset(848UL)]
        public IntPtr ExpDefaultErrorPortProcess { get => ReadHere<IntPtr>(nameof(ExpDefaultErrorPortProcess)); set => WriteHere(nameof(ExpDefaultErrorPortProcess), value); }

        [Offset(856UL)]
        public IntPtr ExpDefaultErrorPort { get => ReadHere<IntPtr>(nameof(ExpDefaultErrorPort)); set => WriteHere(nameof(ExpDefaultErrorPort), value); }

        [Offset(864UL)]
        public uint HardErrorState { get => ReadHere<uint>(nameof(HardErrorState)); set => WriteHere(nameof(HardErrorState), value); }

        [Offset(872UL)]
        public IntPtr ExpLicenseState { get => ReadHere<IntPtr>(nameof(ExpLicenseState)); set => WriteHere(nameof(ExpLicenseState), value); }

        [Offset(880UL)]
        public WnfSilodriverstate WnfSiloState { get => ReadStructure<WnfSilodriverstate>(nameof(WnfSiloState)); set => WriteStructure(nameof(WnfSiloState), value); }

        [Offset(936UL)]
        public DbgkSilostate DbgkSiloState { get => ReadStructure<DbgkSilostate>(nameof(DbgkSiloState)); set => WriteStructure(nameof(DbgkSiloState), value); }

        [Offset(968UL)]
        public UnicodeString PsProtectedCurrentDirectory { get => ReadStructure<UnicodeString>(nameof(PsProtectedCurrentDirectory)); set => WriteStructure(nameof(PsProtectedCurrentDirectory), value); }

        [Offset(984UL)]
        public UnicodeString PsProtectedEnvironment { get => ReadStructure<UnicodeString>(nameof(PsProtectedEnvironment)); set => WriteStructure(nameof(PsProtectedEnvironment), value); }

        [Offset(1000UL)]
        public IntPtr ApiSetSection { get => ReadHere<IntPtr>(nameof(ApiSetSection)); set => WriteHere(nameof(ApiSetSection), value); }

        [Offset(1008UL)]
        public IntPtr ApiSetSchema { get => ReadHere<IntPtr>(nameof(ApiSetSchema)); set => WriteHere(nameof(ApiSetSchema), value); }

        [Offset(1016UL)]
        public byte OneCoreForwardersEnabled { get => ReadHere<byte>(nameof(OneCoreForwardersEnabled)); set => WriteHere(nameof(OneCoreForwardersEnabled), value); }

        [Offset(1024UL)]
        public IntPtr NlsState { get => ReadHere<IntPtr>(nameof(NlsState)); set => WriteHere(nameof(NlsState), value); }

        [Offset(1032UL)]
        public RtlNlsState RtlNlsState { get => ReadStructure<RtlNlsState>(nameof(RtlNlsState)); set => WriteStructure(nameof(RtlNlsState), value); }

        [Offset(1216UL)]
        public IntPtr ImgFileExecOptions { get => ReadHere<IntPtr>(nameof(ImgFileExecOptions)); set => WriteHere(nameof(ImgFileExecOptions), value); }

        [Offset(1224UL)]
        public IntPtr ExTimeZoneState { get => ReadHere<IntPtr>(nameof(ExTimeZoneState)); set => WriteHere(nameof(ExTimeZoneState), value); }

        [Offset(1232UL)]
        public UnicodeString NtSystemRoot { get => ReadStructure<UnicodeString>(nameof(NtSystemRoot)); set => WriteStructure(nameof(NtSystemRoot), value); }

        [Offset(1248UL)]
        public UnicodeString SiloRootDirectoryName { get => ReadStructure<UnicodeString>(nameof(SiloRootDirectoryName)); set => WriteStructure(nameof(SiloRootDirectoryName), value); }

        [Offset(1264UL)]
        public IntPtr Storage { get => ReadHere<IntPtr>(nameof(Storage)); set => WriteHere(nameof(Storage), value); }

        [Offset(1272UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(1276UL)]
        public int ExitStatus { get => ReadHere<int>(nameof(ExitStatus)); set => WriteHere(nameof(ExitStatus), value); }

        [Offset(1280UL)]
        public IntPtr DeleteEvent { get => ReadHere<IntPtr>(nameof(DeleteEvent)); set => WriteHere(nameof(DeleteEvent), value); }

        [Offset(1288UL)]
        public IntPtr UserSharedData { get => ReadHere<IntPtr>(nameof(UserSharedData)); set => WriteHere(nameof(UserSharedData), value); }

        [Offset(1296UL)]
        public IntPtr UserSharedSection { get => ReadHere<IntPtr>(nameof(UserSharedSection)); set => WriteHere(nameof(UserSharedSection), value); }

        [Offset(1304UL)]
        public WorkQueueItem TerminateWorkItem { get => ReadStructure<WorkQueueItem>(nameof(TerminateWorkItem)); set => WriteStructure(nameof(TerminateWorkItem), value); }

        [Offset(1336UL)]
        public uint ContainerBuildNumber { get => ReadHere<uint>(nameof(ContainerBuildNumber)); set => WriteHere(nameof(ContainerBuildNumber), value); }

        [Offset(1340UL)]
        public int CriticalProcessExited { get => ReadHere<int>(nameof(CriticalProcessExited)); set => WriteHere(nameof(CriticalProcessExited), value); }

        [Offset(1344UL)]
        public int CriticalProcessStatus { get => ReadHere<int>(nameof(CriticalProcessStatus)); set => WriteHere(nameof(CriticalProcessStatus), value); }

        [Offset(1348UL)]
        [Length(15)]
        public DynamicArray CriticalProcessName { get => ReadStructure<DynamicArray>(nameof(CriticalProcessName)); set => WriteStructure(nameof(CriticalProcessName), value); }

        [Offset(1368UL)]
        public CriticalProcessExceptionData CriticalProcessExceptionData { get => ReadStructure<CriticalProcessExceptionData>(nameof(CriticalProcessExceptionData)); set => WriteStructure(nameof(CriticalProcessExceptionData), value); }

        [Offset(1416UL)]
        [Length(4)]
        public DynamicArray RtlFunctionalityCache { get => ReadStructure<DynamicArray>(nameof(RtlFunctionalityCache)); set => WriteStructure(nameof(RtlFunctionalityCache), value); }

        public EserversiloGlobals(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EserversiloGlobals>();
        }
    }
}