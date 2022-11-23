﻿using MotoHut2._0.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IMotorDal
    {
        public void RentMotorDal(int motorId, DateTime ophaal, DateTime inlever);
        public Motor GetMotor(int motorId);

    }
}
