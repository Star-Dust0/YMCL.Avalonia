using System.Collections.Generic;
using System.Linq;
using Avalonia.Media.Imaging;
using MinecraftLaunch.Base.Enums;
using MinecraftLaunch.Base.Models.Game;
using YMCL.Public.Classes;
using YMCL.Public.Classes.Operate;

namespace YMCL.Public.Module.Mc;

public class Icon
{
    private static readonly Dictionary<string, Bitmap> _cache = new();

    public static Bitmap GetMinecraftIcon(MinecraftDataEntry entry)
    {
        if (entry.Type == "bedrock")
            return GetCached("YMCL.Public.Assets.McIcons.dirt_path_side.png");
        if (entry.MinecraftEntry.IsVanilla)
        {
            return entry.MinecraftEntry.Version.Type switch
            {
                MinecraftVersionType.Release => GetCached("YMCL.Public.Assets.McIcons.grass_block_side.png"),
                MinecraftVersionType.Snapshot => GetCached("YMCL.Public.Assets.McIcons.crafting_table_front.png"),
                _ => GetCached("YMCL.Public.Assets.McIcons.grass_block_side.png")
            };
        }

        if (entry.MinecraftEntry is not ModifiedMinecraftEntry e)
            return GetCached("YMCL.Public.Assets.McIcons.grass_block_side.png");
        if (e.ModLoaders.Any(a => a.Type == ModLoaderType.Forge))
            return GetCached("YMCL.Public.Assets.McIcons.furnace_front.png");
        if (e.ModLoaders.Any(a => a.Type == ModLoaderType.NeoForge))
            return GetCached("YMCL.Public.Assets.McIcons.NeoForgeIcon.png");
        if (e.ModLoaders.Any(a => a.Type == ModLoaderType.Fabric))
            return GetCached("YMCL.Public.Assets.McIcons.FabricIcon.png");
        if (e.ModLoaders.Any(a => a.Type == ModLoaderType.Quilt))
            return GetCached("YMCL.Public.Assets.McIcons.QuiltIcon.png");

        return GetCached(
            e.ModLoaders.Any(a => a.Type == ModLoaderType.OptiFine)
                ? "YMCL.Public.Assets.McIcons.OptiFineIcon.png"
                : "YMCL.Public.Assets.McIcons.grass_block_side.png");
    }

    private static Bitmap GetCached(string resourcePath)
    {
        if (!_cache.TryGetValue(resourcePath, out var bitmap))
        {
            bitmap = Public.Module.IO.Disk.Getter.LoadBitmapFromAppFile(resourcePath);
            _cache[resourcePath] = bitmap;
        }
        return bitmap;
    }
}
