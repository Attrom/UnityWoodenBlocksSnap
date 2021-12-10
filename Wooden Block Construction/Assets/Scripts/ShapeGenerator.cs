using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    private Vector3 mousePositionOnInstantiate;

    public void InstantiateCube()
    {
        mousePositionOnInstantiate = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(cubePrefab, mousePositionOnInstantiate, Quaternion.identity);
    } 
}
