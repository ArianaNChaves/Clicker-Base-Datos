using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static bool CompareLayerAndMask(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }
    
    public static IEnumerator UiShaker(float duration, float strength, Vector3 basePosition, RectTransform rectTransform)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            float offsetY = UnityEngine.Random.Range(-strength, strength);
            rectTransform.localPosition = basePosition + new Vector3(0f, offsetY, 0f);
            elapsed += Time.deltaTime;
            yield return null;
        }
        rectTransform.localPosition = basePosition;
    }

    public static IEnumerator UiBounce(float duration, float strength, Vector3 from, RectTransform rectTransform)
    {
        Vector3 to = from + new Vector3(0f, strength, 0f);

        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float time = elapsed / duration;
            float bounce = Mathf.Sin(time * Mathf.PI); 
            rectTransform.localPosition = Vector3.Lerp(from, to, bounce);
            yield return null;
        }
        rectTransform.localPosition = from;
    }
}
