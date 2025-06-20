using UnityEngine;

public class Rectangle : Shape
{
    private float width;
    private float height;
    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
        name = "Rectangle"; // Set the name property
    }
    public override void Draw(GameObject rectanglePrefab, Transform parent)
    {
        // Implementation for drawing a rectangle
        Debug.Log("Drawing a rectangle");
        GameObject instance = GameObject.Instantiate(rectanglePrefab, parent);
    }
    public override float Area()
    {
        return (width * height);
    }
    public override float Perimeter()
    {
        return (width + height) * 2;
    }
}
