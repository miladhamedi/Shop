using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IWeightRepository
    {
        List<Weight> GetAll();
        void AddWeight(Weight weight);
        Weight GetById(int weightid);
        void RemoveWeight(Weight weight);
        void UpdateWeight(Weight weight);
        decimal GetWeight_Price(int Weight_Min, int Weight_Max);


    }
}
