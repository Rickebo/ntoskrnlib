using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_EVENT_ENTRY")]
    public sealed class PnpDeviceEventEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint Argument { get => ReadHere<uint>(nameof(Argument)); set => WriteHere(nameof(Argument), value); }

        [Offset(20UL)]
        public int ArgumentStatus { get => ReadHere<int>(nameof(ArgumentStatus)); set => WriteHere(nameof(ArgumentStatus), value); }

        [Offset(24UL)]
        public IntPtr CallerEvent { get => ReadHere<IntPtr>(nameof(CallerEvent)); set => WriteHere(nameof(CallerEvent), value); }

        [Offset(32UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(40UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(48UL)]
        public IntPtr VetoType { get => ReadHere<IntPtr>(nameof(VetoType)); set => WriteHere(nameof(VetoType), value); }

        [Offset(56UL)]
        public IntPtr VetoName { get => ReadHere<IntPtr>(nameof(VetoName)); set => WriteHere(nameof(VetoName), value); }

        [Offset(64UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(68UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(72UL)]
        public byte Cancel { get => ReadHere<byte>(nameof(Cancel)); set => WriteHere(nameof(Cancel), value); }

        [Offset(80UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(88UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(104UL)]
        public IntPtr Watchdog { get => ReadHere<IntPtr>(nameof(Watchdog)); set => WriteHere(nameof(Watchdog), value); }

        [Offset(112UL)]
        public IntPtr PdcActivatorHandle { get => ReadHere<IntPtr>(nameof(PdcActivatorHandle)); set => WriteHere(nameof(PdcActivatorHandle), value); }

        [Offset(120UL)]
        public PlugplayEventBlock Data { get => ReadStructure<PlugplayEventBlock>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public PnpDeviceEventEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceEventEntry>();
        }
    }
}