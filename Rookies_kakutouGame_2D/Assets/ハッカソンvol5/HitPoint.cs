using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitPoint: MonoBehaviour
{
    public int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            if (this.gameObject.tag == "Player1")
            {
                Debug.Log("P1_dead");
                SceneManager.LoadScene("P2_win");
            }

            if (this.gameObject.tag == "Player2")
            {
                Debug.Log("P2_dead");
                SceneManager.LoadScene("P1_win");
            }

        }
    }
}
