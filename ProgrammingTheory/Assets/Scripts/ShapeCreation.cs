using UnityEngine;

public abstract class Shape
{
    public string name{ get; set; }
    public abstract void Draw(GameObject prefab, Transform parent);
    public abstract float Area();
    public abstract float Perimeter();
}

