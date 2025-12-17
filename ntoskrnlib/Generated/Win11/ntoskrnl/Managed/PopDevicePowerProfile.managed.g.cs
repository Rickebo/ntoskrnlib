using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_DEVICE_POWER_PROFILE")]
    public sealed class PopDevicePowerProfile : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString DeviceId { get => ReadStructure<UnicodeString>(nameof(DeviceId)); set => WriteStructure(nameof(DeviceId), value); }

        [Offset(16UL)]
        public IntPtr PowerPlane { get => ReadHere<IntPtr>(nameof(PowerPlane)); set => WriteHere(nameof(PowerPlane), value); }

        [Offset(24UL)]
        public IntPtr FxDevice { get => ReadHere<IntPtr>(nameof(FxDevice)); set => WriteHere(nameof(FxDevice), value); }

        [Offset(32UL)]
        public int PowerDrawMw { get => ReadHere<int>(nameof(PowerDrawMw)); set => WriteHere(nameof(PowerDrawMw), value); }

        [Offset(36UL)]
        [Length(4)]
        public DynamicArray DxPower { get => ReadStructure<DynamicArray>(nameof(DxPower)); set => WriteStructure(nameof(DxPower), value); }

        [Offset(72UL)]
        public ulong ComponentCount { get => ReadHere<ulong>(nameof(ComponentCount)); set => WriteHere(nameof(ComponentCount), value); }

        [Offset(80UL)]
        public IntPtr Components { get => ReadHere<IntPtr>(nameof(Components)); set => WriteHere(nameof(Components), value); }

        public PopDevicePowerProfile(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopDevicePowerProfile>();
        }
    }
}