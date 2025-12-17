using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CONTROLLER_OBJECT")]
    public sealed class ControllerObject : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr ControllerExtension { get => ReadHere<IntPtr>(nameof(ControllerExtension)); set => WriteHere(nameof(ControllerExtension), value); }

        [Offset(16UL)]
        public KdeviceQueue DeviceWaitQueue { get => ReadStructure<KdeviceQueue>(nameof(DeviceWaitQueue)); set => WriteStructure(nameof(DeviceWaitQueue), value); }

        [Offset(56UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(64UL)]
        public LargeInteger Spare2 { get => ReadStructure<LargeInteger>(nameof(Spare2)); set => WriteStructure(nameof(Spare2), value); }

        public ControllerObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ControllerObject>();
        }
    }
}