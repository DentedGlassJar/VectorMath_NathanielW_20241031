using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Vector : MonoBehaviour
{
    /*
        THINGS TO-DO FOR MONDAY:
        Use OnDrawGizmos() method to do the following:
        * 2 Objects, one of them always rotates to look at the second object
        * Draw a line from one object to the other
        * The line should change colors if the distance between them is smaller than a certain amount
    */

    public GameObject objectA;
    public GameObject objectB;

     

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnDrawGizmos();
    }

    private void OnDrawGizmos()
    {
        // This will get ObjectA to look at ObjectB.
        Vector3 objectAPosition = (objectA.transform.position);
        Vector3 objectBPosition = (objectB.transform.position);
        transform.LookAt(objectBPosition);

        // This will draw a line from ObjectA to ObjectB, making the line change color when the distance is smaller then a certain amount.
        if()
        {
            // I want it so if ObjectB gets close enough to ObjectA's range, it will change the color to yellow.
            Debug.DrawLine(objectAPosition, objectBPosition, Color.yellow);
        }
        else
        {
            Debug.DrawLine(objectAPosition, objectBPosition, Color.red);
        }
    }
}
