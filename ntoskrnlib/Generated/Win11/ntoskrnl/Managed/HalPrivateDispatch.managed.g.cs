using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!HAL_PRIVATE_DISPATCH")]
    public sealed class HalPrivateDispatch : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr HalHandlerForBus { get => ReadHere<IntPtr>(nameof(HalHandlerForBus)); set => WriteHere(nameof(HalHandlerForBus), value); }

        [Offset(16UL)]
        public IntPtr HalHandlerForConfigSpace { get => ReadHere<IntPtr>(nameof(HalHandlerForConfigSpace)); set => WriteHere(nameof(HalHandlerForConfigSpace), value); }

        [Offset(24UL)]
        public IntPtr HalLocateHiberRanges { get => ReadHere<IntPtr>(nameof(HalLocateHiberRanges)); set => WriteHere(nameof(HalLocateHiberRanges), value); }

        [Offset(32UL)]
        public IntPtr HalRegisterBusHandler { get => ReadHere<IntPtr>(nameof(HalRegisterBusHandler)); set => WriteHere(nameof(HalRegisterBusHandler), value); }

        [Offset(40UL)]
        public IntPtr HalSetWakeEnable { get => ReadHere<IntPtr>(nameof(HalSetWakeEnable)); set => WriteHere(nameof(HalSetWakeEnable), value); }

        [Offset(48UL)]
        public IntPtr HalSetWakeAlarm { get => ReadHere<IntPtr>(nameof(HalSetWakeAlarm)); set => WriteHere(nameof(HalSetWakeAlarm), value); }

        [Offset(56UL)]
        public IntPtr HalPciTranslateBusAddress { get => ReadHere<IntPtr>(nameof(HalPciTranslateBusAddress)); set => WriteHere(nameof(HalPciTranslateBusAddress), value); }

        [Offset(64UL)]
        public IntPtr HalPciAssignSlotResources { get => ReadHere<IntPtr>(nameof(HalPciAssignSlotResources)); set => WriteHere(nameof(HalPciAssignSlotResources), value); }

        [Offset(72UL)]
        public IntPtr HalHaltSystem { get => ReadHere<IntPtr>(nameof(HalHaltSystem)); set => WriteHere(nameof(HalHaltSystem), value); }

        [Offset(80UL)]
        public IntPtr HalFindBusAddressTranslation { get => ReadHere<IntPtr>(nameof(HalFindBusAddressTranslation)); set => WriteHere(nameof(HalFindBusAddressTranslation), value); }

        [Offset(88UL)]
        public IntPtr HalResetDisplay { get => ReadHere<IntPtr>(nameof(HalResetDisplay)); set => WriteHere(nameof(HalResetDisplay), value); }

        [Offset(96UL)]
        public IntPtr HalAllocateMapRegisters { get => ReadHere<IntPtr>(nameof(HalAllocateMapRegisters)); set => WriteHere(nameof(HalAllocateMapRegisters), value); }

        [Offset(104UL)]
        public IntPtr KdSetupPciDeviceForDebugging { get => ReadHere<IntPtr>(nameof(KdSetupPciDeviceForDebugging)); set => WriteHere(nameof(KdSetupPciDeviceForDebugging), value); }

        [Offset(112UL)]
        public IntPtr KdReleasePciDeviceForDebugging { get => ReadHere<IntPtr>(nameof(KdReleasePciDeviceForDebugging)); set => WriteHere(nameof(KdReleasePciDeviceForDebugging), value); }

        [Offset(120UL)]
        public IntPtr KdGetAcpiTablePhase0 { get => ReadHere<IntPtr>(nameof(KdGetAcpiTablePhase0)); set => WriteHere(nameof(KdGetAcpiTablePhase0), value); }

        [Offset(128UL)]
        public IntPtr KdCheckPowerButton { get => ReadHere<IntPtr>(nameof(KdCheckPowerButton)); set => WriteHere(nameof(KdCheckPowerButton), value); }

        [Offset(136UL)]
        public IntPtr HalVectorToIDTEntry { get => ReadHere<IntPtr>(nameof(HalVectorToIDTEntry)); set => WriteHere(nameof(HalVectorToIDTEntry), value); }

        [Offset(144UL)]
        public IntPtr KdMapPhysicalMemory64 { get => ReadHere<IntPtr>(nameof(KdMapPhysicalMemory64)); set => WriteHere(nameof(KdMapPhysicalMemory64), value); }

        [Offset(152UL)]
        public IntPtr KdUnmapVirtualAddress { get => ReadHere<IntPtr>(nameof(KdUnmapVirtualAddress)); set => WriteHere(nameof(KdUnmapVirtualAddress), value); }

        [Offset(160UL)]
        public IntPtr KdGetPciDataByOffset { get => ReadHere<IntPtr>(nameof(KdGetPciDataByOffset)); set => WriteHere(nameof(KdGetPciDataByOffset), value); }

        [Offset(168UL)]
        public IntPtr KdSetPciDataByOffset { get => ReadHere<IntPtr>(nameof(KdSetPciDataByOffset)); set => WriteHere(nameof(KdSetPciDataByOffset), value); }

        [Offset(176UL)]
        public IntPtr HalGetInterruptVectorOverride { get => ReadHere<IntPtr>(nameof(HalGetInterruptVectorOverride)); set => WriteHere(nameof(HalGetInterruptVectorOverride), value); }

        [Offset(184UL)]
        public IntPtr HalGetVectorInputOverride { get => ReadHere<IntPtr>(nameof(HalGetVectorInputOverride)); set => WriteHere(nameof(HalGetVectorInputOverride), value); }

        [Offset(192UL)]
        public IntPtr HalLoadMicrocode { get => ReadHere<IntPtr>(nameof(HalLoadMicrocode)); set => WriteHere(nameof(HalLoadMicrocode), value); }

        [Offset(200UL)]
        public IntPtr HalUnloadMicrocode { get => ReadHere<IntPtr>(nameof(HalUnloadMicrocode)); set => WriteHere(nameof(HalUnloadMicrocode), value); }

        [Offset(208UL)]
        public IntPtr HalPostMicrocodeUpdate { get => ReadHere<IntPtr>(nameof(HalPostMicrocodeUpdate)); set => WriteHere(nameof(HalPostMicrocodeUpdate), value); }

        [Offset(216UL)]
        public IntPtr HalAllocateMessageTargetOverride { get => ReadHere<IntPtr>(nameof(HalAllocateMessageTargetOverride)); set => WriteHere(nameof(HalAllocateMessageTargetOverride), value); }

        [Offset(224UL)]
        public IntPtr HalFreeMessageTargetOverride { get => ReadHere<IntPtr>(nameof(HalFreeMessageTargetOverride)); set => WriteHere(nameof(HalFreeMessageTargetOverride), value); }

        [Offset(232UL)]
        public IntPtr HalDpReplaceBegin { get => ReadHere<IntPtr>(nameof(HalDpReplaceBegin)); set => WriteHere(nameof(HalDpReplaceBegin), value); }

        [Offset(240UL)]
        public IntPtr HalDpReplaceTarget { get => ReadHere<IntPtr>(nameof(HalDpReplaceTarget)); set => WriteHere(nameof(HalDpReplaceTarget), value); }

        [Offset(248UL)]
        public IntPtr HalDpReplaceControl { get => ReadHere<IntPtr>(nameof(HalDpReplaceControl)); set => WriteHere(nameof(HalDpReplaceControl), value); }

        [Offset(256UL)]
        public IntPtr HalDpReplaceEnd { get => ReadHere<IntPtr>(nameof(HalDpReplaceEnd)); set => WriteHere(nameof(HalDpReplaceEnd), value); }

        [Offset(264UL)]
        public IntPtr HalPrepareForBugcheck { get => ReadHere<IntPtr>(nameof(HalPrepareForBugcheck)); set => WriteHere(nameof(HalPrepareForBugcheck), value); }

        [Offset(272UL)]
        public IntPtr HalQueryWakeTime { get => ReadHere<IntPtr>(nameof(HalQueryWakeTime)); set => WriteHere(nameof(HalQueryWakeTime), value); }

        [Offset(280UL)]
        public IntPtr HalReportIdleStateUsage { get => ReadHere<IntPtr>(nameof(HalReportIdleStateUsage)); set => WriteHere(nameof(HalReportIdleStateUsage), value); }

        [Offset(288UL)]
        public IntPtr HalTscSynchronization { get => ReadHere<IntPtr>(nameof(HalTscSynchronization)); set => WriteHere(nameof(HalTscSynchronization), value); }

        [Offset(296UL)]
        public IntPtr HalWheaInitProcessorGenericSection { get => ReadHere<IntPtr>(nameof(HalWheaInitProcessorGenericSection)); set => WriteHere(nameof(HalWheaInitProcessorGenericSection), value); }

        [Offset(304UL)]
        public IntPtr HalStopLegacyUsbInterrupts { get => ReadHere<IntPtr>(nameof(HalStopLegacyUsbInterrupts)); set => WriteHere(nameof(HalStopLegacyUsbInterrupts), value); }

        [Offset(312UL)]
        public IntPtr HalReadWheaPhysicalMemory { get => ReadHere<IntPtr>(nameof(HalReadWheaPhysicalMemory)); set => WriteHere(nameof(HalReadWheaPhysicalMemory), value); }

        [Offset(320UL)]
        public IntPtr HalWriteWheaPhysicalMemory { get => ReadHere<IntPtr>(nameof(HalWriteWheaPhysicalMemory)); set => WriteHere(nameof(HalWriteWheaPhysicalMemory), value); }

        [Offset(328UL)]
        public IntPtr HalDpMaskLevelTriggeredInterrupts { get => ReadHere<IntPtr>(nameof(HalDpMaskLevelTriggeredInterrupts)); set => WriteHere(nameof(HalDpMaskLevelTriggeredInterrupts), value); }

        [Offset(336UL)]
        public IntPtr HalDpUnmaskLevelTriggeredInterrupts { get => ReadHere<IntPtr>(nameof(HalDpUnmaskLevelTriggeredInterrupts)); set => WriteHere(nameof(HalDpUnmaskLevelTriggeredInterrupts), value); }

        [Offset(344UL)]
        public IntPtr HalDpGetInterruptReplayState { get => ReadHere<IntPtr>(nameof(HalDpGetInterruptReplayState)); set => WriteHere(nameof(HalDpGetInterruptReplayState), value); }

        [Offset(352UL)]
        public IntPtr HalDpReplayInterrupts { get => ReadHere<IntPtr>(nameof(HalDpReplayInterrupts)); set => WriteHere(nameof(HalDpReplayInterrupts), value); }

        [Offset(360UL)]
        public IntPtr HalQueryIoPortAccessSupported { get => ReadHere<IntPtr>(nameof(HalQueryIoPortAccessSupported)); set => WriteHere(nameof(HalQueryIoPortAccessSupported), value); }

        [Offset(368UL)]
        public IntPtr KdSetupIntegratedDeviceForDebugging { get => ReadHere<IntPtr>(nameof(KdSetupIntegratedDeviceForDebugging)); set => WriteHere(nameof(KdSetupIntegratedDeviceForDebugging), value); }

        [Offset(376UL)]
        public IntPtr KdReleaseIntegratedDeviceForDebugging { get => ReadHere<IntPtr>(nameof(KdReleaseIntegratedDeviceForDebugging)); set => WriteHere(nameof(KdReleaseIntegratedDeviceForDebugging), value); }

        [Offset(384UL)]
        public IntPtr HalGetEnlightenmentInformation { get => ReadHere<IntPtr>(nameof(HalGetEnlightenmentInformation)); set => WriteHere(nameof(HalGetEnlightenmentInformation), value); }

        [Offset(392UL)]
        public IntPtr HalAllocateEarlyPages { get => ReadHere<IntPtr>(nameof(HalAllocateEarlyPages)); set => WriteHere(nameof(HalAllocateEarlyPages), value); }

        [Offset(400UL)]
        public IntPtr HalMapEarlyPages { get => ReadHere<IntPtr>(nameof(HalMapEarlyPages)); set => WriteHere(nameof(HalMapEarlyPages), value); }

        [Offset(408UL)]
        public IntPtr Dummy1 { get => ReadHere<IntPtr>(nameof(Dummy1)); set => WriteHere(nameof(Dummy1), value); }

        [Offset(416UL)]
        public IntPtr Dummy2 { get => ReadHere<IntPtr>(nameof(Dummy2)); set => WriteHere(nameof(Dummy2), value); }

        [Offset(424UL)]
        public IntPtr HalNotifyProcessorFreeze { get => ReadHere<IntPtr>(nameof(HalNotifyProcessorFreeze)); set => WriteHere(nameof(HalNotifyProcessorFreeze), value); }

        [Offset(432UL)]
        public IntPtr HalPrepareProcessorForIdle { get => ReadHere<IntPtr>(nameof(HalPrepareProcessorForIdle)); set => WriteHere(nameof(HalPrepareProcessorForIdle), value); }

        [Offset(440UL)]
        public IntPtr HalRegisterLogRoutine { get => ReadHere<IntPtr>(nameof(HalRegisterLogRoutine)); set => WriteHere(nameof(HalRegisterLogRoutine), value); }

        [Offset(448UL)]
        public IntPtr HalResumeProcessorFromIdle { get => ReadHere<IntPtr>(nameof(HalResumeProcessorFromIdle)); set => WriteHere(nameof(HalResumeProcessorFromIdle), value); }

        [Offset(456UL)]
        public IntPtr Dummy { get => ReadHere<IntPtr>(nameof(Dummy)); set => WriteHere(nameof(Dummy), value); }

        [Offset(464UL)]
        public IntPtr HalVectorToIDTEntryEx { get => ReadHere<IntPtr>(nameof(HalVectorToIDTEntryEx)); set => WriteHere(nameof(HalVectorToIDTEntryEx), value); }

        [Offset(472UL)]
        public IntPtr HalSecondaryInterruptQueryPrimaryInformation { get => ReadHere<IntPtr>(nameof(HalSecondaryInterruptQueryPrimaryInformation)); set => WriteHere(nameof(HalSecondaryInterruptQueryPrimaryInformation), value); }

        [Offset(480UL)]
        public IntPtr HalMaskInterrupt { get => ReadHere<IntPtr>(nameof(HalMaskInterrupt)); set => WriteHere(nameof(HalMaskInterrupt), value); }

        [Offset(488UL)]
        public IntPtr HalUnmaskInterrupt { get => ReadHere<IntPtr>(nameof(HalUnmaskInterrupt)); set => WriteHere(nameof(HalUnmaskInterrupt), value); }

        [Offset(496UL)]
        public IntPtr HalIsInterruptTypeSecondary { get => ReadHere<IntPtr>(nameof(HalIsInterruptTypeSecondary)); set => WriteHere(nameof(HalIsInterruptTypeSecondary), value); }

        [Offset(504UL)]
        public IntPtr HalAllocateGsivForSecondaryInterrupt { get => ReadHere<IntPtr>(nameof(HalAllocateGsivForSecondaryInterrupt)); set => WriteHere(nameof(HalAllocateGsivForSecondaryInterrupt), value); }

        [Offset(512UL)]
        public IntPtr HalAddInterruptRemapping { get => ReadHere<IntPtr>(nameof(HalAddInterruptRemapping)); set => WriteHere(nameof(HalAddInterruptRemapping), value); }

        [Offset(520UL)]
        public IntPtr HalRemoveInterruptRemapping { get => ReadHere<IntPtr>(nameof(HalRemoveInterruptRemapping)); set => WriteHere(nameof(HalRemoveInterruptRemapping), value); }

        [Offset(528UL)]
        public IntPtr HalSaveAndDisableHvEnlightenment { get => ReadHere<IntPtr>(nameof(HalSaveAndDisableHvEnlightenment)); set => WriteHere(nameof(HalSaveAndDisableHvEnlightenment), value); }

        [Offset(536UL)]
        public IntPtr HalRestoreHvEnlightenment { get => ReadHere<IntPtr>(nameof(HalRestoreHvEnlightenment)); set => WriteHere(nameof(HalRestoreHvEnlightenment), value); }

        [Offset(544UL)]
        public IntPtr HalFlushIoBuffersExternalCache { get => ReadHere<IntPtr>(nameof(HalFlushIoBuffersExternalCache)); set => WriteHere(nameof(HalFlushIoBuffersExternalCache), value); }

        [Offset(552UL)]
        public IntPtr HalFlushExternalCache { get => ReadHere<IntPtr>(nameof(HalFlushExternalCache)); set => WriteHere(nameof(HalFlushExternalCache), value); }

        [Offset(560UL)]
        public IntPtr HalPciEarlyRestore { get => ReadHere<IntPtr>(nameof(HalPciEarlyRestore)); set => WriteHere(nameof(HalPciEarlyRestore), value); }

        [Offset(568UL)]
        public IntPtr HalGetProcessorId { get => ReadHere<IntPtr>(nameof(HalGetProcessorId)); set => WriteHere(nameof(HalGetProcessorId), value); }

        [Offset(576UL)]
        public IntPtr HalAllocatePmcCounterSet { get => ReadHere<IntPtr>(nameof(HalAllocatePmcCounterSet)); set => WriteHere(nameof(HalAllocatePmcCounterSet), value); }

        [Offset(584UL)]
        public IntPtr HalCollectPmcCounters { get => ReadHere<IntPtr>(nameof(HalCollectPmcCounters)); set => WriteHere(nameof(HalCollectPmcCounters), value); }

        [Offset(592UL)]
        public IntPtr HalFreePmcCounterSet { get => ReadHere<IntPtr>(nameof(HalFreePmcCounterSet)); set => WriteHere(nameof(HalFreePmcCounterSet), value); }

        [Offset(600UL)]
        public IntPtr HalProcessorHalt { get => ReadHere<IntPtr>(nameof(HalProcessorHalt)); set => WriteHere(nameof(HalProcessorHalt), value); }

        [Offset(608UL)]
        public IntPtr HalTimerQueryCycleCounter { get => ReadHere<IntPtr>(nameof(HalTimerQueryCycleCounter)); set => WriteHere(nameof(HalTimerQueryCycleCounter), value); }

        [Offset(616UL)]
        public IntPtr Dummy3 { get => ReadHere<IntPtr>(nameof(Dummy3)); set => WriteHere(nameof(Dummy3), value); }

        [Offset(624UL)]
        public IntPtr HalPciMarkHiberPhase { get => ReadHere<IntPtr>(nameof(HalPciMarkHiberPhase)); set => WriteHere(nameof(HalPciMarkHiberPhase), value); }

        [Offset(632UL)]
        public IntPtr HalQueryProcessorRestartEntryPoint { get => ReadHere<IntPtr>(nameof(HalQueryProcessorRestartEntryPoint)); set => WriteHere(nameof(HalQueryProcessorRestartEntryPoint), value); }

        [Offset(640UL)]
        public IntPtr HalRequestInterrupt { get => ReadHere<IntPtr>(nameof(HalRequestInterrupt)); set => WriteHere(nameof(HalRequestInterrupt), value); }

        [Offset(648UL)]
        public IntPtr HalEnumerateUnmaskedInterrupts { get => ReadHere<IntPtr>(nameof(HalEnumerateUnmaskedInterrupts)); set => WriteHere(nameof(HalEnumerateUnmaskedInterrupts), value); }

        [Offset(656UL)]
        public IntPtr HalFlushAndInvalidatePageExternalCache { get => ReadHere<IntPtr>(nameof(HalFlushAndInvalidatePageExternalCache)); set => WriteHere(nameof(HalFlushAndInvalidatePageExternalCache), value); }

        [Offset(664UL)]
        public IntPtr KdEnumerateDebuggingDevices { get => ReadHere<IntPtr>(nameof(KdEnumerateDebuggingDevices)); set => WriteHere(nameof(KdEnumerateDebuggingDevices), value); }

        [Offset(672UL)]
        public IntPtr HalFlushIoRectangleExternalCache { get => ReadHere<IntPtr>(nameof(HalFlushIoRectangleExternalCache)); set => WriteHere(nameof(HalFlushIoRectangleExternalCache), value); }

        [Offset(680UL)]
        public IntPtr HalPowerEarlyRestore { get => ReadHere<IntPtr>(nameof(HalPowerEarlyRestore)); set => WriteHere(nameof(HalPowerEarlyRestore), value); }

        [Offset(688UL)]
        public IntPtr HalQueryCapsuleCapabilities { get => ReadHere<IntPtr>(nameof(HalQueryCapsuleCapabilities)); set => WriteHere(nameof(HalQueryCapsuleCapabilities), value); }

        [Offset(696UL)]
        public IntPtr HalUpdateCapsule { get => ReadHere<IntPtr>(nameof(HalUpdateCapsule)); set => WriteHere(nameof(HalUpdateCapsule), value); }

        [Offset(704UL)]
        public IntPtr HalPciMultiStageResumeCapable { get => ReadHere<IntPtr>(nameof(HalPciMultiStageResumeCapable)); set => WriteHere(nameof(HalPciMultiStageResumeCapable), value); }

        [Offset(712UL)]
        public IntPtr HalDmaFreeCrashDumpRegisters { get => ReadHere<IntPtr>(nameof(HalDmaFreeCrashDumpRegisters)); set => WriteHere(nameof(HalDmaFreeCrashDumpRegisters), value); }

        [Offset(720UL)]
        public IntPtr HalAcpiAoacCapable { get => ReadHere<IntPtr>(nameof(HalAcpiAoacCapable)); set => WriteHere(nameof(HalAcpiAoacCapable), value); }

        [Offset(728UL)]
        public IntPtr HalInterruptSetDestination { get => ReadHere<IntPtr>(nameof(HalInterruptSetDestination)); set => WriteHere(nameof(HalInterruptSetDestination), value); }

        [Offset(736UL)]
        public IntPtr HalGetClockConfiguration { get => ReadHere<IntPtr>(nameof(HalGetClockConfiguration)); set => WriteHere(nameof(HalGetClockConfiguration), value); }

        [Offset(744UL)]
        public IntPtr HalClockTimerActivate { get => ReadHere<IntPtr>(nameof(HalClockTimerActivate)); set => WriteHere(nameof(HalClockTimerActivate), value); }

        [Offset(752UL)]
        public IntPtr HalClockTimerInitialize { get => ReadHere<IntPtr>(nameof(HalClockTimerInitialize)); set => WriteHere(nameof(HalClockTimerInitialize), value); }

        [Offset(760UL)]
        public IntPtr HalClockTimerStop { get => ReadHere<IntPtr>(nameof(HalClockTimerStop)); set => WriteHere(nameof(HalClockTimerStop), value); }

        [Offset(768UL)]
        public IntPtr HalClockTimerArm { get => ReadHere<IntPtr>(nameof(HalClockTimerArm)); set => WriteHere(nameof(HalClockTimerArm), value); }

        [Offset(776UL)]
        public IntPtr HalTimerOnlyClockInterruptPending { get => ReadHere<IntPtr>(nameof(HalTimerOnlyClockInterruptPending)); set => WriteHere(nameof(HalTimerOnlyClockInterruptPending), value); }

        [Offset(784UL)]
        public IntPtr HalAcpiGetMultiNode { get => ReadHere<IntPtr>(nameof(HalAcpiGetMultiNode)); set => WriteHere(nameof(HalAcpiGetMultiNode), value); }

        [Offset(792UL)]
        public IntPtr HalPowerSetRebootHandler { get => ReadHere<IntPtr>(nameof(HalPowerSetRebootHandler)); set => WriteHere(nameof(HalPowerSetRebootHandler), value); }

        [Offset(800UL)]
        public IntPtr HalIommuRegisterDispatchTable { get => ReadHere<IntPtr>(nameof(HalIommuRegisterDispatchTable)); set => WriteHere(nameof(HalIommuRegisterDispatchTable), value); }

        [Offset(808UL)]
        public IntPtr HalTimerWatchdogStart { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogStart)); set => WriteHere(nameof(HalTimerWatchdogStart), value); }

        [Offset(816UL)]
        public IntPtr HalTimerWatchdogResetCountdown { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogResetCountdown)); set => WriteHere(nameof(HalTimerWatchdogResetCountdown), value); }

        [Offset(824UL)]
        public IntPtr HalTimerWatchdogStop { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogStop)); set => WriteHere(nameof(HalTimerWatchdogStop), value); }

        [Offset(832UL)]
        public IntPtr HalTimerWatchdogGeneratedLastReset { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogGeneratedLastReset)); set => WriteHere(nameof(HalTimerWatchdogGeneratedLastReset), value); }

        [Offset(840UL)]
        public IntPtr HalTimerWatchdogTriggerSystemReset { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogTriggerSystemReset)); set => WriteHere(nameof(HalTimerWatchdogTriggerSystemReset), value); }

        [Offset(848UL)]
        public IntPtr HalInterruptVectorDataToGsiv { get => ReadHere<IntPtr>(nameof(HalInterruptVectorDataToGsiv)); set => WriteHere(nameof(HalInterruptVectorDataToGsiv), value); }

        [Offset(856UL)]
        public IntPtr HalInterruptGetHighestPriorityInterrupt { get => ReadHere<IntPtr>(nameof(HalInterruptGetHighestPriorityInterrupt)); set => WriteHere(nameof(HalInterruptGetHighestPriorityInterrupt), value); }

        [Offset(864UL)]
        public IntPtr HalProcessorOn { get => ReadHere<IntPtr>(nameof(HalProcessorOn)); set => WriteHere(nameof(HalProcessorOn), value); }

        [Offset(872UL)]
        public IntPtr HalProcessorOff { get => ReadHere<IntPtr>(nameof(HalProcessorOff)); set => WriteHere(nameof(HalProcessorOff), value); }

        [Offset(880UL)]
        public IntPtr HalProcessorFreeze { get => ReadHere<IntPtr>(nameof(HalProcessorFreeze)); set => WriteHere(nameof(HalProcessorFreeze), value); }

        [Offset(888UL)]
        public IntPtr HalDmaLinkDeviceObjectByToken { get => ReadHere<IntPtr>(nameof(HalDmaLinkDeviceObjectByToken)); set => WriteHere(nameof(HalDmaLinkDeviceObjectByToken), value); }

        [Offset(896UL)]
        public IntPtr HalDmaCheckAdapterToken { get => ReadHere<IntPtr>(nameof(HalDmaCheckAdapterToken)); set => WriteHere(nameof(HalDmaCheckAdapterToken), value); }

        [Offset(904UL)]
        public IntPtr Dummy4 { get => ReadHere<IntPtr>(nameof(Dummy4)); set => WriteHere(nameof(Dummy4), value); }

        [Offset(912UL)]
        public IntPtr HalTimerConvertPerformanceCounterToAuxiliaryCounter { get => ReadHere<IntPtr>(nameof(HalTimerConvertPerformanceCounterToAuxiliaryCounter)); set => WriteHere(nameof(HalTimerConvertPerformanceCounterToAuxiliaryCounter), value); }

        [Offset(920UL)]
        public IntPtr HalTimerConvertAuxiliaryCounterToPerformanceCounter { get => ReadHere<IntPtr>(nameof(HalTimerConvertAuxiliaryCounterToPerformanceCounter)); set => WriteHere(nameof(HalTimerConvertAuxiliaryCounterToPerformanceCounter), value); }

        [Offset(928UL)]
        public IntPtr HalTimerQueryAuxiliaryCounterFrequency { get => ReadHere<IntPtr>(nameof(HalTimerQueryAuxiliaryCounterFrequency)); set => WriteHere(nameof(HalTimerQueryAuxiliaryCounterFrequency), value); }

        [Offset(936UL)]
        public IntPtr HalConnectThermalInterrupt { get => ReadHere<IntPtr>(nameof(HalConnectThermalInterrupt)); set => WriteHere(nameof(HalConnectThermalInterrupt), value); }

        [Offset(944UL)]
        public IntPtr HalIsEFIRuntimeActive { get => ReadHere<IntPtr>(nameof(HalIsEFIRuntimeActive)); set => WriteHere(nameof(HalIsEFIRuntimeActive), value); }

        [Offset(952UL)]
        public IntPtr HalTimerQueryAndResetRtcErrors { get => ReadHere<IntPtr>(nameof(HalTimerQueryAndResetRtcErrors)); set => WriteHere(nameof(HalTimerQueryAndResetRtcErrors), value); }

        [Offset(960UL)]
        public IntPtr HalAcpiLateRestore { get => ReadHere<IntPtr>(nameof(HalAcpiLateRestore)); set => WriteHere(nameof(HalAcpiLateRestore), value); }

        [Offset(968UL)]
        public IntPtr KdWatchdogDelayExpiration { get => ReadHere<IntPtr>(nameof(KdWatchdogDelayExpiration)); set => WriteHere(nameof(KdWatchdogDelayExpiration), value); }

        [Offset(976UL)]
        public IntPtr HalGetProcessorStats { get => ReadHere<IntPtr>(nameof(HalGetProcessorStats)); set => WriteHere(nameof(HalGetProcessorStats), value); }

        [Offset(984UL)]
        public IntPtr HalTimerWatchdogQueryDueTime { get => ReadHere<IntPtr>(nameof(HalTimerWatchdogQueryDueTime)); set => WriteHere(nameof(HalTimerWatchdogQueryDueTime), value); }

        [Offset(992UL)]
        public IntPtr HalConnectSyntheticInterrupt { get => ReadHere<IntPtr>(nameof(HalConnectSyntheticInterrupt)); set => WriteHere(nameof(HalConnectSyntheticInterrupt), value); }

        [Offset(1000UL)]
        public IntPtr HalPreprocessNmi { get => ReadHere<IntPtr>(nameof(HalPreprocessNmi)); set => WriteHere(nameof(HalPreprocessNmi), value); }

        [Offset(1008UL)]
        public IntPtr HalEnumerateEnvironmentVariablesWithFilter { get => ReadHere<IntPtr>(nameof(HalEnumerateEnvironmentVariablesWithFilter)); set => WriteHere(nameof(HalEnumerateEnvironmentVariablesWithFilter), value); }

        [Offset(1016UL)]
        public IntPtr HalCaptureLastBranchRecordStack { get => ReadHere<IntPtr>(nameof(HalCaptureLastBranchRecordStack)); set => WriteHere(nameof(HalCaptureLastBranchRecordStack), value); }

        [Offset(1024UL)]
        public IntPtr HalClearLastBranchRecordStack { get => ReadHere<IntPtr>(nameof(HalClearLastBranchRecordStack)); set => WriteHere(nameof(HalClearLastBranchRecordStack), value); }

        [Offset(1032UL)]
        public IntPtr HalConfigureLastBranchRecord { get => ReadHere<IntPtr>(nameof(HalConfigureLastBranchRecord)); set => WriteHere(nameof(HalConfigureLastBranchRecord), value); }

        [Offset(1040UL)]
        public IntPtr HalGetLastBranchInformation { get => ReadHere<IntPtr>(nameof(HalGetLastBranchInformation)); set => WriteHere(nameof(HalGetLastBranchInformation), value); }

        [Offset(1048UL)]
        public IntPtr HalResumeLastBranchRecord { get => ReadHere<IntPtr>(nameof(HalResumeLastBranchRecord)); set => WriteHere(nameof(HalResumeLastBranchRecord), value); }

        [Offset(1056UL)]
        public IntPtr HalStartLastBranchRecord { get => ReadHere<IntPtr>(nameof(HalStartLastBranchRecord)); set => WriteHere(nameof(HalStartLastBranchRecord), value); }

        [Offset(1064UL)]
        public IntPtr HalStopLastBranchRecord { get => ReadHere<IntPtr>(nameof(HalStopLastBranchRecord)); set => WriteHere(nameof(HalStopLastBranchRecord), value); }

        [Offset(1072UL)]
        public IntPtr HalIommuBlockDevice { get => ReadHere<IntPtr>(nameof(HalIommuBlockDevice)); set => WriteHere(nameof(HalIommuBlockDevice), value); }

        [Offset(1080UL)]
        public IntPtr HalIommuUnblockDevice { get => ReadHere<IntPtr>(nameof(HalIommuUnblockDevice)); set => WriteHere(nameof(HalIommuUnblockDevice), value); }

        [Offset(1088UL)]
        public IntPtr HalGetIommuInterface { get => ReadHere<IntPtr>(nameof(HalGetIommuInterface)); set => WriteHere(nameof(HalGetIommuInterface), value); }

        [Offset(1096UL)]
        public IntPtr HalRequestGenericErrorRecovery { get => ReadHere<IntPtr>(nameof(HalRequestGenericErrorRecovery)); set => WriteHere(nameof(HalRequestGenericErrorRecovery), value); }

        [Offset(1104UL)]
        public IntPtr HalTimerQueryHostPerformanceCounter { get => ReadHere<IntPtr>(nameof(HalTimerQueryHostPerformanceCounter)); set => WriteHere(nameof(HalTimerQueryHostPerformanceCounter), value); }

        [Offset(1112UL)]
        public IntPtr HalTopologyQueryProcessorRelationships { get => ReadHere<IntPtr>(nameof(HalTopologyQueryProcessorRelationships)); set => WriteHere(nameof(HalTopologyQueryProcessorRelationships), value); }

        [Offset(1120UL)]
        public IntPtr HalInitPlatformDebugTriggers { get => ReadHere<IntPtr>(nameof(HalInitPlatformDebugTriggers)); set => WriteHere(nameof(HalInitPlatformDebugTriggers), value); }

        [Offset(1128UL)]
        public IntPtr HalRunPlatformDebugTriggers { get => ReadHere<IntPtr>(nameof(HalRunPlatformDebugTriggers)); set => WriteHere(nameof(HalRunPlatformDebugTriggers), value); }

        [Offset(1136UL)]
        public IntPtr HalTimerGetReferencePage { get => ReadHere<IntPtr>(nameof(HalTimerGetReferencePage)); set => WriteHere(nameof(HalTimerGetReferencePage), value); }

        [Offset(1144UL)]
        public IntPtr HalGetHiddenProcessorPowerInterface { get => ReadHere<IntPtr>(nameof(HalGetHiddenProcessorPowerInterface)); set => WriteHere(nameof(HalGetHiddenProcessorPowerInterface), value); }

        [Offset(1152UL)]
        public IntPtr HalGetHiddenProcessorPackageId { get => ReadHere<IntPtr>(nameof(HalGetHiddenProcessorPackageId)); set => WriteHere(nameof(HalGetHiddenProcessorPackageId), value); }

        [Offset(1160UL)]
        public IntPtr HalGetHiddenPackageProcessorCount { get => ReadHere<IntPtr>(nameof(HalGetHiddenPackageProcessorCount)); set => WriteHere(nameof(HalGetHiddenPackageProcessorCount), value); }

        [Offset(1168UL)]
        public IntPtr HalGetHiddenProcessorApicIdByIndex { get => ReadHere<IntPtr>(nameof(HalGetHiddenProcessorApicIdByIndex)); set => WriteHere(nameof(HalGetHiddenProcessorApicIdByIndex), value); }

        [Offset(1176UL)]
        public IntPtr HalRegisterHiddenProcessorIdleState { get => ReadHere<IntPtr>(nameof(HalRegisterHiddenProcessorIdleState)); set => WriteHere(nameof(HalRegisterHiddenProcessorIdleState), value); }

        [Offset(1184UL)]
        public IntPtr HalIommuReportIommuFault { get => ReadHere<IntPtr>(nameof(HalIommuReportIommuFault)); set => WriteHere(nameof(HalIommuReportIommuFault), value); }

        [Offset(1192UL)]
        public IntPtr HalIommuDmaRemappingCapable { get => ReadHere<IntPtr>(nameof(HalIommuDmaRemappingCapable)); set => WriteHere(nameof(HalIommuDmaRemappingCapable), value); }

        [Offset(1200UL)]
        public IntPtr HalAllocatePmcCounterSetEx { get => ReadHere<IntPtr>(nameof(HalAllocatePmcCounterSetEx)); set => WriteHere(nameof(HalAllocatePmcCounterSetEx), value); }

        [Offset(1208UL)]
        public IntPtr HalStartProfileInterruptEx { get => ReadHere<IntPtr>(nameof(HalStartProfileInterruptEx)); set => WriteHere(nameof(HalStartProfileInterruptEx), value); }

        [Offset(1216UL)]
        public IntPtr HalGetIommuInterfaceEx { get => ReadHere<IntPtr>(nameof(HalGetIommuInterfaceEx)); set => WriteHere(nameof(HalGetIommuInterfaceEx), value); }

        [Offset(1224UL)]
        public IntPtr HalNotifyIommuDomainPolicyChange { get => ReadHere<IntPtr>(nameof(HalNotifyIommuDomainPolicyChange)); set => WriteHere(nameof(HalNotifyIommuDomainPolicyChange), value); }

        [Offset(1232UL)]
        public IntPtr HalPciGetDeviceLocationFromPhysicalAddress { get => ReadHere<IntPtr>(nameof(HalPciGetDeviceLocationFromPhysicalAddress)); set => WriteHere(nameof(HalPciGetDeviceLocationFromPhysicalAddress), value); }

        [Offset(1240UL)]
        public IntPtr HalInvokeSmc { get => ReadHere<IntPtr>(nameof(HalInvokeSmc)); set => WriteHere(nameof(HalInvokeSmc), value); }

        [Offset(1248UL)]
        public IntPtr HalInvokeHvc { get => ReadHere<IntPtr>(nameof(HalInvokeHvc)); set => WriteHere(nameof(HalInvokeHvc), value); }

        [Offset(1256UL)]
        public IntPtr HalGetSoftRebootDatabase { get => ReadHere<IntPtr>(nameof(HalGetSoftRebootDatabase)); set => WriteHere(nameof(HalGetSoftRebootDatabase), value); }

        [Offset(1264UL)]
        public IntPtr HalRequestPmuAccess { get => ReadHere<IntPtr>(nameof(HalRequestPmuAccess)); set => WriteHere(nameof(HalRequestPmuAccess), value); }

        [Offset(1272UL)]
        public IntPtr HalTopologyQueryProcessorCacheInformation { get => ReadHere<IntPtr>(nameof(HalTopologyQueryProcessorCacheInformation)); set => WriteHere(nameof(HalTopologyQueryProcessorCacheInformation), value); }

        [Offset(1280UL)]
        public IntPtr HalReleasePmuAccessRequest { get => ReadHere<IntPtr>(nameof(HalReleasePmuAccessRequest)); set => WriteHere(nameof(HalReleasePmuAccessRequest), value); }

        [Offset(1288UL)]
        public IntPtr HalTimerQueryRtcErrors { get => ReadHere<IntPtr>(nameof(HalTimerQueryRtcErrors)); set => WriteHere(nameof(HalTimerQueryRtcErrors), value); }

        [Offset(1296UL)]
        public IntPtr HalExternalPciConfigSpaceAccess { get => ReadHere<IntPtr>(nameof(HalExternalPciConfigSpaceAccess)); set => WriteHere(nameof(HalExternalPciConfigSpaceAccess), value); }

        public HalPrivateDispatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalPrivateDispatch>();
        }
    }
}