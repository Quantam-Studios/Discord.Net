using System.Text.Json.Serialization;

namespace Discord.API;

public class NitroStickerPacks
{
    [JsonPropertyName("sticker_packs")]
    public List<StickerPack> StickerPacks { get; set; }
}