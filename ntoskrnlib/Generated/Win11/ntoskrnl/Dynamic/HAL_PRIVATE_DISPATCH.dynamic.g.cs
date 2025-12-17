using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!HAL_PRIVATE_DISPATCH")]
    public sealed class HAL_PRIVATE_DISPATCH : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr HalHandlerForBus { get; }
        public IntPtr HalHandlerForConfigSpace { get; }
        public IntPtr HalLocateHiberRanges { get; }
        public IntPtr HalRegisterBusHandler { get; }
        public IntPtr HalSetWakeEnable { get; }
        public IntPtr HalSetWakeAlarm { get; }
        public IntPtr HalPciTranslateBusAddress { get; }
        public IntPtr HalPciAssignSlotResources { get; }
        public IntPtr HalHaltSystem { get; }
        public IntPtr HalFindBusAddressTranslation { get; }
        public IntPtr HalResetDisplay { get; }
        public IntPtr HalAllocateMapRegisters { get; }
        public IntPtr KdSetupPciDeviceForDebugging { get; }
        public IntPtr KdReleasePciDeviceForDebugging { get; }
        public IntPtr KdGetAcpiTablePhase0 { get; }
        public IntPtr KdCheckPowerButton { get; }
        public IntPtr HalVectorToIDTEntry { get; }
        public IntPtr KdMapPhysicalMemory64 { get; }
        public IntPtr KdUnmapVirtualAddress { get; }
        public IntPtr KdGetPciDataByOffset { get; }
        public IntPtr KdSetPciDataByOffset { get; }
        public IntPtr HalGetInterruptVectorOverride { get; }
        public IntPtr HalGetVectorInputOverride { get; }
        public IntPtr HalLoadMicrocode { get; }
        public IntPtr HalUnloadMicrocode { get; }
        public IntPtr HalPostMicrocodeUpdate { get; }
        public IntPtr HalAllocateMessageTargetOverride { get; }
        public IntPtr HalFreeMessageTargetOverride { get; }
        public IntPtr HalDpReplaceBegin { get; }
        public IntPtr HalDpReplaceTarget { get; }
        public IntPtr HalDpReplaceControl { get; }
        public IntPtr HalDpReplaceEnd { get; }
        public IntPtr HalPrepareForBugcheck { get; }
        public IntPtr HalQueryWakeTime { get; }
        public IntPtr HalReportIdleStateUsage { get; }
        public IntPtr HalTscSynchronization { get; }
        public IntPtr HalWheaInitProcessorGenericSection { get; }
        public IntPtr HalStopLegacyUsbInterrupts { get; }
        public IntPtr HalReadWheaPhysicalMemory { get; }
        public IntPtr HalWriteWheaPhysicalMemory { get; }
        public IntPtr HalDpMaskLevelTriggeredInterrupts { get; }
        public IntPtr HalDpUnmaskLevelTriggeredInterrupts { get; }
        public IntPtr HalDpGetInterruptReplayState { get; }
        public IntPtr HalDpReplayInterrupts { get; }
        public IntPtr HalQueryIoPortAccessSupported { get; }
        public IntPtr KdSetupIntegratedDeviceForDebugging { get; }
        public IntPtr KdReleaseIntegratedDeviceForDebugging { get; }
        public IntPtr HalGetEnlightenmentInformation { get; }
        public IntPtr HalAllocateEarlyPages { get; }
        public IntPtr HalMapEarlyPages { get; }
        public IntPtr Dummy1 { get; }
        public IntPtr Dummy2 { get; }
        public IntPtr HalNotifyProcessorFreeze { get; }
        public IntPtr HalPrepareProcessorForIdle { get; }
        public IntPtr HalRegisterLogRoutine { get; }
        public IntPtr HalResumeProcessorFromIdle { get; }
        public IntPtr Dummy { get; }
        public IntPtr HalVectorToIDTEntryEx { get; }
        public IntPtr HalSecondaryInterruptQueryPrimaryInformation { get; }
        public IntPtr HalMaskInterrupt { get; }
        public IntPtr HalUnmaskInterrupt { get; }
        public IntPtr HalIsInterruptTypeSecondary { get; }
        public IntPtr HalAllocateGsivForSecondaryInterrupt { get; }
        public IntPtr HalAddInterruptRemapping { get; }
        public IntPtr HalRemoveInterruptRemapping { get; }
        public IntPtr HalSaveAndDisableHvEnlightenment { get; }
        public IntPtr HalRestoreHvEnlightenment { get; }
        public IntPtr HalFlushIoBuffersExternalCache { get; }
        public IntPtr HalFlushExternalCache { get; }
        public IntPtr HalPciEarlyRestore { get; }
        public IntPtr HalGetProcessorId { get; }
        public IntPtr HalAllocatePmcCounterSet { get; }
        public IntPtr HalCollectPmcCounters { get; }
        public IntPtr HalFreePmcCounterSet { get; }
        public IntPtr HalProcessorHalt { get; }
        public IntPtr HalTimerQueryCycleCounter { get; }
        public IntPtr Dummy3 { get; }
        public IntPtr HalPciMarkHiberPhase { get; }
        public IntPtr HalQueryProcessorRestartEntryPoint { get; }
        public IntPtr HalRequestInterrupt { get; }
        public IntPtr HalEnumerateUnmaskedInterrupts { get; }
        public IntPtr HalFlushAndInvalidatePageExternalCache { get; }
        public IntPtr KdEnumerateDebuggingDevices { get; }
        public IntPtr HalFlushIoRectangleExternalCache { get; }
        public IntPtr HalPowerEarlyRestore { get; }
        public IntPtr HalQueryCapsuleCapabilities { get; }
        public IntPtr HalUpdateCapsule { get; }
        public IntPtr HalPciMultiStageResumeCapable { get; }
        public IntPtr HalDmaFreeCrashDumpRegisters { get; }
        public IntPtr HalAcpiAoacCapable { get; }
        public IntPtr HalInterruptSetDestination { get; }
        public IntPtr HalGetClockConfiguration { get; }
        public IntPtr HalClockTimerActivate { get; }
        public IntPtr HalClockTimerInitialize { get; }
        public IntPtr HalClockTimerStop { get; }
        public IntPtr HalClockTimerArm { get; }
        public IntPtr HalTimerOnlyClockInterruptPending { get; }
        public IntPtr HalAcpiGetMultiNode { get; }
        public IntPtr HalPowerSetRebootHandler { get; }
        public IntPtr HalIommuRegisterDispatchTable { get; }
        public IntPtr HalTimerWatchdogStart { get; }
        public IntPtr HalTimerWatchdogResetCountdown { get; }
        public IntPtr HalTimerWatchdogStop { get; }
        public IntPtr HalTimerWatchdogGeneratedLastReset { get; }
        public IntPtr HalTimerWatchdogTriggerSystemReset { get; }
        public IntPtr HalInterruptVectorDataToGsiv { get; }
        public IntPtr HalInterruptGetHighestPriorityInterrupt { get; }
        public IntPtr HalProcessorOn { get; }
        public IntPtr HalProcessorOff { get; }
        public IntPtr HalProcessorFreeze { get; }
        public IntPtr HalDmaLinkDeviceObjectByToken { get; }
        public IntPtr HalDmaCheckAdapterToken { get; }
        public IntPtr Dummy4 { get; }
        public IntPtr HalTimerConvertPerformanceCounterToAuxiliaryCounter { get; }
        public IntPtr HalTimerConvertAuxiliaryCounterToPerformanceCounter { get; }
        public IntPtr HalTimerQueryAuxiliaryCounterFrequency { get; }
        public IntPtr HalConnectThermalInterrupt { get; }
        public IntPtr HalIsEFIRuntimeActive { get; }
        public IntPtr HalTimerQueryAndResetRtcErrors { get; }
        public IntPtr HalAcpiLateRestore { get; }
        public IntPtr KdWatchdogDelayExpiration { get; }
        public IntPtr HalGetProcessorStats { get; }
        public IntPtr HalTimerWatchdogQueryDueTime { get; }
        public IntPtr HalConnectSyntheticInterrupt { get; }
        public IntPtr HalPreprocessNmi { get; }
        public IntPtr HalEnumerateEnvironmentVariablesWithFilter { get; }
        public IntPtr HalCaptureLastBranchRecordStack { get; }
        public IntPtr HalClearLastBranchRecordStack { get; }
        public IntPtr HalConfigureLastBranchRecord { get; }
        public IntPtr HalGetLastBranchInformation { get; }
        public IntPtr HalResumeLastBranchRecord { get; }
        public IntPtr HalStartLastBranchRecord { get; }
        public IntPtr HalStopLastBranchRecord { get; }
        public IntPtr HalIommuBlockDevice { get; }
        public IntPtr HalIommuUnblockDevice { get; }
        public IntPtr HalGetIommuInterface { get; }
        public IntPtr HalRequestGenericErrorRecovery { get; }
        public IntPtr HalTimerQueryHostPerformanceCounter { get; }
        public IntPtr HalTopologyQueryProcessorRelationships { get; }
        public IntPtr HalInitPlatformDebugTriggers { get; }
        public IntPtr HalRunPlatformDebugTriggers { get; }
        public IntPtr HalTimerGetReferencePage { get; }
        public IntPtr HalGetHiddenProcessorPowerInterface { get; }
        public IntPtr HalGetHiddenProcessorPackageId { get; }
        public IntPtr HalGetHiddenPackageProcessorCount { get; }
        public IntPtr HalGetHiddenProcessorApicIdByIndex { get; }
        public IntPtr HalRegisterHiddenProcessorIdleState { get; }
        public IntPtr HalIommuReportIommuFault { get; }
        public IntPtr HalIommuDmaRemappingCapable { get; }
        public IntPtr HalAllocatePmcCounterSetEx { get; }
        public IntPtr HalStartProfileInterruptEx { get; }
        public IntPtr HalGetIommuInterfaceEx { get; }
        public IntPtr HalNotifyIommuDomainPolicyChange { get; }
        public IntPtr HalPciGetDeviceLocationFromPhysicalAddress { get; }
        public IntPtr HalInvokeSmc { get; }
        public IntPtr HalInvokeHvc { get; }
        public IntPtr HalGetSoftRebootDatabase { get; }
        public IntPtr HalRequestPmuAccess { get; }
        public IntPtr HalTopologyQueryProcessorCacheInformation { get; }
        public IntPtr HalReleasePmuAccessRequest { get; }
        public IntPtr HalTimerQueryRtcErrors { get; }
        public IntPtr HalExternalPciConfigSpaceAccess { get; }

        public HAL_PRIVATE_DISPATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static HAL_PRIVATE_DISPATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(HAL_PRIVATE_DISPATCH.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalHandlerForBus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalHandlerForConfigSpace),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalLocateHiberRanges),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRegisterBusHandler),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalSetWakeEnable),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalSetWakeAlarm),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciTranslateBusAddress),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciAssignSlotResources),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalHaltSystem),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFindBusAddressTranslation),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalResetDisplay),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocateMapRegisters),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdSetupPciDeviceForDebugging),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdReleasePciDeviceForDebugging),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdGetAcpiTablePhase0),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdCheckPowerButton),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalVectorToIDTEntry),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdMapPhysicalMemory64),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdUnmapVirtualAddress),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdGetPciDataByOffset),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdSetPciDataByOffset),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetInterruptVectorOverride),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetVectorInputOverride),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalLoadMicrocode),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalUnloadMicrocode),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPostMicrocodeUpdate),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocateMessageTargetOverride),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFreeMessageTargetOverride),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpReplaceBegin),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpReplaceTarget),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpReplaceControl),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpReplaceEnd),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPrepareForBugcheck),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalQueryWakeTime),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalReportIdleStateUsage),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTscSynchronization),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalWheaInitProcessorGenericSection),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalStopLegacyUsbInterrupts),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalReadWheaPhysicalMemory),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalWriteWheaPhysicalMemory),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpMaskLevelTriggeredInterrupts),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpUnmaskLevelTriggeredInterrupts),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpGetInterruptReplayState),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDpReplayInterrupts),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalQueryIoPortAccessSupported),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdSetupIntegratedDeviceForDebugging),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdReleaseIntegratedDeviceForDebugging),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetEnlightenmentInformation),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocateEarlyPages),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalMapEarlyPages),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.Dummy1),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.Dummy2),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalNotifyProcessorFreeze),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPrepareProcessorForIdle),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRegisterLogRoutine),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalResumeProcessorFromIdle),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.Dummy),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalVectorToIDTEntryEx),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalSecondaryInterruptQueryPrimaryInformation),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalMaskInterrupt),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalUnmaskInterrupt),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIsInterruptTypeSecondary),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocateGsivForSecondaryInterrupt),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAddInterruptRemapping),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRemoveInterruptRemapping),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalSaveAndDisableHvEnlightenment),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRestoreHvEnlightenment),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFlushIoBuffersExternalCache),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFlushExternalCache),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciEarlyRestore),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetProcessorId),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocatePmcCounterSet),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalCollectPmcCounters),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFreePmcCounterSet),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalProcessorHalt),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerQueryCycleCounter),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.Dummy3),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciMarkHiberPhase),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalQueryProcessorRestartEntryPoint),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRequestInterrupt),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalEnumerateUnmaskedInterrupts),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFlushAndInvalidatePageExternalCache),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdEnumerateDebuggingDevices),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalFlushIoRectangleExternalCache),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPowerEarlyRestore),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalQueryCapsuleCapabilities),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalUpdateCapsule),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciMultiStageResumeCapable),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDmaFreeCrashDumpRegisters),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAcpiAoacCapable),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInterruptSetDestination),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetClockConfiguration),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalClockTimerActivate),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalClockTimerInitialize),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalClockTimerStop),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalClockTimerArm),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerOnlyClockInterruptPending),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAcpiGetMultiNode),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPowerSetRebootHandler),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIommuRegisterDispatchTable),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogStart),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogResetCountdown),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogStop),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogGeneratedLastReset),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogTriggerSystemReset),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInterruptVectorDataToGsiv),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInterruptGetHighestPriorityInterrupt),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalProcessorOn),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalProcessorOff),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalProcessorFreeze),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDmaLinkDeviceObjectByToken),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalDmaCheckAdapterToken),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.Dummy4),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerConvertPerformanceCounterToAuxiliaryCounter),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerConvertAuxiliaryCounterToPerformanceCounter),
                    new ulong[]
                    {
                        920UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerQueryAuxiliaryCounterFrequency),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalConnectThermalInterrupt),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIsEFIRuntimeActive),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerQueryAndResetRtcErrors),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAcpiLateRestore),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.KdWatchdogDelayExpiration),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetProcessorStats),
                    new ulong[]
                    {
                        976UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerWatchdogQueryDueTime),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalConnectSyntheticInterrupt),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPreprocessNmi),
                    new ulong[]
                    {
                        1000UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalEnumerateEnvironmentVariablesWithFilter),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalCaptureLastBranchRecordStack),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalClearLastBranchRecordStack),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalConfigureLastBranchRecord),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetLastBranchInformation),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalResumeLastBranchRecord),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalStartLastBranchRecord),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalStopLastBranchRecord),
                    new ulong[]
                    {
                        1064UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIommuBlockDevice),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIommuUnblockDevice),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetIommuInterface),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRequestGenericErrorRecovery),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerQueryHostPerformanceCounter),
                    new ulong[]
                    {
                        1104UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTopologyQueryProcessorRelationships),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInitPlatformDebugTriggers),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRunPlatformDebugTriggers),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerGetReferencePage),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetHiddenProcessorPowerInterface),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetHiddenProcessorPackageId),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetHiddenPackageProcessorCount),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetHiddenProcessorApicIdByIndex),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRegisterHiddenProcessorIdleState),
                    new ulong[]
                    {
                        1176UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIommuReportIommuFault),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalIommuDmaRemappingCapable),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalAllocatePmcCounterSetEx),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalStartProfileInterruptEx),
                    new ulong[]
                    {
                        1208UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetIommuInterfaceEx),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalNotifyIommuDomainPolicyChange),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalPciGetDeviceLocationFromPhysicalAddress),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInvokeSmc),
                    new ulong[]
                    {
                        1240UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalInvokeHvc),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalGetSoftRebootDatabase),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalRequestPmuAccess),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTopologyQueryProcessorCacheInformation),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalReleasePmuAccessRequest),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalTimerQueryRtcErrors),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(HAL_PRIVATE_DISPATCH.HalExternalPciConfigSpaceAccess),
                    new ulong[]
                    {
                        1296UL
                    }
                }
            };
            Register<HAL_PRIVATE_DISPATCH>((mem, ptr) => new HAL_PRIVATE_DISPATCH(mem, ptr), offsets);
        }
    }
}