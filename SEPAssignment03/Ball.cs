namespace SEPAssignment03;

public class Ball
{
    private int Size { get; set; }
    private Color Color { get; set; }
    private int ThrowCount { get; set; }

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size != 0)
        {
            ThrowCount++;
        }
    }

    public int GetThrowCount()
    {
        return ThrowCount;
    }
}