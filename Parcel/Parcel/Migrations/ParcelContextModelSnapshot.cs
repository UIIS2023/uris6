﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcel.Entities;

#nullable disable

namespace Parcel.Migrations
{
    [DbContext(typeof(ParcelContext))]
    partial class ParcelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Parcel.Entities.CadastralMunicipality", b =>
                {
                    b.Property<Guid>("cadastralMunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cadastralMunicipalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cadastralMunicipalityId");

                    b.ToTable("CadastralMunicipality");

                    b.HasData(
                        new
                        {
                            cadastralMunicipalityId = new Guid("22d1f47a-75b6-4f78-add1-adbb38e009ef"),
                            cadastralMunicipalityName = "Čantavir"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("6e079249-1322-4ebe-b336-d1d80f801fbc"),
                            cadastralMunicipalityName = "Bački Vinogradi"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("93921298-4aa8-4e64-ad44-d8dff1ed0d67"),
                            cadastralMunicipalityName = "Bikovo"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("7957db6a-ce96-4364-bce3-d712fac17292"),
                            cadastralMunicipalityName = "Đuđin"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("60e4d41f-c6ce-48e5-918d-a834ea17efee"),
                            cadastralMunicipalityName = "Žednik"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("8421a65c-1929-4e1b-b005-c19ce6b8084e"),
                            cadastralMunicipalityName = "Tavankut"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("56845d4b-4f9d-40cf-a58c-338949e3719f"),
                            cadastralMunicipalityName = "Bajmok"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("2da53652-4366-45e7-9f4e-75b1768456f9"),
                            cadastralMunicipalityName = "Donji Grad"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("04b12cb0-5d05-4432-87da-81ca464011a2"),
                            cadastralMunicipalityName = "Stari Grad"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("44607cb5-c1ca-4cec-ab46-f0ef67f8656b"),
                            cadastralMunicipalityName = "Novi Grad"
                        },
                        new
                        {
                            cadastralMunicipalityId = new Guid("f427bdf0-4f91-4411-9e9f-085fc44bbdf7"),
                            cadastralMunicipalityName = "Palić"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.Class", b =>
                {
                    b.Property<Guid>("classId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("classId");

                    b.ToTable("Class");

                    b.HasData(
                        new
                        {
                            classId = new Guid("9af0ab6f-c437-4959-9ea3-0c721214147b"),
                            className = "I"
                        },
                        new
                        {
                            classId = new Guid("7af0e459-501b-47cd-9e4e-d329407b1c5b"),
                            className = "II"
                        },
                        new
                        {
                            classId = new Guid("a2d03f10-884e-49c8-a30e-e606a22dc2ba"),
                            className = "III"
                        },
                        new
                        {
                            classId = new Guid("fe3e5d4b-18e5-41d7-b35c-d00ec8171f5f"),
                            className = "IV"
                        },
                        new
                        {
                            classId = new Guid("c8d44720-a933-4a4e-9e73-acc047535a5e"),
                            className = "V"
                        },
                        new
                        {
                            classId = new Guid("ed5e7420-3728-4829-8ac0-67c7ccdb506c"),
                            className = "VI"
                        },
                        new
                        {
                            classId = new Guid("c5b969b4-26ca-4a34-ac80-b26c2a2a5f17"),
                            className = "VII"
                        },
                        new
                        {
                            classId = new Guid("b472b7c5-2648-40ca-a15f-37be449bc80a"),
                            className = "VIII"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.Culture", b =>
                {
                    b.Property<Guid>("cultureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cultureDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cultureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cultureId");

                    b.ToTable("Culture");

                    b.HasData(
                        new
                        {
                            cultureId = new Guid("4960ad3a-cd69-494e-864d-d4e410ce6094"),
                            cultureDescription = "1",
                            cultureName = "Njive"
                        },
                        new
                        {
                            cultureId = new Guid("581b4400-bcde-4fa5-ac85-72a6077af503"),
                            cultureDescription = "2",
                            cultureName = "Vrtovi"
                        },
                        new
                        {
                            cultureId = new Guid("5475e615-4137-4cbc-8daf-4538eae0f37e"),
                            cultureDescription = "3",
                            cultureName = "Voćnjaci"
                        },
                        new
                        {
                            cultureId = new Guid("2d9dcd0e-1705-4aca-b847-724a2c4c4877"),
                            cultureDescription = "4",
                            cultureName = "Vinogradi"
                        },
                        new
                        {
                            cultureId = new Guid("ffcecfaa-b835-41c2-a568-57a564e7a03b"),
                            cultureDescription = "5",
                            cultureName = "Livade"
                        },
                        new
                        {
                            cultureId = new Guid("f0d417fc-8e78-4d0f-a018-d6df8c270737"),
                            cultureDescription = "6",
                            cultureName = "Pašnjaci"
                        },
                        new
                        {
                            cultureId = new Guid("29b64040-ad2a-4859-a540-1d59a475652c"),
                            cultureDescription = "7",
                            cultureName = "Šume"
                        },
                        new
                        {
                            cultureId = new Guid("5fba88b4-c642-4e9e-a5c1-074f91f417df"),
                            cultureDescription = "8",
                            cultureName = "Trstici-močvare"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.Drainage", b =>
                {
                    b.Property<Guid>("drainageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("drainageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("drainageId");

                    b.ToTable("Drainage");

                    b.HasData(
                        new
                        {
                            drainageId = new Guid("d98745a1-7c94-417c-b31a-6efc83acaefc"),
                            drainageName = "Površinsko odvodnjavanje"
                        },
                        new
                        {
                            drainageId = new Guid("e59f5cca-f6ab-44f4-9c04-698d0b310bc5"),
                            drainageName = "Podzemno odvodnjavanje"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.FormOfProperty", b =>
                {
                    b.Property<Guid>("formOfPropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("formOfPropertyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formOfPropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("formOfPropertyId");

                    b.ToTable("FormOfProperty");

                    b.HasData(
                        new
                        {
                            formOfPropertyId = new Guid("d54f5caa-a148-46ab-a6da-f83c9440cbab"),
                            formOfPropertyDescription = "1",
                            formOfPropertyName = "Privatna svojina"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("109932fb-a5b9-4fab-8bb2-4d644df61245"),
                            formOfPropertyDescription = "2",
                            formOfPropertyName = "Državna svojina RS"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("92351865-973d-4ec2-be9c-cdd81b849e99"),
                            formOfPropertyDescription = "3",
                            formOfPropertyName = "Državna svojina"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("2fa236f3-60d1-408d-ac04-bedbd4919bbb"),
                            formOfPropertyDescription = "4",
                            formOfPropertyName = "Društvena svojina"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("9590edb7-593f-42ae-82b8-cf29298fe2d4"),
                            formOfPropertyDescription = "5",
                            formOfPropertyName = "Zadružna svojina"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("35636422-b81c-43c6-9a86-9486cf138c30"),
                            formOfPropertyDescription = "6",
                            formOfPropertyName = "Mešovita svojina"
                        },
                        new
                        {
                            formOfPropertyId = new Guid("9b7b6c58-ace6-4fe8-9176-46323c00d005"),
                            formOfPropertyDescription = "7",
                            formOfPropertyName = "Drugi oblici"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.Parcel", b =>
                {
                    b.Property<Guid>("parcelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cadastralMunicipalityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("classId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("classRealCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("cultureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cultureRealCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("drainageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("drainageRealCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("formOfPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("immovablePropertyListNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parcelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("protectedZoneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("protectedZoneRealCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("surface")
                        .HasColumnType("int");

                    b.Property<Guid>("userOfParcelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("workabilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("workabilityRealCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("parcelId");

                    b.ToTable("Parcel");

                    b.HasData(
                        new
                        {
                            parcelId = new Guid("cf69a921-7a2f-4b8c-be71-92ee821b19ee"),
                            cadastralMunicipalityId = new Guid("f427bdf0-4f91-4411-9e9f-085fc44bbdf7"),
                            classId = new Guid("7af0e459-501b-47cd-9e4e-d329407b1c5b"),
                            classRealCondition = "2",
                            cultureId = new Guid("ffcecfaa-b835-41c2-a568-57a564e7a03b"),
                            cultureRealCondition = "3",
                            drainageId = new Guid("d98745a1-7c94-417c-b31a-6efc83acaefc"),
                            drainageRealCondition = "1",
                            formOfPropertyId = new Guid("92351865-973d-4ec2-be9c-cdd81b849e99"),
                            immovablePropertyListNumber = "LN101",
                            parcelNumber = "PC-2601",
                            protectedZoneId = new Guid("5b1f0cbe-a20c-4747-80db-0b13af254388"),
                            protectedZoneRealCondition = "4",
                            surface = 100,
                            userOfParcelId = new Guid("9f122326-746a-426a-84d1-09501ae77664"),
                            workabilityId = new Guid("69679e47-4d0b-4277-96f5-c1583a97abe8"),
                            workabilityRealCondition = "5"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.ProtectedZone", b =>
                {
                    b.Property<Guid>("protectedZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("protectedZoneName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("protectedZoneId");

                    b.ToTable("ProtectedZone");

                    b.HasData(
                        new
                        {
                            protectedZoneId = new Guid("5b1f0cbe-a20c-4747-80db-0b13af254388"),
                            protectedZoneName = "1"
                        },
                        new
                        {
                            protectedZoneId = new Guid("12d2a98d-7890-44fa-bc30-ee3d77461a7f"),
                            protectedZoneName = "2"
                        },
                        new
                        {
                            protectedZoneId = new Guid("a029cb37-3cb3-4b24-9db2-ef427401f1a5"),
                            protectedZoneName = "3"
                        },
                        new
                        {
                            protectedZoneId = new Guid("3ee483c7-b878-4a0e-a742-8c87a287e5cd"),
                            protectedZoneName = "4"
                        });
                });

            modelBuilder.Entity("Parcel.Entities.Workability", b =>
                {
                    b.Property<Guid>("workabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("workabilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("workabilityId");

                    b.ToTable("Workability");

                    b.HasData(
                        new
                        {
                            workabilityId = new Guid("69679e47-4d0b-4277-96f5-c1583a97abe8"),
                            workabilityName = "Obradivo"
                        },
                        new
                        {
                            workabilityId = new Guid("004b067a-bcbb-47d2-8869-550aeb147138"),
                            workabilityName = "Ostalo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
