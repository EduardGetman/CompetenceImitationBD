using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CompetenceMatrix.entity;
using CompetenceMatrix.ImplementationLogic;

namespace CompetenceMatrix.Forms
{
    public partial class FormConfigurationMatrix : Form
    {
        Position[] positions;
        Employee[] employees;
        Position SelectedPosition
        {
            get
            {
                if (CBPositionName.SelectedIndex >= 0)
                {
                    return GetPositionById(CBPositionName.SelectedIndex);
                }
                return null;
            }
        }

        Employee[] SelectedEmployee { 
            get
            {
                List<Employee> result = new List<Employee>();
                for (int i = 0; i < GridEmployeeSelect.RowCount; i++)
                {
                    if ((bool)GridEmployeeSelect[nameof(IsEmployeeSelected), i].Value)
                    {
                        result.Add(GetEmployeeById(Convert.ToInt32(GridEmployeeSelect[nameof(EmployeeID), i].Value)));
                    }
                }
                return result.ToArray();
            } 
        }
        Employee[] SuitableEmployees { 
            get
            {
                if (CBPositionName.SelectedIndex < 0)
                {
                    return null;
                }
                List<Employee> result = new List<Employee>();
                foreach (var item in employees)
                {
                    if (!ChBSuitableEmployees.Checked || SelectedPosition.IsEmployeeSuitable(item))
                    {
                        if (RBAllEmployee.Checked || !item.HoldPosition() )
                        {
                            result.Add(item);
                        }
                    }
                }
                return result.ToArray();
            }
        }
        public FormConfigurationMatrix(Position[] positions, Employee[] employees)
        {
            InitializeComponent();
            this.employees = employees;
            this.positions = positions;
            CBPositionName.Items.AddRange(GetPositionName(positions));
            RBAllEmployee.Checked = true;
        }

        private void UpdateEmployeeFilter(object sender, EventArgs e)
        {
            if (ConfirmationTableReset() && CBPositionName.SelectedIndex >= 0)
            {
                SetGridEmployeeSelect(SuitableEmployees);
            }
        }

        string[] GetPositionName(Position[] positions)
        {
            List<string> result = new List<string>();
            foreach (var item in positions)
            {
                result.Add(item.Name);
            }
            return result.ToArray();
        }

        bool ConfirmationTableReset()
        {
            if (GridEmployeeSelect.RowCount == 0)
            {
                return true;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите сбросить таблицу выбора сотрудниов?", 
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }

        Position[] GetPositionsByFilter(string filterString, Position[] positions)
        {
            List<Position> result = new List<Position>();
            foreach (var item in positions)
            {
                if (item.Name.Contains(filterString))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }

        void SetGridEmployeeSelect(Employee[] employees)
        {
            GridEmployeeSelect.Rows.Clear();
            foreach (var item in employees)
            {
               GridEmployeeSelect.Rows.Add(item.FullName, item.PositionName(), false, item.Id);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) => Close();

        private void BtnBuildMatrix_Click(object sender, EventArgs e)
        {
            if (CBPositionName.SelectedIndex < 0)
            {
                MessageBox.Show("Для построения матрицы компетенций необходимо выбрать должность!", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MainForm fm = (MainForm)Application.OpenForms[0];
            fm.MatrixCompetence = new MatrixCompetence(SelectedPosition, SelectedEmployee);
            fm.Show();
            fm.Close();
        }

        Employee GetEmployeeById(int Id)
        {
            foreach (var item in employees)
            {
                return item;
            }
            throw new Exception($"Не найден сотрудник с ID = {Id}");
        }
        Position GetPositionById(int Id)
        {
            foreach (var item in positions)
            {
                return item;
            }
            throw new Exception($"Не найдена должность с ID = {Id}");
        }
        int[] GetColectionPositionId(Position[] positions)
        {
            List<int> result = new List<int>();
            foreach (var item in positions)
            {
                result.Add(item.Id);
            }
            return result.ToArray();
        }
    }
}
