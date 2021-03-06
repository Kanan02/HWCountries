// <auto-generated />
using System;
using CodefirstCountry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodefirstCountry.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodefirstCountry.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Medal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedalType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medals");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("SportId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("CodefirstCountry.Models.ParticipantMedal", b =>
                {
                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("MedalId")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId", "MedalId");

                    b.HasIndex("MedalId");

                    b.ToTable("ParticipantMedals");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Participant", b =>
                {
                    b.HasOne("CodefirstCountry.Models.Country", "Country")
                        .WithMany("Participants")
                        .HasForeignKey("CountryId");

                    b.HasOne("CodefirstCountry.Models.Sport", "Sport")
                        .WithMany("Participants")
                        .HasForeignKey("SportId");

                    b.Navigation("Country");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("CodefirstCountry.Models.ParticipantMedal", b =>
                {
                    b.HasOne("CodefirstCountry.Models.Medal", "Medal")
                        .WithMany("ParticipantMedals")
                        .HasForeignKey("MedalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodefirstCountry.Models.Participant", "Participant")
                        .WithMany("ParticipantMedals")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medal");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Country", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Medal", b =>
                {
                    b.Navigation("ParticipantMedals");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Participant", b =>
                {
                    b.Navigation("ParticipantMedals");
                });

            modelBuilder.Entity("CodefirstCountry.Models.Sport", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
