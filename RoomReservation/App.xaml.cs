using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RoomReservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {   
            Hotel hotel = new Hotel("Shangri-La");
            RoomID roomID = new RoomID(5, 11);
            DateTime now = new DateTime(2023, 2, 1); //year, month, day
            DateTime until = new DateTime(2023, 2, 20);
            Customer cust = new Customer(1, "James Lee");
            Reservation reservation = new Reservation(roomID, now, until, cust);

            hotel.makeReservation(reservation);

            hotel.makeReservation(new Reservation(
                new RoomID(5, 12),
                now, until,
                new Customer(2, "Hannah Kim")));


            //This basically just starts up MainWindow.xaml
            MainWindow = new MainWindow();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
