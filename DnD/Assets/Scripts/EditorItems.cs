using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Item
{
  public Sprite sprite;
  
  public GameObject asset;

  public List<Material> materials;
}


[System.Serializable]
public struct ItemCategory
{
  public string name;
  public List<Item> items;

}

public class EditorItems : MonoBehaviour
{

  public List<ItemCategory> items;

  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
