using UnityEngine;
using UnityEngine.UI;

public class AnchorTeleportButton : MonoBehaviour
{
    public GameObject objectToTeleport; // Reference to the GameObject to teleport
    public Transform teleportDestination; // Reference to the teleport destination

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(StartTeleportDelay);
    }

    private void StartTeleportDelay()
    {
        StartCoroutine(TeleportDelayRoutine());
    }

    private System.Collections.IEnumerator TeleportDelayRoutine()
    {
        yield return new WaitForSeconds(2f); // Delay for 2 seconds

        TeleportObject();
    }

    private void TeleportObject()
    {
        if (objectToTeleport != null && teleportDestination != null)
        {
            objectToTeleport.transform.position = teleportDestination.position;
        }
    }
}