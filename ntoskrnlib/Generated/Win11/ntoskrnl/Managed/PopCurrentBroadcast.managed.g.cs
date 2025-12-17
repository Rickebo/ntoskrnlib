using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_CURRENT_BROADCAST")]
    public sealed class PopCurrentBroadcast : DynamicStructure
    {
        [Offset(0UL)]
        public byte InProgress { get => ReadHere<byte>(nameof(InProgress)); set => WriteHere(nameof(InProgress), value); }

        [Offset(4UL)]
        public SystemPowerStateContext SystemContext { get => ReadStructure<SystemPowerStateContext>(nameof(SystemContext)); set => WriteStructure(nameof(SystemContext), value); }

        [Offset(8UL)]
        public uint PowerAction { get => ReadHere<uint>(nameof(PowerAction)); set => WriteHere(nameof(PowerAction), value); }

        [Offset(16UL)]
        public IntPtr DeviceState { get => ReadHere<IntPtr>(nameof(DeviceState)); set => WriteHere(nameof(DeviceState), value); }

        public PopCurrentBroadcast(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopCurrentBroadcast>();
        }
    }
}