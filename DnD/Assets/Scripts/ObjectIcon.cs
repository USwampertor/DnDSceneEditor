using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIcon : MonoBehaviour
{
  public bool isVisible;

  private SpriteRenderer m_renderer;
  
  // Start is called before the first frame update
  void Start()
  {
    m_renderer = GetComponent<SpriteRenderer>();
  }

  // Update is called once per frame
  void Update()
  {
    if (isVisible)
    {
      transform.LookAt(Camera.main.transform);
    }
  }

  public void ToggleIcon(bool active)
  {
    isVisible = active;
    m_renderer.enabled = active;
  }

}
