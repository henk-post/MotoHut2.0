﻿using System.Data.SqlClient;

namespace Business
{
    public interface IMotor
    {

        public void RentMotor(int motorId, DateTime ophaal, DateTime inlever);
        public Motor GetMotor(int motorId);
    }
}