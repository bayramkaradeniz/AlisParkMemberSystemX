namespace AlisPark.WebFormsUI
{
    partial class TableButton
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(9, 40);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(911, 656);
            this.flpTable.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(576, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Masa Ekle-Sil Paneli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masa ödeme sayfası için ilgili masya çift tıklayın - Özel masa işlemleri için sağ" +
    " tıklayın.";
            // 
            // TableButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 798);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flpTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableButton";
            this.Text = "TableButton";
            this.Load += new System.EventHandler(this.TableButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}