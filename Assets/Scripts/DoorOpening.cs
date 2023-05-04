using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public static DoorOpening instance;
    public ConditionOne[] objects;
    public bool[] conditions;
    public Snap[] objects2;
    public bool[] conditions2;
    public Animator anim;
    public Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        Open();
        Open2();
        instance = this;
    }

    public void Open()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            conditions[i] = objects[i].yes;
        }
        if (CheckBool())
        {
            anim.Play("OpenTheDoor");
        }
    }
    public void Open2()
    {
        for (int i = 0; i < objects2.Length; i++)
        {
            conditions2[i] = objects2[i].yes;
        }

        if (CheckBool2())
        {
            anim2.Play("OpenSecondDoor");
        }


    }
    bool CheckBool2()
    {
        int counter = 0;
        for (int i = 0; i < objects2.Length; i++)
        {
            if (objects2[i].yes)
            {
                counter++;
            }

        }
        if (counter == objects2.Length)
        {
            return true;
        }
        else return false;
    }

    bool CheckBool()
    {
        int counter = 0;
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].yes)
            {
                counter++;
            }

        }
        if (counter == objects.Length)
        {
            return true;
        }
        else return false;
    }

}
