using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesMove : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
