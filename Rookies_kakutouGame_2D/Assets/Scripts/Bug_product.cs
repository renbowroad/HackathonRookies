using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug_product: MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabBug;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 30�t���[�����ɃV�[���Ƀv���n�u�𐶐�
        if (Time.frameCount % 1500 == 0)
        {
            // �v���n�u�̈ʒu�������_���Őݒ�
            float x = Random.Range(-5.0f, 5.0f);
        
            Vector3 pos = new Vector3(x, 10.0f, 0);

            // �v���n�u�𐶐�
            Instantiate(PrefabBug, pos, Quaternion.identity);
        }
    }
}
