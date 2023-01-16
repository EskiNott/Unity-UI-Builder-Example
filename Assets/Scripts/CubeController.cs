
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private Material mat;
    private List<Color> c = new();
    private int colorIndex = 0;
    private bool isRotate = false;
    private bool isChangeColor = false;
    private float colorcode = 0;

    private void Start()
    {
        c.Add(Color.black);
        c.Add(Color.white);
        c.Add(Color.blue);
        c.Add(Color.green);
        c.Add(Color.red);
    }

    private void Update()
    {
        Rotate();
        ColorChange();
    }

    private void Rotate()
    {
        if (isRotate)
        {
            cubeTransform.transform.Rotate(10 * Time.deltaTime, 10 * Time.deltaTime, 10 * Time.deltaTime);
        }
    }

    private void ColorChange() 
    {
        if (isChangeColor)
        {
            mat.color = c[colorIndex];
            colorIndex++;
            colorIndex %= c.Count;
        }
    }

    public void StartRotate()
    { 
        isRotate = true;
    }

    public void StopRotate()
    { 
        isRotate = false;
    }

    public void ChangeColor()
    {
        isChangeColor = !isChangeColor;
    }
}
