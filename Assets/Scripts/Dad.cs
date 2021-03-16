using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dad : MonoBehaviour
{
    Material daddy;
    public float starttimer = 0;
    public float endtimer = 3;
    public bool collision = false;

    // Start is called before the first frame update
    void Start()
    {
        daddy = GetComponent<MeshRenderer>().material;
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision)
        {
            daddy.SetFloat("clipWeight", starttimer / endtimer);
            starttimer += Time.deltaTime;
            if (starttimer >= endtimer)
            {
                Destroy(gameObject);
            }
        }
    

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "dadRammer")
        {
            collision = true;
        }
    }
}
