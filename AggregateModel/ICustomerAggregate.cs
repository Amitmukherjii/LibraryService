using System.Collections.Generic;

namespace AggregateModel
{
    public interface ICustomerAggregate
    {
        UIModel LoadDetailsById(int id);
        IEnumerable<UIModel> LoadAllDetails();
    }
}