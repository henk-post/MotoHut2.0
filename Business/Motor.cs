﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Motor : IMotor
    {
        public int MotorId { get; set; }
        public int VerhuurderId { get; set; }
        public string Model { get; set; }
        public int Bouwjaar { get; set; }
        public int Prijs { get; set; }
        public string Status { get; set; }


        public void ReadyReader(SqlDataReader rdr)
        {
            //this.MotorId = (int)rdr["MotorId"];
            //this.VerhuurderId = (int)rdr["VerhuurderId"];
            //this.Model = (string)rdr["Model"];
            //this.Bouwjaar = (int)rdr["Bouwjaar"];
            //this.Prijs = (int)rdr["Prijs"];
            //this.Status = (string)rdr["Status"];
        }


    }
}