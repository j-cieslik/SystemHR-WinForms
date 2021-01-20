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
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields

        private EmployeeModel employee;
        public EventHandler ReloadEmployees;

        #endregion

        #region Constructors

        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            InitializeData();
            this.employee = GetFakeEmployee(employeeId);
            PrepareEmployeeData(employee);
            ValidateControls();
        }




        #endregion

        #region Private Methods

        private void PrepareEmployeeData(EmployeeModel employee)
        {
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.FirstName;
            cbGender.Text = employee.Gender != null ? employee.Gender.Value : null;
            dtpDateBirth.SetDateTimePickerValue(employee.DateBirth);
            txtPesel.Text = employee.PESEL;
            txtPhoneNumber.Text = employee.PhoneNumber;
            txtEmailAddress.Text = employee.EmailAddress;
            txtIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueDateIdentityCard.SetDateTimePickerValue(employee.IssueDateIdentityCard);
            dtpExpirationDateIdentityCard.SetDateTimePickerValue(employee.ExpirationDateIdentityCard);
            txtPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDatePassport);
            dtpExpirationDatePassport.SetDateTimePickerValue(employee.ExpirationDatePassport);

            lblEmployee.Text = $"{employee.FirstName} {employee.LastName} ({employee.Code.ToString().PadLeft(4, '0')}) - {employee.Status.ToString()}";
        }


        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Pole Nazwisko jest wymagane.");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "Pole Imię jest wymagane.");
            }
            else
            {
                epFirstName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtPesel.Text) && !ValidatorsHelper.IsValidPESEL(txtPesel.Text))
            {
                epPESEL.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa");
            }
            else
            {
                epPESEL.Clear();
            }
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("kobieta"),
                new GenderModel("mężczyzna"),
                new GenderModel(string.Empty)
            };

            bsGender.DataSource = genders;
            cbGender.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastName);

            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);

            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie pracownika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            string peselWarningMessage = epPESEL.GetError(txtPesel);

            if (!string.IsNullOrEmpty(peselWarningMessage))
            {
                DialogResult answer =
                    MessageBox.Show(
                        peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika?",
                        "Dodawanie pracownika",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        private EmployeeModel GetFakeEmployee(int employeeId)
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
                    PESEL = "94090142832",
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

            EmployeeModel fakeEmployeeModel = fakeEmployeesModel
                .Where(x => x.Id == employeeId).FirstOrDefault();

            return fakeEmployeeModel;
        }

        #endregion

        #region Events



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;

            if (string.IsNullOrWhiteSpace(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
            {
                epPESEL.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa");
            }
            else
            {
                epPESEL.Clear();
            }
        }

        #endregion

        #region Override

        protected override void Save()
        {
            if (ValidateForm())
            {

                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.Gender = new GenderModel(cbGender.Text);
                employee.DateBirth = dtpDateBirth.Value;
                employee.PESEL = txtPesel.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.EmailAddress = txtEmailAddress.Text;
                employee.IdentityCardNumber = txtIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueDateIdentityCard.Value;
                employee.ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value;
                employee.PassportNumber = txtPassportNumber.Text;
                employee.IssueDatePassport = dtpIssueDatePassport.Value;
                employee.ExpirationDatePassport = dtpExpirationDatePassport.Value;
                

                //employee = ModifyEmployee(employee);


                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));

                Close();
            }
        }



        protected override void Cancel()
        {
            Close();
        }

        #endregion
    }
}
