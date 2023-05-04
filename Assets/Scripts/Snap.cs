using UnityEngine;

public class Snap : MonoBehaviour
{
    public bool yes = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {



    }


    private void OnTriggerEnter(Collider Snapp)
    {

        if (Snapp.gameObject.tag.Equals("Place"))
        {
            transform.position = Snapp.transform.position;
            transform.rotation = Snapp.transform.rotation;
            transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        }
        else
        if (Snapp.gameObject.tag.Equals("Untagged"))
        {
            transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
        if ((this.gameObject.name == Snapp.gameObject.name) && (Snapp.gameObject.tag.Equals("Place")))
        {
            yes = true;
            DoorOpening.instance.Open2();
        }


    }

}
