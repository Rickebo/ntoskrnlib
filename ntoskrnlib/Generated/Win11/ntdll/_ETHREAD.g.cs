#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1944)]
    public partial struct _ETHREAD
    {
        [FieldOffset(0)]
        public _KTHREAD Tcb;
        [FieldOffset(1216)]
        public _LARGE_INTEGER CreateTime;
        [FieldOffset(1224)]
        public _LARGE_INTEGER ExitTime;
        [FieldOffset(1224)]
        public _LIST_ENTRY KeyedWaitChain;
        [FieldOffset(1240)]
        public _LIST_ENTRY PostBlockList;
        [FieldOffset(1240)]
        public IntPtr ForwardLinkShadow;
        [FieldOffset(1248)]
        public IntPtr StartAddress;
        [FieldOffset(1256)]
        public IntPtr TerminationPort;
        [FieldOffset(1256)]
        public IntPtr ReaperLink;
        [FieldOffset(1256)]
        public IntPtr KeyedWaitValue;
        [FieldOffset(1264)]
        public ulong ActiveTimerListLock;
        [FieldOffset(1272)]
        public _LIST_ENTRY ActiveTimerListHead;
        [FieldOffset(1288)]
        public _CLIENT_ID Cid;
        [FieldOffset(1304)]
        public _KSEMAPHORE KeyedWaitSemaphore;
        [FieldOffset(1304)]
        public _KSEMAPHORE AlpcWaitSemaphore;
        [FieldOffset(1336)]
        public _PS_CLIENT_SECURITY_CONTEXT ClientSecurity;
        [FieldOffset(1344)]
        public _LIST_ENTRY IrpList;
        [FieldOffset(1360)]
        public ulong TopLevelIrp;
        [FieldOffset(1368)]
        public IntPtr DeviceToVerify;
        [FieldOffset(1376)]
        public IntPtr Win32StartAddress;
        [FieldOffset(1384)]
        public IntPtr ChargeOnlySession;
        [FieldOffset(1392)]
        public IntPtr LegacyPowerObject;
        [FieldOffset(1400)]
        public _LIST_ENTRY ThreadListEntry;
        [FieldOffset(1416)]
        public _EX_RUNDOWN_REF RundownProtect;
        [FieldOffset(1424)]
        public _EX_PUSH_LOCK ThreadLock;
        [FieldOffset(1432)]
        public uint ReadClusterSize;
        [FieldOffset(1436)]
        public uint MmLockOrdering;
        [FieldOffset(1440)]
        public uint CrossThreadFlags;
        [FieldOffset(1440)]
        public uint Terminated;
        [FieldOffset(1440)]
        public uint ThreadInserted;
        [FieldOffset(1440)]
        public uint HideFromDebugger;
        [FieldOffset(1440)]
        public uint ActiveImpersonationInfo;
        [FieldOffset(1440)]
        public uint HardErrorsAreDisabled;
        [FieldOffset(1440)]
        public uint BreakOnTermination;
        [FieldOffset(1440)]
        public uint SkipCreationMsg;
        [FieldOffset(1440)]
        public uint SkipTerminationMsg;
        [FieldOffset(1440)]
        public uint CopyTokenOnOpen;
        [FieldOffset(1440)]
        public uint ThreadIoPriority;
        [FieldOffset(1440)]
        public uint ThreadPagePriority;
        [FieldOffset(1440)]
        public uint RundownFail;
        [FieldOffset(1440)]
        public uint UmsForceQueueTermination;
        [FieldOffset(1440)]
        public uint IndirectCpuSets;
        [FieldOffset(1440)]
        public uint DisableDynamicCodeOptOut;
        [FieldOffset(1440)]
        public uint ExplicitCaseSensitivity;
        [FieldOffset(1440)]
        public uint PicoNotifyExit;
        [FieldOffset(1440)]
        public uint DbgWerUserReportActive;
        [FieldOffset(1440)]
        public uint ForcedSelfTrimActive;
        [FieldOffset(1440)]
        public uint SamplingCoverage;
        [FieldOffset(1440)]
        public uint ImpersonationSchedulingGroup;
        [FieldOffset(1440)]
        public uint ReservedCrossThreadFlags;
        [FieldOffset(1444)]
        public uint SameThreadPassiveFlags;
        [FieldOffset(1444)]
        public uint ActiveExWorker;
        [FieldOffset(1444)]
        public uint MemoryMaker;
        [FieldOffset(1444)]
        public uint StoreLockThread;
        [FieldOffset(1444)]
        public uint ClonedThread;
        [FieldOffset(1444)]
        public uint KeyedEventInUse;
        [FieldOffset(1444)]
        public uint SelfTerminate;
        [FieldOffset(1444)]
        public uint RespectIoPriority;
        [FieldOffset(1444)]
        public uint ActivePageLists;
        [FieldOffset(1444)]
        public uint SecureContext;
        [FieldOffset(1444)]
        public uint ZeroPageThread;
        [FieldOffset(1444)]
        public uint WorkloadClass;
        [FieldOffset(1444)]
        public uint GenerateDumpOnBadHandleAccess;
        [FieldOffset(1444)]
        public uint BalanceSetManager;
        [FieldOffset(1444)]
        public uint ReservedSameThreadPassiveFlags;
        [FieldOffset(1448)]
        public uint SameThreadApcFlags;
        [FieldOffset(1448)]
        public byte OwnsProcessAddressSpaceExclusive;
        [FieldOffset(1448)]
        public byte OwnsProcessAddressSpaceShared;
        [FieldOffset(1448)]
        public byte HardFaultBehavior;
        [FieldOffset(1448)]
        public byte StartAddressInvalid;
        [FieldOffset(1448)]
        public byte EtwCalloutActive;
        [FieldOffset(1448)]
        public byte SuppressSymbolLoad;
        [FieldOffset(1448)]
        public byte Prefetching;
        [FieldOffset(1448)]
        public byte OwnsVadExclusive;
        [FieldOffset(1449)]
        public byte SystemPagePriorityActive;
        [FieldOffset(1449)]
        public byte SystemPagePriority;
        [FieldOffset(1449)]
        public byte AllowUserWritesToExecutableMemory;
        [FieldOffset(1449)]
        public byte AllowKernelWritesToExecutableMemory;
        [FieldOffset(1449)]
        public byte OwnsVadShared;
        [FieldOffset(1449)]
        public byte PasidMsrValid;
        [FieldOffset(1450)]
        public byte SlabReplenishInProgress;
        [FieldOffset(1452)]
        public byte CacheManagerActive;
        [FieldOffset(1453)]
        public byte DisablePageFaultClustering;
        [FieldOffset(1454)]
        public byte ActiveFaultCount;
        [FieldOffset(1455)]
        public byte LockOrderState;
        [FieldOffset(1456)]
        public uint SharedPsModuleLockAcquires;
        [FieldOffset(1460)]
        public uint MmReserved;
        [FieldOffset(1464)]
        public ulong AlpcMessageId;
        [FieldOffset(1472)]
        public IntPtr AlpcMessage;
        [FieldOffset(1472)]
        public uint AlpcReceiveAttributeSet;
        [FieldOffset(1480)]
        public _LIST_ENTRY AlpcWaitListEntry;
        [FieldOffset(1496)]
        public int ExitStatus;
        [FieldOffset(1500)]
        public uint CacheManagerCount;
        [FieldOffset(1504)]
        public uint IoBoostCount;
        [FieldOffset(1508)]
        public uint IoQoSBoostCount;
        [FieldOffset(1512)]
        public uint IoQoSThrottleCount;
        [FieldOffset(1516)]
        public uint KernelStackReference;
        [FieldOffset(1520)]
        public _LIST_ENTRY BoostList;
        [FieldOffset(1536)]
        public _LIST_ENTRY DeboostList;
        [FieldOffset(1552)]
        public ulong BoostListLock;
        [FieldOffset(1560)]
        public ulong IrpListLock;
        [FieldOffset(1568)]
        public IntPtr ReservedForSynchTracking;
        [FieldOffset(1576)]
        public _SINGLE_LIST_ENTRY CmCallbackListHead;
        [FieldOffset(1584)]
        public IntPtr ActivityId;
        [FieldOffset(1592)]
        public _SINGLE_LIST_ENTRY SeLearningModeListHead;
        [FieldOffset(1600)]
        public IntPtr VerifierContext;
        [FieldOffset(1608)]
        public IntPtr AdjustedClientToken;
        [FieldOffset(1616)]
        public IntPtr WorkOnBehalfThread;
        [FieldOffset(1624)]
        public _PS_PROPERTY_SET PropertySet;
        [FieldOffset(1648)]
        public IntPtr PicoContext;
        [FieldOffset(1656)]
        public ulong UserFsBase;
        [FieldOffset(1664)]
        public ulong UserGsBase;
        [FieldOffset(1672)]
        public IntPtr EnergyValues;
        [FieldOffset(1680)]
        public ulong SelectedCpuSets;
        [FieldOffset(1680)]
        public IntPtr SelectedCpuSetsIndirect;
        [FieldOffset(1688)]
        public IntPtr Silo;
        [FieldOffset(1696)]
        public IntPtr ThreadName;
        [FieldOffset(1704)]
        public IntPtr SetContextState;
        [FieldOffset(1712)]
        public IntPtr EtwSupport;
        [FieldOffset(1720)]
        public _LIST_ENTRY OwnerEntryListHead;
        [FieldOffset(1736)]
        public ulong DisownedOwnerEntryListLock;
        [FieldOffset(1744)]
        public _LIST_ENTRY DisownedOwnerEntryListHead;
        [FieldOffset(1760)]
        public IntPtr SchedulerSharedDataObject;
        [FieldOffset(1768)]
        public IntPtr CmThreadInfo;
        [FieldOffset(1776)]
        public IntPtr FlsData;
        [FieldOffset(1784)]
        public uint LastExpectedRunTime;
        [FieldOffset(1788)]
        public uint LastSoftParkElectionRunTime;
        [FieldOffset(1792)]
        public ulong LastSoftParkElectionGeneration;
        [FieldOffset(1800)]
        public _GROUP_AFFINITY LastSoftParkElectionGroupAffinity;
        [FieldOffset(1816)]
        public ulong UserIsolationDomain;
        [FieldOffset(1824)]
        public _KAPC UpdateTebApc;
        [FieldOffset(1824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] UpdateTebApcFill1;
        [FieldOffset(1827)]
        public sbyte Win32kPriorityFloor;
        [FieldOffset(1824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] UpdateTebApcFill2;
        [FieldOffset(1828)]
        public byte LastSoftParkElectionQos;
        [FieldOffset(1829)]
        public byte LastSoftParkElectionWorkloadType;
        [FieldOffset(1830)]
        public byte LastSoftParkElectionRunningType;
        [FieldOffset(1831)]
        public byte MmSlabIdentity;
        [FieldOffset(1824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] UpdateTebApcFill3;
        [FieldOffset(1888)]
        public _RTL_THREAD_RNG_STATE RngState;
        [FieldOffset(1824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public byte[] UpdateTebApcFill4;
        [FieldOffset(1896)]
        public IntPtr UsedByRngState;
        [FieldOffset(1824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 83)]
        public byte[] UpdateTebApcFill5;
        [FieldOffset(1907)]
        public byte UpdateTebSpareByte2;
        [FieldOffset(1908)]
        public uint HeapData;
        [FieldOffset(1912)]
        public ulong Win32kThreadLock;
        [FieldOffset(1920)]
        public IntPtr ThreadIndex;
        [FieldOffset(1928)]
        public IntPtr MmFaultClusterContext;
        [FieldOffset(1936)]
        public _EX_FAST_REF ProcessFastRef;
    }
}