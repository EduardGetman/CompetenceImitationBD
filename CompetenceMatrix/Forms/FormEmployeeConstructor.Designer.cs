
namespace CompetenceMatrix.Forms
{
    partial class FormEmployeeConstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridCompetenceList = new System.Windows.Forms.DataGridView();
            this.CompetenceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddModel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NUDCountCompetence = new System.Windows.Forms.NumericUpDown();
            this.TBNameModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddCompetence = new System.Windows.Forms.Button();
            this.TBNameCpmpetence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompetenceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCountCompetence)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCompetenceList
            // 
            this.GridCompetenceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCompetenceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompetenceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompetenceColumn,
            this.Skill});
            this.GridCompetenceList.Location = new System.Drawing.Point(12, 251);
            this.GridCompetenceList.Name = "GridCompetenceList";
            this.GridCompetenceList.RowHeadersWidth = 51;
            this.GridCompetenceList.RowTemplate.Height = 24;
            this.GridCompetenceList.Size = new System.Drawing.Size(640, 530);
            this.GridCompetenceList.TabIndex = 0;
            // 
            // CompetenceColumn
            // 
            this.CompetenceColumn.HeaderText = "Компетенция";
            this.CompetenceColumn.MinimumWidth = 6;
            this.CompetenceColumn.Name = "CompetenceColumn";
            this.CompetenceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompetenceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Skill
            // 
            this.Skill.HeaderText = "Уровень владения";
            this.Skill.MinimumWidth = 6;
            this.Skill.Name = "Skill";
            // 
            // BtnAddModel
            // 
            this.BtnAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddModel.Location = new System.Drawing.Point(12, 52);
            this.BtnAddModel.Name = "BtnAddModel";
            this.BtnAddModel.Size = new System.Drawing.Size(150, 34);
            this.BtnAddModel.TabIndex = 9;
            this.BtnAddModel.Text = "Сохрнить";
            this.BtnAddModel.UseVisualStyleBackColor = true;
            this.BtnAddModel.Click += new System.EventHandler(this.BtnAddModel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(12, 10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 34);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Выйти";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAddModel);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Location = new System.Drawing.Point(477, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 93);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NUDCountCompetence);
            this.panel2.Controls.Add(this.TBNameModel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 93);
            this.panel2.TabIndex = 12;
            // 
            // NUDCountCompetence
            // 
            this.NUDCountCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUDCountCompetence.Location = new System.Drawing.Point(245, 10);
            this.NUDCountCompetence.Name = "NUDCountCompetence";
            this.NUDCountCompetence.Size = new System.Drawing.Size(199, 28);
            this.NUDCountCompetence.TabIndex = 16;
            this.NUDCountCompetence.ValueChanged += new System.EventHandler(this.NUDCountCompetence_ValueChanged);
            // 
            // TBNameModel
            // 
            this.TBNameModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNameModel.Location = new System.Drawing.Point(73, 47);
            this.TBNameModel.Name = "TBNameModel";
            this.TBNameModel.Size = new System.Drawing.Size(371, 28);
            this.TBNameModel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество компетенций:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Информация о сотруднике";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(520, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Действия";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddCompetence);
            this.panel3.Controls.Add(this.TBNameCpmpetence);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 59);
            this.panel3.TabIndex = 19;
            // 
            // AddCompetence
            // 
            this.AddCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCompetence.Location = new System.Drawing.Point(477, 12);
            this.AddCompetence.Name = "AddCompetence";
            this.AddCompetence.Size = new System.Drawing.Size(150, 34);
            this.AddCompetence.TabIndex = 21;
            this.AddCompetence.Text = "Добавить";
            this.AddCompetence.UseVisualStyleBackColor = true;
            this.AddCompetence.Click += new System.EventHandler(this.AddCompetence_Click);
            // 
            // TBNameCpmpetence
            // 
            this.TBNameCpmpetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNameCpmpetence.Location = new System.Drawing.Point(158, 14);
            this.TBNameCpmpetence.Name = "TBNameCpmpetence";
            this.TBNameCpmpetence.Size = new System.Drawing.Size(313, 28);
            this.TBNameCpmpetence.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Наименование:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(199, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Добавление новой компетенции";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(214, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Заполнение компетенций";
            // 
            // FormEmployeeConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 793);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GridCompetenceList);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeConstructor";
            this.Text = "FormAddingModel";
            ((System.ComponentModel.ISupportInitialize)(this.GridCompetenceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCountCompetence)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCompetenceList;
        private System.Windows.Forms.Button BtnAddModel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown NUDCountCompetence;
        private System.Windows.Forms.TextBox TBNameModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBNameCpmpetence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCompetence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewComboBoxColumn CompetenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill;
    }
}