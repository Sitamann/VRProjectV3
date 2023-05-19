using UnityEngine;
using UnityEngine.UI;

public class DarkenScreen : MonoBehaviour
{
    public float transitionDuration = 2.0f; // Duration of the transition in seconds

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeIn());
    }

    private System.Collections.IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        Color startColor = image.color;
        Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 100f);

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime * transitionDuration);
            image.color = Color.Lerp(startColor, targetColor, t);
            yield return null;
        }
    }
}