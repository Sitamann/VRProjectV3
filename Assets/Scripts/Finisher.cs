using UnityEngine;

public class Finisher : MonoBehaviour
{
    private Vector3 initialPosition;
    public Transform objectToReset;

    private void Start()
    {
        // Store the initial position of the object
        initialPosition = objectToReset.position;
    }

    public void OnButtonClick()
    {
        ResetObjectPosition();
    }

    private void ResetObjectPosition()
    {
        // Reset the object's position to its initial position
        objectToReset.position = initialPosition;
    }
}

