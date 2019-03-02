using System.Collections.Generic;

namespace AggregateModel
{
    public interface IBookAggregate
    {
        UIModel LoadDetailsById(int id);
        IEnumerable<UIModel> LoadAllDetails();
    }
}