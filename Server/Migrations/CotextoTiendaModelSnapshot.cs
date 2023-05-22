﻿// <auto-generated />
using System;
using Actividad18.Server.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Actividad18.Server.Migrations
{
    [DbContext(typeof(CotextoTienda))]
    partial class CotextoTiendaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Actividad18.Shared.Modelos.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("VentasId")
                        .HasColumnType("int");

                    b.Property<string>("categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("precio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentasId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Ventas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Productos", b =>
                {
                    b.HasOne("Actividad18.Shared.Modelos.Ventas", "Ventas")
                        .WithMany("Productos")
                        .HasForeignKey("VentasId");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Ventas", b =>
                {
                    b.HasOne("Actividad18.Shared.Modelos.Clientes", "Clientes")
                        .WithMany("Ventas")
                        .HasForeignKey("ClientesId");

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Clientes", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Actividad18.Shared.Modelos.Ventas", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
