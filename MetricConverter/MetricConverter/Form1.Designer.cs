namespace MetricConverter {
    partial class MetricConversionForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearBtn = new System.Windows.Forms.Button();
            this.setInchesTxt = new System.Windows.Forms.TextBox();
            this.setFeetTxt = new System.Windows.Forms.TextBox();
            this.setInchesLabel = new System.Windows.Forms.Label();
            this.setFeetLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.convertMetersBtn = new System.Windows.Forms.Button();
            this.getMetersTxt = new System.Windows.Forms.TextBox();
            this.getMetersLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.setMetersTxt = new System.Windows.Forms.TextBox();
            this.setMetersLabel = new System.Windows.Forms.Label();
            this.convertFIBtn = new System.Windows.Forms.Button();
            this.exitBtn2 = new System.Windows.Forms.Button();
            this.getInchesTxt = new System.Windows.Forms.TextBox();
            this.getFeetTxt = new System.Windows.Forms.TextBox();
            this.getInchesLabel = new System.Windows.Forms.Label();
            this.getFeetLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.setInchesTxt);
            this.tabPage1.Controls.Add(this.setFeetTxt);
            this.tabPage1.Controls.Add(this.setInchesLabel);
            this.tabPage1.Controls.Add(this.setFeetLabel);
            this.tabPage1.Controls.Add(this.exitBtn);
            this.tabPage1.Controls.Add(this.convertMetersBtn);
            this.tabPage1.Controls.Add(this.getMetersTxt);
            this.tabPage1.Controls.Add(this.getMetersLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "To Metric";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(241, 262);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 42);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearMetricBtn_Click);
            // 
            // setInchesTxt
            // 
            this.setInchesTxt.Enabled = false;
            this.setInchesTxt.Location = new System.Drawing.Point(500, 115);
            this.setInchesTxt.Name = "setInchesTxt";
            this.setInchesTxt.Size = new System.Drawing.Size(125, 27);
            this.setInchesTxt.TabIndex = 9;
            // 
            // setFeetTxt
            // 
            this.setFeetTxt.Enabled = false;
            this.setFeetTxt.Location = new System.Drawing.Point(500, 55);
            this.setFeetTxt.Name = "setFeetTxt";
            this.setFeetTxt.Size = new System.Drawing.Size(125, 27);
            this.setFeetTxt.TabIndex = 8;
            // 
            // setInchesLabel
            // 
            this.setInchesLabel.AutoSize = true;
            this.setInchesLabel.Location = new System.Drawing.Point(408, 118);
            this.setInchesLabel.Name = "setInchesLabel";
            this.setInchesLabel.Size = new System.Drawing.Size(53, 20);
            this.setInchesLabel.TabIndex = 7;
            this.setInchesLabel.Text = "Inches:";
            // 
            // setFeetLabel
            // 
            this.setFeetLabel.AutoSize = true;
            this.setFeetLabel.Location = new System.Drawing.Point(421, 58);
            this.setFeetLabel.Name = "setFeetLabel";
            this.setFeetLabel.Size = new System.Drawing.Size(40, 20);
            this.setFeetLabel.TabIndex = 6;
            this.setFeetLabel.Text = "Feet:";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Silver;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(381, 262);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 42);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // convertMetersBtn
            // 
            this.convertMetersBtn.BackColor = System.Drawing.Color.Silver;
            this.convertMetersBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.convertMetersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertMetersBtn.Location = new System.Drawing.Point(100, 262);
            this.convertMetersBtn.Name = "convertMetersBtn";
            this.convertMetersBtn.Size = new System.Drawing.Size(107, 42);
            this.convertMetersBtn.TabIndex = 4;
            this.convertMetersBtn.Text = "Convert";
            this.convertMetersBtn.UseVisualStyleBackColor = false;
            this.convertMetersBtn.Click += new System.EventHandler(this.convertMetersBtn_Click);
            // 
            // getMetersTxt
            // 
            this.getMetersTxt.Location = new System.Drawing.Point(166, 55);
            this.getMetersTxt.Name = "getMetersTxt";
            this.getMetersTxt.Size = new System.Drawing.Size(125, 27);
            this.getMetersTxt.TabIndex = 3;
            // 
            // getMetersLabel
            // 
            this.getMetersLabel.AutoSize = true;
            this.getMetersLabel.Location = new System.Drawing.Point(32, 58);
            this.getMetersLabel.Name = "getMetersLabel";
            this.getMetersLabel.Size = new System.Drawing.Size(95, 20);
            this.getMetersLabel.TabIndex = 1;
            this.getMetersLabel.Text = "Enter Meters:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.clearBtn2);
            this.tabPage2.Controls.Add(this.setMetersTxt);
            this.tabPage2.Controls.Add(this.setMetersLabel);
            this.tabPage2.Controls.Add(this.convertFIBtn);
            this.tabPage2.Controls.Add(this.exitBtn2);
            this.tabPage2.Controls.Add(this.getInchesTxt);
            this.tabPage2.Controls.Add(this.getFeetTxt);
            this.tabPage2.Controls.Add(this.getInchesLabel);
            this.tabPage2.Controls.Add(this.getFeetLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "To Imperial";
            // 
            // clearBtn2
            // 
            this.clearBtn2.BackColor = System.Drawing.Color.Silver;
            this.clearBtn2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn2.Location = new System.Drawing.Point(241, 262);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(107, 42);
            this.clearBtn2.TabIndex = 11;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = false;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // setMetersTxt
            // 
            this.setMetersTxt.Enabled = false;
            this.setMetersTxt.Location = new System.Drawing.Point(506, 55);
            this.setMetersTxt.Name = "setMetersTxt";
            this.setMetersTxt.Size = new System.Drawing.Size(125, 27);
            this.setMetersTxt.TabIndex = 9;
            // 
            // setMetersLabel
            // 
            this.setMetersLabel.AutoSize = true;
            this.setMetersLabel.Location = new System.Drawing.Point(414, 58);
            this.setMetersLabel.Name = "setMetersLabel";
            this.setMetersLabel.Size = new System.Drawing.Size(57, 20);
            this.setMetersLabel.TabIndex = 8;
            this.setMetersLabel.Text = "Meters:";
            // 
            // convertFIBtn
            // 
            this.convertFIBtn.BackColor = System.Drawing.Color.Silver;
            this.convertFIBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.convertFIBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertFIBtn.Location = new System.Drawing.Point(100, 262);
            this.convertFIBtn.Name = "convertFIBtn";
            this.convertFIBtn.Size = new System.Drawing.Size(107, 42);
            this.convertFIBtn.TabIndex = 7;
            this.convertFIBtn.Text = "Convert";
            this.convertFIBtn.UseVisualStyleBackColor = false;
            this.convertFIBtn.Click += new System.EventHandler(this.convertFIBtn_Click);
            // 
            // exitBtn2
            // 
            this.exitBtn2.BackColor = System.Drawing.Color.Silver;
            this.exitBtn2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn2.Location = new System.Drawing.Point(381, 262);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(107, 42);
            this.exitBtn2.TabIndex = 6;
            this.exitBtn2.Text = "Exit";
            this.exitBtn2.UseVisualStyleBackColor = false;
            this.exitBtn2.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // getInchesTxt
            // 
            this.getInchesTxt.Location = new System.Drawing.Point(166, 108);
            this.getInchesTxt.Name = "getInchesTxt";
            this.getInchesTxt.Size = new System.Drawing.Size(125, 27);
            this.getInchesTxt.TabIndex = 3;
            // 
            // getFeetTxt
            // 
            this.getFeetTxt.Location = new System.Drawing.Point(166, 55);
            this.getFeetTxt.Name = "getFeetTxt";
            this.getFeetTxt.Size = new System.Drawing.Size(125, 27);
            this.getFeetTxt.TabIndex = 2;
            // 
            // getInchesLabel
            // 
            this.getInchesLabel.AutoSize = true;
            this.getInchesLabel.Location = new System.Drawing.Point(36, 111);
            this.getInchesLabel.Name = "getInchesLabel";
            this.getInchesLabel.Size = new System.Drawing.Size(91, 20);
            this.getInchesLabel.TabIndex = 1;
            this.getInchesLabel.Text = "Enter Inches:";
            // 
            // getFeetLabel
            // 
            this.getFeetLabel.AutoSize = true;
            this.getFeetLabel.Location = new System.Drawing.Point(49, 58);
            this.getFeetLabel.Name = "getFeetLabel";
            this.getFeetLabel.Size = new System.Drawing.Size(78, 20);
            this.getFeetLabel.TabIndex = 0;
            this.getFeetLabel.Text = "Enter Feet:";
            // 
            // MetricConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MetricConversionForm";
            this.Text = "Metric Converstions";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label getMetersLabel;
        private System.Windows.Forms.Label getInchesLabel;
        private System.Windows.Forms.Label getFeetLabel;
        private System.Windows.Forms.TextBox getMetersTxt;
        private System.Windows.Forms.TextBox getInchesTxt;
        private System.Windows.Forms.TextBox getFeetTxt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button convertMetersBtn;
        private System.Windows.Forms.Button convertFIBtn;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.Label setInchesLabel;
        private System.Windows.Forms.Label setFeetLabel;
        private System.Windows.Forms.TextBox setInchesTxt;
        private System.Windows.Forms.TextBox setFeetTxt;
        private System.Windows.Forms.Label setMetersLabel;
        private System.Windows.Forms.TextBox setMetersTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clearBtn2;
    }
}
