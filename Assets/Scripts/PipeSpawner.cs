using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;

    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    IEnumerator SpawnPipe()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1f, 3.75f);
            GameObject newPipe = Instantiate(pipe, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
}
