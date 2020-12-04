using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject obj;
    public GameObject board;

    // Start is called before the first frame update
    void Start()
    {
        float X = board.transform.position.x;
        float Y = board.transform.position.y + 0.5f;
        float Z = board.transform.position.z;
        for (int y = 0; y < 12; y++)
        {
            for (int x = -1; x < 2; x++)
            {
                // プレハブを元にオブジェクトを生成する
                if (y % 2 == 0)
                {
                    GameObject instance = (GameObject)Instantiate(obj, new Vector3(X+0.851f * x, Y+0.821f * y, Z+0.0f), Quaternion.Euler(0f, 90f, 0f)); 
                }
                else
                {
                    GameObject instance = (GameObject)Instantiate(obj, new Vector3(X+0.0f, Y+0.821f * y, Z+0.851f * x), Quaternion.identity);
                }

            }

        }
        
    }
       

    // Update is called once per frame
    void Update()
    {
        
    }
}
