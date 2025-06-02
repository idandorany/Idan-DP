using UnityEngine;

public class AttackState : ICharacterState
{
    private CharacterContext character;
    private float timer;

    public void Enter(CharacterContext character)
    {
        this.character = character;
        timer = 0.3f; // attack duration
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            character.SwitchState(new IdleState());
    }

    public void Exit() { }
}
