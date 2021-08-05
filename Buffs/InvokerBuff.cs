using dotaMod.General.projectilestuffs.minions;
using dotaMod.General.accessories;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace dotaMod.Buffs
{

    public class InvokerBuff : ModBuff
    {

        public override void SetDefaults() {

            DisplayName.SetDefault("INVOKER!");
            Description.SetDefault("QUAS WEX EXPORTS!");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            DotaPlayer modPlayer = player.GetModPlayer<DotaPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<General.projectilestuffs.minions.CagedInvoker>()] < 1)
            {

                int k;
                for (k = 3; k < 8 + player.extraAccessorySlots; k++)
                {
                    if (player.armor[k].type == ItemType<InvokerCage>())
                    {
                        break;
                    }
                }
                Projectile.NewProjectile(player.Center.X, player.Center.Y - 200, 0f, 0f, ProjectileType<CagedInvoker>(), player.GetWeaponDamage(player.armor[k]), player.GetWeaponKnockback(player.armor[k], 2f), player.whoAmI);

            }
            if (!modPlayer.invokerMinionEquipped)
            {

                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {

                player.buffTime[buffIndex] = 18000;

            }

        }

    }

}