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


    public partial class EmployeeAddForm : BaseAddEditForm
    {
        #region Fields

        public EventHandler ReloadEmployees;

        #endregion

        #region Constructors

        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }
        #endregion

        #region Private Methods


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
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DateBirth = dtpDateBirth.Value,
                    PESEL = txtPesel.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EmailAddress = txtEmailAddress.Text,
                    IdentityCardNumber = txtIdentityCardNumber.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentityCard.Value,
                    ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value,
                    PassportNumber = txtPassportNumber.Text,
                    IssueDatePassport = dtpIssueDatePassport.Value,
                    ExpirationDatePassport = dtpExpirationDatePassport.Value,
                    Status = new StatusModel("Wprowadzony")
                };

                //employee = CreateEmployee(employee);

                employee.Id = 4;
                employee.Code = 4;

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
