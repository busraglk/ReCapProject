﻿using Core.Utilies.Results;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetCardsByCustomerId(int customerId);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCard> GetByCreditCardNumber(string creditCardNumber);
    }
}
