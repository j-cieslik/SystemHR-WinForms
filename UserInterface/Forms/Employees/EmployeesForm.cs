  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.DataAccessLayer.ViewModel;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {

        #region Fields

        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;

        #endregion

        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }

        #endregion

        #region Private Methods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Andrzejewski",
                    FirstName = "Paweł",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1994, 9, 1),
                    PESEL = "94090142830",
                    PhoneNumber = "665988254",
                    EmailAddress = "p.andrzejewski@gmail.com",
                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012, 9, 15),
                    ExpirationDateIdentityCard = new DateTime(2032, 9, 15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015, 5, 23),
                    ExpirationDatePassport = new DateTime(2025, 5, 23),
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 2,
                    LastName = "Bednarek",
                    FirstName = "Damian",
                    Code = 2,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1990, 9, 14),
                    PESEL = "90091444249",
                    PhoneNumber = "754952134",
                    EmailAddress = "d.bednarek@gmail.com",
/*                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012, 9, 15),
                    ExpirationDateIdentityCard = new DateTime(2032, 9, 15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015, 5, 23),
                    ExpirationDatePassport = new DateTime(2025, 5, 23),*/
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 3,
                    LastName = "Szczepaniak",
                    FirstName = "Katarzyna",
                    Code = 3,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995, 10, 13),
                    PESEL = "95101361886",
                    PhoneNumber = "852745984",
                    EmailAddress = "k.szczepaniak@gmail.com",
/*                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012, 9, 15),
                    ExpirationDateIdentityCard = new DateTime(2032, 9, 15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015, 5, 23),
                    ExpirationDatePassport = new DateTime(2025, 5, 23),*/
                    Status = new StatusModel("Wprowadzony")
                }
            };

            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }

        #endregion

        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();

            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;

                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);

                    bsEmployees.Add(employee);

                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };

            frm.ShowDialog();
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);

            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            EmployeeEditForm frm = new EmployeeEditForm(employeeId);

            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;

                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    bsEmployees[selectedRowIndex] = employee;
                }
            };

            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);

            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            // RemoveEmployee(emplyeeId);

            EmployeeViewModel employee = fakeEmployees.Where(x => x.Id == employeeId).FirstOrDefault();

            if (employee != null)
            {
                bsEmployees.Remove(employee);

                if (dgvEmployees.Rows.Count > 1)
                {
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                    dgvEmployees.ClearSelection();
                }

            }
        }

        #endregion


    }
}
