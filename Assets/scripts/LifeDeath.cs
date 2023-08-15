using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LifeDeath : MonoBehaviour
{
    bool dead = false;

    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            death();
        }
    }
    private void OnCollisionEnter(Collision collison)
    {
        if (collison.gameObject.CompareTag("Enemy Body"))
        {
            death();
        }
    }
    void death()
    {
        GetComponent<MeshRenderer>().enabled = false;//Make the object invisible
        GetComponent<Rigidbody>().isKinematic = true;//Prevents application of physics to prevent the player being pushed away from enemy objects
        GetComponent<Movement>().enabled = false;//Stops taking input for a short period
        Invoke(nameof(reload), 1.3f);//This function is used to create a delay in reloading the level
        dead = true;
    }
    void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
