using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameObject circlePrefab;
    public GameObject rectanglePrefab;
    public Transform shapesContainer;
    public void StartDraw()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5f),
            new Rectangle(4f, 6f)
        };
        foreach (Shape shape in shapes)
        {
            if (shape is Circle circle)
            {
                circle.Draw(circlePrefab, shapesContainer);
            }
            else if (shape is Rectangle rectangle)
            {
                rectangle.Draw(rectanglePrefab, shapesContainer);
            }
            Debug.Log($"Shape: {shape.name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
        }
    }
}
