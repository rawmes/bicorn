using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
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
        pointNumber++;
        if (pointNumber >= points.Length)
        {
            pointNumber = 0;
        }
        currentTarget = points[pointNumber];
    }
    public GameObject Player;
    private Vector3 scaleStorage;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == Player)
        {
            scaleStorage = other.transform.localScale;
            other.transform.parent = transform;
            other.transform.localScale = scaleStorage;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
        {
            other.transform.parent = null;
            other.transform.localScale = scaleStorage;

        }
       
        
    } 
}



