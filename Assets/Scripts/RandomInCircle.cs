using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInCircle : MonoBehaviour
{
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 randomDirectionWithUnitLength = Quaternion.Euler(0f, 0f, Random.Range(0, 360)) * Vector2.right;

        transform.position = new Vector3(randomDirectionWithUnitLength.x * radius, 0, randomDirectionWithUnitLength.y * radius);
    }
}
