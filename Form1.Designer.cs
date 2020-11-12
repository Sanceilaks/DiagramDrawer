namespace DiagramDrawer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.FirstNumber = new System.Windows.Forms.NumericUpDown();
            this.SecondNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 136);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(684, 355);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(12, 12);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(120, 20);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.FirstNumber.ValueChanged += new System.EventHandler(this.FirstNumber_ValueChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(138, 12);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(120, 20);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SecondNumber.ValueChanged += new System.EventHandler(this.SecondNumber_ValueChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(708, 503);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.NumericUpDown FirstNumber;
        private System.Windows.Forms.NumericUpDown SecondNumber;
    }
}

