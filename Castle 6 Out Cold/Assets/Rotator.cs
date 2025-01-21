using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(-90 + 20 * Mathf.PerlinNoise(Time.time, Mathf.Sin(Time.time)), 90, -90);
        
    }
}
