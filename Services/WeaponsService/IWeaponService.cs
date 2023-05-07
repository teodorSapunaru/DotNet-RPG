using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_RPG.Dtos.Character;
using DotNet_RPG.Dtos.Weapon;

namespace DotNet_RPG.Services.WeaponsService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}