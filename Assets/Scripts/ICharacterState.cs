public interface ICharacterState
{
    void Enter(CharacterContext character);
    void Update();
    void Exit();
}