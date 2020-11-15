using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Home brew camera shake, this is an alternative to using EZCameraShake;
// But you may want ot use EZCameraShake as it's a free package,
// clean to implement and gives us more control.
public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;

        float ellapsed = 0.0f;
        while (ellapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            ellapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;
    }
}
