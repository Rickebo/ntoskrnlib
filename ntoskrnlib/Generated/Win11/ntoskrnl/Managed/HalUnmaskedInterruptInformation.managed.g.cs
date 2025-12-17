using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_UNMASKED_INTERRUPT_INFORMATION")]
    public sealed class HalUnmaskedInterruptInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public HalUnmaskedInterruptFlags Flags { get => ReadStructure<HalUnmaskedInterruptFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public uint Mode { get => ReadHere<uint>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(12UL)]
        public uint Polarity { get => ReadHere<uint>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(16UL)]
        public uint Gsiv { get => ReadHere<uint>(nameof(Gsiv)); set => WriteHere(nameof(Gsiv), value); }

        [Offset(20UL)]
        public ushort PinNumber { get => ReadHere<ushort>(nameof(PinNumber)); set => WriteHere(nameof(PinNumber), value); }

        [Offset(24UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        public HalUnmaskedInterruptInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalUnmaskedInterruptInformation>();
        }
    }
}