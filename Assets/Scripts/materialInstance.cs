using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialInstance : MonoBehaviour
{
    public GameObject go;
    public Color col;
    public Material mat;
    public Color randomColor;
    public float hue;


    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
       
        

        

    }

    // Update is called once per frame
    void Update()
    {
        hue = Random.Range(0f, 255f);
        mat.SetFloat("_hue", hue);
    }
}
