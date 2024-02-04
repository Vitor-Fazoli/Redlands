using Redlands.Enums;
using Redlands.Interfaces;

namespace Redlands.Content;

public class RustedPistol : IWeapon
{
    WeaponID IWeapon.Type { get => WeaponID.Repeater; }
    string IWeapon.Name { get => "Pistola Enferrujada"; }
    int IWeapon.Damage { get => 2; }
}
