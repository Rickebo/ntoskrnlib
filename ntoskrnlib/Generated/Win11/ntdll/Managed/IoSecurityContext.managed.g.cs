using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_SECURITY_CONTEXT")]
    public sealed class IoSecurityContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SecurityQos { get => ReadHere<IntPtr>(nameof(SecurityQos)); set => WriteHere(nameof(SecurityQos), value); }

        [Offset(8UL)]
        public IntPtr AccessState { get => ReadHere<IntPtr>(nameof(AccessState)); set => WriteHere(nameof(AccessState), value); }

        [Offset(16UL)]
        public uint DesiredAccess { get => ReadHere<uint>(nameof(DesiredAccess)); set => WriteHere(nameof(DesiredAccess), value); }

        [Offset(20UL)]
        public uint FullCreateOptions { get => ReadHere<uint>(nameof(FullCreateOptions)); set => WriteHere(nameof(FullCreateOptions), value); }

        public IoSecurityContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoSecurityContext>();
        }
    }
}