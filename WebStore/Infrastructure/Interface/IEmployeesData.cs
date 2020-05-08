using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Infrastructure.Interface
{
    public interface IEmployeesData
    {
        //получение списка сотрудников
        IEnumerable<EmployeeView> GetAll();
        //получение сотрудника по id
        EmployeeView GetById(int id);

        //сохранить
        void Commit();
        //добавить
        void AddNew(EmployeeView model);
        //удалить
        void Delete(int id);
    }
}