using UnityEngine;

public class JumpState : ICharacterState
{
    private CharacterContext character;

    public void Enter(CharacterContext character)
    {
        this.character = character;
        character.rb.linearVelocity = new Vector2(character.rb.linearVelocity.x, character.jumpForce);
    }

    public void Update()
    {
        if (character.rb.linearVelocity.y <= 0)
            character.SwitchState(new IdleState());
    }

    public void Exit() { }
}