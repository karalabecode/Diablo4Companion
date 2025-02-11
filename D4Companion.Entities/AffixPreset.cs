﻿namespace D4Companion.Entities
{
    public class AffixPreset
    {
        public string Name { get; set; } = string.Empty;
        public List<ItemAffix> ItemAffixes { get; set;} = new List<ItemAffix>();
        public List<ItemAspect> ItemAspects { get; set; } = new List<ItemAspect>();
    }
}