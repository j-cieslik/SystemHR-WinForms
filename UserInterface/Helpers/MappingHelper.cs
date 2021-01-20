using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.ViewModel;

namespace SystemHR.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapEmployeeModelToEmployeeViewModel
            (IList<EmployeeModel> employeesModel)
        {
            IList<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel employeeModel in employeesModel)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();

                employeeViewModel.Id = employeeModel.Id;
                employeeViewModel.LastName = employeeModel.LastName;
                employeeViewModel.FirstName = employeeModel.FirstName;
                employeeViewModel.Code = employeeModel.Code.ToString();
                employeeViewModel.Position = string.Empty;
                employeeViewModel.Status = employeeModel.Status.ToString();

                employeesViewModel.Add(employeeViewModel);
            }

            return employeesViewModel;
        }

        public static EmployeeViewModel MapEmployeeModelToEmployeeViewModel
            (EmployeeModel employeeModel)
        {

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.Id = employeeModel.Id;
            employeeViewModel.LastName = employeeModel.LastName;
            employeeViewModel.FirstName = employeeModel.FirstName;
            employeeViewModel.Code = employeeModel.Code.ToString();
            employeeViewModel.Position = string.Empty;
            employeeViewModel.Status = employeeModel.Status.ToString();


            return employeeViewModel;
        }
    }
}
