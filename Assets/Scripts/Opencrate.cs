using UnityEngine;

public class Opencrate : MonoBehaviour
{
    bool open = false;
    // Start is called before the first frame update
    public void OpenCrate()
    {
        if (!open)
        {
            open = true;
            GetComponent<Animator>().SetBool("open", open);
        }

        else
        {
            open = false;
            GetComponent<Animator>().SetBool("open",open);
        }
    }

}
