#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1304)]
    public partial struct HAL_PRIVATE_DISPATCH
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr HalHandlerForBus;
        [FieldOffset(16)]
        public IntPtr HalHandlerForConfigSpace;
        [FieldOffset(24)]
        public IntPtr HalLocateHiberRanges;
        [FieldOffset(32)]
        public IntPtr HalRegisterBusHandler;
        [FieldOffset(40)]
        public IntPtr HalSetWakeEnable;
        [FieldOffset(48)]
        public IntPtr HalSetWakeAlarm;
        [FieldOffset(56)]
        public IntPtr HalPciTranslateBusAddress;
        [FieldOffset(64)]
        public IntPtr HalPciAssignSlotResources;
        [FieldOffset(72)]
        public IntPtr HalHaltSystem;
        [FieldOffset(80)]
        public IntPtr HalFindBusAddressTranslation;
        [FieldOffset(88)]
        public IntPtr HalResetDisplay;
        [FieldOffset(96)]
        public IntPtr HalAllocateMapRegisters;
        [FieldOffset(104)]
        public IntPtr KdSetupPciDeviceForDebugging;
        [FieldOffset(112)]
        public IntPtr KdReleasePciDeviceForDebugging;
        [FieldOffset(120)]
        public IntPtr KdGetAcpiTablePhase0;
        [FieldOffset(128)]
        public IntPtr KdCheckPowerButton;
        [FieldOffset(136)]
        public IntPtr HalVectorToIDTEntry;
        [FieldOffset(144)]
        public IntPtr KdMapPhysicalMemory64;
        [FieldOffset(152)]
        public IntPtr KdUnmapVirtualAddress;
        [FieldOffset(160)]
        public IntPtr KdGetPciDataByOffset;
        [FieldOffset(168)]
        public IntPtr KdSetPciDataByOffset;
        [FieldOffset(176)]
        public IntPtr HalGetInterruptVectorOverride;
        [FieldOffset(184)]
        public IntPtr HalGetVectorInputOverride;
        [FieldOffset(192)]
        public IntPtr HalLoadMicrocode;
        [FieldOffset(200)]
        public IntPtr HalUnloadMicrocode;
        [FieldOffset(208)]
        public IntPtr HalPostMicrocodeUpdate;
        [FieldOffset(216)]
        public IntPtr HalAllocateMessageTargetOverride;
        [FieldOffset(224)]
        public IntPtr HalFreeMessageTargetOverride;
        [FieldOffset(232)]
        public IntPtr HalDpReplaceBegin;
        [FieldOffset(240)]
        public IntPtr HalDpReplaceTarget;
        [FieldOffset(248)]
        public IntPtr HalDpReplaceControl;
        [FieldOffset(256)]
        public IntPtr HalDpReplaceEnd;
        [FieldOffset(264)]
        public IntPtr HalPrepareForBugcheck;
        [FieldOffset(272)]
        public IntPtr HalQueryWakeTime;
        [FieldOffset(280)]
        public IntPtr HalReportIdleStateUsage;
        [FieldOffset(288)]
        public IntPtr HalTscSynchronization;
        [FieldOffset(296)]
        public IntPtr HalWheaInitProcessorGenericSection;
        [FieldOffset(304)]
        public IntPtr HalStopLegacyUsbInterrupts;
        [FieldOffset(312)]
        public IntPtr HalReadWheaPhysicalMemory;
        [FieldOffset(320)]
        public IntPtr HalWriteWheaPhysicalMemory;
        [FieldOffset(328)]
        public IntPtr HalDpMaskLevelTriggeredInterrupts;
        [FieldOffset(336)]
        public IntPtr HalDpUnmaskLevelTriggeredInterrupts;
        [FieldOffset(344)]
        public IntPtr HalDpGetInterruptReplayState;
        [FieldOffset(352)]
        public IntPtr HalDpReplayInterrupts;
        [FieldOffset(360)]
        public IntPtr HalQueryIoPortAccessSupported;
        [FieldOffset(368)]
        public IntPtr KdSetupIntegratedDeviceForDebugging;
        [FieldOffset(376)]
        public IntPtr KdReleaseIntegratedDeviceForDebugging;
        [FieldOffset(384)]
        public IntPtr HalGetEnlightenmentInformation;
        [FieldOffset(392)]
        public IntPtr HalAllocateEarlyPages;
        [FieldOffset(400)]
        public IntPtr HalMapEarlyPages;
        [FieldOffset(408)]
        public IntPtr Dummy1;
        [FieldOffset(416)]
        public IntPtr Dummy2;
        [FieldOffset(424)]
        public IntPtr HalNotifyProcessorFreeze;
        [FieldOffset(432)]
        public IntPtr HalPrepareProcessorForIdle;
        [FieldOffset(440)]
        public IntPtr HalRegisterLogRoutine;
        [FieldOffset(448)]
        public IntPtr HalResumeProcessorFromIdle;
        [FieldOffset(456)]
        public IntPtr Dummy;
        [FieldOffset(464)]
        public IntPtr HalVectorToIDTEntryEx;
        [FieldOffset(472)]
        public IntPtr HalSecondaryInterruptQueryPrimaryInformation;
        [FieldOffset(480)]
        public IntPtr HalMaskInterrupt;
        [FieldOffset(488)]
        public IntPtr HalUnmaskInterrupt;
        [FieldOffset(496)]
        public IntPtr HalIsInterruptTypeSecondary;
        [FieldOffset(504)]
        public IntPtr HalAllocateGsivForSecondaryInterrupt;
        [FieldOffset(512)]
        public IntPtr HalAddInterruptRemapping;
        [FieldOffset(520)]
        public IntPtr HalRemoveInterruptRemapping;
        [FieldOffset(528)]
        public IntPtr HalSaveAndDisableHvEnlightenment;
        [FieldOffset(536)]
        public IntPtr HalRestoreHvEnlightenment;
        [FieldOffset(544)]
        public IntPtr HalFlushIoBuffersExternalCache;
        [FieldOffset(552)]
        public IntPtr HalFlushExternalCache;
        [FieldOffset(560)]
        public IntPtr HalPciEarlyRestore;
        [FieldOffset(568)]
        public IntPtr HalGetProcessorId;
        [FieldOffset(576)]
        public IntPtr HalAllocatePmcCounterSet;
        [FieldOffset(584)]
        public IntPtr HalCollectPmcCounters;
        [FieldOffset(592)]
        public IntPtr HalFreePmcCounterSet;
        [FieldOffset(600)]
        public IntPtr HalProcessorHalt;
        [FieldOffset(608)]
        public IntPtr HalTimerQueryCycleCounter;
        [FieldOffset(616)]
        public IntPtr Dummy3;
        [FieldOffset(624)]
        public IntPtr HalPciMarkHiberPhase;
        [FieldOffset(632)]
        public IntPtr HalQueryProcessorRestartEntryPoint;
        [FieldOffset(640)]
        public IntPtr HalRequestInterrupt;
        [FieldOffset(648)]
        public IntPtr HalEnumerateUnmaskedInterrupts;
        [FieldOffset(656)]
        public IntPtr HalFlushAndInvalidatePageExternalCache;
        [FieldOffset(664)]
        public IntPtr KdEnumerateDebuggingDevices;
        [FieldOffset(672)]
        public IntPtr HalFlushIoRectangleExternalCache;
        [FieldOffset(680)]
        public IntPtr HalPowerEarlyRestore;
        [FieldOffset(688)]
        public IntPtr HalQueryCapsuleCapabilities;
        [FieldOffset(696)]
        public IntPtr HalUpdateCapsule;
        [FieldOffset(704)]
        public IntPtr HalPciMultiStageResumeCapable;
        [FieldOffset(712)]
        public IntPtr HalDmaFreeCrashDumpRegisters;
        [FieldOffset(720)]
        public IntPtr HalAcpiAoacCapable;
        [FieldOffset(728)]
        public IntPtr HalInterruptSetDestination;
        [FieldOffset(736)]
        public IntPtr HalGetClockConfiguration;
        [FieldOffset(744)]
        public IntPtr HalClockTimerActivate;
        [FieldOffset(752)]
        public IntPtr HalClockTimerInitialize;
        [FieldOffset(760)]
        public IntPtr HalClockTimerStop;
        [FieldOffset(768)]
        public IntPtr HalClockTimerArm;
        [FieldOffset(776)]
        public IntPtr HalTimerOnlyClockInterruptPending;
        [FieldOffset(784)]
        public IntPtr HalAcpiGetMultiNode;
        [FieldOffset(792)]
        public IntPtr HalPowerSetRebootHandler;
        [FieldOffset(800)]
        public IntPtr HalIommuRegisterDispatchTable;
        [FieldOffset(808)]
        public IntPtr HalTimerWatchdogStart;
        [FieldOffset(816)]
        public IntPtr HalTimerWatchdogResetCountdown;
        [FieldOffset(824)]
        public IntPtr HalTimerWatchdogStop;
        [FieldOffset(832)]
        public IntPtr HalTimerWatchdogGeneratedLastReset;
        [FieldOffset(840)]
        public IntPtr HalTimerWatchdogTriggerSystemReset;
        [FieldOffset(848)]
        public IntPtr HalInterruptVectorDataToGsiv;
        [FieldOffset(856)]
        public IntPtr HalInterruptGetHighestPriorityInterrupt;
        [FieldOffset(864)]
        public IntPtr HalProcessorOn;
        [FieldOffset(872)]
        public IntPtr HalProcessorOff;
        [FieldOffset(880)]
        public IntPtr HalProcessorFreeze;
        [FieldOffset(888)]
        public IntPtr HalDmaLinkDeviceObjectByToken;
        [FieldOffset(896)]
        public IntPtr HalDmaCheckAdapterToken;
        [FieldOffset(904)]
        public IntPtr Dummy4;
        [FieldOffset(912)]
        public IntPtr HalTimerConvertPerformanceCounterToAuxiliaryCounter;
        [FieldOffset(920)]
        public IntPtr HalTimerConvertAuxiliaryCounterToPerformanceCounter;
        [FieldOffset(928)]
        public IntPtr HalTimerQueryAuxiliaryCounterFrequency;
        [FieldOffset(936)]
        public IntPtr HalConnectThermalInterrupt;
        [FieldOffset(944)]
        public IntPtr HalIsEFIRuntimeActive;
        [FieldOffset(952)]
        public IntPtr HalTimerQueryAndResetRtcErrors;
        [FieldOffset(960)]
        public IntPtr HalAcpiLateRestore;
        [FieldOffset(968)]
        public IntPtr KdWatchdogDelayExpiration;
        [FieldOffset(976)]
        public IntPtr HalGetProcessorStats;
        [FieldOffset(984)]
        public IntPtr HalTimerWatchdogQueryDueTime;
        [FieldOffset(992)]
        public IntPtr HalConnectSyntheticInterrupt;
        [FieldOffset(1000)]
        public IntPtr HalPreprocessNmi;
        [FieldOffset(1008)]
        public IntPtr HalEnumerateEnvironmentVariablesWithFilter;
        [FieldOffset(1016)]
        public IntPtr HalCaptureLastBranchRecordStack;
        [FieldOffset(1024)]
        public IntPtr HalClearLastBranchRecordStack;
        [FieldOffset(1032)]
        public IntPtr HalConfigureLastBranchRecord;
        [FieldOffset(1040)]
        public IntPtr HalGetLastBranchInformation;
        [FieldOffset(1048)]
        public IntPtr HalResumeLastBranchRecord;
        [FieldOffset(1056)]
        public IntPtr HalStartLastBranchRecord;
        [FieldOffset(1064)]
        public IntPtr HalStopLastBranchRecord;
        [FieldOffset(1072)]
        public IntPtr HalIommuBlockDevice;
        [FieldOffset(1080)]
        public IntPtr HalIommuUnblockDevice;
        [FieldOffset(1088)]
        public IntPtr HalGetIommuInterface;
        [FieldOffset(1096)]
        public IntPtr HalRequestGenericErrorRecovery;
        [FieldOffset(1104)]
        public IntPtr HalTimerQueryHostPerformanceCounter;
        [FieldOffset(1112)]
        public IntPtr HalTopologyQueryProcessorRelationships;
        [FieldOffset(1120)]
        public IntPtr HalInitPlatformDebugTriggers;
        [FieldOffset(1128)]
        public IntPtr HalRunPlatformDebugTriggers;
        [FieldOffset(1136)]
        public IntPtr HalTimerGetReferencePage;
        [FieldOffset(1144)]
        public IntPtr HalGetHiddenProcessorPowerInterface;
        [FieldOffset(1152)]
        public IntPtr HalGetHiddenProcessorPackageId;
        [FieldOffset(1160)]
        public IntPtr HalGetHiddenPackageProcessorCount;
        [FieldOffset(1168)]
        public IntPtr HalGetHiddenProcessorApicIdByIndex;
        [FieldOffset(1176)]
        public IntPtr HalRegisterHiddenProcessorIdleState;
        [FieldOffset(1184)]
        public IntPtr HalIommuReportIommuFault;
        [FieldOffset(1192)]
        public IntPtr HalIommuDmaRemappingCapable;
        [FieldOffset(1200)]
        public IntPtr HalAllocatePmcCounterSetEx;
        [FieldOffset(1208)]
        public IntPtr HalStartProfileInterruptEx;
        [FieldOffset(1216)]
        public IntPtr HalGetIommuInterfaceEx;
        [FieldOffset(1224)]
        public IntPtr HalNotifyIommuDomainPolicyChange;
        [FieldOffset(1232)]
        public IntPtr HalPciGetDeviceLocationFromPhysicalAddress;
        [FieldOffset(1240)]
        public IntPtr HalInvokeSmc;
        [FieldOffset(1248)]
        public IntPtr HalInvokeHvc;
        [FieldOffset(1256)]
        public IntPtr HalGetSoftRebootDatabase;
        [FieldOffset(1264)]
        public IntPtr HalRequestPmuAccess;
        [FieldOffset(1272)]
        public IntPtr HalTopologyQueryProcessorCacheInformation;
        [FieldOffset(1280)]
        public IntPtr HalReleasePmuAccessRequest;
        [FieldOffset(1288)]
        public IntPtr HalTimerQueryRtcErrors;
        [FieldOffset(1296)]
        public IntPtr HalExternalPciConfigSpaceAccess;
    }
}