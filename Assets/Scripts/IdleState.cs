using UnityEngine;

public class IdleState : ICharacterState
{
    private CharacterContext character;

    public void Enter(CharacterContext character)
    {
        this.character = character;
    }

    public void Update()
    {
        float input = character.GetHorizontalInput();
        if (input != 0)
            character.SwitchState(new WalkState());
    }

    public void Exit() { }
}