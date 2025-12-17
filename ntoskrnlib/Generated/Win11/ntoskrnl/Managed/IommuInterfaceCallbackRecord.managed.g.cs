using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_CALLBACK_RECORD")]
    public sealed class IommuInterfaceCallbackRecord : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr CallbackRoutine { get => ReadHere<IntPtr>(nameof(CallbackRoutine)); set => WriteHere(nameof(CallbackRoutine), value); }

        [Offset(24UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(32UL)]
        public IntPtr DmaDevice { get => ReadHere<IntPtr>(nameof(DmaDevice)); set => WriteHere(nameof(DmaDevice), value); }

        [Offset(40UL)]
        public IommuInterfaceStateChange LastReportedState { get => ReadStructure<IommuInterfaceStateChange>(nameof(LastReportedState)); set => WriteStructure(nameof(LastReportedState), value); }

        public IommuInterfaceCallbackRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuInterfaceCallbackRecord>();
        }
    }
}