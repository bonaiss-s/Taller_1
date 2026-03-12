using UnityEngine;
using UnityEngine.InputSystem;

public class AgentController : MonoBehaviour
{
    public Vector2 movevalue;

    InputAction moveAction;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("move");
    }


    void Update()
    {
    movevalue = moveAction.ReadValue<Vector3>();
    }
}
