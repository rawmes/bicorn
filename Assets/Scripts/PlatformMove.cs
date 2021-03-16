using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    //remember vector from despicable me? wonder whats he up to these days.
    public Vector3[] points;
    public int pointNumber=0;
    private Vector3 currentTarget;

    public float tolerance;
    public float speed;
    public float delayTime;

    private float delayStart;

    public bool automatic;


    // Start is called before the first frame update
    void Start()
    {
        if (points.Length > 0)
        {
            currentTarget = points[0];

        }
        tolerance = speed * Time.deltaTime;

        
    }

    // Update is called once per frame
    void Update()
    {
        //moving the air escalators here.. well not here but the command to move is here even if move is elsewehre

        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else
        {
            UpdateTarget();
        }
        
    }
    void MovePlatform()
    {

        // ok its here .. happy?
        Vector3 heading = currentTarget-transform.position ;
        transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
        if (heading.magnitude < tolerance)
        {
            transform.position = currentTarget;
            delayStart = Time.time;

        }

    }
    void UpdateTarget()
    {
        //something happens here.. commnet out and figure out
        if (automatic)
        {
            if (Time.time - delayStart > delayTime)
            {
                NextPlatform();

            }
        }

    }
    public void NextPlatform()
    {
        // mehh

        pointNumber++;
        if (pointNumber >= points.Length)
        {
            pointNumber = 0;
        }
        currentTarget = points[pointNumber];
    }
   
    private void OnTriggerEnter(Collider other)
    {
        //love at first sight
        other.transform.parent = transform;
    }
    private void OnTriggerExit(Collider other)
    {
        //breakup
        other.transform.parent = null;
        
    } 
}



