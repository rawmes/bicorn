using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialInstance : MonoBehaviour
{
    //as the wise man once said.. variables are dumb
    public GameObject go;
    public Color col;
    public Material mat;
    public Color randomColor;
    public float hue;


    // Start is called before the first frame update
    void Start()
    {
        // whoooooooooooooo diiiis?
        go = this.gameObject;
       
        

        

    }

    // Update is called once per frame
    void Update()
    {
        // feking useless piece of shit
        hue = Random.Range(0f, 255f);
        mat.SetFloat("_hue", hue);
    }
}
