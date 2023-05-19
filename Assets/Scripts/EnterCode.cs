using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EnterCode : MonoBehaviour
{
    string Code = "9165";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public Text UiText = null;
    public Animator anim3;
    public AudioSource DA3;
    public AudioSource DA4;
    public AudioSource DA5;
    public Light[] lights3;
    public float speed = 0.05f;

    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;

    }
    public void Enter()
    {
        UiText.text = Nr;
        if (Nr == Code)
        {
            anim3.Play("OpenTheDoor");
            DA3.Play();
            DA4.Play();
            lights3[0].color = Color.blue;
            lights3[1].color = Color.blue;
            lights3[2].color = Color.green;
            lights3[3].color = Color.green;
        }
        else if (Nr != Code)
        {
            for (int i = 0; i <= 3; i ++)
            {
                
                DA5.Play();
                lights3[2].color = Color.red;
                lights3[3].color = Color.red;
         

            }
        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}
