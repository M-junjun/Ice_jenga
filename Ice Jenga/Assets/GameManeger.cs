using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        float X = 0; //ジェンガの中心x座標
        float Y = 0; //ジェンガの中心y座標
        float Z = 0; //ジェンガの中心z座標

        for (int y = 0; y < 12; y++)
        {
            for (int x = -1; x < 2; x++)
            {
                // プレハブを元にオブジェクトを生成する
                if (y % 2 == 0)
                {
                    GameObject instance =
                    (GameObject)Instantiate(obj, new Vector3(6.0f * x, 4.0f*y, 0.0f), Quaternion.identity);
                }
                else
                {
                    GameObject instance =
                    (GameObject)Instantiate(obj, new Vector3(0.0f, 4.0f*y, 6.0f * x), Quaternion.Euler(0f,90f,0f));

                }

            }

        }
        
    }
       

    // Update is called once per frame
    void Update()
    {
        
    }
}
