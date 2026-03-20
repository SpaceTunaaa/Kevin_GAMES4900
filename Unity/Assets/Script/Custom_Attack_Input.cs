using UnityEngine;
using UnityEngine.InputSystem;

public class Custom_Attack_Input : MonoBehaviour
{
    private InputSystem_Actions input;
    private bool attackHeld;

    private void Awake() => input = new InputSystem_Actions();

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.Attack.performed += AttackPressed;
        input.Player.Attack.started += _ => attackHeld = true;
        input.Player.Attack.canceled += AttackReleased;
    }

    private void OnDisable()
    {
        input.Player.Attack.performed -= AttackPressed;
        input.Player.Attack.canceled -= AttackReleased;
        Debug.Log("Attack!!");
        input.Player.Disable();
    }

    private void Update(){
        // if (attackHeld) Debug.Log("ATTACK HELD");
        Vector2 move = input.Player.Move.ReadValue<Vector2>();
        if (move != Vector2.zero) Debug.Log($"MOVE {move}");
        
        move = input.Player.Move.ReadValue<Vector2>();
        if (move != Vector2.zero)
        {
            transform.position += new Vector3(move.x, move.y, 0) * 0.01f;
        }

    }

    private void AttackPressed(InputAction.CallbackContext _) => Debug.Log("Attack!!");

    private void AttackReleased(InputAction.CallbackContext _)
    {
        attackHeld = false;
        // Debug.Log("ATTACK RELEASED");
    }
}