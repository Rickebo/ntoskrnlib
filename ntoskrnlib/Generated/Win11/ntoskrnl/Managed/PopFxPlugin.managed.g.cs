using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_PLUGIN")]
    public sealed class PopFxPlugin : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(24UL)]
        public ulong Flags { get => ReadHere<ulong>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(32UL)]
        public Kqueue WorkQueue { get => ReadStructure<Kqueue>(nameof(WorkQueue)); set => WriteStructure(nameof(WorkQueue), value); }

        [Offset(96UL)]
        public IntPtr AcceptDeviceNotification { get => ReadHere<IntPtr>(nameof(AcceptDeviceNotification)); set => WriteHere(nameof(AcceptDeviceNotification), value); }

        [Offset(104UL)]
        public IntPtr AcceptProcessorNotification { get => ReadHere<IntPtr>(nameof(AcceptProcessorNotification)); set => WriteHere(nameof(AcceptProcessorNotification), value); }

        [Offset(112UL)]
        public IntPtr AcceptAcpiNotification { get => ReadHere<IntPtr>(nameof(AcceptAcpiNotification)); set => WriteHere(nameof(AcceptAcpiNotification), value); }

        [Offset(120UL)]
        public PopFxWorkPool PluginWorkPool { get => ReadStructure<PopFxWorkPool>(nameof(PluginWorkPool)); set => WriteStructure(nameof(PluginWorkPool), value); }

        public PopFxPlugin(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxPlugin>();
        }
    }
}