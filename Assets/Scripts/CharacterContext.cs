using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class CharacterContext : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private ICharacterState currentState;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SwitchState(new IdleState());
    }

    void Update()
    {
        currentState?.Update();

        if (Input.GetKeyDown(KeyCode.Space))
            SwitchState(new JumpState());

        if (Input.GetKeyDown(KeyCode.Mouse0))
            SwitchState(new AttackState());

        if (Input.GetKeyDown(KeyCode.LeftShift))
            SwitchState(new DashState());
    }

    public void SwitchState(ICharacterState newState)
    {
        currentState?.Exit();

        Debug.Log($"Switching to state: {newState.GetType().Name}");

        currentState = newState;
        currentState.Enter(this);
    }

    public float GetHorizontalInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }
}
