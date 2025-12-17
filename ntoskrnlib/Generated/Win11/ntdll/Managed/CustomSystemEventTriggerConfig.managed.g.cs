using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")]
    public sealed class CustomSystemEventTriggerConfig : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr TriggerId { get => ReadHere<IntPtr>(nameof(TriggerId)); set => WriteHere(nameof(TriggerId), value); }

        public CustomSystemEventTriggerConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CustomSystemEventTriggerConfig>();
        }
    }
}