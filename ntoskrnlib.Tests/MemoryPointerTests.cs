using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for MemoryPointer value type
/// </summary>
public class MemoryPointerTests
{
    [Fact]
    public void MemoryPointer_Construction_ShouldStoreValue()
    {
        // Arrange & Act
        var ptr = new MemoryPointer(0x1000UL);

        // Assert
        Assert.Equal(0x1000UL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_CastFromULong_ShouldWork()
    {
        // Arrange & Act
        MemoryPointer ptr = (MemoryPointer)0x2000UL;

        // Assert
        Assert.Equal(0x2000UL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_Addition_ShouldCalculateCorrectly()
    {
        // Arrange
        var ptr = (MemoryPointer)0x1000UL;

        // Act
        var result = ptr + 0x100UL;

        // Assert
        Assert.Equal(0x1100UL, result.Value);
    }

    [Fact]
    public void MemoryPointer_Subtraction_ShouldCalculateCorrectly()
    {
        // Arrange
        var ptr = (MemoryPointer)0x2000UL;

        // Act
        var result = ptr - 0x100UL;

        // Assert
        Assert.Equal(0x1F00UL, result.Value);
    }

    [Fact]
    public void MemoryPointer_Increment_ShouldIncrease()
    {
        // Arrange
        var ptr = (MemoryPointer)0x1000UL;

        // Act
        ptr++;

        // Assert
        Assert.Equal(0x1001UL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_Decrement_ShouldDecrease()
    {
        // Arrange
        var ptr = (MemoryPointer)0x1000UL;

        // Act
        ptr--;

        // Assert
        Assert.Equal(0x0FFFUL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_PointerDifference_ShouldCalculateCorrectly()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x2000UL;
        var ptr2 = (MemoryPointer)0x1000UL;

        // Act
        var diff = ptr1 - ptr2;

        // Assert
        Assert.Equal(0x1000L, diff);
    }

    [Fact]
    public void MemoryPointer_Equality_ShouldCompareCorrectly()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x1000UL;
        var ptr2 = (MemoryPointer)0x1000UL;
        var ptr3 = (MemoryPointer)0x2000UL;

        // Act & Assert
        Assert.True(ptr1 == ptr2);
        Assert.False(ptr1 == ptr3);
        Assert.False(ptr1 != ptr2);
        Assert.True(ptr1 != ptr3);
    }

    [Fact]
    public void MemoryPointer_Comparison_ShouldWorkCorrectly()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x1000UL;
        var ptr2 = (MemoryPointer)0x2000UL;

        // Act & Assert
        Assert.True(ptr1 < ptr2);
        Assert.True(ptr1 <= ptr2);
        Assert.False(ptr1 > ptr2);
        Assert.False(ptr1 >= ptr2);
        Assert.True(ptr2 > ptr1);
        Assert.True(ptr2 >= ptr1);
    }

    [Fact]
    public void MemoryPointer_IsValid_ShouldReturnTrueForValidPointers()
    {
        // Arrange
        var validPtr1 = (MemoryPointer)0x1000UL;
        var validPtr2 = (MemoryPointer)0xDEADBEEFUL;

        // Act & Assert
        Assert.True(validPtr1.IsValid());
        Assert.True(validPtr2.IsValid());
    }

    [Fact]
    public void MemoryPointer_IsValid_ShouldReturnFalseForInvalidPointers()
    {
        // Arrange
        var nullPtr = (MemoryPointer)0UL;
        var maxPtr = (MemoryPointer)ulong.MaxValue;

        // Act & Assert
        Assert.False(nullPtr.IsValid());
        Assert.False(maxPtr.IsValid());
    }

    [Fact]
    public void MemoryPointer_Equals_ShouldWorkCorrectly()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x1000UL;
        var ptr2 = (MemoryPointer)0x1000UL;
        var ptr3 = (MemoryPointer)0x2000UL;

        // Act & Assert
        Assert.True(ptr1.Equals(ptr2));
        Assert.False(ptr1.Equals(ptr3));
    }

    [Fact]
    public void MemoryPointer_CompareTo_ShouldReturnCorrectValue()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x1000UL;
        var ptr2 = (MemoryPointer)0x2000UL;
        var ptr3 = (MemoryPointer)0x1000UL;

        // Act & Assert
        Assert.True(ptr1.CompareTo(ptr2) < 0);
        Assert.True(ptr2.CompareTo(ptr1) > 0);
        Assert.Equal(0, ptr1.CompareTo(ptr3));
    }

    [Fact]
    public void MemoryPointer_Zero_ShouldHaveZeroValue()
    {
        // Act
        var zero = MemoryPointer.Zero;

        // Assert
        Assert.Equal(0UL, zero.Value);
        Assert.False(zero.IsValid());
    }

    [Fact]
    public void MemoryPointer_IsZero_ShouldDetectZeroPointers()
    {
        // Arrange
        var zero = MemoryPointer.Zero;
        var nonZero = (MemoryPointer)0x1000UL;

        // Act & Assert
        Assert.True(zero.IsZero);
        Assert.False(nonZero.IsZero);
    }

    [Fact]
    public void MemoryPointer_AdditionWithSignedTypes_ShouldWorkCorrectly()
    {
        // Arrange
        var ptr = (MemoryPointer)0x1000UL;

        // Act
        var resultInt = ptr + 256;
        var resultLong = ptr + 512L;

        // Assert
        Assert.Equal(0x1100UL, resultInt.Value);
        Assert.Equal(0x1200UL, resultLong.Value);
    }

    [Fact]
    public void MemoryPointer_SubtractionWithSignedTypes_ShouldWorkCorrectly()
    {
        // Arrange
        var ptr = (MemoryPointer)0x2000UL;

        // Act
        var resultInt = ptr - 256;
        var resultLong = ptr - 512L;

        // Assert
        Assert.Equal(0x1F00UL, resultInt.Value);
        Assert.Equal(0x1E00UL, resultLong.Value);
    }

    [Fact]
    public void MemoryPointer_ConversionFromIntPtr_ShouldWork()
    {
        // Arrange
        var intPtr = new IntPtr(0x1000);

        // Act
        var memPtr = (MemoryPointer)intPtr;

        // Assert
        Assert.Equal((ulong)intPtr.ToInt64(), memPtr.Value);
    }

    [Fact]
    public void MemoryPointer_ConversionFromUIntPtr_ShouldWork()
    {
        // Arrange
        var uintPtr = new UIntPtr(0x1000);

        // Act
        var memPtr = (MemoryPointer)uintPtr;

        // Assert
        Assert.Equal(uintPtr.ToUInt64(), memPtr.Value);
    }

    [Fact]
    public void MemoryPointer_ConversionToIntPtr_ShouldWork()
    {
        // Arrange
        var memPtr = (MemoryPointer)0x1000UL;

        // Act
        var intPtr = (IntPtr)memPtr;

        // Assert
        Assert.Equal(0x1000, intPtr.ToInt64());
    }

    [Fact]
    public void MemoryPointer_ConversionToUIntPtr_ShouldWork()
    {
        // Arrange
        var memPtr = (MemoryPointer)0x1000UL;

        // Act
        var uintPtr = (UIntPtr)memPtr;

        // Assert
        Assert.Equal(0x1000UL, uintPtr.ToUInt64());
    }
}
