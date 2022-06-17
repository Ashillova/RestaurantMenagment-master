
namespace RestaurantMenagment
{
    partial class Admin
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
            this.DgvDaily = new System.Windows.Forms.DataGridView();
            this.bttClose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.brnDEL = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDaily
            // 
            this.DgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDaily.Location = new System.Drawing.Point(12, 12);
            this.DgvDaily.Name = "DgvDaily";
            this.DgvDaily.RowTemplate.Height = 25;
            this.DgvDaily.Size = new System.Drawing.Size(776, 377);
            this.DgvDaily.TabIndex = 0;
            this.DgvDaily.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttClose
            // 
            this.bttClose.Location = new System.Drawing.Point(696, 404);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(92, 34);
            this.bttClose.TabIndex = 2;
            this.bttClose.Text = "Exit";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(598, 404);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 34);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Sale Details";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // brnDEL
            // 
            this.brnDEL.Location = new System.Drawing.Point(500, 404);
            this.brnDEL.Name = "brnDEL";
            this.brnDEL.Size = new System.Drawing.Size(92, 34);
            this.brnDEL.TabIndex = 4;
            this.brnDEL.Text = "Delete";
            this.brnDEL.UseVisualStyleBackColor = true;
            this.brnDEL.Click += new System.EventHandler(this.brnDEL_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(402, 404);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(92, 34);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(12, 404);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(92, 34);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD User";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.brnDEL);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.DgvDaily);
            this.Name = "Admin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDaily;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button brnDEL;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnADD;
    }
}