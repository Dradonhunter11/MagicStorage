using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class CraftingAccess : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storage Crafting Interface");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Модуль Создания Предметов");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Interfejs Rzemieślniczy Magazynu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Interface de Stockage Artisanat");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Interfaz de Elaboración de almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "制作存储单元");
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = 1;
            Item.consumable = true;
            Item.rare = 1;
            Item.value = Item.sellPrice(0, 1, 16, 25);
            Item.createTile = ModContent.TileType<Components.CraftingAccess>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(null, "StorageComponent");
            recipe.AddRecipeGroup("MagicStorage:AnyDiamond", 3);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Sapphire, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnySapphire", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
            recipe.Create();
        }
    }
}
