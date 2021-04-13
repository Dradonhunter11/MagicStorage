using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元");
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
            Item.rare = 0;
            Item.value = Item.sellPrice(0, 0, 6, 0);
            Item.createTile = ModContent.TileType<Components.StorageUnit>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Items.StorageComponent>());
            recipe.AddRecipeGroup("MagicStorage:AnyChest");
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddTile(TileID.WorkBenches);
            
            recipe.Create();

            recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Items.StorageComponent>());
            recipe.AddRecipeGroup("MagicStorage:AnyChest");
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddTile(TileID.WorkBenches);
            
            recipe.Create();
        }
    }
}
