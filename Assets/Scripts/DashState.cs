using UnityEngine;

public class DashState : ICharacterState
{
    private CharacterContext character;
    private float dashSpeed = 10f;
    private float duration = 0.2f;

    public void Enter(CharacterContext character)
    {
        this.character = character;
        character.rb.linearVelocity = new Vector2(character.GetHorizontalInput() * dashSpeed, 0f);
    }

    public void Update()
    {
        duration -= Time.deltaTime;
        if (duration <= 0)
            character.SwitchState(new IdleState());
    }

    public void Exit() { }
}
