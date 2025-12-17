using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_CAPABILITIES")]
    public sealed class DeviceCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint DeviceD1 { get => ReadHere<uint>(nameof(DeviceD1)); set => WriteHere(nameof(DeviceD1), value); }

        [Offset(4UL)]
        public uint DeviceD2 { get => ReadHere<uint>(nameof(DeviceD2)); set => WriteHere(nameof(DeviceD2), value); }

        [Offset(4UL)]
        public uint LockSupported { get => ReadHere<uint>(nameof(LockSupported)); set => WriteHere(nameof(LockSupported), value); }

        [Offset(4UL)]
        public uint EjectSupported { get => ReadHere<uint>(nameof(EjectSupported)); set => WriteHere(nameof(EjectSupported), value); }

        [Offset(4UL)]
        public uint Removable { get => ReadHere<uint>(nameof(Removable)); set => WriteHere(nameof(Removable), value); }

        [Offset(4UL)]
        public uint DockDevice { get => ReadHere<uint>(nameof(DockDevice)); set => WriteHere(nameof(DockDevice), value); }

        [Offset(4UL)]
        public uint UniqueID { get => ReadHere<uint>(nameof(UniqueID)); set => WriteHere(nameof(UniqueID), value); }

        [Offset(4UL)]
        public uint SilentInstall { get => ReadHere<uint>(nameof(SilentInstall)); set => WriteHere(nameof(SilentInstall), value); }

        [Offset(4UL)]
        public uint RawDeviceOK { get => ReadHere<uint>(nameof(RawDeviceOK)); set => WriteHere(nameof(RawDeviceOK), value); }

        [Offset(4UL)]
        public uint SurpriseRemovalOK { get => ReadHere<uint>(nameof(SurpriseRemovalOK)); set => WriteHere(nameof(SurpriseRemovalOK), value); }

        [Offset(4UL)]
        public uint WakeFromD0 { get => ReadHere<uint>(nameof(WakeFromD0)); set => WriteHere(nameof(WakeFromD0), value); }

        [Offset(4UL)]
        public uint WakeFromD1 { get => ReadHere<uint>(nameof(WakeFromD1)); set => WriteHere(nameof(WakeFromD1), value); }

        [Offset(4UL)]
        public uint WakeFromD2 { get => ReadHere<uint>(nameof(WakeFromD2)); set => WriteHere(nameof(WakeFromD2), value); }

        [Offset(4UL)]
        public uint WakeFromD3 { get => ReadHere<uint>(nameof(WakeFromD3)); set => WriteHere(nameof(WakeFromD3), value); }

        [Offset(4UL)]
        public uint HardwareDisabled { get => ReadHere<uint>(nameof(HardwareDisabled)); set => WriteHere(nameof(HardwareDisabled), value); }

        [Offset(4UL)]
        public uint NonDynamic { get => ReadHere<uint>(nameof(NonDynamic)); set => WriteHere(nameof(NonDynamic), value); }

        [Offset(4UL)]
        public uint WarmEjectSupported { get => ReadHere<uint>(nameof(WarmEjectSupported)); set => WriteHere(nameof(WarmEjectSupported), value); }

        [Offset(4UL)]
        public uint NoDisplayInUI { get => ReadHere<uint>(nameof(NoDisplayInUI)); set => WriteHere(nameof(NoDisplayInUI), value); }

        [Offset(4UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(4UL)]
        public uint WakeFromInterrupt { get => ReadHere<uint>(nameof(WakeFromInterrupt)); set => WriteHere(nameof(WakeFromInterrupt), value); }

        [Offset(4UL)]
        public uint SecureDevice { get => ReadHere<uint>(nameof(SecureDevice)); set => WriteHere(nameof(SecureDevice), value); }

        [Offset(4UL)]
        public uint ChildOfVgaEnabledBridge { get => ReadHere<uint>(nameof(ChildOfVgaEnabledBridge)); set => WriteHere(nameof(ChildOfVgaEnabledBridge), value); }

        [Offset(4UL)]
        public uint DecodeIoOnBoot { get => ReadHere<uint>(nameof(DecodeIoOnBoot)); set => WriteHere(nameof(DecodeIoOnBoot), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public uint Address { get => ReadHere<uint>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(12UL)]
        public uint UINumber { get => ReadHere<uint>(nameof(UINumber)); set => WriteHere(nameof(UINumber), value); }

        [Offset(16UL)]
        [Length(7)]
        public DynamicArray DeviceState { get => ReadStructure<DynamicArray>(nameof(DeviceState)); set => WriteStructure(nameof(DeviceState), value); }

        [Offset(44UL)]
        public uint SystemWake { get => ReadHere<uint>(nameof(SystemWake)); set => WriteHere(nameof(SystemWake), value); }

        [Offset(48UL)]
        public uint DeviceWake { get => ReadHere<uint>(nameof(DeviceWake)); set => WriteHere(nameof(DeviceWake), value); }

        [Offset(52UL)]
        public uint D1Latency { get => ReadHere<uint>(nameof(D1Latency)); set => WriteHere(nameof(D1Latency), value); }

        [Offset(56UL)]
        public uint D2Latency { get => ReadHere<uint>(nameof(D2Latency)); set => WriteHere(nameof(D2Latency), value); }

        [Offset(60UL)]
        public uint D3Latency { get => ReadHere<uint>(nameof(D3Latency)); set => WriteHere(nameof(D3Latency), value); }

        public DeviceCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceCapabilities>();
        }
    }
}