using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject is the player
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);//The transform inside the bracket refers to moving platform
        }
    }
    void OnCollisionExit(Collision collision)
    {
        //collision.gameObject is the player
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);//The transform inside the bracket refers to moving platform
        }
    }
}
