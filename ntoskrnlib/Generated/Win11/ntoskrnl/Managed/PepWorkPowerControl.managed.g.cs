using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_POWER_CONTROL")]
    public sealed class PepWorkPowerControl : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public IntPtr PowerControlCode { get => ReadHere<IntPtr>(nameof(PowerControlCode)); set => WriteHere(nameof(PowerControlCode), value); }

        [Offset(16UL)]
        public IntPtr RequestContext { get => ReadHere<IntPtr>(nameof(RequestContext)); set => WriteHere(nameof(RequestContext), value); }

        [Offset(24UL)]
        public IntPtr InBuffer { get => ReadHere<IntPtr>(nameof(InBuffer)); set => WriteHere(nameof(InBuffer), value); }

        [Offset(32UL)]
        public ulong InBufferSize { get => ReadHere<ulong>(nameof(InBufferSize)); set => WriteHere(nameof(InBufferSize), value); }

        [Offset(40UL)]
        public IntPtr OutBuffer { get => ReadHere<IntPtr>(nameof(OutBuffer)); set => WriteHere(nameof(OutBuffer), value); }

        [Offset(48UL)]
        public ulong OutBufferSize { get => ReadHere<ulong>(nameof(OutBufferSize)); set => WriteHere(nameof(OutBufferSize), value); }

        public PepWorkPowerControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkPowerControl>();
        }
    }
}