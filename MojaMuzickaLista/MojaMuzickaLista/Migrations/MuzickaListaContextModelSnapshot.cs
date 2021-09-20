﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MojaMuzickaLista.Database;

namespace MojaMuzickaLista.Migrations
{
    [DbContext(typeof(MuzickaListaContext))]
    partial class MuzickaListaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MojaMuzickaLista.Database.Kategorije", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazivKategorije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorije");

                    b.HasData(
                        new
                        {
                            KategorijaID = 1,
                            nazivKategorije = "Pop"
                        });
                });

            modelBuilder.Entity("MojaMuzickaLista.Database.Pjesme", b =>
                {
                    b.Property<int>("PjesmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumEditovanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumUnos")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Favorit")
                        .HasColumnType("bit");

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("NazivIzvodjaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivPjesme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PjesmaID");

                    b.HasIndex("KategorijaID");

                    b.ToTable("Pjesme");

                    b.HasData(
                        new
                        {
                            PjesmaID = 1,
                            DatumEditovanja = new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumUnos = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Favorit = true,
                            KategorijaID = 1,
                            NazivIzvodjaca = "naziv izvodjaca",
                            NazivPjesme = "naziv pjesme",
                            Ocjena = 4,
                            Url = "https://www.youtube.com/watch?v=RpyN9pFXUCg&list=RDRpyN9pFXUCg&start_radio=1"
                        },
                        new
                        {
                            PjesmaID = 2,
                            DatumEditovanja = new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumUnos = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Favorit = true,
                            KategorijaID = 1,
                            NazivIzvodjaca = "naziv izvodjaca",
                            NazivPjesme = "naziv pjesme",
                            Ocjena = 4,
                            Url = "https://www.youtube.com/watch?v=RpyN9pFXUCg&list=RDRpyN9pFXUCg&start_radio=1"
                        });
                });

            modelBuilder.Entity("MojaMuzickaLista.Database.Pjesme", b =>
                {
                    b.HasOne("MojaMuzickaLista.Database.Kategorije", "Kategorije")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorije");
                });
#pragma warning restore 612, 618
        }
    }
}
