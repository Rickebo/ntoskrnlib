using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_DEVICE_SYS_STATE")]
    public sealed class PopDeviceSysState : DynamicStructure
    {
        [Offset(0UL)]
        public byte IrpMinor { get => ReadHere<byte>(nameof(IrpMinor)); set => WriteHere(nameof(IrpMinor), value); }

        [Offset(4UL)]
        public uint SystemState { get => ReadHere<uint>(nameof(SystemState)); set => WriteHere(nameof(SystemState), value); }

        [Offset(8UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(16UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(24UL)]
        public IntPtr AbortEvent { get => ReadHere<IntPtr>(nameof(AbortEvent)); set => WriteHere(nameof(AbortEvent), value); }

        [Offset(32UL)]
        public IntPtr ReadySemaphore { get => ReadHere<IntPtr>(nameof(ReadySemaphore)); set => WriteHere(nameof(ReadySemaphore), value); }

        [Offset(40UL)]
        public IntPtr FinishedSemaphore { get => ReadHere<IntPtr>(nameof(FinishedSemaphore)); set => WriteHere(nameof(FinishedSemaphore), value); }

        [Offset(48UL)]
        public PoDeviceNotifyOrder Order { get => ReadStructure<PoDeviceNotifyOrder>(nameof(Order)); set => WriteStructure(nameof(Order), value); }

        [Offset(432UL)]
        public ListEntry Pending { get => ReadStructure<ListEntry>(nameof(Pending)); set => WriteStructure(nameof(Pending), value); }

        [Offset(448UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(456UL)]
        public IntPtr FailedDevice { get => ReadHere<IntPtr>(nameof(FailedDevice)); set => WriteHere(nameof(FailedDevice), value); }

        [Offset(464UL)]
        public byte Waking { get => ReadHere<byte>(nameof(Waking)); set => WriteHere(nameof(Waking), value); }

        [Offset(465UL)]
        public byte Cancelled { get => ReadHere<byte>(nameof(Cancelled)); set => WriteHere(nameof(Cancelled), value); }

        [Offset(466UL)]
        public byte IgnoreErrors { get => ReadHere<byte>(nameof(IgnoreErrors)); set => WriteHere(nameof(IgnoreErrors), value); }

        [Offset(467UL)]
        public byte IgnoreNotImplemented { get => ReadHere<byte>(nameof(IgnoreNotImplemented)); set => WriteHere(nameof(IgnoreNotImplemented), value); }

        [Offset(468UL)]
        public byte TimeRefreshLockAcquired { get => ReadHere<byte>(nameof(TimeRefreshLockAcquired)); set => WriteHere(nameof(TimeRefreshLockAcquired), value); }

        public PopDeviceSysState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopDeviceSysState>();
        }
    }
}