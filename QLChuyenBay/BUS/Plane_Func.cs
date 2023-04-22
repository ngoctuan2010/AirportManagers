using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class Plane_Func
    {
        public void AddPlane (Plane plane)
        {
            Plane_Service.AddPlane(plane.Model, plane.Registration, plane.TotalSeat, plane.Manufacturer, plane.State);
        }

        public void RemovePlane(Plane plane)
        {
            Plane_Service.RemovePlane(plane.PlaneID);
        }
    }
}
