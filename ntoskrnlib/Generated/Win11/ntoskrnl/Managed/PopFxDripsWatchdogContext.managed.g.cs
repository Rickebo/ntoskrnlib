using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DRIPS_WATCHDOG_CONTEXT")]
    public sealed class PopFxDripsWatchdogContext : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public uint ComponentIndex { get => ReadHere<uint>(nameof(ComponentIndex)); set => WriteHere(nameof(ComponentIndex), value); }

        [Offset(24UL)]
        public IntPtr ChildDevices { get => ReadHere<IntPtr>(nameof(ChildDevices)); set => WriteHere(nameof(ChildDevices), value); }

        [Offset(32UL)]
        public uint ChildDeviceCount { get => ReadHere<uint>(nameof(ChildDeviceCount)); set => WriteHere(nameof(ChildDeviceCount), value); }

        public PopFxDripsWatchdogContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDripsWatchdogContext>();
        }
    }
}