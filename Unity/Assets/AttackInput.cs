using UnityEngine;
using UnityEngine.InputSystem;

public class AttackInput : MonoBehaviour
{
    private PlayerInputActions input;

    void Awake()
    {
        input = new PlayerInputActions();
    }

    void OnEnable()
    {
        input.Enable();
        input.Player.Attack.performed += OnAttack;
    }

    void OnDisable()
    {
        input.Player.Attack.performed -= OnAttack;
        input.Disable();
    }

    private void OnAttack(InputAction.CallbackContext ctx)
    {
        Debug.Log("Attack!!");
    }
}