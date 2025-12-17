using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_FLAGS")]
    public sealed class DeviceFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Failed { get => ReadHere<uint>(nameof(Failed)); set => WriteHere(nameof(Failed), value); }

        [Offset(0UL)]
        public uint ReadOnly { get => ReadHere<uint>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(0UL)]
        public uint Removable { get => ReadHere<uint>(nameof(Removable)); set => WriteHere(nameof(Removable), value); }

        [Offset(0UL)]
        public uint ConsoleIn { get => ReadHere<uint>(nameof(ConsoleIn)); set => WriteHere(nameof(ConsoleIn), value); }

        [Offset(0UL)]
        public uint ConsoleOut { get => ReadHere<uint>(nameof(ConsoleOut)); set => WriteHere(nameof(ConsoleOut), value); }

        [Offset(0UL)]
        public uint Input { get => ReadHere<uint>(nameof(Input)); set => WriteHere(nameof(Input), value); }

        [Offset(0UL)]
        public uint Output { get => ReadHere<uint>(nameof(Output)); set => WriteHere(nameof(Output), value); }

        public DeviceFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceFlags>();
        }
    }
}