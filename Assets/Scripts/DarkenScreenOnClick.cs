using UnityEngine;
using UnityEngine.UI;

public class DarkenScreenOnClick : MonoBehaviour
{
    public float transitionDuration = 1.0f; // Duration of the transition in seconds
    public float displayDuration = 2.0f; // Duration to display at full opacity in seconds
    public Button button; // Reference to the button that triggers the effect
    public Image image; // Reference to the image component for darkening effect

    private bool isTransitioning = false;

    private void Start()
    {
        button.onClick.AddListener(StartTransition);
    }

    private void StartTransition()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            StartCoroutine(TransitionRoutine());
        }
    }

    private System.Collections.IEnumerator TransitionRoutine()
    {
        Color startColor = new Color(image.color.r, image.color.g, image.color.b, 0f);
        Color targetColor = new Color(image.color.r, image.color.g, image.color.b, 1f);

        // Transition from 0 opacity to 100 opacity
        float elapsedTime = 0f;
        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            image.color = Color.Lerp(startColor, targetColor, t);
            yield return null;
        }

        // Stay at full opacity for displayDuration
        yield return new WaitForSeconds(displayDuration);

        // Transition from 100 opacity to 0 opacity
        elapsedTime = 0f;
        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            image.color = Color.Lerp(targetColor, startColor, t);
            yield return null;
        }

        // Reset the color to fully transparent
        image.color = startColor;

        isTransitioning = false;
    }
}
