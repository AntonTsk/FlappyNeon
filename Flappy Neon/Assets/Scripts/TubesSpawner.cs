using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesSpawner : MonoBehaviour
{
    public GameObject Tubes;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true) 
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1.5f, 2.7f);
            GameObject newTubes = Instantiate(Tubes, new Vector3(7, rand, -7), Quaternion.identity);
            Destroy(newTubes, 10);


        }
    }
    
}
