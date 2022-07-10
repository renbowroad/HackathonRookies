using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    GameObject Cube2;//Cube2���̂��̂�����ϐ�

    HitPoint script;//cube2_hp������ϐ�
    Bug_HP script2;
    public AudioClip sound1;
    AudioSource audioSource;

    public int damage = 0;
    // Start is called before the first frame update
    void Start()
    {
        damage = 10;
        //Component���擾
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.1f;
        //  Cube2 = GameObject.Find("Cube2");//Cube2���I�u�W�F�N�g������擾���ĕϐ��Ɋi�[
        // script = Cube2.GetComponent<HitPoint>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Bug")
        {
            script2 = collision.gameObject.GetComponent<Bug_HP>();
            script2.HP -= 10;

            if (script2.HP == 0)
            {
                damage = damage + 5;
            }
        }

        if ((collision.gameObject.tag != this.gameObject.tag))
        {
            script = collision.gameObject.GetComponent<HitPoint>();
            script.HP -= 10 + damage;
            audioSource.PlayOneShot(sound1);
            if (script.HP <= 0)
            {  

                if (collision.gameObject.tag == "Player1")
                {
                    Debug.Log("P1_dead");
                    SceneManager.LoadScene("P2_win");
                }
                if (collision.gameObject.tag == "Player2")
                {
                    Debug.Log("P2_dead");
                    SceneManager.LoadScene("P1_win");
                }
            }

        }

        

        
    }
}
