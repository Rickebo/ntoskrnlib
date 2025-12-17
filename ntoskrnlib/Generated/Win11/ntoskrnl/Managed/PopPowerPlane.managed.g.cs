using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_POWER_PLANE")]
    public sealed class PopPowerPlane : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString PowerPlaneId { get => ReadStructure<UnicodeString>(nameof(PowerPlaneId)); set => WriteStructure(nameof(PowerPlaneId), value); }

        [Offset(16UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(24UL)]
        public byte OldIrql { get => ReadHere<byte>(nameof(OldIrql)); set => WriteHere(nameof(OldIrql), value); }

        [Offset(28UL)]
        public int DevicePowerMw { get => ReadHere<int>(nameof(DevicePowerMw)); set => WriteHere(nameof(DevicePowerMw), value); }

        [Offset(32UL)]
        public IntPtr PmaxHandle { get => ReadHere<IntPtr>(nameof(PmaxHandle)); set => WriteHere(nameof(PmaxHandle), value); }

        [Offset(40UL)]
        public IntPtr NotifyDevicePowerDraw { get => ReadHere<IntPtr>(nameof(NotifyDevicePowerDraw)); set => WriteHere(nameof(NotifyDevicePowerDraw), value); }

        [Offset(48UL)]
        public ulong DeviceCount { get => ReadHere<ulong>(nameof(DeviceCount)); set => WriteHere(nameof(DeviceCount), value); }

        [Offset(56UL)]
        public IntPtr Devices { get => ReadHere<IntPtr>(nameof(Devices)); set => WriteHere(nameof(Devices), value); }

        public PopPowerPlane(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPowerPlane>();
        }
    }
}