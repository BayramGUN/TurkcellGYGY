// See https://aka.ms/new-console-template for more information

using CounterStrike;
Console.WriteLine("Hello, World!");

Player player = new Player();
Console.WriteLine(player.WeaponOfPlayer.Name.Equals(string.Empty));
Ak47 ak47 = new Ak47();
Gun gun = new Gun();
DesertEagle desertEagle = new DesertEagle();


player.WeaponOfPlayer = new Weapon {
    Name = "Eppah biçaği",
    Damage = 5
};
player.RightClick();
player.Attack();
player.WeaponOfPlayer = gun;
player.Reload();
player.WeaponOfPlayer = desertEagle;
player.RightClick();
player.Attack();
player.Reload();
player.WeaponOfPlayer = ak47;
player.RightClick();
player.Attack();
player.Reload();