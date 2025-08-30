
namespace CapaVista
{
    partial class ConsultasVista
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(327, 31);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(152, 67);
            this.btn_consulta.TabIndex = 0;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(10, 136);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersWidth = 62;
            this.dgv_consulta.RowTemplate.Height = 28;
            this.dgv_consulta.Size = new System.Drawing.Size(965, 294);
            this.dgv_consulta.TabIndex = 1;
            // 
            // ConsultasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.btn_consulta);
            this.Name = "ConsultasVista";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.DataGridView dgv_consulta;
    }
}