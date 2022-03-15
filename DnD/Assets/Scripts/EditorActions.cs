using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class EditorActions : MonoBehaviour, EditorControl.IEditorMapActionsActions
{
  public GameObject marker;
  public InputUser? inputUser = null;
  public InputDevice pairedDevice = null;
  private EditorControl actions;
  private EditorItems itemCatalog;

  private GameObject activeObject;
  protected bool isLeftClicking = false;
  protected Dictionary<Vector3, bool> floorTiles = new Dictionary<Vector3, bool>();

  #region monobehaviorMethods
  // Awake is called at the very beginning of everything
  void Awake()
  {
    actions = new EditorControl();
  }

  // Start is called before the first frame update
  void Start()
  {
    inputUser?.AssociateActionsWithUser(actions);

    actions?.Enable();
    actions?.EditorMapActions.Enable();
    actions?.EditorMapActions.SetCallbacks(this);
    itemCatalog = GetComponent<EditorItems>();
    // DEBUG
    activeObject = itemCatalog.items[0].items[0].asset;

  }

  // Update is called once per frame
  void Update()
  {
        
  }

  private void OnEnable()
  {
    actions?.EditorMapActions.Enable();
  }

  private void OnDisable()
  {
    actions?.EditorMapActions.Disable();
  }

  private void OnDestroy()
  {
    actions.Dispose();
  }

  #endregion 

  #region controllerInterface
  public void OnLeftClick(InputAction.CallbackContext context)
  {
    if (context.phase == InputActionPhase.Started) { isLeftClicking = true; }
    else if (context.phase == InputActionPhase.Canceled) { isLeftClicking = false; }

    if (context.phase == InputActionPhase.Performed)
    {

      if (!floorTiles.ContainsKey(marker.transform.position))
      {
        Instantiate(activeObject, marker.transform.position, Quaternion.identity);
        floorTiles.Add(marker.transform.position, true);
      }

      else if (!floorTiles[marker.transform.position])
      {
        Instantiate(activeObject, marker.transform.position, Quaternion.identity);
        floorTiles[marker.transform.position] = true;
      }
    }
  }

  public void OnMouseMovement(InputAction.CallbackContext context)
  {


    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(context.ReadValue<Vector2>());

    if (Physics.Raycast(ray, out hit))
    {
      marker.transform.position = new Vector3(Mathf.Round(hit.point.x + 0.5f) - 0.5f,
                                              hit.transform.position.y,
                                              Mathf.Round(hit.point.z + 0.5f) - 0.5f);
      if (isLeftClicking)
      {
        if (!floorTiles.ContainsKey(marker.transform.position))
        {
          Instantiate(activeObject, marker.transform.position, Quaternion.identity);
          floorTiles.Add(marker.transform.position, true);
        }

        else if (!floorTiles[marker.transform.position])
        {
          Instantiate(activeObject, marker.transform.position, Quaternion.identity);
          floorTiles[marker.transform.position] = true;
        }
      }
    }

  }

  #endregion

}
