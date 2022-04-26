using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private Stopwatch time;
    private int spawnTime = 500;

    void Start()
    {
        time = System.Diagnostics.Stopwatch.StartNew();
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            time.Stop();
            if(time.ElapsedMilliseconds > spawnTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time = System.Diagnostics.Stopwatch.StartNew();
            }
            else
            {
                time.Start();
            }
        }
    }
}
