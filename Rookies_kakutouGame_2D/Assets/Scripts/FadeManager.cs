using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{


    public GameObject fight;   

    Text fadealpha;             

    private float alpha;        

    private bool fadeout;          
    private bool fadein;    

    //public int SceneNo;           


    // Use this for initialization
    void Start()
    {
        fight = GameObject.Find("fight");
        fadealpha = fight.GetComponent<Text>(); 
        alpha = fadealpha.color.a;                
        fadein = true;                             
    }

    // Update is called once per frame
    void Update()
    {



        if (fadein == true)
        {
            FadeIn();
        }

        if (fadeout == true)
        {
            FadeOut();
        }
    }

    void FadeIn()
    {
        alpha -= 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha <= 0)
        {
            fadein = false;
            fight.SetActive(false);

        }
    }

    void FadeOut()
    {

        alpha += 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fadeout = false;
            //SceneManager.LoadScene("Fade" + SceneNo);
        }
    }

    public void SceneMove()
    {
        fadeout = true;
        fight.SetActive(true);
    }
}
