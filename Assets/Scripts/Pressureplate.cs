using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressureplate : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        door.transform.position += new Vector3(0, 4, 0);
    }

    private void OnTriggerExit(Collider other)
    {
        door.transform.position += new Vector3(0, -4, 0);
    }
}
