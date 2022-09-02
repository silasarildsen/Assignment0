namespace Assignment0;
public class LeapYearTests
{
    [Fact]
    public void Is_Leap_Year_returns_false_when_1(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(1);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Is_Leap_Year_returns_false_when_1700(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(1700);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Is_Leap_Year_returns_false_when_1800(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(1800);

        // Assert
        result.Should().Be(false);
    }
    [Fact]
    public void Is_Leap_Year_returns_false_when_1900(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(1900);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Is_Leap_Year_returns_true_when_1600(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(1600);

        // Assert
        result.Should().Be(true);
    }
    [Fact]
    public void Is_Leap_Year_returns_true_when_2000(){
        // Assign
        var ly = new LeapYear();

        // Act
        var result = ly.IsLeapYear(2000);

        // Assert
        result.Should().Be(true);
    }
}