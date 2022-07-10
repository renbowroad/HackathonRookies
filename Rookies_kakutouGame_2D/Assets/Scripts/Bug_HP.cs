using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug_HP : MonoBehaviour
{
    public int HP = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
