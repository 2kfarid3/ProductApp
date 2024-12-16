namespace ProductApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            name_tb = new TextBox();
            desc_tb = new TextBox();
            cat_tb = new TextBox();
            dgv = new DataGridView();
            insert_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // name_tb
            // 
            name_tb.Location = new Point(133, 466);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(200, 39);
            name_tb.TabIndex = 0;
            // 
            // desc_tb
            // 
            desc_tb.Location = new Point(402, 466);
            desc_tb.Name = "desc_tb";
            desc_tb.Size = new Size(200, 39);
            desc_tb.TabIndex = 1;
            // 
            // cat_tb
            // 
            cat_tb.Location = new Point(666, 466);
            cat_tb.Name = "cat_tb";
            cat_tb.Size = new Size(200, 39);
            cat_tb.TabIndex = 2;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(66, 52);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.Size = new Size(878, 364);
            dgv.TabIndex = 3;
            dgv.CellContentClick += dgv_CellContentClick_1;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(157, 534);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(150, 46);
            insert_btn.TabIndex = 4;
            insert_btn.Text = "insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click_1;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(419, 534);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(150, 46);
            update_btn.TabIndex = 5;
            update_btn.Text = "update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click_1;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(693, 534);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(150, 46);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 769);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(insert_btn);
            Controls.Add(dgv);
            Controls.Add(cat_tb);
            Controls.Add(desc_tb);
            Controls.Add(name_tb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_tb;
        private TextBox desc_tb;
        private TextBox cat_tb;
        private DataGridView dgv;
        private Button insert_btn;
        private Button update_btn;
        private Button delete_btn;
    }
}
