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
    public Light[] lights3;
    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;

    }
    public void Enter()
    {
        if (Nr == Code)
        {
            anim3.Play("OpenTheDoor");
            DA3.Play();
            lights3[0].color = Color.blue;
            lights3[1].color = Color.blue;
        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}
