using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interface;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementation
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeViewModel> _employees;
        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeViewModel>(3)
            {
                new EmployeeViewModel()
                {
                    Id=1,
                    FirstName="Уася",
                    SurName="Волков",
                    Patronymic="Николаевич",
                    Age=22,
                    Position="Директор",
                },
                new EmployeeViewModel()
                {
                    Id=2,
                    FirstName="Ваня",
                    SurName="Халявщиков",
                    Patronymic="Санович",
                    Age=30,
                    Position="Программист"
                },
                new EmployeeViewModel()
                {
                    Id=3,
                    FirstName="Вини",
                    SurName="Пухов",
                    Patronymic="Непроизносимович",
                    Age=50,
                    Position="Медвед"
                }
            };
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return _employees;
        }

        public EmployeeViewModel GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Commit()
        { }

        public void AddNew(EmployeeViewModel model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}