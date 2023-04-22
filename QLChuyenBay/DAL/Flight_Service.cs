using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using DTO;

namespace DAL
{
    public class Flight_Service
    {
        public static List<Plane> LoadPlane()
        {
            List<Plane> list = new List<Plane>();
            using (var db = new AirportManager())
            {
                list = db.Planes.ToList();
            }
            return list;
        }

        public static DbSet<Plane> AddPlane(string model, string registration, int totalSeat, string manufacturer, int state)
        {
            DbSet<Plane> flights;
            using (var db = new AirportManager())
            {
                flights = db.Set<Plane>();
                flights.Add(new Plane() { Model = model, Registration = registration, TotalSeat = totalSeat, Manufacturer = manufacturer, State = state });

                db.SaveChanges();
            }
            return flights;
        }

        public static void UpdatePlane(int id, string model, string registration, int totalSeat, string manufacturer, int state)
        {
            using (var db = new AirportManager())
            {
                var pickedPlane = (from d in db.Planes
                    where d.PlaneID == id
                    select d).Single();
                pickedPlane.Model = model;
                pickedPlane.Registration = registration;
                pickedPlane.TotalSeat = totalSeat;
                pickedPlane.Manufacturer = manufacturer;
                pickedPlane.State = state;
                db.Planes.AddOrUpdate(pickedPlane);
                db.SaveChanges();
            }
        }

        public static void RemovePlane(int id, string model, string registration, int totalSeat, string manufacturer, int state)
        {
            using (var db = new AirportManager())
            {
                var pickedPlane = (from d in db.Planes
                    where d.PlaneID == id
                    select d).Single();

                db.SaveChanges();
            }
        }
    }
}
