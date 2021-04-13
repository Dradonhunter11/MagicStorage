using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сердце Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Serce Jednostki Magazynującej");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Cœur de Stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Corazón de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储核心");
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
            Item.value = Item.sellPrice(0, 1, 35, 0);
            Item.createTile = ModContent.TileType<Components.StorageHeart>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(null, "StorageComponent");
            recipe.AddRecipeGroup("MagicStorage:AnyDiamond", 3);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Emerald, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyEmerald", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
            
            recipe.Create();
        }
    }
}
