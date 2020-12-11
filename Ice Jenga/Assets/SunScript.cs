using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    public GameObject obj;
    public Vector3 V;

    // Start is called before the first frame update
    void Start()
    {
        float X = this.transform.position.x;
        float Y = this.transform.position.y;
        float Z = this.transform.position.z;
        GameObject instance = (GameObject)Instantiate(obj, new Vector3(X, Y, Z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += V;
    }
}
