using GeometryLib.Factories;

namespace GeometryTest;

public class UnitTest1
{
    [Fact]
    public void CreateCircle()
    {
        var cf = new CircleFactory(5.0);
        var circle = cf.GetShape();

        Assert.NotNull(circle);
    }

    [Fact]
    public void NotCreateCircle()
    {
        var cf = new CircleFactory(-5.0);
        var circle = cf.GetShape();

        Assert.Null(circle);
    }

    [Fact]
    public void CreateTraingle()
    {
        var tf = new TriangleFactory(4.0, 4.0, 5.0);
        var triangle = tf.GetShape();

        Assert.NotNull(triangle);
    }

    [Fact]
    public void IsNotRectangle()
    {
        var tf = new TriangleFactory(4.0, 4.0, 5.0);
        var triangle = tf.GetShape();

        Assert.False(triangle.IsRectangle);
    }
    
    [Fact]
    public void CreateRectangle()
    {
        var tf = new TriangleFactory(3.0, 4.0, 5.0);
        var triangle = tf.GetShape();

        Assert.NotNull(triangle);
    }

    [Fact]
    public void IsRectangle()
    {
        var tf = new TriangleFactory(3.0, 4.0, 5.0);
        var triangle = tf.GetShape();

        Assert.True(triangle.IsRectangle);
    }

    [Fact]
    public void NotCreateTraingle()
    {
        var tf = new TriangleFactory(4.0, 4.0, 15.0);
        var triangle = tf.GetShape();

        Assert.Null(triangle);
    }
}
