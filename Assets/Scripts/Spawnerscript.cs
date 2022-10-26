using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] _SpawnObject;
    float PositionY;
    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        int rand = Random.Range(0, _SpawnObject.Length);
        PositionY = Random.Range(4, -4f);
         this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
         Instantiate(_SpawnObject[rand], transform.position, transform.rotation);
    }
}
