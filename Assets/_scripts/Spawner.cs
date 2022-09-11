using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float moveX,moveY,moveZ;
    public float waitTime;
    public GameObject myPrefab;

    // Update is called once per frame
    void Update()
    {
        myPrefab.transform.position += new Vector3(moveX,moveY,moveZ);
    }


}
