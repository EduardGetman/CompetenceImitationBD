
namespace CompetenceMatrix.Forms
{
    partial class FormConfigurationMatrix
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
            this.GridEmployeeSelect = new System.Windows.Forms.DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEmployeeSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBPositionName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuildMatrix = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChBSuitableEmployees = new System.Windows.Forms.CheckBox();
            this.RBEmployeeWOutPosition = new System.Windows.Forms.RadioButton();
            this.RBAllEmployee = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeSelect)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridEmployeeSelect
            // 
            this.GridEmployeeSelect.AllowUserToAddRows = false;
            this.GridEmployeeSelect.AllowUserToDeleteRows = false;
            this.GridEmployeeSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmployeeSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployeeSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.Position,
            this.IsEmployeeSelected,
            this.EmployeeID});
            this.GridEmployeeSelect.Location = new System.Drawing.Point(13, 153);
            this.GridEmployeeSelect.Name = "GridEmployeeSelect";
            this.GridEmployeeSelect.RowHeadersWidth = 51;
            this.GridEmployeeSelect.RowTemplate.Height = 24;
            this.GridEmployeeSelect.Size = new System.Drawing.Size(884, 402);
            this.GridEmployeeSelect.TabIndex = 0;
            // 
            // EmployeeName
            // 
            this.EmployeeName.FillWeight = 93.04813F;
            this.EmployeeName.HeaderText = "Сотрудник";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // IsEmployeeSelected
            // 
            this.IsEmployeeSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsEmployeeSelected.HeaderText = "Включить в матрицу";
            this.IsEmployeeSelected.MinimumWidth = 6;
            this.IsEmployeeSelected.Name = "IsEmployeeSelected";
            this.IsEmployeeSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsEmployeeSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsEmployeeSelected.Width = 107;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID Сотрудника";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // CBPositionName
            // 
            this.CBPositionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBPositionName.FormattingEnabled = true;
            this.CBPositionName.Location = new System.Drawing.Point(121, 12);
            this.CBPositionName.Name = "CBPositionName";
            this.CBPositionName.Size = new System.Drawing.Size(251, 30);
            this.CBPositionName.TabIndex = 1;
            this.CBPositionName.SelectedIndexChanged += new System.EventHandler(this.UpdateEmployeeFilter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(754, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Действия";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBuildMatrix);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Location = new System.Drawing.Point(711, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 93);
            this.panel1.TabIndex = 19;
            // 
            // BtnBuildMatrix
            // 
            this.BtnBuildMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBuildMatrix.Location = new System.Drawing.Point(12, 52);
            this.BtnBuildMatrix.Name = "BtnBuildMatrix";
            this.BtnBuildMatrix.Size = new System.Drawing.Size(150, 34);
            this.BtnBuildMatrix.TabIndex = 9;
            this.BtnBuildMatrix.Text = "Построить";
            this.BtnBuildMatrix.UseVisualStyleBackColor = true;
            this.BtnBuildMatrix.Click += new System.EventHandler(this.BtnBuildMatrix_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.CBPositionName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 92);
            this.panel2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(158, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Должность";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ChBSuitableEmployees);
            this.panel3.Controls.Add(this.RBEmployeeWOutPosition);
            this.panel3.Controls.Add(this.RBAllEmployee);
            this.panel3.Location = new System.Drawing.Point(404, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 92);
            this.panel3.TabIndex = 23;
            // 
            // ChBSuitableEmployees
            // 
            this.ChBSuitableEmployees.AutoSize = true;
            this.ChBSuitableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChBSuitableEmployees.Location = new System.Drawing.Point(12, 59);
            this.ChBSuitableEmployees.Name = "ChBSuitableEmployees";
            this.ChBSuitableEmployees.Size = new System.Drawing.Size(256, 28);
            this.ChBSuitableEmployees.TabIndex = 19;
            this.ChBSuitableEmployees.Text = "Подходящие сотрудники";
            this.ChBSuitableEmployees.UseVisualStyleBackColor = true;
            this.ChBSuitableEmployees.CheckedChanged += new System.EventHandler(this.UpdateEmployeeFilter);
            // 
            // RBEmployeeWOutPosition
            // 
            this.RBEmployeeWOutPosition.AutoSize = true;
            this.RBEmployeeWOutPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBEmployeeWOutPosition.Location = new System.Drawing.Point(12, 31);
            this.RBEmployeeWOutPosition.Name = "RBEmployeeWOutPosition";
            this.RBEmployeeWOutPosition.Size = new System.Drawing.Size(281, 28);
            this.RBEmployeeWOutPosition.TabIndex = 18;
            this.RBEmployeeWOutPosition.TabStop = true;
            this.RBEmployeeWOutPosition.Text = "Сотрудники без должности";
            this.RBEmployeeWOutPosition.UseVisualStyleBackColor = true;
            this.RBEmployeeWOutPosition.CheckedChanged += new System.EventHandler(this.UpdateEmployeeFilter);
            // 
            // RBAllEmployee
            // 
            this.RBAllEmployee.AutoSize = true;
            this.RBAllEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBAllEmployee.Location = new System.Drawing.Point(12, 3);
            this.RBAllEmployee.Name = "RBAllEmployee";
            this.RBAllEmployee.Size = new System.Drawing.Size(174, 28);
            this.RBAllEmployee.TabIndex = 17;
            this.RBAllEmployee.TabStop = true;
            this.RBAllEmployee.Text = "Все сотрудники";
            this.RBAllEmployee.UseVisualStyleBackColor = true;
            this.RBAllEmployee.CheckedChanged += new System.EventHandler(this.UpdateEmployeeFilter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(462, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Фильтры сотрудников";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(374, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Выбор сотрудников";
            // 
            // FormConfigurationMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridEmployeeSelect);
            this.Controls.Add(this.panel2);
            this.Name = "FormConfigurationMatrix";
            this.Text = "FormConfigurationMatrix";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeSelect)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEmployeeSelect;
        private System.Windows.Forms.ComboBox CBPositionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuildMatrix;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RBAllEmployee;
        private System.Windows.Forms.CheckBox ChBSuitableEmployees;
        private System.Windows.Forms.RadioButton RBEmployeeWOutPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEmployeeSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
    }
}