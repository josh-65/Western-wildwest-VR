using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Rendering;
using UnityEngine;

public class timeCycle : MonoBehaviour
{
    public Light sun;
    public Light moon;
    public Volume skyVolume;
    public AnimationCurve stars;
    private PhysicallyBasedSky sky;

    [Range(0,24)]
    public float time = 12f;
    public float timeSpeed = 1.0f;

    void Start() {
        skyVolume.profile.TryGet(out sky);
    }

    void Update()
    {
        time += Time.deltaTime * (timeSpeed * 0.000411f);
        if (time > 24) {
            time = 0.0f;
        }

        if(moon.transform.rotation.eulerAngles.x > 180){
            sun.shadows = LightShadows.Soft;
            moon.shadows = LightShadows.None;
        } else {
            if(sun.transform.rotation.eulerAngles.x > 180){
                sun.shadows = LightShadows.None;
                moon.shadows = LightShadows.Soft;
            }
        }

        float alpha = time / 24.0f;
        float sunRotation = Mathf.Lerp(-90, 270, alpha);
        float moonRotation = sunRotation - 180.0f;
        sun.transform.rotation = Quaternion.Euler(sunRotation, -150.0f, 0);
        moon.transform.rotation = Quaternion.Euler(moonRotation, -150.0f, 0);
        sky.spaceEmissionMultiplier.value = stars.Evaluate(alpha) * 5.0f;
    }
}