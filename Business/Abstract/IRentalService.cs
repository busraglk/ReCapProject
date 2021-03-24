﻿using Core.Utilies.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);    
        IDataResult<List<RentalDetailDto>> GetRentalByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult IsRentable(Rental rental);
    }
}
