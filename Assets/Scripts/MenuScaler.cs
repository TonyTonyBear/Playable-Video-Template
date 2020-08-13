using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScaler : MonoBehaviour
{
    private Vector3 scaleOrigin;

    private void Awake()
    {
        scaleOrigin = transform.localScale;
        transform.localScale = Vector3.zero;
        StartCoroutine(ScaleIn());
    }

    private IEnumerator ScaleIn()
    {
        float duration = 0.5f;
        float timer = 0f;

        while (timer < duration)
        {
            float t = timer / duration;
            transform.localScale = Vector3.LerpUnclamped(Vector3.zero, scaleOrigin, Easing.Back.Out(t));
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
