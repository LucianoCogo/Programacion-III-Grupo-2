﻿namespace TP1_Grupo_Nro_02
{
    partial class FormEjercicio2
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
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.ElementsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.DataGroupBox.SuspendLayout();
            this.ElementsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.NameInput);
            this.DataGroupBox.Controls.Add(this.SurnameInput);
            this.DataGroupBox.Controls.Add(this.SurnameLabel);
            this.DataGroupBox.Controls.Add(this.NameLabel);
            this.DataGroupBox.Controls.Add(this.AddBtn);
            this.DataGroupBox.Location = new System.Drawing.Point(12, 24);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(289, 400);
            this.DataGroupBox.TabIndex = 0;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Ingreso de datos";
            // 
            // ElementsGroupBox
            // 
            this.ElementsGroupBox.Controls.Add(this.DataListBox);
            this.ElementsGroupBox.Controls.Add(this.DeleteBtn);
            this.ElementsGroupBox.Location = new System.Drawing.Point(336, 24);
            this.ElementsGroupBox.Name = "ElementsGroupBox";
            this.ElementsGroupBox.Size = new System.Drawing.Size(293, 400);
            this.ElementsGroupBox.TabIndex = 1;
            this.ElementsGroupBox.TabStop = false;
            this.ElementsGroupBox.Text = "Elementos";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(100, 342);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(91, 31);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Borarr";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(79, 342);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(92, 31);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(32, 44);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(232, 277);
            this.DataListBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(91, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nombre";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(91, 129);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(50, 13);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Apelledio";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(24, 145);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(180, 20);
            this.SurnameInput.TabIndex = 4;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(24, 65);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(180, 20);
            this.NameInput.TabIndex = 5;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.ElementsGroupBox);
            this.Controls.Add(this.DataGroupBox);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.ElementsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.GroupBox ElementsGroupBox;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}