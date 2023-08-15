using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;//This creates an array for the two waypoints.
    int curWayPoint=0;//Maybe 0 or 1 as we have 2 waypoints.
    [SerializeField] float speed=1f;
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[curWayPoint].transform.position) < .1f)
        {
            curWayPoint++;
            if(curWayPoint >= waypoints.Length)
            {
                curWayPoint=0;
            }
        }
        //Now we need to change the position of the floor, so we'll use transform function.
        //We use the Vector.moveTowards function
        //1st Argument:- The object which needs to be moved.
        //2nd Argument:- The object towards which we need to move.
        transform.position = Vector3.MoveTowards(transform.position,waypoints[curWayPoint].transform.position, speed * Time.deltaTime);
        // speed * Time.deltaTime -> This ensures that the movement is one unit per second regardless of the current frame rate.
    }
}
