using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug_product: MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabBug;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 30フレーム毎にシーンにプレハブを生成
        if (Time.frameCount % 1500 == 0)
        {
            // プレハブの位置をランダムで設定
            float x = Random.Range(-5.0f, 5.0f);
        
            Vector3 pos = new Vector3(x, 10.0f, 0);

            // プレハブを生成
            Instantiate(PrefabBug, pos, Quaternion.identity);
        }
    }
}
