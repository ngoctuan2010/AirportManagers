﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using DTO;

namespace DAL
{
    public class DAL_Flight
    {

        public List<Flight> LoadFlights()
        {
            List<Flight> list = new List<Flight>();
            using (var db = new AirportManager())
            {
                list = db.Flights.ToList();
            }
            return list;
        }

        public List<Location> LoadLocationsToBox()
        {
            List<Location> list = new List<Location>();
            using (var db = new AirportManager())
            {
                list = db.Locations.ToList();
            }
            return list;
        }



        public bool AddFlight(int planeID , int departure, int destination, DateTime datetimedepart, string airline)
        {
            using (var db = new AirportManager())
            {
                db.Flights.Add(new Flight() { PlaneID = planeID, Departure = departure, Destination = destination, DateOfDeparture = DateTime.Parse(datetimedepart.ToString("yyyy/MM/dd HH:mm:ss")), Airline = airline});
                return db.SaveChanges() > 0;
            }
        }

        public bool UpdateFlight(int id, int planeId, int departure, int destination, DateTime datetimedepart, string airline)
        {
            using (var db = new AirportManager())
            {
                var pickedFlight = (from d in db.Flights where d.FlightID == id select d).SingleOrDefault();
                pickedFlight.PlaneID = planeId;
                pickedFlight.Departure = departure;
                pickedFlight.Destination = destination;
                pickedFlight.DateOfDeparture = datetimedepart;
                pickedFlight.Airline = airline;
                db.Flights.AddOrUpdate(pickedFlight);
                return db.SaveChanges() > 0;
            }
        }

        public bool RemoveFlight(int id)
        {
            using (var db = new AirportManager())
            {
                var pickedFlight = (from d in db.Flights where d.FlightID == id select d).SingleOrDefault();
                db.Flights.Remove(pickedFlight);
                return db.SaveChanges() > 0;
            }
        }

        public bool checkValidFlight(Flight flight)
        {
            using (var db = new AirportManager())
            {
                var pickedFlight = (from d in db.Flights where d.PlaneID == flight.PlaneID & d.Departure != d.Destination select d).FirstOrDefault();
                return pickedFlight == null;
            }
        }
    }
}
