using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCubeScript : MonoBehaviour
{
    private float melt = -2;
    private const float MELTMAX = 100;
    private Vector3 size; 

    public float Melt { get => melt;}
    public void MeltAdd(float value)
    {
        melt += value;
    }
    private System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        size = new Vector3
            (this.transform.localScale.x,
            this.transform.localScale.y,
            this.transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (melt > 0 && random.NextDouble() > 0.999) {
            this.transform.localScale = size * (MELTMAX - melt) / MELTMAX;
            melt += 0.002f;
        }
        if(melt <= 0)
        {
            melt += 0.001f;
        }
    }
}
