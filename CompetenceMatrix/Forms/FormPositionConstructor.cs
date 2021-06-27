using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompetenceMatrix.entity;
using CompetenceMatrix.Forms;

namespace CompetenceMatrix.Forms
{
    public partial class FormPositionConstructor : Form
    {
        Position position;
        List<Competence> competences;
        public FormPositionConstructor(Competence[] competences)
        {
            this.competences = new List<Competence>();
            InitializeComponent();

            foreach (var competence in ModelKeeper.competences)
            {
                ((DataGridViewComboBoxColumn) GridCompetenceList
                        .Columns[0])
                    .Items.AddRange(competence.Name);
            }
            
            this.competences.AddRange(competences);
            AddCompetencesToCompetenceColumn(competences);
        }
        public FormPositionConstructor(Competence[] competences, Position position) : this(competences)
        {
            this.position = position;
            SetPositionToGridCompetenceList(position);
        }
        void SetPositionToGridCompetenceList(Position position)
        {
            TBNameModel.Text = position.Name;
            NUDCountCompetence.Value = position.Requirements.Count;
            GridCompetenceList.Rows.Clear();
            
            foreach (var item in position.Requirements)
            {
                GridCompetenceList.Rows.Add(item.Competence.Name, item.Level);
            }
        }
        private void NUDCountCompetence_ValueChanged(object sender, EventArgs e)
        {
            GridCompetenceList.RowCount = Convert.ToInt32(NUDCountCompetence.Value) > 0?
                Convert.ToInt32(NUDCountCompetence.Value): 1;
        }

        private void AddCompetence_Click(object sender, EventArgs e)
        {
            if (TBNameCpmpetence.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Наименование компетенции\"", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Competence competence = new Competence(TBNameCpmpetence.Text);
            
            ModelKeeper.competences.Add(competence);
            
            competences.Add(competence);
            CompetenceColumn.Items.Add(competence.Name);
        }
        private void AddCompetencesToCompetenceColumn(Competence[] competences) =>
            CompetenceColumn.Items.AddRange(GetCompetencesName(competences));

        private string[] GetCompetencesName(Competence[] competences)
        {
            List<string> result = new List<string>();
            foreach (var item in competences)
            {
                result.Add(item.Name);
            }
            return result.ToArray();
        }

        private void BtnAddModel_Click(object sender, EventArgs e)
        {
            if (GridCompetenceList.RowCount == 0)
            {
                MessageBox.Show("Заполните таблицу компетенций, а затем ещё раз нажмите на кнопку сохранить",
                   "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!AllCellsLevelColumnIsNumber())
            {
                MessageBox.Show("Уровень владения компетенцией задаётся положительным числом!" +
                   " Внесите изменения в поле уровень владения, а затем ещё раз нажмите на кнопку сохранить",
                   "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm form = (MainForm)Application.OpenForms[0];
            if (this.position is null)
            {
                Position position = AddPosition();
                form.Positions.Add(position);
            }
            else
            {
                Position position = UpdatePosition();
                form.Positions[form.Positions.IndexOf(this.position)] = position;
            }        
            form.Show();
            Close();
        }
        private Position AddPosition()
        {
            List<Requirement> requirements = new List<Requirement>();
            for (int i = 0; i < Int32.Parse(NUDCountCompetence.Text); i++)
            {
               requirements.Add(new Requirement(Convert.ToInt32(GridCompetenceList[1, i].Value),
                   GetCompetenceByName(GridCompetenceList[0, i].Value.ToString())));
            }
            Position position = new Position(TBNameModel.Text, requirements.ToArray());
            return position;
        }
        private Position UpdatePosition()
        {
            List<Requirement> requirements = new List<Requirement>();
            for (int i = 0; i < Int32.Parse(NUDCountCompetence.Text); i++)
            {
                requirements.Add(new Requirement(Convert.ToInt32(GridCompetenceList[1, i].Value),
                    GetCompetenceByName(GridCompetenceList[0, i].Value.ToString())));
            }
            Position position = new Position(TBNameModel.Text, requirements.ToArray());
            return position;
        }

        private Competence GetCompetenceByName(string name)
        {
            foreach (var item in competences)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            throw new Exception();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Application.OpenForms[0];
            form.Show();
            Close();
        }

        private void GridCompetenceList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCompetenceList[e.ColumnIndex, e.RowIndex].Value is null)
            {
                return;
            }
            if (!IsNumber(GridCompetenceList[e.ColumnIndex,e.RowIndex].Value.ToString()))
            {
                MessageBox.Show("Уровень владения компетенцией задаётся положительным числом!", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GridCompetenceList[e.ColumnIndex, e.RowIndex].Value = "";
            }
        }
        private bool IsNumber(string str)
        {
            foreach (var item in str)
            {
                if (!Char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }

        private bool AllCellsLevelColumnIsNumber()
        {            
            for (int i = 0; i <Int32.Parse(NUDCountCompetence.Text); i++)
            {
                if (!IsNumber(GridCompetenceList[1,i].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
