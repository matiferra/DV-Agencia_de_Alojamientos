﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210627215415_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Agencia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantAlojamientos")
                        .HasColumnType("int");

                    b.Property<int?>("id_alojamientoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id_alojamientoid");

                    b.ToTable("Agencia");
                });

            modelBuilder.Entity("Entities.AgenciaManager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("id_agenciaid")
                        .HasColumnType("int");

                    b.Property<int?>("id_reservaid")
                        .HasColumnType("int");

                    b.Property<int?>("id_usuarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id_agenciaid");

                    b.HasIndex("id_reservaid");

                    b.HasIndex("id_usuarioid");

                    b.ToTable("AgenciaManager");
                });

            modelBuilder.Entity("Entities.Alojamiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidadDeBanios")
                        .HasColumnType("int");

                    b.Property<int>("cantidadDePersonas")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_de_habitaciones")
                        .HasColumnType("int");

                    b.Property<int?>("ciudadid")
                        .HasColumnType("int");

                    b.Property<bool>("esHotel")
                        .HasColumnType("bit");

                    b.Property<string>("estrellas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio_por_dia")
                        .HasColumnType("float");

                    b.Property<double>("precio_por_persona")
                        .HasColumnType("float");

                    b.Property<bool>("tv")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("ciudadid");

                    b.ToTable("Alojamiento");
                });

            modelBuilder.Entity("Entities.Ciudades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Ciudades");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nombre = "buenos aires"
                        },
                        new
                        {
                            id = 2,
                            nombre = "rio negro"
                        },
                        new
                        {
                            id = 3,
                            nombre = "la plata"
                        },
                        new
                        {
                            id = 4,
                            nombre = "bariloche"
                        },
                        new
                        {
                            id = 5,
                            nombre = "lujan"
                        });
                });

            modelBuilder.Entity("Entities.Reserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FHasta")
                        .HasColumnType("datetime2");

                    b.Property<int>("contador")
                        .HasColumnType("int");

                    b.Property<int?>("id_alojamientoid")
                        .HasColumnType("int");

                    b.Property<int?>("id_usuarioid")
                        .HasColumnType("int");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("id_alojamientoid");

                    b.HasIndex("id_usuarioid");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<bool>("bloqueado")
                        .HasColumnType("bit");

                    b.Property<bool>("esAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("intentosLogueo")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DNI = 0,
                            bloqueado = false,
                            esAdmin = true,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "fede",
                            pass = "123"
                        },
                        new
                        {
                            id = 2,
                            DNI = 111111,
                            bloqueado = false,
                            esAdmin = false,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "gianpool",
                            pass = "123"
                        },
                        new
                        {
                            id = 3,
                            DNI = 222222,
                            bloqueado = false,
                            esAdmin = false,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "matiferra",
                            pass = "123"
                        },
                        new
                        {
                            id = 4,
                            DNI = 333333,
                            bloqueado = true,
                            esAdmin = false,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "gabo",
                            pass = "123"
                        },
                        new
                        {
                            id = 5,
                            DNI = 444444,
                            bloqueado = false,
                            esAdmin = true,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "dino",
                            pass = "123"
                        },
                        new
                        {
                            id = 6,
                            DNI = 555555,
                            bloqueado = false,
                            esAdmin = false,
                            intentosLogueo = 0,
                            mail = "soporte@gmail.com",
                            nombre = "fran",
                            pass = "123"
                        });
                });

            modelBuilder.Entity("Entities.Agencia", b =>
                {
                    b.HasOne("Entities.Alojamiento", "id_alojamiento")
                        .WithMany()
                        .HasForeignKey("id_alojamientoid");

                    b.Navigation("id_alojamiento");
                });

            modelBuilder.Entity("Entities.AgenciaManager", b =>
                {
                    b.HasOne("Entities.Agencia", "id_agencia")
                        .WithMany()
                        .HasForeignKey("id_agenciaid");

                    b.HasOne("Entities.Reserva", "id_reserva")
                        .WithMany()
                        .HasForeignKey("id_reservaid");

                    b.HasOne("Entities.Usuario", "id_usuario")
                        .WithMany()
                        .HasForeignKey("id_usuarioid");

                    b.Navigation("id_agencia");

                    b.Navigation("id_reserva");

                    b.Navigation("id_usuario");
                });

            modelBuilder.Entity("Entities.Alojamiento", b =>
                {
                    b.HasOne("Entities.Ciudades", "ciudad")
                        .WithMany()
                        .HasForeignKey("ciudadid");

                    b.Navigation("ciudad");
                });

            modelBuilder.Entity("Entities.Reserva", b =>
                {
                    b.HasOne("Entities.Alojamiento", "id_alojamiento")
                        .WithMany()
                        .HasForeignKey("id_alojamientoid");

                    b.HasOne("Entities.Usuario", "id_usuario")
                        .WithMany()
                        .HasForeignKey("id_usuarioid");

                    b.Navigation("id_alojamiento");

                    b.Navigation("id_usuario");
                });
#pragma warning restore 612, 618
        }
    }
}