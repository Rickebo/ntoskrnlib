using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_FUNCTION_TABLE")]
    public sealed class InterruptFunctionTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr InitializeLocalUnit { get => ReadHere<IntPtr>(nameof(InitializeLocalUnit)); set => WriteHere(nameof(InitializeLocalUnit), value); }

        [Offset(8UL)]
        public IntPtr InitializeIoUnit { get => ReadHere<IntPtr>(nameof(InitializeIoUnit)); set => WriteHere(nameof(InitializeIoUnit), value); }

        [Offset(16UL)]
        public IntPtr SetPriority { get => ReadHere<IntPtr>(nameof(SetPriority)); set => WriteHere(nameof(SetPriority), value); }

        [Offset(24UL)]
        public IntPtr GetLocalUnitError { get => ReadHere<IntPtr>(nameof(GetLocalUnitError)); set => WriteHere(nameof(GetLocalUnitError), value); }

        [Offset(32UL)]
        public IntPtr ClearLocalUnitError { get => ReadHere<IntPtr>(nameof(ClearLocalUnitError)); set => WriteHere(nameof(ClearLocalUnitError), value); }

        [Offset(40UL)]
        public IntPtr GetLogicalId { get => ReadHere<IntPtr>(nameof(GetLogicalId)); set => WriteHere(nameof(GetLogicalId), value); }

        [Offset(48UL)]
        public IntPtr SetLogicalId { get => ReadHere<IntPtr>(nameof(SetLogicalId)); set => WriteHere(nameof(SetLogicalId), value); }

        [Offset(56UL)]
        public IntPtr AcceptAndGetSource { get => ReadHere<IntPtr>(nameof(AcceptAndGetSource)); set => WriteHere(nameof(AcceptAndGetSource), value); }

        [Offset(64UL)]
        public IntPtr EndOfInterrupt { get => ReadHere<IntPtr>(nameof(EndOfInterrupt)); set => WriteHere(nameof(EndOfInterrupt), value); }

        [Offset(72UL)]
        public IntPtr FastEndOfInterrupt { get => ReadHere<IntPtr>(nameof(FastEndOfInterrupt)); set => WriteHere(nameof(FastEndOfInterrupt), value); }

        [Offset(80UL)]
        public IntPtr SetLineState { get => ReadHere<IntPtr>(nameof(SetLineState)); set => WriteHere(nameof(SetLineState), value); }

        [Offset(88UL)]
        public IntPtr RequestInterrupt { get => ReadHere<IntPtr>(nameof(RequestInterrupt)); set => WriteHere(nameof(RequestInterrupt), value); }

        [Offset(96UL)]
        public IntPtr StartProcessor { get => ReadHere<IntPtr>(nameof(StartProcessor)); set => WriteHere(nameof(StartProcessor), value); }

        [Offset(104UL)]
        public IntPtr GenerateMessage { get => ReadHere<IntPtr>(nameof(GenerateMessage)); set => WriteHere(nameof(GenerateMessage), value); }

        [Offset(112UL)]
        public IntPtr ConvertId { get => ReadHere<IntPtr>(nameof(ConvertId)); set => WriteHere(nameof(ConvertId), value); }

        [Offset(120UL)]
        public IntPtr SaveLocalInterrupts { get => ReadHere<IntPtr>(nameof(SaveLocalInterrupts)); set => WriteHere(nameof(SaveLocalInterrupts), value); }

        [Offset(128UL)]
        public IntPtr ReplayLocalInterrupts { get => ReadHere<IntPtr>(nameof(ReplayLocalInterrupts)); set => WriteHere(nameof(ReplayLocalInterrupts), value); }

        [Offset(136UL)]
        public IntPtr DeinitializeLocalUnit { get => ReadHere<IntPtr>(nameof(DeinitializeLocalUnit)); set => WriteHere(nameof(DeinitializeLocalUnit), value); }

        [Offset(144UL)]
        public IntPtr DeinitializeIoUnit { get => ReadHere<IntPtr>(nameof(DeinitializeIoUnit)); set => WriteHere(nameof(DeinitializeIoUnit), value); }

        [Offset(152UL)]
        public IntPtr QueryAndGetSource { get => ReadHere<IntPtr>(nameof(QueryAndGetSource)); set => WriteHere(nameof(QueryAndGetSource), value); }

        [Offset(160UL)]
        public IntPtr DeactivateInterrupt { get => ReadHere<IntPtr>(nameof(DeactivateInterrupt)); set => WriteHere(nameof(DeactivateInterrupt), value); }

        [Offset(168UL)]
        public IntPtr DirectedEndOfInterrupt { get => ReadHere<IntPtr>(nameof(DirectedEndOfInterrupt)); set => WriteHere(nameof(DirectedEndOfInterrupt), value); }

        [Offset(176UL)]
        public IntPtr QueryLocalUnitInfo { get => ReadHere<IntPtr>(nameof(QueryLocalUnitInfo)); set => WriteHere(nameof(QueryLocalUnitInfo), value); }

        [Offset(184UL)]
        public IntPtr QueryPendingState { get => ReadHere<IntPtr>(nameof(QueryPendingState)); set => WriteHere(nameof(QueryPendingState), value); }

        [Offset(192UL)]
        public IntPtr CaptureGlobalCrashdumpState { get => ReadHere<IntPtr>(nameof(CaptureGlobalCrashdumpState)); set => WriteHere(nameof(CaptureGlobalCrashdumpState), value); }

        [Offset(200UL)]
        public IntPtr CaptureProcessorCrashdumpState { get => ReadHere<IntPtr>(nameof(CaptureProcessorCrashdumpState)); set => WriteHere(nameof(CaptureProcessorCrashdumpState), value); }

        public InterruptFunctionTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptFunctionTable>();
        }
    }
}