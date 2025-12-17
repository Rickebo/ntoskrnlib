using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_REGISTRATION_INFORMATION")]
    public sealed class PcwRegistrationInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Name { get => ReadHere<IntPtr>(nameof(Name)); set => WriteHere(nameof(Name), value); }

        [Offset(16UL)]
        public uint CounterCount { get => ReadHere<uint>(nameof(CounterCount)); set => WriteHere(nameof(CounterCount), value); }

        [Offset(24UL)]
        public IntPtr Counters { get => ReadHere<IntPtr>(nameof(Counters)); set => WriteHere(nameof(Counters), value); }

        [Offset(32UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(40UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(48UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public PcwRegistrationInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwRegistrationInformation>();
        }
    }
}