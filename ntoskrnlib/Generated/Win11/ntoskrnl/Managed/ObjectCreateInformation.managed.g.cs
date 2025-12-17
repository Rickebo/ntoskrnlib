using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_CREATE_INFORMATION")]
    public sealed class ObjectCreateInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Attributes { get => ReadHere<uint>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(8UL)]
        public IntPtr RootDirectory { get => ReadHere<IntPtr>(nameof(RootDirectory)); set => WriteHere(nameof(RootDirectory), value); }

        [Offset(16UL)]
        public sbyte ProbeMode { get => ReadHere<sbyte>(nameof(ProbeMode)); set => WriteHere(nameof(ProbeMode), value); }

        [Offset(20UL)]
        public uint PagedPoolCharge { get => ReadHere<uint>(nameof(PagedPoolCharge)); set => WriteHere(nameof(PagedPoolCharge), value); }

        [Offset(24UL)]
        public uint NonPagedPoolCharge { get => ReadHere<uint>(nameof(NonPagedPoolCharge)); set => WriteHere(nameof(NonPagedPoolCharge), value); }

        [Offset(28UL)]
        public uint SecurityDescriptorCharge { get => ReadHere<uint>(nameof(SecurityDescriptorCharge)); set => WriteHere(nameof(SecurityDescriptorCharge), value); }

        [Offset(32UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(40UL)]
        public IntPtr SecurityQos { get => ReadHere<IntPtr>(nameof(SecurityQos)); set => WriteHere(nameof(SecurityQos), value); }

        [Offset(48UL)]
        public SecurityQualityOfService SecurityQualityOfService { get => ReadStructure<SecurityQualityOfService>(nameof(SecurityQualityOfService)); set => WriteStructure(nameof(SecurityQualityOfService), value); }

        public ObjectCreateInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectCreateInformation>();
        }
    }
}