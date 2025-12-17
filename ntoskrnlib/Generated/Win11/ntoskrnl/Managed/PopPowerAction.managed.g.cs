using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_POWER_ACTION")]
    public sealed class PopPowerAction : DynamicStructure
    {
        [Offset(0UL)]
        public byte Updates { get => ReadHere<byte>(nameof(Updates)); set => WriteHere(nameof(Updates), value); }

        [Offset(1UL)]
        public byte State { get => ReadHere<byte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(2UL)]
        public byte Shutdown { get => ReadHere<byte>(nameof(Shutdown)); set => WriteHere(nameof(Shutdown), value); }

        [Offset(4UL)]
        public uint Action { get => ReadHere<uint>(nameof(Action)); set => WriteHere(nameof(Action), value); }

        [Offset(8UL)]
        public uint LightestState { get => ReadHere<uint>(nameof(LightestState)); set => WriteHere(nameof(LightestState), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(20UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(24UL)]
        public uint DeviceTypeFlags { get => ReadHere<uint>(nameof(DeviceTypeFlags)); set => WriteHere(nameof(DeviceTypeFlags), value); }

        [Offset(32UL)]
        public IntPtr RequestorInformation { get => ReadHere<IntPtr>(nameof(RequestorInformation)); set => WriteHere(nameof(RequestorInformation), value); }

        [Offset(40UL)]
        public byte IrpMinor { get => ReadHere<byte>(nameof(IrpMinor)); set => WriteHere(nameof(IrpMinor), value); }

        [Offset(41UL)]
        public byte Waking { get => ReadHere<byte>(nameof(Waking)); set => WriteHere(nameof(Waking), value); }

        [Offset(44UL)]
        public uint SystemState { get => ReadHere<uint>(nameof(SystemState)); set => WriteHere(nameof(SystemState), value); }

        [Offset(48UL)]
        public uint NextSystemState { get => ReadHere<uint>(nameof(NextSystemState)); set => WriteHere(nameof(NextSystemState), value); }

        [Offset(52UL)]
        public uint EffectiveSystemState { get => ReadHere<uint>(nameof(EffectiveSystemState)); set => WriteHere(nameof(EffectiveSystemState), value); }

        [Offset(56UL)]
        public uint CurrentSystemState { get => ReadHere<uint>(nameof(CurrentSystemState)); set => WriteHere(nameof(CurrentSystemState), value); }

        [Offset(64UL)]
        public IntPtr ShutdownBugCode { get => ReadHere<IntPtr>(nameof(ShutdownBugCode)); set => WriteHere(nameof(ShutdownBugCode), value); }

        [Offset(72UL)]
        public IntPtr DevState { get => ReadHere<IntPtr>(nameof(DevState)); set => WriteHere(nameof(DevState), value); }

        [Offset(80UL)]
        public IntPtr HiberContext { get => ReadHere<IntPtr>(nameof(HiberContext)); set => WriteHere(nameof(HiberContext), value); }

        [Offset(88UL)]
        public ulong WakeTime { get => ReadHere<ulong>(nameof(WakeTime)); set => WriteHere(nameof(WakeTime), value); }

        [Offset(96UL)]
        public ulong SleepTime { get => ReadHere<ulong>(nameof(SleepTime)); set => WriteHere(nameof(SleepTime), value); }

        [Offset(104UL)]
        public ulong WakeFirstUnattendedTime { get => ReadHere<ulong>(nameof(WakeFirstUnattendedTime)); set => WriteHere(nameof(WakeFirstUnattendedTime), value); }

        [Offset(112UL)]
        public uint WakeAlarmSignaled { get => ReadHere<uint>(nameof(WakeAlarmSignaled)); set => WriteHere(nameof(WakeAlarmSignaled), value); }

        [Offset(120UL)]
        [Length(3)]
        public DynamicArray WakeAlarm { get => ReadStructure<DynamicArray>(nameof(WakeAlarm)); set => WriteStructure(nameof(WakeAlarm), value); }

        [Offset(192UL)]
        public byte WakeAlarmPaused { get => ReadHere<byte>(nameof(WakeAlarmPaused)); set => WriteHere(nameof(WakeAlarmPaused), value); }

        [Offset(200UL)]
        public ulong WakeAlarmLastTime { get => ReadHere<ulong>(nameof(WakeAlarmLastTime)); set => WriteHere(nameof(WakeAlarmLastTime), value); }

        [Offset(208UL)]
        public ulong DozeDeferralStartTime { get => ReadHere<ulong>(nameof(DozeDeferralStartTime)); set => WriteHere(nameof(DozeDeferralStartTime), value); }

        [Offset(216UL)]
        public SystemPowerCapabilities FilteredCapabilities { get => ReadStructure<SystemPowerCapabilities>(nameof(FilteredCapabilities)); set => WriteStructure(nameof(FilteredCapabilities), value); }

        [Offset(296UL)]
        public ulong WatchdogLock { get => ReadHere<ulong>(nameof(WatchdogLock)); set => WriteHere(nameof(WatchdogLock), value); }

        [Offset(304UL)]
        public Kdpc WatchdogDpc { get => ReadStructure<Kdpc>(nameof(WatchdogDpc)); set => WriteStructure(nameof(WatchdogDpc), value); }

        [Offset(368UL)]
        public Ktimer WatchdogTimer { get => ReadStructure<Ktimer>(nameof(WatchdogTimer)); set => WriteStructure(nameof(WatchdogTimer), value); }

        [Offset(432UL)]
        public byte WatchdogInitialized { get => ReadHere<byte>(nameof(WatchdogInitialized)); set => WriteHere(nameof(WatchdogInitialized), value); }

        [Offset(436UL)]
        public uint WatchdogState { get => ReadHere<uint>(nameof(WatchdogState)); set => WriteHere(nameof(WatchdogState), value); }

        [Offset(440UL)]
        public ulong WatchdogStartTime { get => ReadHere<ulong>(nameof(WatchdogStartTime)); set => WriteHere(nameof(WatchdogStartTime), value); }

        [Offset(448UL)]
        public uint WatchdogTimeout { get => ReadHere<uint>(nameof(WatchdogTimeout)); set => WriteHere(nameof(WatchdogTimeout), value); }

        [Offset(456UL)]
        public IntPtr ActionWorkerThread { get => ReadHere<IntPtr>(nameof(ActionWorkerThread)); set => WriteHere(nameof(ActionWorkerThread), value); }

        [Offset(464UL)]
        public IntPtr PromoteActionWorkerThread { get => ReadHere<IntPtr>(nameof(PromoteActionWorkerThread)); set => WriteHere(nameof(PromoteActionWorkerThread), value); }

        [Offset(472UL)]
        public IntPtr UnlockAfterSleepWorkerThread { get => ReadHere<IntPtr>(nameof(UnlockAfterSleepWorkerThread)); set => WriteHere(nameof(UnlockAfterSleepWorkerThread), value); }

        public PopPowerAction(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPowerAction>();
        }
    }
}