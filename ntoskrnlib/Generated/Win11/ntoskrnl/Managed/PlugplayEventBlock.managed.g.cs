using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PLUGPLAY_EVENT_BLOCK")]
    public sealed class PlugplayEventBlock : DynamicStructure
    {
        [Offset(0UL)]
        public Guid EventGuid { get => ReadStructure<Guid>(nameof(EventGuid)); set => WriteStructure(nameof(EventGuid), value); }

        [Offset(16UL)]
        public uint EventCategory { get => ReadHere<uint>(nameof(EventCategory)); set => WriteHere(nameof(EventCategory), value); }

        [Offset(24UL)]
        public IntPtr Result { get => ReadHere<IntPtr>(nameof(Result)); set => WriteHere(nameof(Result), value); }

        [Offset(32UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(36UL)]
        public uint TotalSize { get => ReadHere<uint>(nameof(TotalSize)); set => WriteHere(nameof(TotalSize), value); }

        [Offset(40UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(48UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public PlugplayEventBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PlugplayEventBlock>();
        }
    }
}