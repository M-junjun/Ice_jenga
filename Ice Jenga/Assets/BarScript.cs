using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            this.transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
        }
    }
}
