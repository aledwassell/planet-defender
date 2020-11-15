using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Home brew camera shake, this is an alternative to using EZCameraShake;
// But you may want ot use EZCameraShake as it's a free package,
// clean to implement and gives us more control.
public class CameraShake : MonoBehaviour
{
    private void Start() {
        GameController gameCtrl = GameObject.Find("GameManager").GetComponent<GameController>();
        gameCtrl.OnSpacePressed += Check_OnSpacePressed;
    }

    void Check_OnSpacePressed(object sender, EventArgs e){
        Debug.Log("pressed");
        Shake(2f, 5f);
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;

        float ellapsed = 0.0f;
        while (ellapsed < duration)
        {
            // float x = Random.Range(-1f, 1f) * magnitude;
            // float y = Random.Range(-1f, 1f) * magnitude;
            float x = 0.3f * magnitude;
            float y = -.4f * magnitude;
            transform.localPosition = new Vector3(x, y, originalPosition.z);

            ellapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;
    }
}
