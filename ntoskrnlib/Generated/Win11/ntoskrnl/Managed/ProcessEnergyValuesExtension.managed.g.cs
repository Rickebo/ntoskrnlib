using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESS_ENERGY_VALUES_EXTENSION")]
    public sealed class ProcessEnergyValuesExtension : DynamicStructure
    {
        [Offset(0UL)]
        [Length(14)]
        public DynamicArray Timelines { get => ReadStructure<DynamicArray>(nameof(Timelines)); set => WriteStructure(nameof(Timelines), value); }

        [Offset(0UL)]
        public TimelineBitmap CpuTimeline { get => ReadStructure<TimelineBitmap>(nameof(CpuTimeline)); set => WriteStructure(nameof(CpuTimeline), value); }

        [Offset(8UL)]
        public TimelineBitmap DiskTimeline { get => ReadStructure<TimelineBitmap>(nameof(DiskTimeline)); set => WriteStructure(nameof(DiskTimeline), value); }

        [Offset(16UL)]
        public TimelineBitmap NetworkTimeline { get => ReadStructure<TimelineBitmap>(nameof(NetworkTimeline)); set => WriteStructure(nameof(NetworkTimeline), value); }

        [Offset(24UL)]
        public TimelineBitmap MBBTimeline { get => ReadStructure<TimelineBitmap>(nameof(MBBTimeline)); set => WriteStructure(nameof(MBBTimeline), value); }

        [Offset(32UL)]
        public TimelineBitmap ForegroundTimeline { get => ReadStructure<TimelineBitmap>(nameof(ForegroundTimeline)); set => WriteStructure(nameof(ForegroundTimeline), value); }

        [Offset(40UL)]
        public TimelineBitmap DesktopVisibleTimeline { get => ReadStructure<TimelineBitmap>(nameof(DesktopVisibleTimeline)); set => WriteStructure(nameof(DesktopVisibleTimeline), value); }

        [Offset(48UL)]
        public TimelineBitmap CompositionRenderedTimeline { get => ReadStructure<TimelineBitmap>(nameof(CompositionRenderedTimeline)); set => WriteStructure(nameof(CompositionRenderedTimeline), value); }

        [Offset(56UL)]
        public TimelineBitmap CompositionDirtyGeneratedTimeline { get => ReadStructure<TimelineBitmap>(nameof(CompositionDirtyGeneratedTimeline)); set => WriteStructure(nameof(CompositionDirtyGeneratedTimeline), value); }

        [Offset(64UL)]
        public TimelineBitmap CompositionDirtyPropagatedTimeline { get => ReadStructure<TimelineBitmap>(nameof(CompositionDirtyPropagatedTimeline)); set => WriteStructure(nameof(CompositionDirtyPropagatedTimeline), value); }

        [Offset(72UL)]
        public TimelineBitmap InputTimeline { get => ReadStructure<TimelineBitmap>(nameof(InputTimeline)); set => WriteStructure(nameof(InputTimeline), value); }

        [Offset(80UL)]
        public TimelineBitmap AudioInTimeline { get => ReadStructure<TimelineBitmap>(nameof(AudioInTimeline)); set => WriteStructure(nameof(AudioInTimeline), value); }

        [Offset(88UL)]
        public TimelineBitmap AudioOutTimeline { get => ReadStructure<TimelineBitmap>(nameof(AudioOutTimeline)); set => WriteStructure(nameof(AudioOutTimeline), value); }

        [Offset(96UL)]
        public TimelineBitmap DisplayRequiredTimeline { get => ReadStructure<TimelineBitmap>(nameof(DisplayRequiredTimeline)); set => WriteStructure(nameof(DisplayRequiredTimeline), value); }

        [Offset(104UL)]
        public TimelineBitmap KeyboardInputTimeline { get => ReadStructure<TimelineBitmap>(nameof(KeyboardInputTimeline)); set => WriteStructure(nameof(KeyboardInputTimeline), value); }

        [Offset(112UL)]
        [Length(5)]
        public DynamicArray Durations { get => ReadStructure<DynamicArray>(nameof(Durations)); set => WriteStructure(nameof(Durations), value); }

        [Offset(112UL)]
        public EnergyStateDuration InputDuration { get => ReadStructure<EnergyStateDuration>(nameof(InputDuration)); set => WriteStructure(nameof(InputDuration), value); }

        [Offset(120UL)]
        public EnergyStateDuration AudioInDuration { get => ReadStructure<EnergyStateDuration>(nameof(AudioInDuration)); set => WriteStructure(nameof(AudioInDuration), value); }

        [Offset(128UL)]
        public EnergyStateDuration AudioOutDuration { get => ReadStructure<EnergyStateDuration>(nameof(AudioOutDuration)); set => WriteStructure(nameof(AudioOutDuration), value); }

        [Offset(136UL)]
        public EnergyStateDuration DisplayRequiredDuration { get => ReadStructure<EnergyStateDuration>(nameof(DisplayRequiredDuration)); set => WriteStructure(nameof(DisplayRequiredDuration), value); }

        [Offset(144UL)]
        public EnergyStateDuration PSMBackgroundDuration { get => ReadStructure<EnergyStateDuration>(nameof(PSMBackgroundDuration)); set => WriteStructure(nameof(PSMBackgroundDuration), value); }

        [Offset(152UL)]
        public uint KeyboardInput { get => ReadHere<uint>(nameof(KeyboardInput)); set => WriteHere(nameof(KeyboardInput), value); }

        [Offset(156UL)]
        public uint MouseInput { get => ReadHere<uint>(nameof(MouseInput)); set => WriteHere(nameof(MouseInput), value); }

        public ProcessEnergyValuesExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessEnergyValuesExtension>();
        }
    }
}