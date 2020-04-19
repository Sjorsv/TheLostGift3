using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climable : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    // bool climbing = false;
    private void OnTriggerEnter(Collider other)
    {
        // climbing = true;
        if (Input.GetKeyDown(KeyCode.W) == true) //& climbing == true 
                player.transform.position += new Vector3(0, 5, 0);
    }

    private void OnTriggerExit(Collider other)
    {
        //climbing = false;
        player.transform.position += new Vector3(0, -4, 0);
    }
}
