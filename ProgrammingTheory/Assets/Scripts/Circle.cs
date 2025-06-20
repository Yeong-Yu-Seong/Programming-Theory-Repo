using UnityEngine;

public class Circle : Shape
{
    private float radius;
    public Circle(float radius)
    {
        this.radius = radius;
        name = "Circle"; // Set the name property
    }
    public override void Draw(GameObject circlePrefab, Transform parent)
    {
        // Implementation for drawing a rectangle
        Debug.Log("Drawing a circle");
        GameObject instance = GameObject.Instantiate(circlePrefab, parent);
    }
    public override float Area()
    {
        return Mathf.PI * radius * radius;
    }
    public override float Perimeter()
    {
        return Mathf.PI * 2 * radius;
    }
}
