using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_spawner : MonoBehaviour
{
    public GameObject cubeprefabVar;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubeprefabVar);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubeprefabVar);
    }
}
