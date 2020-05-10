using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called before the first frame update

    public float xSpread;
    public float ySpread;
    public float zSpread;
    public Transform centerPoint;
    public float angleOffset;

    public float rotSpeed;
    public bool horizontal;

    float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * rotSpeed;
        Rotate();
        transform.LookAt(centerPoint);
    }

    void Rotate()
    {
        float number = Random.Range(0.0f, 1.0f);

        float x = -Mathf.Cos(timer + angleOffset) * xSpread;
        float z = Mathf.Sin(timer + angleOffset) * zSpread;
        float y = Mathf.Sin(timer + angleOffset) * ySpread;
        if (horizontal)
        {
            y = 0;
        }
        Vector3 pos = new Vector3(x, y, z);
        transform.position = pos + centerPoint.position;
    }
}
