﻿using Business.Abstract;
using Business.Constants;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.AddedCreditCard);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.DeletedCreditCard);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(), Messages.ListedCars);
        }

        public IDataResult<CreditCard> GetByCreditCardNumber(string creditCardNumber)
        {
            var result = _creditCardDal.Get(c => c.CreditCardNumber == creditCardNumber);
            return new SuccessDataResult<CreditCard>(result);
        }

        public IDataResult<CreditCard> GetByName(string name)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.CustomerName == name));
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.UpdatedCreditCard);
        }
    }
}