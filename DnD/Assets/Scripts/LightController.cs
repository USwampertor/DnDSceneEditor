using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
  public Light directionalLight;
  public Slider dayTimeSlider;
  public Slider rayLightSlider;

  // Start is called before the first frame update
  void Start()
  {
    dayTimeSlider.onValueChanged.AddListener(ChangeDayTime);
    rayLightSlider.onValueChanged.AddListener(ChangeRayLight);
    dayTimeSlider.value = 0;
    rayLightSlider.value = 0;
    ChangeDayTime(dayTimeSlider.value);
    ChangeRayLight(rayLightSlider.value);
  }

  // Update is called once per frame
  void Update()
  {
     
  }

  void ChangeDayTime(float dayTime)
  {
    Vector3 finalRotation = new Vector3(dayTimeSlider.value * 89.0f, 
                                        directionalLight.gameObject.transform.rotation.eulerAngles.y,
                                        directionalLight.gameObject.transform.rotation.eulerAngles.z);
    directionalLight.gameObject.transform.rotation = Quaternion.Euler(finalRotation);
  }

  void ChangeRayLight(float rayLight)
  {
    Vector3 finalRotation = new Vector3(directionalLight.gameObject.transform.rotation.eulerAngles.x,
                                        rayLightSlider.value * 359.0f,
                                        directionalLight.gameObject.transform.rotation.eulerAngles.z);
    directionalLight.gameObject.transform.rotation = Quaternion.Euler(finalRotation);
  }
}
