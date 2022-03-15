using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class EditorCamera : MonoBehaviour, EditorControl.IEditorMapCameraActions
{
  // Values that can be modified as the camera editor in the Scene Editor 
  [Tooltip("Defines the moving speed of the camera"), Range(0.1f,5.0f)]
  public float speed = 4.0f;
  public float friction = 0.001f;

  protected bool m_canMove = false;
  protected Vector3 m_finalPosition = Vector3.zero;
  protected Vector2 m_rotation = Vector2.zero;
  private Vector3 m_frictionPosition = Vector3.zero;

  public InputUser? inputUser = null;
  public InputDevice pairedDevice = null;
  private EditorControl actions;

  // Awake is called at the very beggining of everything
  void Awake()
  {
    actions = new EditorControl();
  }

  // Start is called before the first frame update
  void Start()
  {
    inputUser?.AssociateActionsWithUser(actions);

    actions?.Enable();
    actions?.EditorMapCamera.Enable();
    actions?.EditorMapCamera.SetCallbacks(this);
  }

  // Update is called once per frame
  void Update()
  {
    InputHandling();
  }

  private void OnEnable()
  {
    actions?.EditorMapCamera.Enable();
  }

  private void OnDisable()
  {
    actions?.EditorMapCamera.Disable();
    

  }

  private void OnDestroy()
  {
    actions.Dispose();
  }

  #region methods

  void InputHandling()
  {
    Vector3 scaledPosition = m_finalPosition * (Time.deltaTime * speed);
    if (m_canMove)
    {
      transform.Translate(0, scaledPosition.y, 0, Space.World);
      transform.Translate(scaledPosition.x, 0, scaledPosition.z, Space.Self);
      transform.Rotate(Vector3.up, m_rotation.x * 40 * Time.deltaTime, Space.World);
      transform.Rotate(Vector3.right, -m_rotation.y * 40 * Time.deltaTime, Space.Self);
    }
    m_frictionPosition = (m_frictionPosition + scaledPosition) * friction;
    transform.Translate(0, m_frictionPosition.y, 0, Space.World);
    transform.Translate(m_frictionPosition.x, 0, m_frictionPosition.z, Space.Self);
  }

  #endregion

  #region controllerInterface

  public void OnTruck(InputAction.CallbackContext context)
  {
    m_finalPosition.Set(context.ReadValue<float>(),
                        m_finalPosition.y, 
                        m_finalPosition.z);
  }

  public void OnBoom(InputAction.CallbackContext context)
  {
    m_finalPosition.Set(m_finalPosition.x,
                        context.ReadValue<float>(),
                        m_finalPosition.z);
  }

  public void OnDolly(InputAction.CallbackContext context)
  {
    m_finalPosition.Set(m_finalPosition.x,
                        m_finalPosition.y,
                        context.ReadValue<float>());
  }

  public void OnRotation(InputAction.CallbackContext context)
  {
    m_rotation = context.ReadValue<Vector2>();
  }

  public void OnStartMovement(InputAction.CallbackContext context)
  {
    if (context.phase == InputActionPhase.Started )
    {
      m_canMove = true;
    }
    else if (context.phase == InputActionPhase.Canceled)
    {
      m_canMove = false;
    }
  }
  #endregion
}
