using UnityEngine;

public class WalkState : ICharacterState
{
    private CharacterContext character;

    public void Enter(CharacterContext character)
    {
        this.character = character;
    }

    public void Update()
    {
        float input = character.GetHorizontalInput();
        character.rb.linearVelocity = new Vector2(input * character.moveSpeed, character.rb.linearVelocity.y);

        if (input == 0)
            character.SwitchState(new IdleState());
    }

    public void Exit() { }
}
