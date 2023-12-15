using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _1_DAL.Models
{
    public partial class BookingAirlineContext : DbContext
    {
        public BookingAirlineContext()
        {
        }

        public BookingAirlineContext(DbContextOptions<BookingAirlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<PlaneType> PlaneTypes { get; set; } = null!;
        public virtual DbSet<Recommend> Recommends { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SeatDetail> SeatDetails { get; set; } = null!;
        public virtual DbSet<SeatFlight> SeatFlights { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=BookingAirline;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("airport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("airportCode");

                entity.Property(e => e.AirportName)
                    .HasMaxLength(50)
                    .HasColumnName("airportName");

                entity.Property(e => e.LocationFly)
                    .HasMaxLength(50)
                    .HasColumnName("locationFly");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankAccountNum).HasColumnName("bankAccountNum");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .HasColumnName("displayName");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bank__bankAccoun__403A8C7D");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("displayName");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("middle_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFlight)
                    .HasColumnType("date")
                    .HasColumnName("dateFlight");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.FlightCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flightCode");

                entity.Property(e => e.GoFrom)
                    .HasMaxLength(100)
                    .HasColumnName("goFrom");

                entity.Property(e => e.GoTom)
                    .HasMaxLength(100)
                    .HasColumnName("goTom");

                entity.Property(e => e.LocationId).HasColumnName("locationId");

                entity.Property(e => e.PlaneTypeId).HasColumnName("planeTypeId");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TimeEnd).HasColumnName("timeEnd");

                entity.Property(e => e.TimeStart).HasColumnName("timeStart");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flight__location__47DBAE45");

                entity.HasOne(d => d.PlaneType)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.PlaneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flight__dateTo__46E78A0C");
            });

            modelBuilder.Entity<PlaneType>(entity =>
            {
                entity.ToTable("Plane_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("displayName");

                entity.Property(e => e.PlaneCode)
                    .HasMaxLength(50)
                    .HasColumnName("planeCode");

                entity.Property(e => e.TotalSeat).HasColumnName("totalSeat");
            });

            modelBuilder.Entity<Recommend>(entity =>
            {
                entity.ToTable("Recommend");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(200)
                    .HasColumnName("content");

                entity.Property(e => e.IdFlight).HasColumnName("idFlight");

                entity.HasOne(d => d.IdFlightNavigation)
                    .WithMany(p => p.Recommends)
                    .HasForeignKey(d => d.IdFlight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recommend__conte__5535A963");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(10)
                    .HasColumnName("displayName");
            });

            modelBuilder.Entity<SeatDetail>(entity =>
            {
                entity.ToTable("Seat_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.PlaneTypeId).HasColumnName("planeTypeId");

                entity.Property(e => e.SeatCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seatCode");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SeatDetails)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Seat_deta__statu__03F0984C");

                entity.HasOne(d => d.PlaneType)
                    .WithMany(p => p.SeatDetails)
                    .HasForeignKey(d => d.PlaneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Seat_deta__plane__04E4BC85");
            });

            modelBuilder.Entity<SeatFlight>(entity =>
            {
                entity.ToTable("Seat_flight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.Seatid).HasColumnName("seatid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.SeatFlights)
                    .HasForeignKey(d => d.Flightid)
                    .HasConstraintName("FK__Seat_flig__fligh__2A164134");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.SeatFlights)
                    .HasForeignKey(d => d.Seatid)
                    .HasConstraintName("FK_Seat_SeatFl");

            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.LastUpdate)
                   .HasColumnType("datetime")
                   .HasColumnName("lastUpdate");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.NameTicket)
                    .HasMaxLength(100)
                    .HasColumnName("nameTicket");

                entity.Property(e => e.SeatCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seatCode");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.Property(e => e.TotalTicket).HasColumnName("totalTicket");

                entity.Property(e => e.TwoWay).HasColumnName("twoWay");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket__customer__4AB81AF0");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket__flightId__4BAC3F29");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("displayName");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Staff__status__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
