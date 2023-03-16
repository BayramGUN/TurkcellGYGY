namespace CounterStrike;

public class Player
{
    public string? Name { get; set; } = string.Empty;
    public string? Icon { get; set; } = string.Empty;
    public Weapon WeaponOfPlayer { get; set; } = new Weapon();

    public void Attack()
    {
        WeaponOfPlayer.Attack();
    }
    public void Reload()
    {
        if(WeaponOfPlayer is Gun) 
        {
            ((Gun)WeaponOfPlayer).Reload();
        }
    }
    public void RightClick()
    {
        WeaponOfPlayer.GetReadyToAttack();
    }
}