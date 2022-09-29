﻿// <auto-generated />
using System;
using Buzz.Jewelcrafting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Buzz.Jewelcrafting.Migrations
{
    [DbContext(typeof(BuzzDbContext))]
    [Migration("20220929205039_Gem_Jewels_Seed")]
    partial class Gem_Jewels_Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.BuzzUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.Design", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Cost")
                        .HasColumnType("integer");

                    b.Property<int?>("GemCutId")
                        .HasColumnType("integer");

                    b.Property<string>("IconName")
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("JewelryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GemCutId");

                    b.HasIndex("JewelryId");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.GemCut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("IconName")
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Stat1")
                        .HasColumnType("text");

                    b.Property<string>("Stat2")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GemCuts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_shadowspirit_02",
                            ItemId = 41398,
                            Name = "Relentless Earthsiege Diamond"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_icediamond_02",
                            ItemId = 41258,
                            Name = "Chaotic Skyflare Diamond"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_shadowspirit_02",
                            ItemId = 41401,
                            Name = "Insightful Earthsiege Diamond"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_icediamond_02",
                            ItemId = 41333,
                            Name = "Ember Skyflare Diamond"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_shadowspirit_02",
                            ItemId = 41385,
                            Name = "Invigorating Earthsiege Diamond"
                        },
                        new
                        {
                            Id = 6,
                            Color = "Meta",
                            IconName = "inv_jewelcrafting_icediamond_02",
                            ItemId = 41376,
                            Name = "Revitalizing Skyflare Diamond"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Red",
                            IconName = "inv_jewelcrafting_gem_28",
                            ItemId = 39996,
                            Name = "Bold Scarlet Ruby",
                            Stat1 = "Strength"
                        },
                        new
                        {
                            Id = 8,
                            Color = "Blue",
                            IconName = "inv_jewelcrafting_gem_27",
                            ItemId = 40008,
                            Name = "Solid Sky Sapphire",
                            Stat1 = "Stamina"
                        },
                        new
                        {
                            Id = 9,
                            Color = "Red",
                            IconName = "inv_jewelcrafting_gem_28",
                            ItemId = 39997,
                            Name = "Delicate Scarlet Ruby",
                            Stat1 = "Agility"
                        },
                        new
                        {
                            Id = 10,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40089,
                            Name = "Enduring Forest Emerald",
                            Stat1 = "Defense Rating",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 11,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40051,
                            Name = "Reckless Monarch Topaz",
                            Stat1 = "Spell Power",
                            Stat2 = "Haste"
                        },
                        new
                        {
                            Id = 12,
                            Color = "Yellow",
                            IconName = "inv_jewelcrafting_gem_26",
                            ItemId = 40014,
                            Name = "Rigid Autumn's Glow",
                            Stat1 = "Hit Rating"
                        },
                        new
                        {
                            Id = 13,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40049,
                            Name = "Veiled Monarch Topaz",
                            Stat1 = "Spell Power",
                            Stat2 = "Hit Rating"
                        },
                        new
                        {
                            Id = 14,
                            Color = "Yellow",
                            IconName = "inv_jewelcrafting_gem_26",
                            ItemId = 40017,
                            Name = "Quick Autumn's Glow",
                            Stat1 = "Haste Rating"
                        },
                        new
                        {
                            Id = 15,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40092,
                            Name = "Seer's Forest Emerald",
                            Stat1 = "Intellect",
                            Stat2 = "Spirit"
                        },
                        new
                        {
                            Id = 16,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40044,
                            Name = "Glinting Monarch Topaz",
                            Stat1 = "Agility",
                            Stat2 = "Hit Rating"
                        },
                        new
                        {
                            Id = 17,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40047,
                            Name = "Luminous Monarch Topaz",
                            Stat1 = "Luminous",
                            Stat2 = "Intellect"
                        },
                        new
                        {
                            Id = 18,
                            Color = "Red",
                            IconName = "inv_jewelcrafting_gem_28",
                            ItemId = 40000,
                            Name = "Subtle Scarlet Ruby",
                            Stat1 = "Dodge Rating"
                        },
                        new
                        {
                            Id = 19,
                            Color = "Purple",
                            IconName = "inv_jewelcrafting_gem_29",
                            ItemId = 40031,
                            Name = "Regal Twilight Opal",
                            Stat1 = "Dodge Rating",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 20,
                            Color = "Purple",
                            IconName = "inv_jewelcrafting_gem_29",
                            ItemId = 40027,
                            Name = "Royal Twilight Opal",
                            Stat1 = "Spell Power",
                            Stat2 = "Mp5"
                        },
                        new
                        {
                            Id = 21,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40104,
                            Name = "Intricate Forest Emerald",
                            Stat1 = "Haste Rating",
                            Stat2 = "Spirit"
                        },
                        new
                        {
                            Id = 22,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40105,
                            Name = "Energized Forest Emerald",
                            Stat1 = "Haste Rating",
                            Stat2 = "Mp5"
                        },
                        new
                        {
                            Id = 23,
                            Color = "Blue",
                            IconName = "inv_jewelcrafting_gem_27",
                            ItemId = 40010,
                            Name = "Lustrous Sky Sapphire",
                            Stat1 = "Mp5"
                        },
                        new
                        {
                            Id = 24,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40088,
                            Name = "Vivid Forest Emerald",
                            Stat1 = "Hit Rating",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 25,
                            Color = "Red",
                            IconName = "inv_jewelcrafting_gem_28",
                            ItemId = 40001,
                            Name = "Flashing Scarlet Ruby",
                            Stat1 = "Parry Rating"
                        },
                        new
                        {
                            Id = 26,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40100,
                            Name = "Lambent Forest Emerald",
                            Stat1 = "Hit Rating",
                            Stat2 = "Mp5"
                        },
                        new
                        {
                            Id = 27,
                            Color = "Purple",
                            IconName = "inv_jewelcrafting_gem_29",
                            ItemId = 40023,
                            Name = "Shifting Twilight Opal",
                            Stat1 = "Agility",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 28,
                            Color = "Green",
                            IconName = "inv_jewelcrafting_gem_25",
                            ItemId = 40091,
                            Name = "Forceful Forest Emerald",
                            Stat1 = "Haste Rating",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 29,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40048,
                            Name = "Potent Monarch Topaz",
                            Stat1 = "Spell Power",
                            Stat2 = "Critical Strike Rating"
                        },
                        new
                        {
                            Id = 30,
                            Color = "Purple",
                            IconName = "inv_jewelcrafting_gem_29",
                            ItemId = 40033,
                            Name = "Puissant Twilight Opal",
                            Stat1 = "Armor Penetration Rating",
                            Stat2 = "Stamina"
                        },
                        new
                        {
                            Id = 31,
                            Color = "Orange",
                            IconName = "inv_jewelcrafting_gem_30",
                            ItemId = 40055,
                            Name = "Stark Monarch Topaz",
                            Stat1 = "Attack Power",
                            Stat2 = "Haste Rating"
                        });
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.Jewelry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("IconName")
                        .HasColumnType("text");

                    b.Property<string>("InventorySlot")
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Jewelry");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconName = "inv_jewelry_ring_59",
                            InventorySlot = "Ring",
                            ItemId = 42643,
                            Name = "Design: Titanium Earthguard Ring"
                        },
                        new
                        {
                            Id = 2,
                            IconName = "inv_jewelry_ring_63",
                            InventorySlot = "Ring",
                            ItemId = 42644,
                            Name = "Design: Titanium Spellshock Ring"
                        },
                        new
                        {
                            Id = 3,
                            IconName = "inv_jewelry_ring_57",
                            InventorySlot = "Ring",
                            ItemId = 43582,
                            Name = "Design: Titanium Frostguard Ring"
                        },
                        new
                        {
                            Id = 4,
                            IconName = "inv_jewelry_ring_55",
                            InventorySlot = "Ring",
                            ItemId = 42642,
                            Name = "Design: Titanium Impact Band"
                        },
                        new
                        {
                            Id = 5,
                            IconName = "inv_jewelry_necklace_14",
                            InventorySlot = "Neck",
                            ItemId = 42645,
                            Name = "Design: Titanium Impact Choker"
                        },
                        new
                        {
                            Id = 6,
                            IconName = "inv_jewelry_necklace_35",
                            InventorySlot = "Neck",
                            ItemId = 42647,
                            Name = "Design: Titanium Spellshock Necklace"
                        },
                        new
                        {
                            Id = 7,
                            IconName = "inv_jewelry_necklace_33",
                            InventorySlot = "Neck",
                            ItemId = 42646,
                            Name = "Design: Titanium Earthguard Chain"
                        });
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.UserDesign", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("DesignId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId", "DesignId");

                    b.HasIndex("DesignId");

                    b.ToTable("UserDesigns");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.Design", b =>
                {
                    b.HasOne("Buzz.Jewelcrafting.Data.Entities.GemCut", "GemCut")
                        .WithMany()
                        .HasForeignKey("GemCutId");

                    b.HasOne("Buzz.Jewelcrafting.Data.Entities.Jewelry", "Jewelry")
                        .WithMany()
                        .HasForeignKey("JewelryId");

                    b.Navigation("GemCut");

                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.UserDesign", b =>
                {
                    b.HasOne("Buzz.Jewelcrafting.Data.Entities.Design", "Design")
                        .WithMany("UserDesigns")
                        .HasForeignKey("DesignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Buzz.Jewelcrafting.Data.Entities.BuzzUser", "User")
                        .WithMany("UserDesigns")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Design");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.BuzzUser", b =>
                {
                    b.Navigation("UserDesigns");
                });

            modelBuilder.Entity("Buzz.Jewelcrafting.Data.Entities.Design", b =>
                {
                    b.Navigation("UserDesigns");
                });
#pragma warning restore 612, 618
        }
    }
}
